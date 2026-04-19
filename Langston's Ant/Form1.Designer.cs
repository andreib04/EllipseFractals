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
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStepsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblGrid = new System.Windows.Forms.Label();
            this.cmbGrid = new System.Windows.Forms.ComboBox();
            this.lblAnts = new System.Windows.Forms.Label();
            this.numAnts = new System.Windows.Forms.NumericUpDown();
            this.lblRules = new System.Windows.Forms.Label();
            this.txtRules = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.trackSpeed = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.panelCanvas.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelTop.Controls.Add(this.trackSpeed);
            this.panelTop.Controls.Add(this.lblSpeed);
            this.panelTop.Controls.Add(this.txtRules);
            this.panelTop.Controls.Add(this.lblRules);
            this.panelTop.Controls.Add(this.numAnts);
            this.panelTop.Controls.Add(this.lblAnts);
            this.panelTop.Controls.Add(this.cmbGrid);
            this.panelTop.Controls.Add(this.lblGrid);
            this.panelTop.Controls.Add(this.btnReset);
            this.panelTop.Controls.Add(this.btnStop);
            this.panelTop.Controls.Add(this.btnStart);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1087, 80);
            this.panelTop.TabIndex = 0;
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.Color.White;
            this.panelCanvas.Controls.Add(this.statusStrip1);
            this.panelCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCanvas.Location = new System.Drawing.Point(0, 80);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(1087, 616);
            this.panelCanvas.TabIndex = 1;
            this.panelCanvas.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_Scroll);
            this.panelCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCanvas_Paint_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStepsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 594);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1087, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStepsStatus
            // 
            this.lblStepsStatus.ForeColor = System.Drawing.Color.White;
            this.lblStepsStatus.Name = "lblStepsStatus";
            this.lblStepsStatus.Size = new System.Drawing.Size(47, 17);
            this.lblStepsStatus.Text = "Steps: 0";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(80)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(12, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(102, 22);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(84, 36);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(192, 22);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 36);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // lblGrid
            // 
            this.lblGrid.AutoSize = true;
            this.lblGrid.BackColor = System.Drawing.Color.Transparent;
            this.lblGrid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblGrid.Location = new System.Drawing.Point(297, 14);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(29, 15);
            this.lblGrid.TabIndex = 3;
            this.lblGrid.Text = "Grid";
            // 
            // cmbGrid
            // 
            this.cmbGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.cmbGrid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGrid.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrid.ForeColor = System.Drawing.Color.White;
            this.cmbGrid.FormattingEnabled = true;
            this.cmbGrid.Items.AddRange(new object[] {
            "Square",
            "Hex"});
            this.cmbGrid.Location = new System.Drawing.Point(300, 34);
            this.cmbGrid.Name = "cmbGrid";
            this.cmbGrid.Size = new System.Drawing.Size(90, 21);
            this.cmbGrid.TabIndex = 4;
            // 
            // lblAnts
            // 
            this.lblAnts.AutoSize = true;
            this.lblAnts.BackColor = System.Drawing.Color.Transparent;
            this.lblAnts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblAnts.Location = new System.Drawing.Point(408, 14);
            this.lblAnts.Name = "lblAnts";
            this.lblAnts.Size = new System.Drawing.Size(31, 15);
            this.lblAnts.TabIndex = 5;
            this.lblAnts.Text = "Ants";
            // 
            // numAnts
            // 
            this.numAnts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.numAnts.ForeColor = System.Drawing.Color.White;
            this.numAnts.Location = new System.Drawing.Point(408, 34);
            this.numAnts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAnts.Name = "numAnts";
            this.numAnts.Size = new System.Drawing.Size(60, 20);
            this.numAnts.TabIndex = 6;
            this.numAnts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.BackColor = System.Drawing.Color.Transparent;
            this.lblRules.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblRules.Location = new System.Drawing.Point(486, 14);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(35, 15);
            this.lblRules.TabIndex = 7;
            this.lblRules.Text = "Rules";
            // 
            // txtRules
            // 
            this.txtRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.txtRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRules.ForeColor = System.Drawing.Color.White;
            this.txtRules.Location = new System.Drawing.Point(486, 34);
            this.txtRules.Name = "txtRules";
            this.txtRules.Size = new System.Drawing.Size(90, 20);
            this.txtRules.TabIndex = 8;
            this.txtRules.Text = "RL";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblSpeed.Location = new System.Drawing.Point(596, 14);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(39, 15);
            this.lblSpeed.TabIndex = 9;
            this.lblSpeed.Text = "Speed";
            // 
            // trackSpeed
            // 
            this.trackSpeed.Location = new System.Drawing.Point(590, 30);
            this.trackSpeed.Maximum = 50;
            this.trackSpeed.Minimum = 1;
            this.trackSpeed.Name = "trackSpeed";
            this.trackSpeed.Size = new System.Drawing.Size(200, 45);
            this.trackSpeed.TabIndex = 10;
            this.trackSpeed.TickFrequency = 10;
            this.trackSpeed.Value = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStepsStatus;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numAnts;
        private System.Windows.Forms.Label lblAnts;
        private System.Windows.Forms.ComboBox cmbGrid;
        private System.Windows.Forms.TextBox txtRules;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.TrackBar trackSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Timer timer1;
    }
}

