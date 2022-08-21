using KeysRegister.Data;
using KeysRegister.Entities;

namespace KeysRegister.Repository
{
    internal class IdentifierRepository
    {
        private readonly AppDbContext _appDbContext;
        private IEnumerable<Identifier> _allEmployee;
        private IEnumerable<Identifier> _allKeys;

        internal IdentifierRepository(AppDbContext appDbContext)
        {
            _allEmployee = new List<Identifier>();
            _allKeys = new List<Identifier>();
            _appDbContext = appDbContext;
        }

        internal Identifier? GetIdentifierByRfidCode(string rfidCode)
        {
            return _appDbContext.Identifiers.FirstOrDefault(c => c.RfidCode == rfidCode);
        }

        internal IEnumerable<Identifier> FindEmploee(string searchPhrase)
        {
            searchPhrase = searchPhrase.ToLower();
            return _allEmployee.Where(e => e.FirstName.ToLower().Contains(searchPhrase)
                     || e.LastName.ToLower().Contains(searchPhrase)
                     || e.Description.ToLower().Contains(searchPhrase)).ToList();
        }

        internal IEnumerable<Identifier> FindKey(string searchPhrase)
        {
            return _allKeys.Where(e => e.RfidCode.ToLower().Contains(searchPhrase)
                     || e.FirstName.ToLower().Contains(searchPhrase)
                     || e.LastName.ToLower().Contains(searchPhrase)
                     || e.Description.ToLower().Contains(searchPhrase)).ToList();
        }

        internal void RefreshAllEmploee()
        {
            _allEmployee = _appDbContext.Identifiers.Where(e => e.Type == ObjectType.Person).ToList();
        }

        internal void RefreshAllKeys()
        {
            _allKeys = _appDbContext.Identifiers.Where(e => e.Type == ObjectType.Key).ToList();
        }

        internal Identifier? GetIdentifierById(int id)
        {
            return _appDbContext.Identifiers.FirstOrDefault(c => c.Id == id);
        }

        internal IEnumerable<ReleasedKeyHistory> GetKeyHistory(int keyId, DateTime dateFrom)
        {
            return _appDbContext.ReleasedKeysHistory.Where(e => e.KeyId == keyId && e.OperationDate >= dateFrom).ToList();
        }

        internal IEnumerable<Identifier> GetAllEmployee()
        {
            return _appDbContext.Identifiers.Where(e => e.Type == ObjectType.Person).ToList();
        }

        internal IEnumerable<Identifier> GetAllKeys()
        {
            return _appDbContext.Identifiers.Where(e => e.Type == ObjectType.Key).ToList();
        }

        internal int AddIdentifier(Identifier identifier)
        {
            _appDbContext.Add(identifier);
            _appDbContext.SaveChanges();
            return identifier.Id;
        }
    }
}
