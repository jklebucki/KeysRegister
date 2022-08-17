using KeysRegister.Repository;

namespace KeysRegister.Forms
{
    public enum OperationType
    {
        In, Out
    }
    public partial class KeyHandlingForm : Form
    {
        private readonly OperationType _operationType;
        private readonly IdentifierRepository _identifierRepository;
        public KeyHandlingForm(OperationType operationType, IdentifierRepository identifierRepository)
        {
            InitializeComponent();
            _operationType = operationType;
            _identifierRepository = identifierRepository;
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
                var ident = _identifierRepository.GetIdentifier(scanTextBox.Text);
                if (ident != null)
                    codeLabel.Text = $"{ident.FirstName} / {ident.LastName} / {ident.Description}";
                else
                    codeLabel.Text = "Nie znaleziono";
                scanTextBox.Text = string.Empty;
            }

        }
    }
}
