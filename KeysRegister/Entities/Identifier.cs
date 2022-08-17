namespace KeysRegister.Entities
{
    public enum ObjectType
    {
        Key,
        Person
    }

    public class Identifier
    {
        public int Id { get; private set; }
        public string RfidCode { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Description { get; private set; }
        public ObjectType Type { get; private set; }

        public Identifier(int id, string rfidCode, string firstName, string lastName, string description, ObjectType type)
        {
            Id = id;
            RfidCode = rfidCode;
            FirstName = firstName;
            LastName = lastName;
            Description = description;
            Type = type;
        }
    }
}
