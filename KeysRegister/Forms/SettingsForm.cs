using KeysRegister.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            _settingsService.SaveSettingsToFile();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
