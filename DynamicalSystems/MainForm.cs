using DynamicalSystems.Core;
using DynamicalSystems.Systems;
using DynamicalSystems.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DynamicalSystems
{
    public partial class MainForm : Form
    {
        private DynamicSystem _system;

        public MainForm()
        {
            InitializeComponent();
            InitializeChart();
            InitializeSystemCombo();
        }

        private void InitializeChart()
        {
            chart.Series.Clear();

            chart.ChartAreas.Clear();
            var area = new ChartArea("main");
            area.BackColor = Color.White;
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 8);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 8);
            chart.ChartAreas.Add(area);
        }

        private void InitializeSystemCombo()
        {
            cmbSystem.Items.Clear();
            cmbSystem.Items.Add("Hénon Map");
            cmbSystem.Items.Add("Logistic Map");
            cmbSystem.Items.Add("Ikeda Map");
            cmbSystem.Items.Add("Tent Map");
            cmbSystem.Items.Add("Custom...");
            cmbSystem.SelectedIndex = 0;
        }

        private void cmbSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbSystem.SelectedItem?.ToString();

            if (selected == "Custom...") return;

            if (selected == "Hénon Map")
                _system = KnownSystems.Henon();
            else if (selected == "Logistic Map")
                _system = KnownSystems.Logistic();
            else if (selected == "Ikeda Map")
                _system = KnownSystems.Ikeda();
            else if (selected == "Tent Map")
                _system = KnownSystems.TentMap();

            if (_system != null) RefreshUI();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var form = new SystemEditorForm(_system))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    _system = form.Result;

                    if (!cmbSystem.Items.Contains(_system.Name))
                        cmbSystem.Items.Insert(cmbSystem.Items.Count - 1, _system.Name);

                    cmbSystem.SelectedItem = _system.Name;
                    RefreshUI();
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (_system == null)
            {
                MessageBox.Show("Please select or build a system first.",
                    "No System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Citim parametrii din grid
            foreach (DataGridViewRow row in gridParams.Rows)
            {
                if (row.IsNewRow) continue;
                string key = row.Cells[0].Value?.ToString();
                if (double.TryParse(row.Cells[1].Value?.ToString(), out double val) && key != null)
                    _system.Parameters[key] = val;
            }

            // Citim starea initiala
            var initial = new Dictionary<string, double>();
            foreach (DataGridViewRow row in gridInitial.Rows)
            {
                if (row.IsNewRow) continue;
                string key = row.Cells[0].Value?.ToString();
                if (double.TryParse(row.Cells[1].Value?.ToString(), out double val) && key != null)
                    initial[key] = val;
            }

            if (!initial.Any())
            {
                MessageBox.Show("Initial state is empty.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var orbit = _system.Iterate(initial, (int)numSteps.Value, (int)numTransient.Value);
                DrawChart(orbit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Simulation error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshUI()
        {
            // Ecuatii preview
            lblEquations.Text = string.Join("\n", _system.Equations.Select(e => e.ToString()));

            // Parametri
            gridParams.Rows.Clear();
            foreach (var p in _system.Parameters)
                gridParams.Rows.Add(p.Key, p.Value);

            // Stare initiala
            gridInitial.Rows.Clear();
            foreach (var v in _system.StateVariables)
                gridInitial.Rows.Add(v, "0.1");
        }

        private void DrawChart(List<Dictionary<string, double>> orbit)
        {
            chart.Series.Clear();
            var vars = _system.StateVariables;
            var area = chart.ChartAreas["main"];

            if (vars.Count >= 2)
            {
                area.AxisX.Title = vars[0];
                area.AxisY.Title = vars[1];

                var series = new Series("orbit")
                {
                    ChartType = SeriesChartType.Point,
                    MarkerSize = 3,
                    MarkerStyle = MarkerStyle.Circle,
                    Color = Color.FromArgb(160, Color.SteelBlue)
                };

                foreach (var state in orbit)
                    series.Points.AddXY(state[vars[0]], state[vars[1]]);

                chart.Series.Add(series);
            }
            else
            {
                area.AxisX.Title = "t";
                area.AxisY.Title = vars[0];

                var series = new Series("x(t)")
                {
                    ChartType = SeriesChartType.Line,
                    Color = Color.SteelBlue
                };

                for (int i = 0; i < orbit.Count; i++)
                    series.Points.AddXY(i, orbit[i][vars[0]]);

                chart.Series.Add(series);
            }
        }

    
    }
}
