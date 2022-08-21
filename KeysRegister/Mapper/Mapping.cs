using KeysRegister.Entities;

namespace KeysRegister.Mapper
{
    internal static class Mapping
    {
        public static ReleasedKeyHistory MapReleasedKeyToReleasedKeyHistory(ReleasedKey releasedKey, Identifier? returnPerson,
                                                                            KeyOperatiomType keyOperatiomType, DateTime operationDate)
        {
            return new ReleasedKeyHistory(
                releasedKey.KeyId, releasedKey.KeyName, releasedKey.KeyInfo, releasedKey.KeyDescription,
                returnPerson == null ? releasedKey.EmployeeId : returnPerson.Id,
                returnPerson == null ? releasedKey.EmployeeFirstName : returnPerson.FirstName,
                returnPerson == null ? releasedKey.EmployeeLastName : returnPerson.LastName,
                returnPerson == null ? releasedKey.EmployeeDescription : returnPerson.Description,
                keyOperatiomType, operationDate
                );
        }
    }
}
