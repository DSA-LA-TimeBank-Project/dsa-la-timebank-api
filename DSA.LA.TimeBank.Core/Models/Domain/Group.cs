using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using DSA.LA.TimeBank.Core.Interfaces.Domain;

namespace DSA.LA.TimeBank.Core.Models.Domain
{
    internal class Group : IGroup
    {
        #region Fields
        private readonly JsonSerializerOptions _serializerOptions = new()
        {
            ReferenceHandler = ReferenceHandler.IgnoreCycles
        };
        private List<PersonGroup> _members = [];
        #endregion

        #region Properties
        [Required, JsonPropertyName("id")]
        public int Id { get; set; } = 0;
        [Required, JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        [JsonIgnore]
        List<IPersonGroup> IGroup.Members
        {
            get => _members.ConvertAll(m => (IPersonGroup)m);
            set => _members = value.ConvertAll(m => (PersonGroup)m);
        }
        [Required, JsonPropertyName("members")]
        public List<PersonGroup> Members
        {
            get => _members;
            set => _members = value;
        }
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

        public override string ToString() => string.Format(base.ToString() + ".Id:{0}.Name:{1}", Id, Name);
        #endregion
    }
}
