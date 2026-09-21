using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using DSA.LA.TimeBank.Core.Enums;
using DSA.LA.TimeBank.Core.Interfaces.Domain;

namespace DSA.LA.TimeBank.Core.Models.Domain
{
    internal class Person : IPerson
    {
        #region Fields
        private readonly JsonSerializerOptions _serializerOptions = new()
        {
            ReferenceHandler = ReferenceHandler.IgnoreCycles
        };

        private List<PersonTalent> _talents = [];
        private List<PersonInterest> _interests = [];
        #endregion

        #region Properties
        [Required, JsonPropertyName("id")]
        public int Id { get; set; } = 0;
        [Required, JsonPropertyName("firstName")]
        public string FirstName { get; set; } = string.Empty;
        [JsonPropertyName("middleName")]
        public string? MiddleName { get; set; } = null;
        [Required, JsonPropertyName("lastName")]
        public string LastName { get; set; } = string.Empty;
        [JsonPropertyName("fullName")]
        public string FullName => string.IsNullOrEmpty(MiddleName) ? 
            string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName) ? 
                string.Empty : 
                string.Format("{0} {1}", FirstName, LastName).Trim() : 
            string.Format("{0} {1} {2}", FirstName, MiddleName, LastName).Trim();
        [Required, JsonPropertyName("pronouns")]
        public string Pronouns { get; set; } = string.Empty;
        [Required, JsonPropertyName("street1")]
        public string Street1 { get; set; } = string.Empty;
        [JsonPropertyName("street2")]
        public string? Street2 { get; set; } = null;
        [Required, JsonPropertyName("city")]
        public string City { get; set; } = string.Empty;
        [Required, JsonPropertyName("state")]
        public States? State { get; set; } = null;
        [Required, JsonPropertyName("zipCode")]
        public string ZipCode { get; set; } = string.Empty;
        [Required, JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;
        [Required, JsonPropertyName("primaryPhone")]
        public string PrimaryPhone { get; set; } = string.Empty;
        [JsonPropertyName("alternatePhone")]
        public string? AlternatePhone { get; set; } = string.Empty;
        [JsonPropertyName("mobilePhone")]
        public string? MobilePhone { get; set; } = string.Empty;
        [Required, JsonPropertyName("emergencyContactFirstName")]
        public string EmergencyContactFirstName { get; set; } = string.Empty;
        [JsonPropertyName("emergencyContactMiddleName")]
        public string? EmergencyContactMiddleName { get; set; } = null;
        [Required, JsonPropertyName("emergencyContactLastName")]
        public string EmergencyContactLastName { get; set; } = string.Empty;
        [JsonPropertyName("emergencyContactFullName")]
        public string EmergencyContactFullName => string.IsNullOrEmpty(EmergencyContactMiddleName) ? 
            string.IsNullOrEmpty(EmergencyContactFirstName) && string.IsNullOrEmpty(EmergencyContactLastName) ?
                string.Empty :
                string.Format("{0} {1}", EmergencyContactFirstName, EmergencyContactLastName).Trim() : 
            string.Format("{0} {1} {2}", EmergencyContactFirstName, EmergencyContactMiddleName, EmergencyContactLastName).Trim();
        [Required, JsonPropertyName("emergencyContactPhone")]
        public string EmergencyContactPhone { get; set; } = string.Empty;
        [Required, JsonPropertyName("emergencyContactRelationship")]
        public string EmergencyContactRelationship { get; set; } = string.Empty;
        [JsonPropertyName("website")]
        public string? Website { get; set; } = null;
        [JsonPropertyName("biography")]
        public string? Biography { get; set; } = null;
        [JsonIgnore]
        List<IPersonTalent> IPerson.Talents
        {
            get => _talents.ConvertAll(t => (IPersonTalent)t);
            set => _talents = [.. value.Cast<PersonTalent>()];
        }
        [Required, JsonPropertyName("talents")]
        public List<PersonTalent> Talents
        {
            get => _talents;
            set => _talents = value;
        }
        [JsonIgnore]
        List<IPersonInterest> IPerson.Interests
        {
            get => _interests.ConvertAll(i => (IPersonInterest)i);
            set => _interests = [.. value.Cast<PersonInterest>()];
        }
        [Required, JsonPropertyName("interests")]
        public List<PersonInterest> Interests
        {
            get => _interests;
            set => _interests = value;
        }
        [Required, JsonPropertyName("hours")]
        public int Hours { get; set; } = 0;
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

        public override string ToString() => string.Format(base.ToString() + ".Id:{0}.FullName:{1}", Id, FullName);
        #endregion
    }
}
