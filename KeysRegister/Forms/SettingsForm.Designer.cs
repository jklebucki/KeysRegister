namespace KeysRegister.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.databaseTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.databaseSectionTitleLabel = new System.Windows.Forms.Label();
            this.hostLabel = new System.Windows.Forms.Label();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.databaseTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.buttonsLableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            this.databaseTableLayoutPanel.SuspendLayout();
            this.buttonsLableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.databaseTableLayoutPanel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.buttonsLableLayoutPanel, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(940, 611);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // databaseTableLayoutPanel
            // 
            this.databaseTableLayoutPanel.ColumnCount = 3;
            this.databaseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.databaseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.databaseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.databaseTableLayoutPanel.Controls.Add(this.databaseSectionTitleLabel, 1, 0);
            this.databaseTableLayoutPanel.Controls.Add(this.hostLabel, 0, 1);
            this.databaseTableLayoutPanel.Controls.Add(this.databaseLabel, 0, 2);
            this.databaseTableLayoutPanel.Controls.Add(this.usernameLabel, 0, 3);
            this.databaseTableLayoutPanel.Controls.Add(this.passwordLabel, 0, 4);
            this.databaseTableLayoutPanel.Controls.Add(this.hostTextBox, 1, 1);
            this.databaseTableLayoutPanel.Controls.Add(this.databaseTextBox, 1, 2);
            this.databaseTableLayoutPanel.Controls.Add(this.usernameTextBox, 1, 3);
            this.databaseTableLayoutPanel.Controls.Add(this.passwordTextBox, 1, 4);
            this.databaseTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseTableLayoutPanel.Location = new System.Drawing.Point(3, 186);
            this.databaseTableLayoutPanel.Name = "databaseTableLayoutPanel";
            this.databaseTableLayoutPanel.RowCount = 8;
            this.databaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.databaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.databaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.databaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.databaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.databaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.databaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.databaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.databaseTableLayoutPanel.Size = new System.Drawing.Size(934, 238);
            this.databaseTableLayoutPanel.TabIndex = 0;
            // 
            // databaseSectionTitleLabel
            // 
            this.databaseSectionTitleLabel.AutoSize = true;
            this.databaseSectionTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseSectionTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.databaseSectionTitleLabel.Location = new System.Drawing.Point(314, 3);
            this.databaseSectionTitleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.databaseSectionTitleLabel.Name = "databaseSectionTitleLabel";
            this.databaseSectionTitleLabel.Padding = new System.Windows.Forms.Padding(3);
            this.databaseSectionTitleLabel.Size = new System.Drawing.Size(305, 29);
            this.databaseSectionTitleLabel.TabIndex = 0;
            this.databaseSectionTitleLabel.Text = "Ustawienia bazy danych";
            this.databaseSectionTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostLabel.Location = new System.Drawing.Point(3, 38);
            this.hostLabel.Margin = new System.Windows.Forms.Padding(3);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Padding = new System.Windows.Forms.Padding(3);
            this.hostLabel.Size = new System.Drawing.Size(305, 29);
            this.hostLabel.TabIndex = 1;
            this.hostLabel.Text = "Nazwa hosta lub adres IP";
            this.hostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseLabel.Location = new System.Drawing.Point(3, 73);
            this.databaseLabel.Margin = new System.Windows.Forms.Padding(3);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Padding = new System.Windows.Forms.Padding(3);
            this.databaseLabel.Size = new System.Drawing.Size(305, 29);
            this.databaseLabel.TabIndex = 2;
            this.databaseLabel.Text = "Nazwa bazy danych";
            this.databaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLabel.Location = new System.Drawing.Point(3, 108);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Padding = new System.Windows.Forms.Padding(3);
            this.usernameLabel.Size = new System.Drawing.Size(305, 29);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Użytkownik";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordLabel.Location = new System.Drawing.Point(3, 143);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(3);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Padding = new System.Windows.Forms.Padding(3);
            this.passwordLabel.Size = new System.Drawing.Size(305, 29);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Hasło";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hostTextBox
            // 
            this.hostTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostTextBox.Location = new System.Drawing.Point(314, 38);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(305, 27);
            this.hostTextBox.TabIndex = 5;
            // 
            // databaseTextBox
            // 
            this.databaseTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseTextBox.Location = new System.Drawing.Point(314, 73);
            this.databaseTextBox.Name = "databaseTextBox";
            this.databaseTextBox.Size = new System.Drawing.Size(305, 27);
            this.databaseTextBox.TabIndex = 6;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTextBox.Location = new System.Drawing.Point(314, 108);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(305, 27);
            this.usernameTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTextBox.Location = new System.Drawing.Point(314, 143);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(305, 27);
            this.passwordTextBox.TabIndex = 8;
            // 
            // buttonsLableLayoutPanel
            // 
            this.buttonsLableLayoutPanel.ColumnCount = 4;
            this.buttonsLableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsLableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsLableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsLableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsLableLayoutPanel.Controls.Add(this.applyButton, 3, 3);
            this.buttonsLableLayoutPanel.Controls.Add(this.cancelButton, 2, 3);
            this.buttonsLableLayoutPanel.Controls.Add(this.infoLabel, 0, 0);
            this.buttonsLableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsLableLayoutPanel.Location = new System.Drawing.Point(3, 430);
            this.buttonsLableLayoutPanel.Name = "buttonsLableLayoutPanel";
            this.buttonsLableLayoutPanel.RowCount = 4;
            this.buttonsLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsLableLayoutPanel.Size = new System.Drawing.Size(934, 178);
            this.buttonsLableLayoutPanel.TabIndex = 1;
            // 
            // applyButton
            // 
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyButton.Location = new System.Drawing.Point(702, 135);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(229, 40);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Zapisz";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(469, 135);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(227, 40);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.buttonsLableLayoutPanel.SetColumnSpan(this.infoLabel, 4);
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel.Location = new System.Drawing.Point(3, 3);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(3);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Padding = new System.Windows.Forms.Padding(3);
            this.infoLabel.Size = new System.Drawing.Size(928, 38);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "--------";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 611);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ustawienia";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.databaseTableLayoutPanel.ResumeLayout(false);
            this.databaseTableLayoutPanel.PerformLayout();
            this.buttonsLableLayoutPanel.ResumeLayout(false);
            this.buttonsLableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private TableLayoutPanel databaseTableLayoutPanel;
        private Label databaseSectionTitleLabel;
        private Label hostLabel;
        private Label databaseLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox hostTextBox;
        private TextBox databaseTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private TableLayoutPanel buttonsLableLayoutPanel;
        private Button applyButton;
        private Button cancelButton;
        private Label infoLabel;
    }
}