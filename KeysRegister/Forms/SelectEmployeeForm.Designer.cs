namespace KeysRegister.Forms
{
    partial class SelectEmployeeForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.searchLabel);
            this.splitContainer1.Panel1.Controls.Add(this.searchTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.employeeDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.TabIndex = 0;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(62, 41);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(186, 20);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Wpisz dane do wyszukania";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(265, 34);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(345, 27);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToAddRows = false;
            this.employeeDataGridView.AllowUserToDeleteRows = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 29;
            this.employeeDataGridView.Size = new System.Drawing.Size(800, 355);
            this.employeeDataGridView.TabIndex = 0;
            this.employeeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGridView_CellDoubleClick);
            // 
            // SelectEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SelectEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wybór osoby";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox searchTextBox;
        private DataGridView employeeDataGridView;
        private Label searchLabel;
    }
}