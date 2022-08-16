using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeysRegister.Forms
{
    public enum OperationType
    {
        In,Out
    }
    public partial class KeyHandlingForm : Form
    {
        private readonly OperationType _operationType;
        public KeyHandlingForm(OperationType operationType)
        {
            InitializeComponent();
            _operationType = operationType;
            SetForm();
        }

        private void SetForm()
        {
            if( _operationType == OperationType.Out )
            {
                Text = "Wydanie klucza";
            } else if( _operationType == OperationType.In )
            {
                Text = "Zwrot klucza";
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var test = e.KeyChar == (char)Keys.Enter;
            if (test)
            {
                codeLabel.Text = scanTextBox.Text;
                scanTextBox.Text = string.Empty;
            }

        }
    }
}
