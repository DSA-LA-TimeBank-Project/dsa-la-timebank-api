 namespace DSA.LA.TimeBank.Core.Interfaces.Domain
{
    internal interface IGroup : IDomainEntity
    {
        string Name { get; set; }
        List<IPersonGroup> Members { get; set; }
    }
}
