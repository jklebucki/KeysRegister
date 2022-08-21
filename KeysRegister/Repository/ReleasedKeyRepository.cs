using KeysRegister.Data;
using KeysRegister.Entities;
using KeysRegister.Mapper;

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
                var historyEntry = Mapping.MapReleasedKeyToReleasedKeyHistory(releasedKey, null, KeyOperatiomType.Release, DateTime.UtcNow);
                _appDbContext.Database.BeginTransaction();
                _appDbContext.ReleasedKeys.Add(releasedKey);
                _appDbContext.Add(historyEntry);
                _appDbContext.Database.CommitTransaction();
                _appDbContext.SaveChanges();
            }
            else
            {
                throw new Exception("ReleasedKey is null");
            }
        }

        public void RemoveReleasedKey(ReleasedKey releasedKey, Identifier? returnPerson)
        {
            var key = _appDbContext.ReleasedKeys.FirstOrDefault(i => i.KeyId == releasedKey.KeyId);
            if (key != null)
            {
                var releasedKeyHistory = Mapping.MapReleasedKeyToReleasedKeyHistory(key, returnPerson, KeyOperatiomType.Return, DateTime.UtcNow);
                if (releasedKeyHistory == null)
                    throw new Exception("ReleasedKeyHistory object not set");
                _appDbContext.Database.BeginTransaction();
                _appDbContext.ReleasedKeysHistory.Add(releasedKeyHistory);
                _appDbContext.ReleasedKeys.Remove(key);
                _appDbContext.Database.CommitTransaction();
                _appDbContext.SaveChanges();
            }
            else
            {
                var releasedKeyHistory = Mapping.MapReleasedKeyToReleasedKeyHistory(releasedKey, returnPerson, KeyOperatiomType.Return, DateTime.UtcNow);
                if (releasedKeyHistory == null)
                    throw new Exception("ReleasedKeyHistory object not set");
                _appDbContext.ReleasedKeysHistory.Add(releasedKeyHistory);
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
                                    releasedKey.EmployeeLastName, releasedKey.EmployeeDescription, DateTime.UtcNow);
                var historyEntry = Mapping.MapReleasedKeyToReleasedKeyHistory(key, null, KeyOperatiomType.Release, DateTime.UtcNow);
                _appDbContext.Database.BeginTransaction();
                _appDbContext.Update(key);
                _appDbContext.Add(historyEntry);
                _appDbContext.Database.CommitTransaction();
                _appDbContext.SaveChanges();
            }
            else
            {
                throw new Exception("Key not found");
            }

        }

        internal IEnumerable<ReleasedKey> GetAll()
        {
            return _appDbContext.ReleasedKeys.ToList();
        }
    }
}
