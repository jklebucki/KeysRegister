namespace KeysRegister.Settings
{
    internal class SystemSettings
    {
        public int DefaultReportDays { get; protected set; }
        public DatabaseSettings DatabaseSettings { get; protected set; }
        public SystemSettings()
        {
            DefaultReportDays = 30;
            DatabaseSettings = new DatabaseSettings();
        }
    }
}
