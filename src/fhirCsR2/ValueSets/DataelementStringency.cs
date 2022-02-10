// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// Indicates the degree of precision of the data element definition.
  /// </summary>
  public static class DataelementStringencyCodes
  {
    /// <summary>
    /// The data element is sufficiently well-constrained that multiple pieces of data captured according to the constraints of the data element will be comparable (though in some cases, a degree of automated conversion/normalization may be required).
    /// </summary>
    public static readonly Coding Comparable = new Coding
    {
      Code = "comparable",
      Display = "Comparable",
      System = "http://hl7.org/fhir/dataelement-stringency"
    };
    /// <summary>
    /// The data element allows multiple units of measure that are convertable between each other (e.g. inches and centimeters) and/or allows data to be captured in multiple value sets for which a known mapping exists allowing conversion of meaning.
    /// </summary>
    public static readonly Coding Convertable = new Coding
    {
      Code = "convertable",
      Display = "Convertable",
      System = "http://hl7.org/fhir/dataelement-stringency"
    };
    /// <summary>
    /// The data element allows multiple units of measure having equivalent meaning; e.g. "cc" (cubic centimeter) and "mL" (milliliter).
    /// </summary>
    public static readonly Coding Equivalent = new Coding
    {
      Code = "equivalent",
      Display = "Equivalent",
      System = "http://hl7.org/fhir/dataelement-stringency"
    };
    /// <summary>
    /// The data element is unconstrained in units, choice of data types and/or choice of vocabulary such that automated comparison of data captured using the data element is not possible.
    /// </summary>
    public static readonly Coding Flexible = new Coding
    {
      Code = "flexible",
      Display = "Flexible",
      System = "http://hl7.org/fhir/dataelement-stringency"
    };
    /// <summary>
    /// The data element is fully specified down to a single value set, single unit of measure, single data type, etc.  Multiple pieces of data associated with this data element are fully comparable.
    /// </summary>
    public static readonly Coding FullySpecified = new Coding
    {
      Code = "fully-specified",
      Display = "Fully Specified",
      System = "http://hl7.org/fhir/dataelement-stringency"
    };
    /// <summary>
    /// A convertable data element where unit conversions are different only by a power of 10; e.g. g, mg, kg.
    /// </summary>
    public static readonly Coding Scaleable = new Coding
    {
      Code = "scaleable",
      Display = "Scaleable",
      System = "http://hl7.org/fhir/dataelement-stringency"
    };

    /// <summary>
    /// Literal for code: Comparable
    /// </summary>
    public const string LiteralComparable = "comparable";

    /// <summary>
    /// Literal for code: DataelementStringencyComparable
    /// </summary>
    public const string LiteralDataelementStringencyComparable = "http://hl7.org/fhir/dataelement-stringency#comparable";

    /// <summary>
    /// Literal for code: Convertable
    /// </summary>
    public const string LiteralConvertable = "convertable";

    /// <summary>
    /// Literal for code: DataelementStringencyConvertable
    /// </summary>
    public const string LiteralDataelementStringencyConvertable = "http://hl7.org/fhir/dataelement-stringency#convertable";

    /// <summary>
    /// Literal for code: Equivalent
    /// </summary>
    public const string LiteralEquivalent = "equivalent";

    /// <summary>
    /// Literal for code: DataelementStringencyEquivalent
    /// </summary>
    public const string LiteralDataelementStringencyEquivalent = "http://hl7.org/fhir/dataelement-stringency#equivalent";

    /// <summary>
    /// Literal for code: Flexible
    /// </summary>
    public const string LiteralFlexible = "flexible";

    /// <summary>
    /// Literal for code: DataelementStringencyFlexible
    /// </summary>
    public const string LiteralDataelementStringencyFlexible = "http://hl7.org/fhir/dataelement-stringency#flexible";

    /// <summary>
    /// Literal for code: FullySpecified
    /// </summary>
    public const string LiteralFullySpecified = "fully-specified";

    /// <summary>
    /// Literal for code: DataelementStringencyFullySpecified
    /// </summary>
    public const string LiteralDataelementStringencyFullySpecified = "http://hl7.org/fhir/dataelement-stringency#fully-specified";

    /// <summary>
    /// Literal for code: Scaleable
    /// </summary>
    public const string LiteralScaleable = "scaleable";

    /// <summary>
    /// Literal for code: DataelementStringencyScaleable
    /// </summary>
    public const string LiteralDataelementStringencyScaleable = "http://hl7.org/fhir/dataelement-stringency#scaleable";

    /// <summary>
    /// Dictionary for looking up DataelementStringency Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "comparable", Comparable }, 
      { "http://hl7.org/fhir/dataelement-stringency#comparable", Comparable }, 
      { "convertable", Convertable }, 
      { "http://hl7.org/fhir/dataelement-stringency#convertable", Convertable }, 
      { "equivalent", Equivalent }, 
      { "http://hl7.org/fhir/dataelement-stringency#equivalent", Equivalent }, 
      { "flexible", Flexible }, 
      { "http://hl7.org/fhir/dataelement-stringency#flexible", Flexible }, 
      { "fully-specified", FullySpecified }, 
      { "http://hl7.org/fhir/dataelement-stringency#fully-specified", FullySpecified }, 
      { "scaleable", Scaleable }, 
      { "http://hl7.org/fhir/dataelement-stringency#scaleable", Scaleable }, 
    };
  };
}
