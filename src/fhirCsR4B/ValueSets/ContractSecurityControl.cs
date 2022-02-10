// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set contract specific codes for security control.
  /// </summary>
  public static class ContractSecurityControlCodes
  {
    /// <summary>
    /// To be completed
    /// </summary>
    public static readonly Coding Policy = new Coding
    {
      Code = "policy",
      Display = "Policy",
      System = "http://hl7.org/fhir/contract-security-control"
    };

    /// <summary>
    /// Literal for code: Policy
    /// </summary>
    public const string LiteralPolicy = "policy";

    /// <summary>
    /// Literal for code: ContractSecurityControlPolicy
    /// </summary>
    public const string LiteralContractSecurityControlPolicy = "http://hl7.org/fhir/contract-security-control#policy";

    /// <summary>
    /// Dictionary for looking up ContractSecurityControl Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "policy", Policy }, 
      { "http://hl7.org/fhir/contract-security-control#policy", Policy }, 
    };
  };
}
