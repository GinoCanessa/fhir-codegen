// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Type of alerts/updates the primary source can send
  /// </summary>
  public static class VerificationresultPushTypeAvailableCodes
  {
    /// <summary>
    /// Any changes
    /// </summary>
    public static readonly Coding AnyChanges = new Coding
    {
      Code = "any",
      Display = "Any changes",
      System = "http://terminology.hl7.org/CodeSystem/push-type-available"
    };
    /// <summary>
    /// As defined by source
    /// </summary>
    public static readonly Coding AsDefinedBySource = new Coding
    {
      Code = "source",
      Display = "As defined by source",
      System = "http://terminology.hl7.org/CodeSystem/push-type-available"
    };
    /// <summary>
    /// Specific requested changes
    /// </summary>
    public static readonly Coding SpecificRequestedChanges = new Coding
    {
      Code = "specific",
      Display = "Specific requested changes",
      System = "http://terminology.hl7.org/CodeSystem/push-type-available"
    };

    /// <summary>
    /// Literal for code: AnyChanges
    /// </summary>
    public const string LiteralAnyChanges = "any";

    /// <summary>
    /// Literal for code: VerificationresultPushTypeAvailableAnyChanges
    /// </summary>
    public const string LiteralVerificationresultPushTypeAvailableAnyChanges = "http://terminology.hl7.org/CodeSystem/push-type-available#any";

    /// <summary>
    /// Literal for code: AsDefinedBySource
    /// </summary>
    public const string LiteralAsDefinedBySource = "source";

    /// <summary>
    /// Literal for code: VerificationresultPushTypeAvailableAsDefinedBySource
    /// </summary>
    public const string LiteralVerificationresultPushTypeAvailableAsDefinedBySource = "http://terminology.hl7.org/CodeSystem/push-type-available#source";

    /// <summary>
    /// Literal for code: SpecificRequestedChanges
    /// </summary>
    public const string LiteralSpecificRequestedChanges = "specific";

    /// <summary>
    /// Literal for code: VerificationresultPushTypeAvailableSpecificRequestedChanges
    /// </summary>
    public const string LiteralVerificationresultPushTypeAvailableSpecificRequestedChanges = "http://terminology.hl7.org/CodeSystem/push-type-available#specific";

    /// <summary>
    /// Dictionary for looking up VerificationresultPushTypeAvailable Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "any", AnyChanges }, 
      { "http://terminology.hl7.org/CodeSystem/push-type-available#any", AnyChanges }, 
      { "source", AsDefinedBySource }, 
      { "http://terminology.hl7.org/CodeSystem/push-type-available#source", AsDefinedBySource }, 
      { "specific", SpecificRequestedChanges }, 
      { "http://terminology.hl7.org/CodeSystem/push-type-available#specific", SpecificRequestedChanges }, 
    };
  };
}
