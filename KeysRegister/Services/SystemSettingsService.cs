using KeysRegister.Settings;
using Newtonsoft.Json;
using System.Text;

namespace KeysRegister.Services
{
    internal class SystemSettingsService
    {
        public SystemSettings SystemSettings { get; protected set; }
        public readonly string _settingsPath;

        public SystemSettingsService()
        {
            _settingsPath = SetSettingsPath();
            SystemSettings = new SystemSettings();
        }

        internal void SaveSettingsToFile()
        {
            using (StreamWriter sw = new StreamWriter(_settingsPath, false, Encoding.UTF8))
            {
                var settingsJson = JsonConvert.SerializeObject(SystemSettings);
                sw.Write(settingsJson);
            }
        }

        internal void ReadSettingsFromFile()
        {
            using (StreamReader sr = new StreamReader(_settingsPath, Encoding.UTF8))
            {
                var settings = JsonConvert.DeserializeObject<SystemSettings>(sr.ReadToEnd());
                if (settings != null)
                    SystemSettings = settings;
            }
        }

        internal void SetConnectionString(string host, string database, string username, string password)
        {
            SystemSettings.DatabaseSettings.SetDatabaseSettings(host, database, username, password);
        }

        private string SetSettingsPath()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "SystemSettings.json");
        }
    }
}