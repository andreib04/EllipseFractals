namespace DynamicalSystems
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblSystem = new System.Windows.Forms.Label();
            this.cmbSystem = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblEquations = new System.Windows.Forms.Label();
            this.lblParams = new System.Windows.Forms.Label();
            this.gridParams = new System.Windows.Forms.DataGridView();
            this.lblInitial = new System.Windows.Forms.Label();
            this.gridInitial = new System.Windows.Forms.DataGridView();
            this.lblSteps = new System.Windows.Forms.Label();
            this.numSteps = new System.Windows.Forms.NumericUpDown();
            this.lblTransient = new System.Windows.Forms.Label();
            this.numTransient = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Var = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Val = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridParams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTransient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.panelLeft);
            this.splitMain.Panel1MinSize = 250;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.chart);
            this.splitMain.Panel2MinSize = 400;
            this.splitMain.Size = new System.Drawing.Size(1265, 786);
            this.splitMain.SplitterDistance = 280;
            this.splitMain.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.AutoScroll = true;
            this.panelLeft.Controls.Add(this.btnRun);
            this.panelLeft.Controls.Add(this.numTransient);
            this.panelLeft.Controls.Add(this.lblTransient);
            this.panelLeft.Controls.Add(this.numSteps);
            this.panelLeft.Controls.Add(this.lblSteps);
            this.panelLeft.Controls.Add(this.gridInitial);
            this.panelLeft.Controls.Add(this.lblInitial);
            this.panelLeft.Controls.Add(this.gridParams);
            this.panelLeft.Controls.Add(this.lblParams);
            this.panelLeft.Controls.Add(this.lblEquations);
            this.panelLeft.Controls.Add(this.btnEdit);
            this.panelLeft.Controls.Add(this.cmbSystem);
            this.panelLeft.Controls.Add(this.lblSystem);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(8);
            this.panelLeft.Size = new System.Drawing.Size(280, 786);
            this.panelLeft.TabIndex = 0;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.Location = new System.Drawing.Point(8, 8);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(51, 15);
            this.lblSystem.TabIndex = 0;
            this.lblSystem.Text = "System:";
            // 
            // cmbSystem
            // 
            this.cmbSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSystem.DropDownWidth = 121;
            this.cmbSystem.FormattingEnabled = true;
            this.cmbSystem.Location = new System.Drawing.Point(8, 26);
            this.cmbSystem.Name = "cmbSystem";
            this.cmbSystem.Size = new System.Drawing.Size(248, 23);
            this.cmbSystem.TabIndex = 1;
            this.cmbSystem.SelectedIndexChanged += new System.EventHandler(this.cmbSystem_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(8, 55);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(248, 28);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit / Build system... ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblEquations
            // 
            this.lblEquations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEquations.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquations.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblEquations.Location = new System.Drawing.Point(8, 90);
            this.lblEquations.Name = "lblEquations";
            this.lblEquations.Size = new System.Drawing.Size(248, 75);
            this.lblEquations.TabIndex = 3;
            this.lblEquations.Text = "(no system)";
            // 
            // lblParams
            // 
            this.lblParams.AutoSize = true;
            this.lblParams.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParams.Location = new System.Drawing.Point(8, 173);
            this.lblParams.Name = "lblParams";
            this.lblParams.Size = new System.Drawing.Size(77, 15);
            this.lblParams.TabIndex = 4;
            this.lblParams.Text = "Parameters: ";
            // 
            // gridParams
            // 
            this.gridParams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridParams.ColumnHeadersHeight = 22;
            this.gridParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Val});
            this.gridParams.Location = new System.Drawing.Point(8, 193);
            this.gridParams.Name = "gridParams";
            this.gridParams.RowHeadersVisible = false;
            this.gridParams.Size = new System.Drawing.Size(248, 110);
            this.gridParams.TabIndex = 5;
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitial.Location = new System.Drawing.Point(8, 312);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(75, 15);
            this.lblInitial.TabIndex = 6;
            this.lblInitial.Text = "Initial state: ";
            // 
            // gridInitial
            // 
            this.gridInitial.AllowUserToAddRows = false;
            this.gridInitial.AllowUserToDeleteRows = false;
            this.gridInitial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridInitial.ColumnHeadersHeight = 22;
            this.gridInitial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridInitial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Var,
            this.Value});
            this.gridInitial.Location = new System.Drawing.Point(8, 332);
            this.gridInitial.Name = "gridInitial";
            this.gridInitial.RowHeadersVisible = false;
            this.gridInitial.Size = new System.Drawing.Size(248, 80);
            this.gridInitial.TabIndex = 7;
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteps.Location = new System.Drawing.Point(8, 422);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(44, 15);
            this.lblSteps.TabIndex = 8;
            this.lblSteps.Text = "Steps: ";
            // 
            // numSteps
            // 
            this.numSteps.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSteps.Location = new System.Drawing.Point(8, 440);
            this.numSteps.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSteps.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numSteps.Name = "numSteps";
            this.numSteps.Size = new System.Drawing.Size(248, 23);
            this.numSteps.TabIndex = 9;
            this.numSteps.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lblTransient
            // 
            this.lblTransient.AutoSize = true;
            this.lblTransient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransient.Location = new System.Drawing.Point(8, 470);
            this.lblTransient.Name = "lblTransient";
            this.lblTransient.Size = new System.Drawing.Size(64, 15);
            this.lblTransient.TabIndex = 10;
            this.lblTransient.Text = "Transient: ";
            // 
            // numTransient
            // 
            this.numTransient.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTransient.Location = new System.Drawing.Point(8, 488);
            this.numTransient.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTransient.Name = "numTransient";
            this.numTransient.Size = new System.Drawing.Size(248, 23);
            this.numTransient.TabIndex = 11;
            this.numTransient.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRun.Location = new System.Drawing.Point(8, 522);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(248, 34);
            this.btnRun.TabIndex = 12;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // chart
            // 
            chartArea4.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea4);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart.Legends.Add(legend4);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(981, 786);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // Var
            // 
            this.Var.HeaderText = "Variable";
            this.Var.Name = "Var";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // Key
            // 
            this.Key.HeaderText = "Name";
            this.Key.Name = "Key";
            // 
            // Val
            // 
            this.Val.HeaderText = "Val";
            this.Val.Name = "Val";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 786);
            this.Controls.Add(this.splitMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1047, 686);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discrete Dynamic Systems";
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridParams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTransient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.ComboBox cmbSystem;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblEquations;
        private System.Windows.Forms.Label lblParams;
        private System.Windows.Forms.DataGridView gridParams;
        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.DataGridView gridInitial;
        private System.Windows.Forms.Label lblTransient;
        private System.Windows.Forms.NumericUpDown numSteps;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.NumericUpDown numTransient;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Var;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Val;
    }
}

