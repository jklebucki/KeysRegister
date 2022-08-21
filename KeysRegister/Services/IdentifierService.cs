using KeysRegister.Entities;
using KeysRegister.Repository;

namespace KeysRegister.Services
{
    internal class IdentifierService
    {
        private readonly IdentifierRepository _identifierRepository;
        internal IdentifierService(IdentifierRepository identifierRepository)
        {
            _identifierRepository = identifierRepository;
        }

        internal Identifier? GetIdentifierByRfidCode(string rfidCode)
        {
            return _identifierRepository.GetIdentifierByRfidCode(rfidCode);
        }

        internal Identifier? GetIdentifierById(int id)
        {
            return _identifierRepository.GetIdentifierById(id);
        }

        internal IEnumerable<Identifier> FindEmploee(string searchPhrase)
        {
            return _identifierRepository.FindEmploee(searchPhrase);
        }

        internal IEnumerable<ReleasedKeyHistory> KeyHistory(int keyId)
        {
            return _identifierRepository.GetKeyHistory(keyId);
        }

        internal IEnumerable<Identifier> FindKey(string searchPhrase)
        {
            return _identifierRepository.FindKey(searchPhrase);
        }

        internal void RefreshEmployee()
        {
            _identifierRepository.RefreshAllEmploee();
        }

        internal void RefreshKeys()
        {
            _identifierRepository.RefreshAllKeys();
        }
    }
}
