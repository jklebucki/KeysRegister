using KeysRegister.Entities;
using KeysRegister.Repository;

namespace KeysRegister.Services
{
    internal class IdentifierService
    {
        private readonly IdentifierRepository _identifierRepository;
        public IdentifierService(IdentifierRepository identifierRepository)
        {
            _identifierRepository = identifierRepository;
        }

        public Identifier? GetIdentifierByRfidCode(string rfidCode)
        {
            return _identifierRepository.GetIdentifierByRfidCode(rfidCode);
        }

        public Identifier? GetIdentifierById(int id)
        {
            return _identifierRepository.GetIdentifierById(id);
        }

        public IEnumerable<Identifier> FindEmploee(string searchPhrase)
        {
            return _identifierRepository.FindEmploee(searchPhrase);
        }

        public void RefreshEmployee()
        {
            _identifierRepository.RefreshAllEmploee();
        }
    }
}
