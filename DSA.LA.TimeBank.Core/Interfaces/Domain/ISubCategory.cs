namespace DSA.LA.TimeBank.Core.Interfaces.Domain
{
    internal interface ISubCategory : IDomainEntity
    {
        string Name { get; set; }
        int CategoryId { get; set; }
        ICategory Category { get; set; }
    }
}
