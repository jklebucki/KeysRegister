namespace KeysRegister.Forms
{
    partial class IdentifierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentifierForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rfidCodeLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.rfidTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.buttonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.68293F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.31707F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1117, 741);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.13501F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.86499F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonsTableLayoutPanel, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1111, 236);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.39746F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.60254F));
            this.tableLayoutPanel2.Controls.Add(this.rfidCodeLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.firstNameLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lastNameLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.descriptionLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.rfidTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.firstNameTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lastNameTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.descriptionTextBox, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(550, 230);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // rfidCodeLabel
            // 
            this.rfidCodeLabel.AutoSize = true;
            this.rfidCodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rfidCodeLabel.Location = new System.Drawing.Point(3, 41);
            this.rfidCodeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.rfidCodeLabel.Name = "rfidCodeLabel";
            this.rfidCodeLabel.Padding = new System.Windows.Forms.Padding(3);
            this.rfidCodeLabel.Size = new System.Drawing.Size(166, 32);
            this.rfidCodeLabel.TabIndex = 0;
            this.rfidCodeLabel.Text = "Kod RFID";
            this.rfidCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rfidCodeLabel.DoubleClick += new System.EventHandler(this.rfidCodeLabel_DoubleClick);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameLabel.Location = new System.Drawing.Point(3, 79);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Padding = new System.Windows.Forms.Padding(3);
            this.firstNameLabel.Size = new System.Drawing.Size(166, 32);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "Imię";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameLabel.Location = new System.Drawing.Point(3, 117);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Padding = new System.Windows.Forms.Padding(3);
            this.lastNameLabel.Size = new System.Drawing.Size(166, 32);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Nazwisko";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 155);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Padding = new System.Windows.Forms.Padding(3);
            this.descriptionLabel.Size = new System.Drawing.Size(166, 32);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Opis";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rfidTextBox
            // 
            this.rfidTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rfidTextBox.Location = new System.Drawing.Point(175, 41);
            this.rfidTextBox.Name = "rfidTextBox";
            this.rfidTextBox.Size = new System.Drawing.Size(372, 27);
            this.rfidTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameTextBox.Location = new System.Drawing.Point(175, 79);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(372, 27);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameTextBox.Location = new System.Drawing.Point(175, 117);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(372, 27);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Location = new System.Drawing.Point(175, 155);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(372, 27);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.ColumnCount = 5;
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.buttonsTableLayoutPanel.Controls.Add(this.btnAdd, 1, 2);
            this.buttonsTableLayoutPanel.Controls.Add(this.btnRemove, 2, 2);
            this.buttonsTableLayoutPanel.Controls.Add(this.btnSave, 3, 2);
            this.buttonsTableLayoutPanel.Controls.Add(this.btnCancel, 1, 3);
            this.buttonsTableLayoutPanel.Controls.Add(this.btnClose, 3, 3);
            this.buttonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(559, 3);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 5;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(549, 230);
            this.buttonsTableLayoutPanel.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(42, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Location = new System.Drawing.Point(198, 95);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 40);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(354, 95);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(42, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(354, 141);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 245);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(1111, 493);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // IdentifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 741);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IdentifierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IdentifierForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label rfidCodeLabel;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label descriptionLabel;
        private TextBox rfidTextBox;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox descriptionTextBox;
        private DataGridView dataGridView;
        private TableLayoutPanel buttonsTableLayoutPanel;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnSave;
        private Button btnCancel;
        private Button btnClose;
    }
}