using Fractals.Models;
using Fractals.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Form1 : Form
    {
        private List<Branch> branches = new List<Branch>();

        private BoxCountingEstimator boxEstimator = new BoxCountingEstimator();

        private bool showBoxes = false;

        private int currentDepth = 1;

        private int renderMode = 0;

        public Form1()
        {
            InitializeComponent();

            numSides.ValueChanged += Control_ValueChanged;
            numDepth.ValueChanged += Control_ValueChanged;
            numReduction.ValueChanged += Control_ValueChanged;
            trackProbability.Scroll += Control_ValueChanged;

            btnGenerate.Click += btnGenerate_Click;

            timer1.Tick += timer1_Tick;

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GenerateFractal();
        }

        private void GenerateFractal()
        {
            var parameters = new FractalParameters
            {
                PolygonSides = (int)numSides.Value,

                Center = new PointF(
                         panelCanvas.Width / 2f,
                        panelCanvas.Height / 2f),

                CircumscribedRadius = 150,

                ReductionFactor = (float)numReduction.Value / 100f,

                MaxDepth = currentDepth,

                BranchProbability = trackProbability.Value / 100f,

                EllipseA = 300,
                EllipseB = 200
            };

            var polygon = new PolygonBase();

            List<PointF> vertices = polygon.GenerateVertices(
                parameters.PolygonSides,
                parameters.Center,
                parameters.CircumscribedRadius
            );

            List<Branch> roots = new List<Branch>();

            foreach (var v in vertices)
            {
                roots.Add(new Branch(parameters.Center, v, 0));
            }

            EllipseConstraint ellipse = new EllipseConstraint(
                parameters.EllipseA,
                parameters.EllipseB,
                parameters.Center);

            RandomProvider random = new RandomProvider();

            BranchGenerator generator =
                new BranchGenerator(parameters, random, ellipse);

            FractalEngine engine = new FractalEngine(generator);

            branches = engine.Generate(roots);

            UpdateBoxCounting();

            panelCanvas.Invalidate();
        }

        private void UpdateBoxCounting()
        {
            if (!showBoxes)
                return;

            boxEstimator.Compute(branches, panelCanvas.Size);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            renderMode = 0;

            currentDepth = 1;

            timer1.Start();
        }


        private void Control_ValueChanged(object sender, EventArgs e)
        {
            GenerateFractal();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentDepth >= numDepth.Value)
            {
                timer1.Stop();
                return;
            }

            currentDepth++;

            GenerateFractal();
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (branches == null)
                return;

            FractalRenderer renderer = new FractalRenderer();

            renderer.Draw(e.Graphics, branches, renderMode);

            if (showBoxes)
            {
                using (Pen pen = new Pen(Color.Red, 1))
                {
                    foreach (var cell in boxEstimator.Cells)
                    {
                        e.Graphics.DrawRectangle(
                            pen,
                            cell.Rect.X,
                            cell.Rect.Y,
                            cell.Rect.Width,
                            cell.Rect.Height);
                    }
                }
            }
        }

        private void trackProbability_Scroll(object sender, EventArgs e)
        {
            lblProbability.Text = $"{trackProbability.Value}%";

            GenerateFractal();
        }

        private void btnBezierMode_Click(object sender, EventArgs e)
        {
            renderMode = 1;

            panelCanvas.Invalidate();
        }

        private void btnOrganic_Click(object sender, EventArgs e)
        {
            renderMode = 2;

            panelCanvas.Invalidate();
        }

        private void btnBoxCounting_Click(object sender, EventArgs e)
        {
            if (branches == null || branches.Count == 0)
                return;

            showBoxes = true;

            boxEstimator.Compute(branches, panelCanvas.Size);

            MessageBox.Show(
                "Estimated fractal dimension: " +
                boxEstimator.EstimatedDimension.ToString("0.###"));

            panelCanvas.Invalidate();
        }

        private void btnHideBoxes_Click(object sender, EventArgs e)
        {
            showBoxes = false;

            boxEstimator.Cells.Clear();

            panelCanvas.Invalidate();
        }
    }
}
