// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// A list of all the knowledge resource types defined in this version of the FHIR specification.
  /// </summary>
  public static class KnowledgeResourceTypesCodes
  {
    /// <summary>
    /// The definition of a specific activity to be taken, independent of any particular patient or context.
    /// </summary>
    public static readonly Coding ActivityDefinition = new Coding
    {
      Code = "ActivityDefinition",
      Display = "ActivityDefinition",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };
    /// <summary>
    /// A set of codes drawn from one or more code systems.
    /// </summary>
    public static readonly Coding CodeSystem = new Coding
    {
      Code = "CodeSystem",
      Display = "CodeSystem",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };
    /// <summary>
    /// A map from one set of concepts to one or more other concepts.
    /// </summary>
    public static readonly Coding ConceptMap = new Coding
    {
      Code = "ConceptMap",
      Display = "ConceptMap",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };
    /// <summary>
    /// Represents a library of quality improvement components.
    /// </summary>
    public static readonly Coding Library = new Coding
    {
      Code = "Library",
      Display = "Library",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };
    /// <summary>
    /// A quality measure definition.
    /// </summary>
    public static readonly Coding Measure = new Coding
    {
      Code = "Measure",
      Display = "Measure",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };
    /// <summary>
    /// The definition of a plan for a series of actions, independent of any specific patient or context.
    /// </summary>
    public static readonly Coding PlanDefinition = new Coding
    {
      Code = "PlanDefinition",
      Display = "PlanDefinition",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };
    /// <summary>
    /// Structural Definition.
    /// </summary>
    public static readonly Coding StructureDefinition = new Coding
    {
      Code = "StructureDefinition",
      Display = "StructureDefinition",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };
    /// <summary>
    /// A Map of relationships between 2 structures that can be used to transform data.
    /// </summary>
    public static readonly Coding StructureMap = new Coding
    {
      Code = "StructureMap",
      Display = "StructureMap",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };
    /// <summary>
    /// A set of codes drawn from one or more code systems.
    /// </summary>
    public static readonly Coding ValueSet = new Coding
    {
      Code = "ValueSet",
      Display = "ValueSet",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };

    /// <summary>
    /// Literal for code: ActivityDefinition
    /// </summary>
    public const string LiteralActivityDefinition = "ActivityDefinition";

    /// <summary>
    /// Literal for code: KnowledgeResourceTypesActivityDefinition
    /// </summary>
    public const string LiteralKnowledgeResourceTypesActivityDefinition = "http://hl7.org/fhir/knowledge-resource-types#ActivityDefinition";

    /// <summary>
    /// Literal for code: CodeSystem
    /// </summary>
    public const string LiteralCodeSystem = "CodeSystem";

    /// <summary>
    /// Literal for code: KnowledgeResourceTypesCodeSystem
    /// </summary>
    public const string LiteralKnowledgeResourceTypesCodeSystem = "http://hl7.org/fhir/knowledge-resource-types#CodeSystem";

    /// <summary>
    /// Literal for code: ConceptMap
    /// </summary>
    public const string LiteralConceptMap = "ConceptMap";

    /// <summary>
    /// Literal for code: KnowledgeResourceTypesConceptMap
    /// </summary>
    public const string LiteralKnowledgeResourceTypesConceptMap = "http://hl7.org/fhir/knowledge-resource-types#ConceptMap";

    /// <summary>
    /// Literal for code: Library
    /// </summary>
    public const string LiteralLibrary = "Library";

    /// <summary>
    /// Literal for code: KnowledgeResourceTypesLibrary
    /// </summary>
    public const string LiteralKnowledgeResourceTypesLibrary = "http://hl7.org/fhir/knowledge-resource-types#Library";

    /// <summary>
    /// Literal for code: Measure
    /// </summary>
    public const string LiteralMeasure = "Measure";

    /// <summary>
    /// Literal for code: KnowledgeResourceTypesMeasure
    /// </summary>
    public const string LiteralKnowledgeResourceTypesMeasure = "http://hl7.org/fhir/knowledge-resource-types#Measure";

    /// <summary>
    /// Literal for code: PlanDefinition
    /// </summary>
    public const string LiteralPlanDefinition = "PlanDefinition";

    /// <summary>
    /// Literal for code: KnowledgeResourceTypesPlanDefinition
    /// </summary>
    public const string LiteralKnowledgeResourceTypesPlanDefinition = "http://hl7.org/fhir/knowledge-resource-types#PlanDefinition";

    /// <summary>
    /// Literal for code: StructureDefinition
    /// </summary>
    public const string LiteralStructureDefinition = "StructureDefinition";

    /// <summary>
    /// Literal for code: KnowledgeResourceTypesStructureDefinition
    /// </summary>
    public const string LiteralKnowledgeResourceTypesStructureDefinition = "http://hl7.org/fhir/knowledge-resource-types#StructureDefinition";

    /// <summary>
    /// Literal for code: StructureMap
    /// </summary>
    public const string LiteralStructureMap = "StructureMap";

    /// <summary>
    /// Literal for code: KnowledgeResourceTypesStructureMap
    /// </summary>
    public const string LiteralKnowledgeResourceTypesStructureMap = "http://hl7.org/fhir/knowledge-resource-types#StructureMap";

    /// <summary>
    /// Literal for code: ValueSet
    /// </summary>
    public const string LiteralValueSet = "ValueSet";

    /// <summary>
    /// Literal for code: KnowledgeResourceTypesValueSet
    /// </summary>
    public const string LiteralKnowledgeResourceTypesValueSet = "http://hl7.org/fhir/knowledge-resource-types#ValueSet";

    /// <summary>
    /// Dictionary for looking up KnowledgeResourceTypes Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "ActivityDefinition", ActivityDefinition }, 
      { "http://hl7.org/fhir/knowledge-resource-types#ActivityDefinition", ActivityDefinition }, 
      { "CodeSystem", CodeSystem }, 
      { "http://hl7.org/fhir/knowledge-resource-types#CodeSystem", CodeSystem }, 
      { "ConceptMap", ConceptMap }, 
      { "http://hl7.org/fhir/knowledge-resource-types#ConceptMap", ConceptMap }, 
      { "Library", Library }, 
      { "http://hl7.org/fhir/knowledge-resource-types#Library", Library }, 
      { "Measure", Measure }, 
      { "http://hl7.org/fhir/knowledge-resource-types#Measure", Measure }, 
      { "PlanDefinition", PlanDefinition }, 
      { "http://hl7.org/fhir/knowledge-resource-types#PlanDefinition", PlanDefinition }, 
      { "StructureDefinition", StructureDefinition }, 
      { "http://hl7.org/fhir/knowledge-resource-types#StructureDefinition", StructureDefinition }, 
      { "StructureMap", StructureMap }, 
      { "http://hl7.org/fhir/knowledge-resource-types#StructureMap", StructureMap }, 
      { "ValueSet", ValueSet }, 
      { "http://hl7.org/fhir/knowledge-resource-types#ValueSet", ValueSet }, 
    };
  };
}
