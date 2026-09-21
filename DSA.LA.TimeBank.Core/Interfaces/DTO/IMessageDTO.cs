using DSA.LA.TimeBank.Core.Interfaces.Domain;

namespace DSA.LA.TimeBank.Core.Interfaces.DTO
{
    internal interface IMessageDTO
    {
        string Subject { get; set; }
        string Body { get; set; }
        bool IsResponse { get; set; }
        IMessage ParentMessage { get; set; }
        int ParentMessageId { get; set; }
        int AdvertisementId { get; set; }
    }
}
