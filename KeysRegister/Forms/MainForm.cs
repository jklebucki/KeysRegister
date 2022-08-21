using KeysRegister.Data;
using KeysRegister.Entities;
using KeysRegister.Repository;
using KeysRegister.Services;

namespace KeysRegister.Forms
{
    internal partial class MainForm : Form
    {
        private readonly AppDbContext _appDbContext = new();
        private readonly IdentifierRepository _identifierRepository;
        private readonly IdentifierService _identifierService;
        private readonly ReleasedKeyRepository _releasedKeyRepository;
        private readonly ReleasedKeyService _releasedKeyService;
        internal MainForm()
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
            SetReleasesDataGridView();
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
            if (sender != null)
            {
                var form = (KeyHandlingForm)sender;
                if (form.DialogResult == DialogResult.OK)
                {

                    _releasedKeyService.ReturnKey(form.ReleaseKeys);
                    SetReleasesDataGridView();
                }
            }
        }

        private void KeyHandlingForm_FormClosingOut(object? sender, FormClosingEventArgs e)
        {
            if (sender != null)
            {
                var form = (KeyHandlingForm)sender;
                if (form.DialogResult == DialogResult.OK)
                {

                    _releasedKeyService.AddReleaseKey(form.ReleaseKeys);
                    SetReleasesDataGridView();
                }
            }
        }

        private void SetReleasesDataGridView()
        {
            releasesDataGridView.DataSource = null;
            releasesDataGridView.DataSource = _releasedKeyService.GetAllReleasedKeys().OrderByDescending(d => d.ReleaseDate).ToList();
            releasesDataGridView.Columns[0].Visible = false;
            releasesDataGridView.Columns[1].Visible = false;
            releasesDataGridView.Columns[2].HeaderText = "Nazwa klucza";
            releasesDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            releasesDataGridView.Columns[3].HeaderText = "Informacja o kluczu";
            releasesDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            releasesDataGridView.Columns[4].HeaderText = "Opis klucza";
            releasesDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            releasesDataGridView.Columns[5].Visible = false;
            releasesDataGridView.Columns[6].HeaderText = "Imi�";
            releasesDataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            releasesDataGridView.Columns[7].HeaderText = "Nazwisko";
            releasesDataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            releasesDataGridView.Columns[8].HeaderText = "Opis";
            releasesDataGridView.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            releasesDataGridView.Columns[9].HeaderText = "Data wydania";
            releasesDataGridView.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            releasesDataGridView.Invalidate();
        }

        private void keyHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyHistoryForm keyHistoryForm = new KeyHistoryForm(_identifierService);
            keyHistoryForm.ShowDialog(this);
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdentifierForm identifierForm = new IdentifierForm(_identifierService, ObjectType.Person);
            identifierForm.ShowDialog(this);
        }

        private void keysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdentifierForm identifierForm = new IdentifierForm(_identifierService, ObjectType.Key);
            identifierForm.ShowDialog(this);
        }
    }
}