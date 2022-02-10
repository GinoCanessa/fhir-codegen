// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Type for orientation.
  /// </summary>
  public static class OrientationTypeCodes
  {
    /// <summary>
    /// Antisense orientation of reference sequence.
    /// </summary>
    public static readonly Coding AntisenseOrientationOfReferenceSeq = new Coding
    {
      Code = "antisense",
      Display = "Antisense orientation of referenceSeq",
      System = "http://hl7.org/fhir/orientation-type"
    };
    /// <summary>
    /// Sense orientation of reference sequence.
    /// </summary>
    public static readonly Coding SenseOrientationOfReferenceSeq = new Coding
    {
      Code = "sense",
      Display = "Sense orientation of referenceSeq",
      System = "http://hl7.org/fhir/orientation-type"
    };

    /// <summary>
    /// Literal for code: AntisenseOrientationOfReferenceSeq
    /// </summary>
    public const string LiteralAntisenseOrientationOfReferenceSeq = "antisense";

    /// <summary>
    /// Literal for code: OrientationTypeAntisenseOrientationOfReferenceSeq
    /// </summary>
    public const string LiteralOrientationTypeAntisenseOrientationOfReferenceSeq = "http://hl7.org/fhir/orientation-type#antisense";

    /// <summary>
    /// Literal for code: SenseOrientationOfReferenceSeq
    /// </summary>
    public const string LiteralSenseOrientationOfReferenceSeq = "sense";

    /// <summary>
    /// Literal for code: OrientationTypeSenseOrientationOfReferenceSeq
    /// </summary>
    public const string LiteralOrientationTypeSenseOrientationOfReferenceSeq = "http://hl7.org/fhir/orientation-type#sense";

    /// <summary>
    /// Dictionary for looking up OrientationType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "antisense", AntisenseOrientationOfReferenceSeq }, 
      { "http://hl7.org/fhir/orientation-type#antisense", AntisenseOrientationOfReferenceSeq }, 
      { "sense", SenseOrientationOfReferenceSeq }, 
      { "http://hl7.org/fhir/orientation-type#sense", SenseOrientationOfReferenceSeq }, 
    };
  };
}
