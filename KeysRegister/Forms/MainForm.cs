using KeysRegister.Repository;

namespace KeysRegister.Forms
{
    public partial class MainForm : Form
    {
        private readonly IdentifierRepository _identifierRepository = new();
        public MainForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            using (KeyHandlingForm keyHandlingForm = new KeyHandlingForm(OperationType.Out, _identifierRepository))
            {
                keyHandlingForm.StartPosition = FormStartPosition.CenterParent;
                keyHandlingForm.ShowDialog();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            KeyHandlingForm keyHandlingForm = new KeyHandlingForm(OperationType.In, _identifierRepository);
            keyHandlingForm.StartPosition = FormStartPosition.CenterParent;
            keyHandlingForm.ShowDialog();
        }
    }
}