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
            this.dateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dateFromLabel = new System.Windows.Forms.Label();
            this.dateFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyHistoryDataGridView)).BeginInit();
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.dateTableLayoutPanel.SuspendLayout();
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
            this.keyHistoryDataGridView.RowHeadersVisible = false;
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
            this.buttonsTableLayoutPanel.Controls.Add(this.dateTableLayoutPanel, 1, 1);
            this.buttonsTableLayoutPanel.Controls.Add(this.selectKeyButton, 1, 2);
            this.buttonsTableLayoutPanel.Controls.Add(this.label1, 1, 0);
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
            this.selectKeyButton.Location = new System.Drawing.Point(422, 81);
            this.selectKeyButton.Name = "selectKeyButton";
            this.selectKeyButton.Size = new System.Drawing.Size(413, 35);
            this.selectKeyButton.TabIndex = 0;
            this.selectKeyButton.Text = "Wybierz klucz";
            this.selectKeyButton.UseVisualStyleBackColor = true;
            this.selectKeyButton.Click += new System.EventHandler(this.selectKeyButton_Click);
            // 
            // dateTableLayoutPanel
            // 
            this.dateTableLayoutPanel.ColumnCount = 2;
            this.dateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dateTableLayoutPanel.Controls.Add(this.dateFromLabel, 0, 0);
            this.dateTableLayoutPanel.Controls.Add(this.dateFromDateTimePicker, 1, 0);
            this.dateTableLayoutPanel.Location = new System.Drawing.Point(422, 42);
            this.dateTableLayoutPanel.Name = "dateTableLayoutPanel";
            this.dateTableLayoutPanel.RowCount = 1;
            this.dateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dateTableLayoutPanel.Size = new System.Drawing.Size(413, 33);
            this.dateTableLayoutPanel.TabIndex = 1;
            // 
            // dateFromLabel
            // 
            this.dateFromLabel.AutoSize = true;
            this.dateFromLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFromLabel.Location = new System.Drawing.Point(3, 0);
            this.dateFromLabel.Name = "dateFromLabel";
            this.dateFromLabel.Padding = new System.Windows.Forms.Padding(3);
            this.dateFromLabel.Size = new System.Drawing.Size(200, 33);
            this.dateFromLabel.TabIndex = 1;
            this.dateFromLabel.Text = "Od daty";
            this.dateFromLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateFromDateTimePicker
            // 
            this.dateFromDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateFromDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromDateTimePicker.Location = new System.Drawing.Point(209, 3);
            this.dateFromDateTimePicker.Name = "dateFromDateTimePicker";
            this.dateFromDateTimePicker.Size = new System.Drawing.Size(201, 27);
            this.dateFromDateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(422, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(413, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Historia klucza";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeyHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 764);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "KeyHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historia klucza";
            this.mainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.keyHistoryDataGridView)).EndInit();
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.buttonsTableLayoutPanel.PerformLayout();
            this.dateTableLayoutPanel.ResumeLayout(false);
            this.dateTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private DataGridView keyHistoryDataGridView;
        private TableLayoutPanel buttonsTableLayoutPanel;
        private Button selectKeyButton;
        private TableLayoutPanel dateTableLayoutPanel;
        private DateTimePicker dateFromDateTimePicker;
        private Label dateFromLabel;
        private Label label1;
    }
}