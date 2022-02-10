// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set contract specific codes for status.
  /// </summary>
  public static class ContractExpirationTypeCodes
  {
    /// <summary>
    /// To be completed
    /// </summary>
    public static readonly Coding Breach = new Coding
    {
      Code = "breach",
      Display = "Breach",
      System = "http://hl7.org/fhir/contract-expiration-type"
    };

    /// <summary>
    /// Literal for code: Breach
    /// </summary>
    public const string LiteralBreach = "breach";

    /// <summary>
    /// Literal for code: ContractExpirationTypeBreach
    /// </summary>
    public const string LiteralContractExpirationTypeBreach = "http://hl7.org/fhir/contract-expiration-type#breach";

    /// <summary>
    /// Dictionary for looking up ContractExpirationType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "breach", Breach }, 
      { "http://hl7.org/fhir/contract-expiration-type#breach", Breach }, 
    };
  };
}
