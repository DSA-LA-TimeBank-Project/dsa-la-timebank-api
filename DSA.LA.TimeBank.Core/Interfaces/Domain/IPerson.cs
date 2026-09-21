using DSA.LA.TimeBank.Core.Enums;

namespace DSA.LA.TimeBank.Core.Interfaces.Domain
{
    internal interface IPerson : IDomainEntity
    {
        string FirstName { get; set; }
        string? MiddleName { get; set; }
        string LastName { get; set; }
        string FullName { get; }
        string Pronouns { get; set; }
        string Street1 { get; set; }
        string? Street2 { get; set; }
        string City { get; set; }
        States? State { get; set; }
        string ZipCode { get; set; }
        string Email { get; set; }
        string PrimaryPhone { get; set; }
        string? AlternatePhone { get; set; }
        string? MobilePhone { get; set; }
        string EmergencyContactFirstName { get; set; }
        string? EmergencyContactMiddleName { get; set; }
        string EmergencyContactLastName { get; set; }
        string EmergencyContactFullName { get; }
        string EmergencyContactPhone { get; set; }
        string EmergencyContactRelationship { get; set; }
        string? Website { get; set; }
        string? Biography { get; set; }
        List<IPersonTalent> Talents { get; set; }
        List<IPersonInterest> Interests { get; set; }
        int Hours { get; set; }
    }
}
