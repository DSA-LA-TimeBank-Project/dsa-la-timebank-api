namespace DSA.LA.TimeBank.Core.Interfaces.Domain
{
    internal interface ICategory : IDomainEntity
    {
        string Name { get; set; }
        List<ISubCategory> SubCategories { get; set; }
    }
}
