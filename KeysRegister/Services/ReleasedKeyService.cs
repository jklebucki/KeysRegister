using KeysRegister.Entities;
using KeysRegister.Repository;

namespace KeysRegister.Services
{
    internal class ReleasedKeyService
    {
        private readonly ReleasedKeyRepository _releasedKeyRepository;

        public ReleasedKeyService(ReleasedKeyRepository releasedKeyRepository)
        {
            _releasedKeyRepository = releasedKeyRepository;
        }

        public void AddReleaseKey(ReleaseKeys releaseKeys)
        {
            var releasedKeysList = SetReleaseKey(releaseKeys);
            foreach (var releaseKey in releasedKeysList)
            {
                if (_releasedKeyRepository.CheckIfKeyIsReleased(releaseKey.KeyId))
                    _releasedKeyRepository.UpdateReleasedKey(releaseKey);
                else
                    _releasedKeyRepository.AddReleasedKey(releaseKey);
            }
        }

        public void ReturnKey(ReleaseKeys releaseKeys)
        {
            var releasedKeysList = SetReleaseKey(releaseKeys);
            foreach (var releaseKey in releasedKeysList)
            {
                _releasedKeyRepository.RemoveReleasedKey(releaseKey, releaseKeys.Employee);
            }
        }

        private static IEnumerable<ReleasedKey> SetReleaseKey(ReleaseKeys releaseKeys)
        {
            List<ReleasedKey> releaseKeysList = new();
            foreach (var releaseKey in releaseKeys.Keys)
            {
                releaseKeysList.Add(new ReleasedKey(
                    releaseKey.Id,
                    releaseKey.FirstName,
                    releaseKey.LastName,
                    releaseKey.Description,
                    releaseKeys.Employee != null ? releaseKeys.Employee.Id : 0,
                    releaseKeys.Employee != null ? releaseKeys.Employee.FirstName : "",
                    releaseKeys.Employee != null ? releaseKeys.Employee.LastName : "",
                    releaseKeys.Employee != null ? releaseKeys.Employee.Description : "",
                    DateTime.UtcNow
                    ));
            }
            return releaseKeysList;
        }

        public IEnumerable<ReleasedKey> GetAllReleasedKeys()
        {
            return _releasedKeyRepository.GetAll();
        }
    }
}
