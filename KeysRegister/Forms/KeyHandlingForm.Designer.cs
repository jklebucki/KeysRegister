namespace KeysRegister.Forms
{
    partial class KeyHandlingForm
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
            this.scanLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.keysDataGridView = new System.Windows.Forms.DataGridView();
            this.infoLabel = new System.Windows.Forms.Label();
            this.employeeTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.employeeLastNameLabel = new System.Windows.Forms.Label();
            this.employeeFirstNameLabel = new System.Windows.Forms.Label();
            this.employeeDepartmentLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keysDataGridView)).BeginInit();
            this.employeeTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // scanLabel
            // 
            this.scanLabel.AutoSize = true;
            this.scanLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scanLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scanLabel.Location = new System.Drawing.Point(3, 0);
            this.scanLabel.Name = "scanLabel";
            this.scanLabel.Size = new System.Drawing.Size(794, 60);
            this.scanLabel.TabIndex = 1;
            this.scanLabel.Text = "Zeskanuj indentyfikator";
            this.scanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.scanLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.keysDataGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.infoLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.employeeTableLayout, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 451);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // keysDataGridView
            // 
            this.keysDataGridView.AllowUserToAddRows = false;
            this.keysDataGridView.AllowUserToDeleteRows = false;
            this.keysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keysDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keysDataGridView.Enabled = false;
            this.keysDataGridView.Location = new System.Drawing.Point(3, 172);
            this.keysDataGridView.Name = "keysDataGridView";
            this.keysDataGridView.ReadOnly = true;
            this.keysDataGridView.RowHeadersWidth = 51;
            this.keysDataGridView.RowTemplate.Height = 29;
            this.keysDataGridView.Size = new System.Drawing.Size(794, 238);
            this.keysDataGridView.TabIndex = 2;
            this.keysDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyHandlingForm_KeyPress);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.Location = new System.Drawing.Point(3, 413);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(794, 38);
            this.infoLabel.TabIndex = 3;
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeeTableLayout
            // 
            this.employeeTableLayout.ColumnCount = 5;
            this.employeeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.employeeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.employeeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.employeeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.employeeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.employeeTableLayout.Controls.Add(this.employeeLabel, 2, 0);
            this.employeeTableLayout.Controls.Add(this.employeeLastNameLabel, 2, 1);
            this.employeeTableLayout.Controls.Add(this.employeeFirstNameLabel, 1, 1);
            this.employeeTableLayout.Controls.Add(this.employeeDepartmentLabel, 3, 1);
            this.employeeTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeTableLayout.Location = new System.Drawing.Point(3, 63);
            this.employeeTableLayout.Name = "employeeTableLayout";
            this.employeeTableLayout.RowCount = 3;
            this.employeeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.employeeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.employeeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.employeeTableLayout.Size = new System.Drawing.Size(794, 103);
            this.employeeTableLayout.TabIndex = 4;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeLabel.Location = new System.Drawing.Point(271, 3);
            this.employeeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(252, 28);
            this.employeeLabel.TabIndex = 0;
            this.employeeLabel.Text = "Pobierający";
            this.employeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeeLastNameLabel
            // 
            this.employeeLastNameLabel.AutoSize = true;
            this.employeeLastNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeLastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeLastNameLabel.Location = new System.Drawing.Point(271, 37);
            this.employeeLastNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.employeeLastNameLabel.Name = "employeeLastNameLabel";
            this.employeeLastNameLabel.Size = new System.Drawing.Size(252, 28);
            this.employeeLastNameLabel.TabIndex = 2;
            this.employeeLastNameLabel.Text = "Nazwisko";
            this.employeeLastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // employeeFirstNameLabel
            // 
            this.employeeFirstNameLabel.AutoSize = true;
            this.employeeFirstNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeFirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeFirstNameLabel.Location = new System.Drawing.Point(13, 37);
            this.employeeFirstNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.employeeFirstNameLabel.Name = "employeeFirstNameLabel";
            this.employeeFirstNameLabel.Size = new System.Drawing.Size(252, 28);
            this.employeeFirstNameLabel.TabIndex = 1;
            this.employeeFirstNameLabel.Text = "Imię";
            this.employeeFirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // employeeDepartmentLabel
            // 
            this.employeeDepartmentLabel.AutoSize = true;
            this.employeeDepartmentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDepartmentLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeDepartmentLabel.Location = new System.Drawing.Point(529, 37);
            this.employeeDepartmentLabel.Margin = new System.Windows.Forms.Padding(3);
            this.employeeDepartmentLabel.Name = "employeeDepartmentLabel";
            this.employeeDepartmentLabel.Size = new System.Drawing.Size(252, 28);
            this.employeeDepartmentLabel.TabIndex = 3;
            this.employeeDepartmentLabel.Text = "Dział";
            this.employeeDepartmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KeyHandlingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KeyHandlingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KeyHandlingForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyHandlingForm_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keysDataGridView)).EndInit();
            this.employeeTableLayout.ResumeLayout(false);
            this.employeeTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label scanLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView keysDataGridView;
        private Label infoLabel;
        private TableLayoutPanel employeeTableLayout;
        private Label employeeLabel;
        private Label employeeFirstNameLabel;
        private Label employeeLastNameLabel;
        private Label employeeDepartmentLabel;
    }
}