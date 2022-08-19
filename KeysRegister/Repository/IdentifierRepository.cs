using KeysRegister.Data;
using KeysRegister.Entities;

namespace KeysRegister.Repository
{
    public class IdentifierRepository
    {
        private readonly AppDbContext _appDbContext;
        private IEnumerable<Identifier> _allEmployee;

        public IdentifierRepository()
        {
            _allEmployee = new List<Identifier>();
            _appDbContext = new AppDbContext();
        }

        public Identifier? GetIdentifierByRfidCode(string rfidCode)
        {
            return _appDbContext.Identifiers.FirstOrDefault(c => c.RfidCode == rfidCode);
        }

        public IEnumerable<Identifier> FindEmploee(string searchPhrase)
        {
            searchPhrase = searchPhrase.ToLower();
            return _allEmployee.Where(e => e.FirstName.ToLower().Contains(searchPhrase)
                     || e.LastName.ToLower().Contains(searchPhrase)
                     || e.Description.ToLower().Contains(searchPhrase)).ToList();
        }

        public void RefreshAllEmploee()
        {
            _allEmployee = _appDbContext.Identifiers.Where(e => e.Type == ObjectType.Person).ToList();
        }

        internal Identifier? GetIdentifierById(int id)
        {
            return _appDbContext.Identifiers.FirstOrDefault(c => c.Id == id);
        }
    }
}
