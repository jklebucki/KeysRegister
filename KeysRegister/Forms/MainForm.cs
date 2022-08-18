using KeysRegister.Services;

namespace KeysRegister.Forms
{
    public partial class MainForm : Form
    {
        private readonly IdentifierService _identifierService = new();
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
            using (KeyHandlingForm keyHandlingForm = new KeyHandlingForm(OperationType.Out, _identifierService))
            {
                keyHandlingForm.StartPosition = FormStartPosition.CenterParent;
                keyHandlingForm.FormClosing += KeyHandlingForm_FormClosingOut;
                keyHandlingForm.ShowDialog();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            KeyHandlingForm keyHandlingForm = new KeyHandlingForm(OperationType.In, _identifierService);
            keyHandlingForm.StartPosition = FormStartPosition.CenterParent;
            keyHandlingForm.ShowDialog();


        }

        private void KeyHandlingForm_FormClosingOut(object? sender, FormClosingEventArgs e)
        {
            if (sender != null)
            {
                var form = (KeyHandlingForm)sender;
                if (form.DialogResult == DialogResult.OK)
                {
                    releasesDataGridView.DataSource = form.ReleaseKeys.Keys;
                    releasesDataGridView.Invalidate();
                }
            }
        }
    }
}