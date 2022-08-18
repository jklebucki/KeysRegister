namespace KeysRegister.Entities
{
    public class ReleaseKeys
    {
        public Identifier Employee { get; protected set; }
        public IEnumerable<Identifier> Keys { get; protected set; }
        private List<Identifier> _keys = new List<Identifier>();

        public ReleaseKeys()
        {
            Keys = _keys;
        }

        public void SetEmployee(Identifier identifier)
        {
            Employee = identifier;
        }

        public void AddKey(Identifier identifier)
        {
            var exist = _keys.Contains(identifier);
            if (!exist)
                _keys.Add(identifier);
        }
    }
}
