namespace KeysRegister.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            using (KeyHandlingForm keyHandlingForm = new KeyHandlingForm(OperationType.Out))
            {
                keyHandlingForm.StartPosition = FormStartPosition.CenterParent;
                keyHandlingForm.ShowDialog();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            KeyHandlingForm keyHandlingForm = new KeyHandlingForm(OperationType.In);
            keyHandlingForm.StartPosition = FormStartPosition.CenterParent;
            keyHandlingForm.ShowDialog();
        }
    }
}