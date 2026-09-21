namespace DSA.LA.TimeBank.Core.Interfaces.Domain
{
    internal interface IInterestTalent
    {
        int TalentId { get; set; }
        ITalent Talent { get; set; }
        int InterestId { get; set; }
        IInterest Interest { get; set; }
    }
}
