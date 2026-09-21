using DSA.LA.TimeBank.Core.Interfaces.Domain;

namespace DSA.LA.TimeBank.Core.Interfaces.DTO
{
    internal interface ITalentDTO : IDomainEntity
    {
        string Name { get; set; }
    }
}
