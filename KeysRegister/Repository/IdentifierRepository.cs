using KeysRegister.Entities;

namespace KeysRegister.Repository
{
    public class IdentifierRepository
    {
        private readonly IEnumerable<Identifier> _identiefers;

        public IdentifierRepository()
        {
            _identiefers = new List<Identifier>()
            {
                new Identifier(1,"0010614285","Jan","Kowalski","Dział IT",ObjectType.Person),
                new Identifier(2,"0004714539","Arkadiusz","Nowak","Dział Transportu",ObjectType.Person),
                new Identifier(3,"0011079912","DZG27216",string.Empty,"100",ObjectType.Key),
                new Identifier(4,"0004861400","DZG27215",string.Empty,"185",ObjectType.Key),
                new Identifier(5,"0004734756","DZG00009",string.Empty,"185",ObjectType.Key),
                new Identifier(6,"0004968393","DZG10001",string.Empty,"188",ObjectType.Key)
            };
        }
        public Identifier? GetIdentifier(string rfidCode)
        {
            return _identiefers.FirstOrDefault(c => c.RfidCode == rfidCode);
        }

    }
}
