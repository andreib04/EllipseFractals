namespace Langston_s_Ant
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStepsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbGrid = new System.Windows.Forms.ComboBox();
            this.numAnts = new System.Windows.Forms.NumericUpDown();
            this.txtRules = new System.Windows.Forms.TextBox();
            this.trackSpeed = new System.Windows.Forms.TrackBar();
            this.panelTop.SuspendLayout();
            this.panelCanvas.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightGray;
            this.panelTop.Controls.Add(this.trackSpeed);
            this.panelTop.Controls.Add(this.txtRules);
            this.panelTop.Controls.Add(this.numAnts);
            this.panelTop.Controls.Add(this.cmbGrid);
            this.panelTop.Controls.Add(this.btnReset);
            this.panelTop.Controls.Add(this.btnStop);
            this.panelTop.Controls.Add(this.btnStart);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1087, 70);
            this.panelTop.TabIndex = 0;
            // 
            // panelCanvas
            // 
            this.panelCanvas.Controls.Add(this.statusStrip);
            this.panelCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCanvas.Location = new System.Drawing.Point(0, 70);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(1087, 626);
            this.panelCanvas.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStepsStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 604);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1087, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStepsStatus
            // 
            this.lblStepsStatus.Name = "lblStepsStatus";
            this.lblStepsStatus.Size = new System.Drawing.Size(47, 17);
            this.lblStepsStatus.Text = "Steps: 0";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(10, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(70, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(90, 20);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(70, 30);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(170, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 30);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbGrid
            // 
            this.cmbGrid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrid.FormattingEnabled = true;
            this.cmbGrid.Items.AddRange(new object[] {
            "Square",
            "Hex"});
            this.cmbGrid.Location = new System.Drawing.Point(260, 25);
            this.cmbGrid.Name = "cmbGrid";
            this.cmbGrid.Size = new System.Drawing.Size(100, 21);
            this.cmbGrid.TabIndex = 4;
            // 
            // numAnts
            // 
            this.numAnts.Location = new System.Drawing.Point(370, 25);
            this.numAnts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAnts.Name = "numAnts";
            this.numAnts.Size = new System.Drawing.Size(120, 20);
            this.numAnts.TabIndex = 5;
            this.numAnts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtRules
            // 
            this.txtRules.Location = new System.Drawing.Point(500, 25);
            this.txtRules.Name = "txtRules";
            this.txtRules.Size = new System.Drawing.Size(80, 20);
            this.txtRules.TabIndex = 6;
            // 
            // trackSpeed
            // 
            this.trackSpeed.Location = new System.Drawing.Point(590, 15);
            this.trackSpeed.Maximum = 50;
            this.trackSpeed.Minimum = 1;
            this.trackSpeed.Name = "trackSpeed";
            this.trackSpeed.Size = new System.Drawing.Size(150, 45);
            this.trackSpeed.TabIndex = 7;
            this.trackSpeed.Value = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 696);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCanvas.ResumeLayout(false);
            this.panelCanvas.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStepsStatus;
        private System.Windows.Forms.TrackBar trackSpeed;
        private System.Windows.Forms.TextBox txtRules;
        private System.Windows.Forms.NumericUpDown numAnts;
        private System.Windows.Forms.ComboBox cmbGrid;
    }
}

