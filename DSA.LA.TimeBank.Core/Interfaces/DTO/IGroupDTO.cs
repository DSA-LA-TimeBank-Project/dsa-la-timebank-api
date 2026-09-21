using DSA.LA.TimeBank.Core.Interfaces.Domain;

namespace DSA.LA.TimeBank.Core.Interfaces.DTO
{
    internal interface IGroupDTO : IDomainEntity
    {
        string Name { get; set; }
        List<IPersonDTO> Members { get; set; }
    }
}
