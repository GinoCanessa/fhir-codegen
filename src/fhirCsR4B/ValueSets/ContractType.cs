// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set includes sample Contract Type codes.
  /// </summary>
  public static class ContractTypeCodes
  {
    /// <summary>
    /// Consent
    /// </summary>
    public static readonly Coding Consent = new Coding
    {
      Code = "consent",
      Display = "Consent",
      System = "http://terminology.hl7.org/CodeSystem/contract-type"
    };
    /// <summary>
    /// Disclosure
    /// </summary>
    public static readonly Coding Disclosure = new Coding
    {
      Code = "disclosure",
      Display = "Disclosure",
      System = "http://terminology.hl7.org/CodeSystem/contract-type"
    };
    /// <summary>
    /// Health Insurance
    /// </summary>
    public static readonly Coding HealthInsurance = new Coding
    {
      Code = "healthinsurance",
      Display = "Health Insurance",
      System = "http://terminology.hl7.org/CodeSystem/contract-type"
    };
    /// <summary>
    /// Privacy
    /// </summary>
    public static readonly Coding Privacy = new Coding
    {
      Code = "privacy",
      Display = "Privacy",
      System = "http://terminology.hl7.org/CodeSystem/contract-type"
    };
    /// <summary>
    /// Supply Contract
    /// </summary>
    public static readonly Coding SupplyContract = new Coding
    {
      Code = "supply",
      Display = "Supply Contract",
      System = "http://terminology.hl7.org/CodeSystem/contract-type"
    };

    /// <summary>
    /// Literal for code: Consent
    /// </summary>
    public const string LiteralConsent = "consent";

    /// <summary>
    /// Literal for code: ContractTypeConsent
    /// </summary>
    public const string LiteralContractTypeConsent = "http://terminology.hl7.org/CodeSystem/contract-type#consent";

    /// <summary>
    /// Literal for code: Disclosure
    /// </summary>
    public const string LiteralDisclosure = "disclosure";

    /// <summary>
    /// Literal for code: ContractTypeDisclosure
    /// </summary>
    public const string LiteralContractTypeDisclosure = "http://terminology.hl7.org/CodeSystem/contract-type#disclosure";

    /// <summary>
    /// Literal for code: HealthInsurance
    /// </summary>
    public const string LiteralHealthInsurance = "healthinsurance";

    /// <summary>
    /// Literal for code: ContractTypeHealthInsurance
    /// </summary>
    public const string LiteralContractTypeHealthInsurance = "http://terminology.hl7.org/CodeSystem/contract-type#healthinsurance";

    /// <summary>
    /// Literal for code: Privacy
    /// </summary>
    public const string LiteralPrivacy = "privacy";

    /// <summary>
    /// Literal for code: ContractTypePrivacy
    /// </summary>
    public const string LiteralContractTypePrivacy = "http://terminology.hl7.org/CodeSystem/contract-type#privacy";

    /// <summary>
    /// Literal for code: SupplyContract
    /// </summary>
    public const string LiteralSupplyContract = "supply";

    /// <summary>
    /// Literal for code: ContractTypeSupplyContract
    /// </summary>
    public const string LiteralContractTypeSupplyContract = "http://terminology.hl7.org/CodeSystem/contract-type#supply";

    /// <summary>
    /// Dictionary for looking up ContractType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "consent", Consent }, 
      { "http://terminology.hl7.org/CodeSystem/contract-type#consent", Consent }, 
      { "disclosure", Disclosure }, 
      { "http://terminology.hl7.org/CodeSystem/contract-type#disclosure", Disclosure }, 
      { "healthinsurance", HealthInsurance }, 
      { "http://terminology.hl7.org/CodeSystem/contract-type#healthinsurance", HealthInsurance }, 
      { "privacy", Privacy }, 
      { "http://terminology.hl7.org/CodeSystem/contract-type#privacy", Privacy }, 
      { "supply", SupplyContract }, 
      { "http://terminology.hl7.org/CodeSystem/contract-type#supply", SupplyContract }, 
    };
  };
}
