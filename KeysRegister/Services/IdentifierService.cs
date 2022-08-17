using KeysRegister.Entities;
using KeysRegister.Repository;

namespace KeysRegister.Services
{
    public class IdentifierService
    {
        private readonly IdentifierRepository _identifierRepository;
        public IdentifierService()
        {
            _identifierRepository = new IdentifierRepository();
        }

        public Identifier? GetIdentifierByRfidCode(string rfidCode)
        {
            return _identifierRepository.GetIdentifierByRfidCode(rfidCode);
        }

    }
}
