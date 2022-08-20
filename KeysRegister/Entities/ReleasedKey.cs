namespace KeysRegister.Entities
{
    internal class ReleasedKey
    {
        public int KeyId { get; protected set; }
        public string? KeyName { get; protected set; }
        public string? KeyInfo { get; protected set; }
        public string? KeyDescription { get; protected set; }
        public int EmployeeId { get; protected set; }
        public string? EmployeeFirstName { get; protected set; }
        public string? EmployeeLastName { get; protected set; }
        public string? EmployeeDescription { get; protected set; }
        public DateTime ReleaseDate { get; protected set; }

        public ReleasedKey(int keyId, string? keyName, string? keyInfo, string? keyDescription, int employeeId, string? employeeFirstName, string? employeeLastName, string? employeeDescription, DateTime releaseDate)
        {
            KeyId = keyId;
            KeyName = keyName;
            KeyInfo = keyInfo;
            KeyDescription = keyDescription;
            EmployeeId = employeeId;
            EmployeeFirstName = employeeFirstName;
            EmployeeLastName = employeeLastName;
            EmployeeDescription = employeeDescription;
            ReleaseDate = releaseDate;
        }

        public void UpdateKey(string keyName, string keyInfo, string keyDescription)
        {
            KeyName = keyName;
            KeyInfo = keyInfo;
            KeyDescription = keyDescription;
        }

        public void UpdateKeyRelease(int employeeId, string employeeFirstName, string employeeLastName, string employeeDescription, DateTime releaseDate)
        {
            EmployeeId = employeeId;
            EmployeeFirstName = employeeFirstName;
            EmployeeLastName = employeeLastName;
            EmployeeDescription = employeeDescription;
            ReleaseDate = releaseDate;
        }
    }
}
