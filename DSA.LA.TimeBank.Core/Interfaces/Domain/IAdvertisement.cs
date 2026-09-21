namespace DSA.LA.TimeBank.Core.Interfaces.Domain
{
    internal interface IAdvertisement : IDomainEntity
    {
        string Title { get; set; }
        string Description { get; set; }
        int CategoryId { get; set; }
        ISubCategory? SubCategory { get; set; }
        int SubCategoryId { get; set; }
        DateTime? ExpirationDate { get; set; }
        int MemberId { get; set; }
        IPerson? Member { get; set; }
        List<IMessage> Conversation { get; set; }
        bool IsOffer { get; set; }
        bool DoesExpires { get; set; }
    }
}
