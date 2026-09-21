namespace DSA.LA.TimeBank.Core.Interfaces.Domain
{
    internal interface IDomainEntity
    {
        int Id { get; set; }
        DateTime DateCreated { get; set; }
        DateTime? DateModified { get; set; }
        IDomainEntity Cast<T>() where T : IDomainEntity;
        string ToJson();
    }
}
