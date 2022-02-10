// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The gender of a person used for administrative purposes.
  /// </summary>
  public static class AdministrativeGenderCodes
  {
    /// <summary>
    /// Female.
    /// </summary>
    public static readonly Coding Female = new Coding
    {
      Code = "female",
      Display = "Female",
      System = "http://hl7.org/fhir/administrative-gender"
    };
    /// <summary>
    /// Male.
    /// </summary>
    public static readonly Coding Male = new Coding
    {
      Code = "male",
      Display = "Male",
      System = "http://hl7.org/fhir/administrative-gender"
    };
    /// <summary>
    /// Other.
    /// </summary>
    public static readonly Coding Other = new Coding
    {
      Code = "other",
      Display = "Other",
      System = "http://hl7.org/fhir/administrative-gender"
    };
    /// <summary>
    /// Unknown.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/administrative-gender"
    };

    /// <summary>
    /// Literal for code: Female
    /// </summary>
    public const string LiteralFemale = "female";

    /// <summary>
    /// Literal for code: AdministrativeGenderFemale
    /// </summary>
    public const string LiteralAdministrativeGenderFemale = "http://hl7.org/fhir/administrative-gender#female";

    /// <summary>
    /// Literal for code: Male
    /// </summary>
    public const string LiteralMale = "male";

    /// <summary>
    /// Literal for code: AdministrativeGenderMale
    /// </summary>
    public const string LiteralAdministrativeGenderMale = "http://hl7.org/fhir/administrative-gender#male";

    /// <summary>
    /// Literal for code: Other
    /// </summary>
    public const string LiteralOther = "other";

    /// <summary>
    /// Literal for code: AdministrativeGenderOther
    /// </summary>
    public const string LiteralAdministrativeGenderOther = "http://hl7.org/fhir/administrative-gender#other";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: AdministrativeGenderUnknown
    /// </summary>
    public const string LiteralAdministrativeGenderUnknown = "http://hl7.org/fhir/administrative-gender#unknown";

    /// <summary>
    /// Dictionary for looking up AdministrativeGender Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "female", Female }, 
      { "http://hl7.org/fhir/administrative-gender#female", Female }, 
      { "male", Male }, 
      { "http://hl7.org/fhir/administrative-gender#male", Male }, 
      { "other", Other }, 
      { "http://hl7.org/fhir/administrative-gender#other", Other }, 
      { "unknown", Unknown }, 
      { "http://hl7.org/fhir/administrative-gender#unknown", Unknown }, 
    };
  };
}
