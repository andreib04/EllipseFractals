namespace Fractals
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.numSides = new System.Windows.Forms.NumericUpDown();
            this.numDepth = new System.Windows.Forms.NumericUpDown();
            this.numReduction = new System.Windows.Forms.NumericUpDown();
            this.trackProbability = new System.Windows.Forms.TrackBar();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.lblProbability = new System.Windows.Forms.Label();
            this.btnBezierMode = new System.Windows.Forms.Button();
            this.btnOrganic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackProbability)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCanvas
            // 
            this.panelCanvas.Location = new System.Drawing.Point(13, 13);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(1071, 664);
            this.panelCanvas.TabIndex = 0;
            this.panelCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCanvas_Paint);
            // 
            // numSides
            // 
            this.numSides.Location = new System.Drawing.Point(1106, 34);
            this.numSides.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSides.Name = "numSides";
            this.numSides.Size = new System.Drawing.Size(120, 20);
            this.numSides.TabIndex = 1;
            this.numSides.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numDepth
            // 
            this.numDepth.Location = new System.Drawing.Point(1106, 91);
            this.numDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDepth.Name = "numDepth";
            this.numDepth.Size = new System.Drawing.Size(120, 20);
            this.numDepth.TabIndex = 2;
            this.numDepth.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numReduction
            // 
            this.numReduction.Location = new System.Drawing.Point(1106, 155);
            this.numReduction.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numReduction.Name = "numReduction";
            this.numReduction.Size = new System.Drawing.Size(120, 20);
            this.numReduction.TabIndex = 3;
            this.numReduction.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // trackProbability
            // 
            this.trackProbability.Location = new System.Drawing.Point(1106, 232);
            this.trackProbability.Maximum = 100;
            this.trackProbability.Name = "trackProbability";
            this.trackProbability.Size = new System.Drawing.Size(120, 45);
            this.trackProbability.TabIndex = 4;
            this.trackProbability.Value = 80;
            this.trackProbability.Scroll += new System.EventHandler(this.trackProbability_Scroll);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(1106, 302);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 38);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(1106, 13);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(120, 22);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.Text = "Number of sides";
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(1106, 63);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(120, 22);
            this.maskedTextBox2.TabIndex = 7;
            this.maskedTextBox2.Text = "Max depth";
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox3.Location = new System.Drawing.Point(1106, 127);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(120, 22);
            this.maskedTextBox3.TabIndex = 8;
            this.maskedTextBox3.Text = "Reduction factor";
            this.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.maskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox4.Location = new System.Drawing.Point(1106, 204);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(120, 22);
            this.maskedTextBox4.TabIndex = 9;
            this.maskedTextBox4.Text = "Branch probability";
            this.maskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProbability
            // 
            this.lblProbability.Location = new System.Drawing.Point(1232, 232);
            this.lblProbability.Name = "lblProbability";
            this.lblProbability.Size = new System.Drawing.Size(100, 23);
            this.lblProbability.TabIndex = 10;
            this.lblProbability.Text = "80%";
            // 
            // btnBezierMode
            // 
            this.btnBezierMode.Location = new System.Drawing.Point(1106, 355);
            this.btnBezierMode.Name = "btnBezierMode";
            this.btnBezierMode.Size = new System.Drawing.Size(120, 38);
            this.btnBezierMode.TabIndex = 11;
            this.btnBezierMode.Text = "Show Curved Tree";
            this.btnBezierMode.UseVisualStyleBackColor = true;
            this.btnBezierMode.Click += new System.EventHandler(this.btnBezierMode_Click);
            // 
            // btnOrganic
            // 
            this.btnOrganic.Location = new System.Drawing.Point(1106, 408);
            this.btnOrganic.Name = "btnOrganic";
            this.btnOrganic.Size = new System.Drawing.Size(120, 38);
            this.btnOrganic.TabIndex = 12;
            this.btnOrganic.Text = "Show Organic Tree";
            this.btnOrganic.UseVisualStyleBackColor = true;
            this.btnOrganic.Click += new System.EventHandler(this.btnOrganic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 689);
            this.Controls.Add(this.btnOrganic);
            this.Controls.Add(this.btnBezierMode);
            this.Controls.Add(this.lblProbability);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.trackProbability);
            this.Controls.Add(this.numReduction);
            this.Controls.Add(this.numDepth);
            this.Controls.Add(this.numSides);
            this.Controls.Add(this.panelCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numSides)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackProbability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.NumericUpDown numSides;
        private System.Windows.Forms.NumericUpDown numDepth;
        private System.Windows.Forms.NumericUpDown numReduction;
        private System.Windows.Forms.TrackBar trackProbability;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        public System.Windows.Forms.Label lblProbability;
        private System.Windows.Forms.Button btnBezierMode;
        private System.Windows.Forms.Button btnOrganic;
    }
}

