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

        private IEnumerable<ReleasedKey> SetReleaseKey(ReleaseKeys releaseKeys)
        {
            List<ReleasedKey> releaseKeysList = new List<ReleasedKey>();
            foreach (var releaseKey in releaseKeys.Keys)
            {
                releaseKeysList.Add(new ReleasedKey(
                    releaseKey.Id,
                    releaseKey.FirstName,
                    releaseKey.LastName,
                    releaseKey.Description,
                    releaseKeys.Employee.Id,
                    releaseKeys.Employee.FirstName,
                    releaseKeys.Employee.LastName,
                    releaseKeys.Employee.Description,
                    DateTime.UtcNow.Date
                    ));
            }
            return releaseKeysList;
        }
    }
}
