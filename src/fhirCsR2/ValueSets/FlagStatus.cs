// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// Indicates whether this flag is active and needs to be displayed to a user, or whether it is no longer needed or entered in error.
  /// </summary>
  public static class FlagStatusCodes
  {
    /// <summary>
    /// A current flag that should be displayed to a user. A system may use the category to determine which roles should view the flag.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/flag-status"
    };
    /// <summary>
    /// The flag was added in error, and should no longer be displayed.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/flag-status"
    };
    /// <summary>
    /// The flag does not need to be displayed any more.
    /// </summary>
    public static readonly Coding Inactive = new Coding
    {
      Code = "inactive",
      Display = "Inactive",
      System = "http://hl7.org/fhir/flag-status"
    };

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: FlagStatusActive
    /// </summary>
    public const string LiteralFlagStatusActive = "http://hl7.org/fhir/flag-status#active";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: FlagStatusEnteredInError
    /// </summary>
    public const string LiteralFlagStatusEnteredInError = "http://hl7.org/fhir/flag-status#entered-in-error";

    /// <summary>
    /// Literal for code: Inactive
    /// </summary>
    public const string LiteralInactive = "inactive";

    /// <summary>
    /// Literal for code: FlagStatusInactive
    /// </summary>
    public const string LiteralFlagStatusInactive = "http://hl7.org/fhir/flag-status#inactive";

    /// <summary>
    /// Dictionary for looking up FlagStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "active", Active }, 
      { "http://hl7.org/fhir/flag-status#active", Active }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/flag-status#entered-in-error", EnteredInError }, 
      { "inactive", Inactive }, 
      { "http://hl7.org/fhir/flag-status#inactive", Inactive }, 
    };
  };
}
