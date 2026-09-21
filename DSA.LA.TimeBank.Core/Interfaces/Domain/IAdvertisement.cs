namespace DSA.LA.TimeBank.Core.Interfaces.Domain
{
    internal interface IAdvertisement : IDomainEntity
    {
        string Title { get; set; }
        string Description { get; set; }
        int CategoryId { get; set; }
        ISubCategory SubCategory { get; set; }
        int SubCategoryId { get; set; }
        DateTime ExpirationDate { get; set; }
        IPerson Member { get; set; }
        int MemberId { get; set; }
        List<IMessage> Conversation { get; set; }
        bool IsOffer { get; set; }
        bool Expires { get; set; }
    }
}
