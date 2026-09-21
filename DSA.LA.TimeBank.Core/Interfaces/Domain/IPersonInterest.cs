namespace DSA.LA.TimeBank.Core.Interfaces.Domain
{
    internal interface IPersonInterest : IDomainEntity
    {
        int PersonId { get; set; }
        IPerson? Person { get; set; }
        int InterestId { get; set; }
        IInterest? Interest { get; set; }
    }
}
