namespace DynamicalSystems.UI
{
    partial class SystemEditorForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEqInfo = new System.Windows.Forms.Label();
            this.gridEquations = new System.Windows.Forms.DataGridView();
            this.lblParamsInfo = new System.Windows.Forms.Label();
            this.gridParameters = new System.Windows.Forms.DataGridView();
            this.lblPreview = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridParameters)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(10, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "System name: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "My System";
            // 
            // lblEqInfo
            // 
            this.lblEqInfo.Location = new System.Drawing.Point(10, 45);
            this.lblEqInfo.Name = "lblEqInfo";
            this.lblEqInfo.Size = new System.Drawing.Size(640, 18);
            this.lblEqInfo.TabIndex = 2;
            this.lblEqInfo.Text = "Equations  (monoms separated by pipe: coef  or  coef var pow  or  coef var pow va" +
    "r pow ...)";
            // 
            // gridEquations
            // 
            this.gridEquations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEquations.ColumnHeadersHeight = 22;
            this.gridEquations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridEquations.Location = new System.Drawing.Point(10, 68);
            this.gridEquations.Name = "gridEquations";
            this.gridEquations.RowHeadersVisible = false;
            this.gridEquations.Size = new System.Drawing.Size(640, 160);
            this.gridEquations.TabIndex = 3;
            // 
            // lblParamsInfo
            // 
            this.lblParamsInfo.AutoSize = true;
            this.lblParamsInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParamsInfo.Location = new System.Drawing.Point(10, 238);
            this.lblParamsInfo.Name = "lblParamsInfo";
            this.lblParamsInfo.Size = new System.Drawing.Size(209, 15);
            this.lblParamsInfo.TabIndex = 5;
            this.lblParamsInfo.Text = "Parameters: (name + numeric value)";
            // 
            // gridParameters
            // 
            this.gridParameters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridParameters.ColumnHeadersHeight = 22;
            this.gridParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridParameters.Location = new System.Drawing.Point(10, 258);
            this.gridParameters.Name = "gridParameters";
            this.gridParameters.RowHeadersVisible = false;
            this.gridParameters.Size = new System.Drawing.Size(640, 100);
            this.gridParameters.TabIndex = 6;
            // 
            // lblPreview
            // 
            this.lblPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPreview.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPreview.Location = new System.Drawing.Point(10, 368);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(640, 60);
            this.lblPreview.TabIndex = 7;
            this.lblPreview.Text = "(preview)";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(490, 440);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 28);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(580, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SystemEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 555);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.gridParameters);
            this.Controls.Add(this.lblParamsInfo);
            this.Controls.Add(this.gridEquations);
            this.Controls.Add(this.lblEqInfo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SystemEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "System Editor";
            ((System.ComponentModel.ISupportInitialize)(this.gridEquations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridParameters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEqInfo;
        private System.Windows.Forms.DataGridView gridEquations;
        private System.Windows.Forms.Label lblParamsInfo;
        private System.Windows.Forms.DataGridView gridParameters;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}