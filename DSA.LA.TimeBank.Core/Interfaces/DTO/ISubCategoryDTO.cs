using DSA.LA.TimeBank.Core.Interfaces.Domain;

namespace DSA.LA.TimeBank.Core.Interfaces.DTO
{
    internal interface ISubCategoryDTO : IDomainEntity
    {
        string Name { get; set; }
        ICategoryDTO Category { get; set; }
    }
}
