namespace DSA.LA.TimeBank.Core.Interfaces.Domain
{
    internal interface IPersonTalent : IDomainEntity
    {
        int PersonId { get; set; }
        IPerson Person { get; set; }
        int TalentId { get; set; }
        ITalent Talent { get; set; }
    }
}
