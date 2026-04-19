using Langston_s_Ant.Application;
using Langston_s_Ant.Domain;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private int cellSize = 4;

        private Bitmap gridBitmap;
        private bool bitmapDirty = true;

        private int offsetX = 0;
        private int offsetY = 0;

        public Form1()
        {
            InitializeComponent();
            InitTimer();

            panelCanvas.Paint += panelCanvas_Paint_1;
            panelCanvas.MouseWheel += panelCanvas_Scroll;
        }

        private void InitTimer()
        {
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += timer1_Tick;
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRules.Text) ||
                !txtRules.Text.All(c => c == 'L' || c == 'R'))
            {
                MessageBox.Show(
                    "Rules must contain only L and R (e.g. RL, RLLR)",
                    "Invalid Rules",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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

            gridBitmap = new Bitmap(gridW * cellSize, gridH * cellSize);
            bitmapDirty = true;

            btnStart.Enabled = false;
            btnStop.Enabled = true;

            timer.Start();
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            timer.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            timer.Stop();
            sim = null;

            if (gridBitmap != null)
            {
                gridBitmap.Dispose();
                gridBitmap = null;
            }

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblStepsStatus.Text = "Steps: 0";
            panelCanvas.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sim == null) return;

            int steps = trackSpeed.Value * 5;

            for (int i = 0; i < steps; i++)
                sim.Step();

            bitmapDirty = true;
            lblStepsStatus.Text = "Steps: " + sim.Steps.ToString("N0");
            panelCanvas.Invalidate();
        }

        private void RecalcOffset()
        {
            offsetX = Math.Max(0, (panelCanvas.Width - gridW * cellSize) / 2);
            offsetY = Math.Max(0, (panelCanvas.Height - gridH * cellSize) / 2);
        }
        
        private void panelCanvas_Paint_1(object sender, PaintEventArgs e)
        {
            if (sim == null)
            {
                DrawPlaceholder(e.Graphics);
                return;
            }

            RecalcOffset();

            if (bitmapDirty)
            {
                RebuildBitmap();
                bitmapDirty = false;
            }

            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

            e.Graphics.DrawImage(gridBitmap, offsetX, offsetY);

            DrawAnts(e.Graphics);
        }

        private void panelCanvas_Scroll(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && cellSize < 20)
                cellSize++;
            else if (e.Delta < 0 && cellSize > 1)
                cellSize--;

            if (gridBitmap != null)
            {
                gridBitmap.Dispose();
                gridBitmap = null;
            }

            bitmapDirty = true;
            panelCanvas.Invalidate();
        }

        private void RebuildBitmap()
        {
            if (gridBitmap == null || gridBitmap.Width != gridW * cellSize || gridBitmap.Height != gridH * cellSize)
            {
                if (gridBitmap != null) 
                    gridBitmap.Dispose();
                
                gridBitmap = new Bitmap(gridW * cellSize, gridH * cellSize);
            }

            using (Graphics g = Graphics.FromImage(gridBitmap))
            {
                g.Clear(Color.White);

                for (int x = 0; x < gridW; x++)
                {
                    for (int y = 0; y < gridH; y++)
                    {
                        int state = sim.GetState(x, y);
                        if (state == 0) continue;

                        using (SolidBrush b = new SolidBrush(GetColor(state)))
                        {
                            g.FillRectangle(b,
                                x * cellSize,
                                y * cellSize,
                                cellSize,
                                cellSize);
                        }
                    }
                }
            }
        }

        private void DrawAnts(Graphics g)
        {
            int antSize = Math.Max(cellSize, 4);

            foreach (var ant in sim.Ants)
            {
                int px = offsetX + ant.X * cellSize;
                int py = offsetY + ant.Y * cellSize;

                using (SolidBrush fill = new SolidBrush(Color.Red))
                    g.FillEllipse(fill, px, py, antSize, antSize);

                using (Pen outline = new Pen(Color.DarkRed, 1))
                    g.DrawEllipse(outline, px, py, antSize, antSize);
            }
        }

        private void DrawPlaceholder(Graphics g)
        {
            g.Clear(Color.FromArgb(245, 245, 245));

            using (Font font = new Font("Segoe UI", 14, FontStyle.Regular))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(180, 180, 180)))
            {
                string msg = "Configure and press Start";
                SizeF size = g.MeasureString(msg, font);
                g.DrawString(
                    msg, font, brush,
                    (panelCanvas.Width - size.Width) / 2f,
                    (panelCanvas.Height - size.Height) / 2f
                );
            }
        }

        private Color GetColor(int state)
        {
            switch (state)
            {
                case 0: return Color.White;
                case 1: return Color.FromArgb(30, 30, 30);
                case 2: return Color.FromArgb(220, 50, 50);
                case 3: return Color.FromArgb(50, 100, 220);
                case 4: return Color.FromArgb(50, 180, 80);
                case 5: return Color.FromArgb(220, 160, 20);
                default: return Color.FromArgb(140, 80, 200);
            }
        }
    }
}
