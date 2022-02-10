// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Type for quality report.
  /// </summary>
  public static class QualityTypeCodes
  {
    /// <summary>
    /// INDEL Comparison.
    /// </summary>
    public static readonly Coding INDELComparison = new Coding
    {
      Code = "indel",
      Display = "INDEL Comparison",
      System = "http://hl7.org/fhir/quality-type"
    };
    /// <summary>
    /// SNP Comparison.
    /// </summary>
    public static readonly Coding SNPComparison = new Coding
    {
      Code = "snp",
      Display = "SNP Comparison",
      System = "http://hl7.org/fhir/quality-type"
    };
    /// <summary>
    /// UNKNOWN Comparison.
    /// </summary>
    public static readonly Coding UNKNOWNComparison = new Coding
    {
      Code = "unknown",
      Display = "UNKNOWN Comparison",
      System = "http://hl7.org/fhir/quality-type"
    };

    /// <summary>
    /// Literal for code: INDELComparison
    /// </summary>
    public const string LiteralINDELComparison = "indel";

    /// <summary>
    /// Literal for code: QualityTypeINDELComparison
    /// </summary>
    public const string LiteralQualityTypeINDELComparison = "http://hl7.org/fhir/quality-type#indel";

    /// <summary>
    /// Literal for code: SNPComparison
    /// </summary>
    public const string LiteralSNPComparison = "snp";

    /// <summary>
    /// Literal for code: QualityTypeSNPComparison
    /// </summary>
    public const string LiteralQualityTypeSNPComparison = "http://hl7.org/fhir/quality-type#snp";

    /// <summary>
    /// Literal for code: UNKNOWNComparison
    /// </summary>
    public const string LiteralUNKNOWNComparison = "unknown";

    /// <summary>
    /// Literal for code: QualityTypeUNKNOWNComparison
    /// </summary>
    public const string LiteralQualityTypeUNKNOWNComparison = "http://hl7.org/fhir/quality-type#unknown";

    /// <summary>
    /// Dictionary for looking up QualityType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "indel", INDELComparison }, 
      { "http://hl7.org/fhir/quality-type#indel", INDELComparison }, 
      { "snp", SNPComparison }, 
      { "http://hl7.org/fhir/quality-type#snp", SNPComparison }, 
      { "unknown", UNKNOWNComparison }, 
      { "http://hl7.org/fhir/quality-type#unknown", UNKNOWNComparison }, 
    };
  };
}
