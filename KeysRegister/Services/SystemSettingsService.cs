using KeysRegister.Data;
using KeysRegister.Settings;
using Microsoft.EntityFrameworkCore;
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
                var settingsJson = JsonConvert.SerializeObject(SystemSettings, Formatting.Indented);
                sw.Write(settingsJson);
            }
        }

        internal void ReadSettingsFromFile()
        {
            using (StreamReader sr = new StreamReader(_settingsPath, Encoding.UTF8))
            {
                var json = sr.ReadToEnd();
                var settings = JsonConvert.DeserializeObject<SystemSettings>(json);
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

        public bool DatabaseCanConnect()
        {
            AppDbContext appDbContext = new AppDbContext(SystemSettings.DatabaseSettings.GetConnectionString());
            return appDbContext.Database.CanConnect();
        }

        public string InitDatabase()
        {
            try
            {
                AppDbContext appDbContextInit = new AppDbContext(SystemSettings.DatabaseSettings.GetConnectionString());
                appDbContextInit.Database.Migrate();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.InnerException != null ? ex.InnerException.Message : ex.Message;
            }

        }
    }
}