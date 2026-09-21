namespace DSA.LA.TimeBank.Core.Interfaces.Domain
{
    internal interface IMessage : IDomainEntity
    {
        string Subject { get; set; }
        string Body { get; set; }
        bool IsResponse { get; set; }
        int ParentMessageId { get; set; }
        IMessage? ParentMessage { get; set; }
        int AdvertisementId { get; set; }
    }
}
