using KeysRegister.Services;

namespace KeysRegister.Forms
{
    internal partial class SettingsForm : Form
    {
        private readonly SystemSettingsService _settingsService;
        internal SettingsForm(SystemSettingsService systemSettingsService)
        {
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
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            _settingsService.SystemSettings.DatabaseSettings.SetDatabaseSettings(hostTextBox.Text, databaseTextBox.Text, usernameTextBox.Text, passwordTextBox.Text);         
            if (_settingsService.DatabaseCanConnect())
            {
                _settingsService.SaveSettingsToFile();
                Close();
            } else
            {

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
