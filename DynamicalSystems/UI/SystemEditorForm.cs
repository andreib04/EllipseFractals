using DynamicalSystems.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicalSystems.UI
{
    public partial class SystemEditorForm : Form
    {
        public DynamicSystem Result { get; private set; }

        public SystemEditorForm(DynamicSystem existing = null)
        {
            InitializeComponent();
            InitializeGridColumns();
            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;
            btnOk.Click += BtnOk_Click;
            gridEquations.CellEndEdit += (s, e) => UpdatePreview();
            gridParameters.CellEndEdit += (s, e) => UpdatePreview();

            if (existing != null)
                LoadFrom(existing);
        }

        private void InitializeGridColumns()
        {
            gridEquations.Columns.Clear();
            gridEquations.Columns.Add("var", "Variable (t+1)");
            gridEquations.Columns.Add("monoms", "Monoms  (e.g.:  1 | -1 a 1 x 2 | 1 y 1)");

            gridParameters.Columns.Clear();
            gridParameters.Columns.Add("pname", "Parameter");
            gridParameters.Columns.Add("pvalue", "Value");
        }

        private void LoadFrom(DynamicSystem sys)
        {
            txtName.Text = sys.Name;

            foreach (var eq in sys.Equations)
            {
                string monomStr = string.Join(" | ",
                    eq.Monoms.Select(m =>
                    {
                        string s = m.Coefficient.ToString("G");
                        foreach (var v in m.Variables)
                            s += $" {v.Name} {v.Power}";
                        return s;
                    }));
                gridEquations.Rows.Add(eq.VariableName, monomStr);
            }

            foreach (var p in sys.Parameters)
                gridParameters.Rows.Add(p.Key, p.Value);

            UpdatePreview();
        }

        private void UpdatePreview()
        {
            try
            {
                var sys = Build();
                lblPreview.ForeColor = Color.DarkBlue;
                lblPreview.Text = string.Join("\n",
                    sys.Equations.Select(e => e.ToString()));
            }
            catch (Exception ex)
            {
                lblPreview.ForeColor = Color.Red;
                lblPreview.Text = "Error: " + ex.Message;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Result = Build();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Parse error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

        private DynamicSystem Build()
        {
            // Citim parametrii
            var parameters = new Dictionary<string, double>();
            foreach (DataGridViewRow row in gridParameters.Rows)
            {
                if (row.IsNewRow) continue;
                string name = row.Cells["pname"].Value?.ToString()?.Trim();
                string valStr = row.Cells["pvalue"].Value?.ToString();
                if (!string.IsNullOrEmpty(name) &&
                    double.TryParse(valStr, out double val))
                    parameters[name] = val;
            }

            // Citim ecuatiile
            var equations = new List<Equation>();
            foreach (DataGridViewRow row in gridEquations.Rows)
            {
                if (row.IsNewRow) continue;
                string varName = row.Cells["var"].Value?.ToString()?.Trim();
                string monomStr = row.Cells["monoms"].Value?.ToString() ?? "";
                if (string.IsNullOrEmpty(varName)) continue;

                var monoms = ParseMonoms(monomStr, parameters);
                if (!monoms.Any())
                    throw new InvalidOperationException(
                        $"Equation for '{varName}' has no valid monoms.");

                equations.Add(new Equation(varName, monoms));
            }

            if (!equations.Any())
                throw new InvalidOperationException(
                    "Add at least one equation.");

            string sysName = txtName.Text.Trim();
            if (string.IsNullOrEmpty(sysName))
                throw new InvalidOperationException("System name cannot be empty.");

            return new DynamicSystem(sysName, equations, parameters);
        }

        private List<Monom> ParseMonoms(string input,
                                         Dictionary<string, double> parameters)
        {
            var result = new List<Monom>();

            foreach (var part in input.Split(
                new[] { '|' }, StringSplitOptions.RemoveEmptyEntries))
            {
                string trimmed = part.Trim();
                if (string.IsNullOrEmpty(trimmed)) continue;

                var tokens = trimmed.Split(
                    new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 0) continue;

                double coef = ResolveCoef(tokens[0], parameters);
                var vars = new List<Variable>();

                for (int i = 1; i + 1 < tokens.Length; i += 2)
                {
                    string vname = tokens[i];
                    if (!int.TryParse(tokens[i + 1], out int power))
                        throw new FormatException(
                            $"Expected integer power after '{vname}', got '{tokens[i + 1]}'.");
                    vars.Add(new Variable(vname, power));
                }

                result.Add(vars.Any()
                    ? new Monom(coef, vars)
                    : Monom.Constant(coef));
            }

            return result;
        }

        private static double ResolveCoef(string token,
                                           Dictionary<string, double> parameters)
        {
            if (double.TryParse(token,
                    System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out double d))
                return d;

            bool negative = token.StartsWith("-");
            string key = token.TrimStart('-', '+');

            if (parameters.TryGetValue(key, out double pval))
                return negative ? -pval : pval;

            throw new ArgumentException(
                $"Unknown coefficient '{token}'. " +
                $"Add '{key}' to the Parameters table first.");
        }
    }
}
