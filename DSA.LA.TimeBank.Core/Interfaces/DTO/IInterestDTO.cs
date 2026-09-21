using DSA.LA.TimeBank.Core.Interfaces.Domain;

namespace DSA.LA.TimeBank.Core.Interfaces.DTO
{
    internal interface IInterestDTO : IDomainEntity
    {
        string Name { get; set; }
    }
}
