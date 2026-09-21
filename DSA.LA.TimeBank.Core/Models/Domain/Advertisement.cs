using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using DSA.LA.TimeBank.Core.Interfaces.Domain;

namespace DSA.LA.TimeBank.Core.Models.Domain
{
    internal class Advertisement : IAdvertisement
    {
        #region Fields
        private readonly JsonSerializerOptions _serializerOptions = new()
        {
            ReferenceHandler = ReferenceHandler.IgnoreCycles
        };

        private SubCategory? _subCategory = null;
        private Person? _member = null;
        #endregion

        #region Properties
        [Required, JsonPropertyName("id")]
        public int Id { get; set; } = 0;
        [Required, JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;
        [Required, JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
        [Required, JsonPropertyName("categoryId")]
        public int CategoryId { get; set; } = 0;
        [JsonIgnore]
        ISubCategory? IAdvertisement.SubCategory
        {
            get => _subCategory;
            set => _subCategory = (SubCategory)value!;
        }
        [Required, JsonPropertyName("subCategory")]
        public SubCategory? SubCategory
        {
            get => _subCategory;
            set => _subCategory = value;
        }
        [Required, JsonPropertyName("subCategoryId")]
        public int SubCategoryId { get; set; } = 0;
        [JsonPropertyName("expirationDate")]
        public DateTime? ExpirationDate { get; set; } = null;
        [JsonIgnore]
        IPerson? IAdvertisement.Member
        {
            get => _member; 
            set => _member = (Person)value!;
        }
        [Required, JsonPropertyName("memberId")]
        public int MemberId { get; set; } = 0;
        [Required, JsonPropertyName("member")]
        public Person? Member
        {
            get => _member;
            set => _member = value;
        }
        [Required, JsonPropertyName("conversation")]
        public List<IMessage> Conversation { get; set; } = [];
        [Required, JsonPropertyName("isOffer")]
        public bool IsOffer { get; set; } = false;
        [Required, JsonPropertyName("doesExpires")]
        public bool DoesExpires { get; set; } = false;
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

        public override string ToString() => string.Format(base.ToString() + ".Id:{0}.Title:{1}", Id, Title);
        #endregion
    }
}
