using Langston_s_Ant.Application;
using Langston_s_Ant.Domain;
using System.Linq;
using System.Windows.Forms;

namespace Langston_s_Ant
{
    public partial class Form1 : Form
    {
        private Simulation sim;
        private Timer timer;

        private int gridW = 200;
        private int gridH = 200;
        private int cellSize = 5;

        public Form1()
        {
            InitializeComponent();
            InitTimer();

            panelCanvas.Paint += PanelCanvas_Paint;
        }

        private void InitTimer()
        {
            timer = new Timer();
            timer.Interval = 10;

            timer.Tick += (s, e) =>
            {
                if (sim == null) return;

                for (int i = 0; i < trackSpeed.Value; i++)
                    sim.Step();

                lblStepsStatus.Text = $"Steps: {sim.Steps}";
                panelCanvas.Invalidate();
            };
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            if (!txtRules.Text.All(c => c == 'L' || c == 'R'))
            {
                MessageBox.Show("Rules must be only L and R");
                return;
            }

            IGrid grid;
            if (cmbGrid.SelectedIndex == 0)
                grid = new SquareGrid(gridW, gridH);
            else
                grid = new HexGrid(gridW, gridH);

            sim = new Simulation(
                grid,
                new AntRules(txtRules.Text),
                (int)numAnts.Value
            );

            timer.Start();
        }

        private void btnStop_Click(object sender, System.EventArgs e)
        {
            timer.Stop();
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            timer.Stop();
            sim = null; 

            lblStepsStatus.Text = "Steps: 0";
            panelCanvas.Invalidate();
        }
    }
}
