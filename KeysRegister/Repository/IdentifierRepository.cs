using KeysRegister.Data;
using KeysRegister.Entities;

namespace KeysRegister.Repository
{
    public class IdentifierRepository
    {
        private readonly AppDbContext _appDbContext;

        public IdentifierRepository()
        {
            _appDbContext = new AppDbContext();
        }

        public Identifier? GetIdentifier(string rfidCode)
        {
            return _appDbContext.Identifiers.FirstOrDefault(c => c.RfidCode == rfidCode);
        }

    }
}
