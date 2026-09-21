using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using DSA.LA.TimeBank.Core.Interfaces.Domain;

namespace DSA.LA.TimeBank.Core.Models.Domain
{
    internal class Message : IMessage
    {
        #region Fields
        private readonly JsonSerializerOptions _serializerOptions = new()
        {
            ReferenceHandler = ReferenceHandler.IgnoreCycles
        };

        private Message? _parentMessage = null;
        #endregion

        #region Properties
        [Required, JsonPropertyName("id")]
        public int Id { get; set; } = 0;
        [Required, JsonPropertyName("subject")]
        public string Subject { get; set; } = string.Empty;
        [Required, JsonPropertyName("body")]
        public string Body { get; set; } = string.Empty;
        [Required, JsonPropertyName("isResponse")]
        public bool IsResponse { get; set; } = false;
        [JsonIgnore]
        IMessage? IMessage.ParentMessage
        {
            get => _parentMessage;
            set => _parentMessage = (Message)value!;
        }
        [Required, JsonPropertyName("parentMessageId")]
        public int ParentMessageId { get; set; } = 0;
        [Required, JsonPropertyName("parentMessage")]
        public Message? ParentMessage
        {
            get => _parentMessage;
            set => _parentMessage = value;
        }
        [Required, JsonPropertyName("advertisementId")]
        public int AdvertisementId { get; set; } = 0;
        [Required, JsonPropertyName("dateCreated")]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        [JsonPropertyName("dateModified")]
        public DateTime? DateModified { get; set; } = null;
        #endregion

        #region Methods
        public IDomainEntity Cast<T>() where T : IDomainEntity
        {
            throw new NotImplementedException();
        }

        public string ToJson() => JsonSerializer.Serialize(
            this,
            _serializerOptions);

        public override string ToString() => string.Format(base.ToString() + ".Id:{0}.Subject:{1}", Id, Subject);
        #endregion
    }
}
