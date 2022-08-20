namespace KeysRegister.Entities
{
    internal enum KeyOperatiomType
    {
        Release,
        Return
    }

    internal class ReleasedKeyHistory
    {
        public int Id { get; protected set; }
        public int KeyId { get; protected set; }
        public string KeyName { get; protected set; }
        public string KeyInfo { get; protected set; }
        public string KeyDescription { get; protected set; }
        public int EmployeeId { get; protected set; }
        public string EmployeeFirstName { get; protected set; }
        public string EmployeeLastName { get; protected set; }
        public string EmployeeDescription { get; protected set; }
        public KeyOperatiomType KeyOperatiomType { get; protected set; }
        public DateTime OperationDate { get; protected set; }

        public ReleasedKeyHistory(int keyId, string keyName, string keyInfo, string keyDescription,
            int employeeId, string employeeFirstName, string employeeLastName, string employeeDescription,
            KeyOperatiomType keyOperatiomType, DateTime operationDate)
        {
            KeyId = keyId;
            KeyName = keyName;
            KeyInfo = keyInfo;
            KeyDescription = keyDescription;
            EmployeeId = employeeId;
            EmployeeFirstName = employeeFirstName;
            EmployeeLastName = employeeLastName;
            EmployeeDescription = employeeDescription;
            KeyOperatiomType = keyOperatiomType;
            OperationDate = operationDate;
        }
    }
}
