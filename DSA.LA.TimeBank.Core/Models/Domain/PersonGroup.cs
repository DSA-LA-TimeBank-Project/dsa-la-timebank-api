using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using DSA.LA.TimeBank.Core.Interfaces.Domain;

namespace DSA.LA.TimeBank.Core.Models.Domain
{
    internal class PersonGroup : IPersonGroup
    {
        #region Fields
        private readonly JsonSerializerOptions _serializerOptions = new()
        {
            ReferenceHandler = ReferenceHandler.IgnoreCycles
        };

        private Person? _person = null;
        private Group? _group = null;
        #endregion

        #region Properties
        [Required, JsonPropertyName("id")]
        public int Id { get; set; } = 0;
        [Required, JsonPropertyName("personId")]
        public int PersonId { get; set; } = 0;
        [JsonIgnore]
        IPerson? IPersonGroup.Person
        {
            get => _person;
            set => _person = (Person)value!;
        }
        [Required, JsonPropertyName("person")]
        public Person? Person
        {
            get => _person;
            set => _person = value;
        }
        [Required, JsonPropertyName("groupId")]
        public int GroupId { get; set; } = 0;
        [JsonIgnore]
        IGroup? IPersonGroup.Group
        {
            get => _group;
            set => _group = (Group)value!;
        }
        [Required, JsonPropertyName("group")]
        public Group? Group
        {
            get => _group;
            set => _group = value;
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

        public override string ToString() => string.Format(base.ToString() + ".Id:{0}.PersonId:{1}.GroupId:{2}", Id, PersonId, GroupId);
        #endregion
    }
}
