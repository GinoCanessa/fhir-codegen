// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Permitted data type for observation value.
  /// </summary>
  public static class PermittedDataTypeCodes
  {
    /// <summary>
    /// true or false.
    /// </summary>
    public static readonly Coding Boolean = new Coding
    {
      Code = "boolean",
      Display = "boolean",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A coded concept from a reference terminology and/or text.
    /// </summary>
    public static readonly Coding CodeableConcept = new Coding
    {
      Code = "CodeableConcept",
      Display = "CodeableConcept",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A date, date-time or partial date (e.g. just year or year + month) as used in human communication.
    /// </summary>
    public static readonly Coding DateTime = new Coding
    {
      Code = "dateTime",
      Display = "dateTime",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A signed integer.
    /// </summary>
    public static readonly Coding Integer = new Coding
    {
      Code = "integer",
      Display = "integer",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A time range defined by start and end date/time.
    /// </summary>
    public static readonly Coding Period = new Coding
    {
      Code = "Period",
      Display = "Period",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A measured amount.
    /// </summary>
    public static readonly Coding Quantity = new Coding
    {
      Code = "Quantity",
      Display = "Quantity",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A set of values bounded by low and high.
    /// </summary>
    public static readonly Coding Range = new Coding
    {
      Code = "Range",
      Display = "Range",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A ratio of two Quantity values - a numerator and a denominator.
    /// </summary>
    public static readonly Coding Ratio = new Coding
    {
      Code = "Ratio",
      Display = "Ratio",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A series of measurements taken by a device.
    /// </summary>
    public static readonly Coding SampledData = new Coding
    {
      Code = "SampledData",
      Display = "SampledData",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A sequence of Unicode characters.
    /// </summary>
    public static readonly Coding VALString = new Coding
    {
      Code = "string",
      Display = "string",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A time during the day, in the format hh:mm:ss.
    /// </summary>
    public static readonly Coding Time = new Coding
    {
      Code = "time",
      Display = "time",
      System = "http://hl7.org/fhir/permitted-data-type"
    };

    /// <summary>
    /// Literal for code: Boolean
    /// </summary>
    public const string LiteralBoolean = "boolean";

    /// <summary>
    /// Literal for code: PermittedDataTypeBoolean
    /// </summary>
    public const string LiteralPermittedDataTypeBoolean = "http://hl7.org/fhir/permitted-data-type#boolean";

    /// <summary>
    /// Literal for code: CodeableConcept
    /// </summary>
    public const string LiteralCodeableConcept = "CodeableConcept";

    /// <summary>
    /// Literal for code: PermittedDataTypeCodeableConcept
    /// </summary>
    public const string LiteralPermittedDataTypeCodeableConcept = "http://hl7.org/fhir/permitted-data-type#CodeableConcept";

    /// <summary>
    /// Literal for code: DateTime
    /// </summary>
    public const string LiteralDateTime = "dateTime";

    /// <summary>
    /// Literal for code: PermittedDataTypeDateTime
    /// </summary>
    public const string LiteralPermittedDataTypeDateTime = "http://hl7.org/fhir/permitted-data-type#dateTime";

    /// <summary>
    /// Literal for code: Integer
    /// </summary>
    public const string LiteralInteger = "integer";

    /// <summary>
    /// Literal for code: PermittedDataTypeInteger
    /// </summary>
    public const string LiteralPermittedDataTypeInteger = "http://hl7.org/fhir/permitted-data-type#integer";

    /// <summary>
    /// Literal for code: Period
    /// </summary>
    public const string LiteralPeriod = "Period";

    /// <summary>
    /// Literal for code: PermittedDataTypePeriod
    /// </summary>
    public const string LiteralPermittedDataTypePeriod = "http://hl7.org/fhir/permitted-data-type#Period";

    /// <summary>
    /// Literal for code: Quantity
    /// </summary>
    public const string LiteralQuantity = "Quantity";

    /// <summary>
    /// Literal for code: PermittedDataTypeQuantity
    /// </summary>
    public const string LiteralPermittedDataTypeQuantity = "http://hl7.org/fhir/permitted-data-type#Quantity";

    /// <summary>
    /// Literal for code: Range
    /// </summary>
    public const string LiteralRange = "Range";

    /// <summary>
    /// Literal for code: PermittedDataTypeRange
    /// </summary>
    public const string LiteralPermittedDataTypeRange = "http://hl7.org/fhir/permitted-data-type#Range";

    /// <summary>
    /// Literal for code: Ratio
    /// </summary>
    public const string LiteralRatio = "Ratio";

    /// <summary>
    /// Literal for code: PermittedDataTypeRatio
    /// </summary>
    public const string LiteralPermittedDataTypeRatio = "http://hl7.org/fhir/permitted-data-type#Ratio";

    /// <summary>
    /// Literal for code: SampledData
    /// </summary>
    public const string LiteralSampledData = "SampledData";

    /// <summary>
    /// Literal for code: PermittedDataTypeSampledData
    /// </summary>
    public const string LiteralPermittedDataTypeSampledData = "http://hl7.org/fhir/permitted-data-type#SampledData";

    /// <summary>
    /// Literal for code: VALString
    /// </summary>
    public const string LiteralVALString = "string";

    /// <summary>
    /// Literal for code: PermittedDataTypeVALString
    /// </summary>
    public const string LiteralPermittedDataTypeVALString = "http://hl7.org/fhir/permitted-data-type#string";

    /// <summary>
    /// Literal for code: Time
    /// </summary>
    public const string LiteralTime = "time";

    /// <summary>
    /// Literal for code: PermittedDataTypeTime
    /// </summary>
    public const string LiteralPermittedDataTypeTime = "http://hl7.org/fhir/permitted-data-type#time";

    /// <summary>
    /// Dictionary for looking up PermittedDataType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "boolean", Boolean }, 
      { "http://hl7.org/fhir/permitted-data-type#boolean", Boolean }, 
      { "CodeableConcept", CodeableConcept }, 
      { "http://hl7.org/fhir/permitted-data-type#CodeableConcept", CodeableConcept }, 
      { "dateTime", DateTime }, 
      { "http://hl7.org/fhir/permitted-data-type#dateTime", DateTime }, 
      { "integer", Integer }, 
      { "http://hl7.org/fhir/permitted-data-type#integer", Integer }, 
      { "Period", Period }, 
      { "http://hl7.org/fhir/permitted-data-type#Period", Period }, 
      { "Quantity", Quantity }, 
      { "http://hl7.org/fhir/permitted-data-type#Quantity", Quantity }, 
      { "Range", Range }, 
      { "http://hl7.org/fhir/permitted-data-type#Range", Range }, 
      { "Ratio", Ratio }, 
      { "http://hl7.org/fhir/permitted-data-type#Ratio", Ratio }, 
      { "SampledData", SampledData }, 
      { "http://hl7.org/fhir/permitted-data-type#SampledData", SampledData }, 
      { "string", VALString }, 
      { "http://hl7.org/fhir/permitted-data-type#string", VALString }, 
      { "time", Time }, 
      { "http://hl7.org/fhir/permitted-data-type#time", Time }, 
    };
  };
}
