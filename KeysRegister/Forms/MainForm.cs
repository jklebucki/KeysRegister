using KeysRegister.Data;
using KeysRegister.Entities;
using KeysRegister.Repository;
using KeysRegister.Services;

namespace KeysRegister.Forms
{
    internal partial class MainForm : Form
    {
        private readonly AppDbContext _appDbContext;
        private readonly IdentifierRepository _identifierRepository;
        private readonly IdentifierService _identifierService;
        private readonly ReleasedKeyRepository _releasedKeyRepository;
        private readonly ReleasedKeyService _releasedKeyService;
        private readonly SystemSettingsService _settingsService = new();
        private bool settingsResult = true;
        internal MainForm(string[] args)
        {
            InitializeComponent();
            settingsResult = SystemInit(args);
            if (settingsResult)
            {
                _appDbContext = GetAppDbContext();
                _identifierRepository = new IdentifierRepository(_appDbContext);
                _identifierService = new IdentifierService(_identifierRepository);
                _releasedKeyRepository = new ReleasedKeyRepository(_appDbContext);
                _releasedKeyService = new ReleasedKeyService(_releasedKeyRepository);
                releasesDataGridView.CellFormatting += ReleasesDataGridView_CellFormatting;
            }
        }

        private AppDbContext GetAppDbContext()
        {
            try
            {
                return new AppDbContext(_settingsService.SystemSettings.DatabaseSettings.GetConnectionString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Baza danych niedostêpna: {ex.Message}");
            }
            this.Close();
            return null;
        }

        private bool SystemInit(string[] args)
        {
            var result = false;
            var dbInit = args.Length > 0 && args[0].ToLower() == "-i" ? true : false;
            if (dbInit)
                result = HandlingSettings(dbInit);
            try
            {
                _settingsService.ReadSettingsFromFile();
            }
            catch
            {
                result = HandlingSettings(dbInit);
            }
            var dbContextCheck = new AppDbContext(_settingsService.SystemSettings.DatabaseSettings.GetConnectionString());
            if (!dbContextCheck.Database.CanConnect())
                result = HandlingSettings(dbInit);
            else
                result = true;
            return result;
        }

        private bool HandlingSettings(bool dbInit)
        {
            SettingsForm settingsForm = new SettingsForm(_settingsService, dbInit);
            if (settingsForm.ShowDialog() == DialogResult.Cancel)
                return false;
            return true;
        }

        private void ReleasesDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9 && e.Value != null)
                e.Value = ((DateTime)e.Value).ToLocalTime();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!settingsResult)
            {
                MessageBox.Show("Brak dostêpu do bazy danych - zamykam program", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
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
            releasesDataGridView.Columns[6].HeaderText = "Imiê";
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

        private void systemSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(_settingsService, false);
            settingsForm.ShowDialog(this);
        }
    }
}