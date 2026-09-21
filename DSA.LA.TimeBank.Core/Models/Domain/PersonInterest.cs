using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using DSA.LA.TimeBank.Core.Interfaces.Domain;

namespace DSA.LA.TimeBank.Core.Models.Domain
{
    internal class PersonInterest : IPersonInterest
    {
        #region Fields
        private readonly JsonSerializerOptions _serializerOptions = new()
        {
            ReferenceHandler = ReferenceHandler.IgnoreCycles
        };

        private Person? _person = null;
        private Interest? _interest = null;
        #endregion

        #region Properties
        [Required, JsonPropertyName("id")]
        public int Id { get; set; } = 0;
        [Required, JsonPropertyName("personId")]
        public int PersonId { get; set; } = 0;
        [JsonIgnore]
        IPerson? IPersonInterest.Person
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
        [Required, JsonPropertyName("interestId")]
        public int InterestId { get; set; } = 0;
        [JsonIgnore]
        IInterest? IPersonInterest.Interest
        {
            get => _interest;
            set => _interest = (Interest)value!;
        }
        [Required, JsonPropertyName("interest")]
        public Interest? Interest
        {
            get => _interest;
            set => _interest = value;
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

        public override string ToString() => string.Format(base.ToString() + ".Id:{0}.PersonId:{1}.InterestId:{2}", Id, PersonId, InterestId);
        #endregion
    }
}
