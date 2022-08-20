using KeysRegister.Data;
using KeysRegister.Entities;

namespace KeysRegister.Repository
{
    internal class ReleasedKeyRepository
    {
        private readonly AppDbContext _appDbContext;

        public ReleasedKeyRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool CheckIfKeyIsReleased(int keyId)
        {
            return _appDbContext.ReleasedKeys.Any(i => i.KeyId == keyId);
        }

        public void AddReleasedKey(ReleasedKey releasedKey)
        {
            if (releasedKey != null)
            {
                _appDbContext.ReleasedKeys.Add(releasedKey);
                _appDbContext.SaveChanges();
            }
        }

        public void RemoveReleasedKey(ReleasedKey releasedKey)
        {
            var key = _appDbContext.ReleasedKeys.FirstOrDefault(i => i.KeyId == releasedKey.KeyId);
            if (key != null)
            {
                _appDbContext.Remove(key);
                _appDbContext.SaveChanges();
            }

        }

        public void UpdateReleasedKey(ReleasedKey releasedKey)
        {
            var key = _appDbContext.ReleasedKeys.FirstOrDefault(i => i.KeyId == releasedKey.KeyId);
            if (key != null && releasedKey != null)
            {
                key.UpdateKey(releasedKey.KeyName, releasedKey.KeyInfo, releasedKey.KeyDescription);
                key.UpdateKeyRelease(releasedKey.EmployeeId, releasedKey.EmployeeFirstName,
                                    releasedKey.EmployeeLastName, releasedKey.EmployeeDescription, DateTime.UtcNow.Date);
                _appDbContext.Update(key);
                _appDbContext.SaveChanges();
            }

        }
    }
}
