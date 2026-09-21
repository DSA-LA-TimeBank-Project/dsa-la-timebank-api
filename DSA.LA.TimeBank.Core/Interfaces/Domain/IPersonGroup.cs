namespace DSA.LA.TimeBank.Core.Interfaces.Domain
{
    internal interface IPersonGroup : IDomainEntity
    {
        int PersonId { get; set; }
        IPerson Person { get; set; }
        int GroupId { get; set; }
        IGroup Group { get; set; }
    }
}
