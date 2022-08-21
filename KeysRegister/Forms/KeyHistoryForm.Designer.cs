namespace KeysRegister.Forms
{
    partial class KeyHistoryForm
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.keyHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.selectKeyButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyHistoryDataGridView)).BeginInit();
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.keyHistoryDataGridView, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.buttonsTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.36126F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.63874F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1263, 764);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // keyHistoryDataGridView
            // 
            this.keyHistoryDataGridView.AllowUserToAddRows = false;
            this.keyHistoryDataGridView.AllowUserToDeleteRows = false;
            this.keyHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keyHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyHistoryDataGridView.Location = new System.Drawing.Point(3, 128);
            this.keyHistoryDataGridView.Name = "keyHistoryDataGridView";
            this.keyHistoryDataGridView.ReadOnly = true;
            this.keyHistoryDataGridView.RowHeadersWidth = 51;
            this.keyHistoryDataGridView.RowTemplate.Height = 29;
            this.keyHistoryDataGridView.Size = new System.Drawing.Size(1257, 633);
            this.keyHistoryDataGridView.TabIndex = 0;
            // 
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.ColumnCount = 3;
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTableLayoutPanel.Controls.Add(this.selectKeyButton, 1, 0);
            this.buttonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 3;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(1257, 119);
            this.buttonsTableLayoutPanel.TabIndex = 1;
            // 
            // selectKeyButton
            // 
            this.selectKeyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectKeyButton.Location = new System.Drawing.Point(422, 3);
            this.selectKeyButton.Name = "selectKeyButton";
            this.selectKeyButton.Size = new System.Drawing.Size(413, 33);
            this.selectKeyButton.TabIndex = 0;
            this.selectKeyButton.Text = "Wybierz klucz";
            this.selectKeyButton.UseVisualStyleBackColor = true;
            this.selectKeyButton.Click += new System.EventHandler(this.selectKeyButton_Click);
            // 
            // KeyHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 764);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "KeyHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KeyHistoryForm";
            this.mainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.keyHistoryDataGridView)).EndInit();
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private DataGridView keyHistoryDataGridView;
        private TableLayoutPanel buttonsTableLayoutPanel;
        private Button selectKeyButton;
    }
}