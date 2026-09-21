namespace DSA.LA.TimeBank.Core.Interfaces.Domain
{
    internal interface IMessage
    {
        string Subject { get; set; }
        string Body { get; set; }
        bool IsResponse { get; set; }
        IMessage ParentMessage { get; set; }
        int ParentMessageId { get; set; }
        int AdvertisementId { get; set; }
    }
}
