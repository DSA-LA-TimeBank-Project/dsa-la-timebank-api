using DSA.LA.TimeBank.Core.Interfaces.Domain;

namespace DSA.LA.TimeBank.Core.Interfaces.DTO
{
    internal interface ICategoryDTO : IDomainEntity
    {
        string Name { get; set; }
        List<ISubCategoryDTO> SubCategories { get; set; }
    }
}
