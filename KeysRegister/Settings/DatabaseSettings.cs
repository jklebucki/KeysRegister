namespace KeysRegister.Settings
{
    internal class DatabaseSettings
    {
        public string Host { get; protected set; }
        public string Database { get; protected set; }
        public string Username { get; protected set; }
        public string Password { get; protected set; }

        internal DatabaseSettings(string host = "", string database = "", string username = "", string password = "")
        {
            Host = host;
            Database = database;
            Username = username;
            Password = password;
        }

        internal void SetDefaultData()
        {
            Host = "localhost";
            Database = "KeyRegisters";
            Username = "root";
            Password = "sasa";
        }

        internal string GetConnectionString()
        {
            return $"Host={Host};Database={Database};Username={Username};Password={Password}";
        }
    }
}
