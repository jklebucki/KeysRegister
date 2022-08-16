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
            this.scanTextBox = new System.Windows.Forms.TextBox();
            this.scanLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scanTextBox
            // 
            this.scanTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanTextBox.Location = new System.Drawing.Point(274, 114);
            this.scanTextBox.Name = "scanTextBox";
            this.scanTextBox.Size = new System.Drawing.Size(256, 27);
            this.scanTextBox.TabIndex = 0;
            this.scanTextBox.UseSystemPasswordChar = true;
            this.scanTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // scanLabel
            // 
            this.scanLabel.AutoSize = true;
            this.scanLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scanLabel.Location = new System.Drawing.Point(236, 70);
            this.scanLabel.Name = "scanLabel";
            this.scanLabel.Size = new System.Drawing.Size(327, 41);
            this.scanLabel.TabIndex = 1;
            this.scanLabel.Text = "Zeskanuj indentyfikator";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codeLabel.Location = new System.Drawing.Point(250, 217);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(0, 54);
            this.codeLabel.TabIndex = 2;
            // 
            // KeyInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.scanLabel);
            this.Controls.Add(this.scanTextBox);
            this.Name = "KeyInForm";
            this.Text = "KeyInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label labelScan;
        private Label codeLabel;
        private TextBox scanTextBox;
        private Label scanLabel;
    }
}