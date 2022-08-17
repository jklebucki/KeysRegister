using KeysRegister.Repository;
using KeysRegister.Services;

namespace KeysRegister.Forms
{
    public enum OperationType
    {
        In, Out
    }
    public partial class KeyHandlingForm : Form
    {
        private readonly OperationType _operationType;
        private readonly IdentifierService _identifierService;
        public KeyHandlingForm(OperationType operationType, IdentifierService identifierService)
        {
            InitializeComponent();
            _operationType = operationType;
            _identifierService = identifierService;
            SetForm();
        }

        private void SetForm()
        {
            if (_operationType == OperationType.Out)
            {
                Text = "Wydanie klucza";
            }
            else if (_operationType == OperationType.In)
            {
                Text = "Zwrot klucza";
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var test = e.KeyChar == (char)Keys.Enter;
            if (test)
            {
                var ident = _identifierService.GetIdentifierByRfidCode(scanTextBox.Text);
                if (ident != null)
                    codeLabel.Text = $"{ident.FirstName} / {ident.LastName} / {ident.Description}";
                else
                    codeLabel.Text = "Nie znaleziono";
                scanTextBox.Text = string.Empty;
            }

        }
    }
}
