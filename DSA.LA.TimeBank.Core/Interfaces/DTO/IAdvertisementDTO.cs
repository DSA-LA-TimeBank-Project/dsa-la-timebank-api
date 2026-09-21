using DSA.LA.TimeBank.Core.Interfaces.Domain;

namespace DSA.LA.TimeBank.Core.Interfaces.DTO
{
    internal interface IAdvertisementDTO : IDomainEntity
    {
        string Title { get; set; }
        string Description { get; set; }
        ISubCategoryDTO SubCategory { get; set; }
        DateTime ExpirationDate { get; set; }
        IPerson Member { get; set; }
        List<IMessage> Conversation { get; set; }
        bool IsOffer { get; set; }
        bool Expires { get; set; }
    }
}
