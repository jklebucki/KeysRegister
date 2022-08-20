using KeysRegister.Data;
using KeysRegister.Repository;
using KeysRegister.Services;
using System;

namespace KeysRegister.Forms
{
    internal partial class MainForm : Form
    {
        private readonly AppDbContext _appDbContext = new();
        private readonly IdentifierRepository _identifierRepository; 
        private readonly IdentifierService _identifierService;
        private readonly ReleasedKeyRepository _releasedKeyRepository;
        private readonly ReleasedKeyService _releasedKeyService;
        public MainForm()
        {
            _identifierRepository = new IdentifierRepository(_appDbContext);
            _identifierService = new IdentifierService(_identifierRepository);
            _releasedKeyRepository = new ReleasedKeyRepository(_appDbContext);
            _releasedKeyService = new ReleasedKeyService(_releasedKeyRepository);

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
            using (KeyHandlingForm keyHandlingForm = new KeyHandlingForm(OperationType.In, _identifierService))
            {
                keyHandlingForm.StartPosition = FormStartPosition.CenterParent;
                keyHandlingForm.FormClosing += KeyHandlingForm_FormClosingIn;
                keyHandlingForm.ShowDialog();
            }
        }

        private void KeyHandlingForm_FormClosingIn(object? sender, FormClosingEventArgs e)
        {
           
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