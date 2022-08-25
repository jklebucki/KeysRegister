using KeysRegister.Services;

namespace KeysRegister.Forms
{
    internal partial class SettingsForm : Form
    {
        private readonly SystemSettingsService _settingsService;
        private readonly bool _dbInit;
        internal SettingsForm(SystemSettingsService systemSettingsService, bool dbInit)
        {
            _dbInit = dbInit;
            _settingsService = systemSettingsService;
            InitializeComponent();
            FillForm();
        }

        private void FillForm()
        {
            var dbSettings = _settingsService.SystemSettings.DatabaseSettings;
            hostTextBox.Text = dbSettings.Host;
            databaseTextBox.Text = dbSettings.Database;
            usernameTextBox.Text = dbSettings.Username;
            passwordTextBox.Text = dbSettings.Password;
            if (_dbInit)
                applyButton.Text = "Inicjalizuj bazę danych";
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (!_dbInit)
                SetDatabase();
            else
                InitDatabase();
        }

        private void InitDatabase()
        {
            _settingsService.SystemSettings.DatabaseSettings.SetDatabaseSettings(hostTextBox.Text, databaseTextBox.Text, usernameTextBox.Text, passwordTextBox.Text);
            var initResult = _settingsService.InitDatabase();
            if (initResult != null && initResult == "OK")
            {
                _settingsService.SaveSettingsToFile();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                infoLabel.Text = initResult;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SetDatabase()
        {
            _settingsService.SystemSettings.DatabaseSettings.SetDatabaseSettings(hostTextBox.Text, databaseTextBox.Text, usernameTextBox.Text, passwordTextBox.Text);
            if (_settingsService.DatabaseCanConnect())
            {
                _settingsService.SaveSettingsToFile();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                infoLabel.Text = "Brak połączenia z bazą danych";
            }
        }
    }
}
