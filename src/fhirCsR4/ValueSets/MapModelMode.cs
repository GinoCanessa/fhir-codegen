// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// How the referenced structure is used in this mapping.
  /// </summary>
  public static class MapModelModeCodes
  {
    /// <summary>
    /// This structure describes an instance that the mapping engine may ask to create that is used a target of data.
    /// </summary>
    public static readonly Coding ProducedStructureDefinition = new Coding
    {
      Code = "produced",
      Display = "Produced Structure Definition",
      System = "http://hl7.org/fhir/map-model-mode"
    };
    /// <summary>
    /// This structure describes an instance that the mapping engine may ask for that is used a source of data.
    /// </summary>
    public static readonly Coding QueriedStructureDefinition = new Coding
    {
      Code = "queried",
      Display = "Queried Structure Definition",
      System = "http://hl7.org/fhir/map-model-mode"
    };
    /// <summary>
    /// This structure describes an instance passed to the mapping engine that is used a source of data.
    /// </summary>
    public static readonly Coding SourceStructureDefinition = new Coding
    {
      Code = "source",
      Display = "Source Structure Definition",
      System = "http://hl7.org/fhir/map-model-mode"
    };
    /// <summary>
    /// This structure describes an instance passed to the mapping engine that is used a target of data.
    /// </summary>
    public static readonly Coding TargetStructureDefinition = new Coding
    {
      Code = "target",
      Display = "Target Structure Definition",
      System = "http://hl7.org/fhir/map-model-mode"
    };

    /// <summary>
    /// Literal for code: ProducedStructureDefinition
    /// </summary>
    public const string LiteralProducedStructureDefinition = "produced";

    /// <summary>
    /// Literal for code: MapModelModeProducedStructureDefinition
    /// </summary>
    public const string LiteralMapModelModeProducedStructureDefinition = "http://hl7.org/fhir/map-model-mode#produced";

    /// <summary>
    /// Literal for code: QueriedStructureDefinition
    /// </summary>
    public const string LiteralQueriedStructureDefinition = "queried";

    /// <summary>
    /// Literal for code: MapModelModeQueriedStructureDefinition
    /// </summary>
    public const string LiteralMapModelModeQueriedStructureDefinition = "http://hl7.org/fhir/map-model-mode#queried";

    /// <summary>
    /// Literal for code: SourceStructureDefinition
    /// </summary>
    public const string LiteralSourceStructureDefinition = "source";

    /// <summary>
    /// Literal for code: MapModelModeSourceStructureDefinition
    /// </summary>
    public const string LiteralMapModelModeSourceStructureDefinition = "http://hl7.org/fhir/map-model-mode#source";

    /// <summary>
    /// Literal for code: TargetStructureDefinition
    /// </summary>
    public const string LiteralTargetStructureDefinition = "target";

    /// <summary>
    /// Literal for code: MapModelModeTargetStructureDefinition
    /// </summary>
    public const string LiteralMapModelModeTargetStructureDefinition = "http://hl7.org/fhir/map-model-mode#target";

    /// <summary>
    /// Dictionary for looking up MapModelMode Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "produced", ProducedStructureDefinition }, 
      { "http://hl7.org/fhir/map-model-mode#produced", ProducedStructureDefinition }, 
      { "queried", QueriedStructureDefinition }, 
      { "http://hl7.org/fhir/map-model-mode#queried", QueriedStructureDefinition }, 
      { "source", SourceStructureDefinition }, 
      { "http://hl7.org/fhir/map-model-mode#source", SourceStructureDefinition }, 
      { "target", TargetStructureDefinition }, 
      { "http://hl7.org/fhir/map-model-mode#target", TargetStructureDefinition }, 
    };
  };
}
