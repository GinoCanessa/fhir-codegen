// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// High-level categorization of the definition, used for searching, sorting, and filtering.
  /// </summary>
  public static class DefinitionTopicCodes
  {
    /// <summary>
    /// The definition is related to assessment of the patient.
    /// </summary>
    public static readonly Coding Assessment = new Coding
    {
      Code = "assessment",
      Display = "Assessment",
      System = "http://terminology.hl7.org/CodeSystem/definition-topic"
    };
    /// <summary>
    /// The definition is related to education of the patient.
    /// </summary>
    public static readonly Coding Education = new Coding
    {
      Code = "education",
      Display = "Education",
      System = "http://terminology.hl7.org/CodeSystem/definition-topic"
    };
    /// <summary>
    /// The definition is related to treatment of the patient.
    /// </summary>
    public static readonly Coding Treatment = new Coding
    {
      Code = "treatment",
      Display = "Treatment",
      System = "http://terminology.hl7.org/CodeSystem/definition-topic"
    };

    /// <summary>
    /// Literal for code: Assessment
    /// </summary>
    public const string LiteralAssessment = "assessment";

    /// <summary>
    /// Literal for code: DefinitionTopicAssessment
    /// </summary>
    public const string LiteralDefinitionTopicAssessment = "http://terminology.hl7.org/CodeSystem/definition-topic#assessment";

    /// <summary>
    /// Literal for code: Education
    /// </summary>
    public const string LiteralEducation = "education";

    /// <summary>
    /// Literal for code: DefinitionTopicEducation
    /// </summary>
    public const string LiteralDefinitionTopicEducation = "http://terminology.hl7.org/CodeSystem/definition-topic#education";

    /// <summary>
    /// Literal for code: Treatment
    /// </summary>
    public const string LiteralTreatment = "treatment";

    /// <summary>
    /// Literal for code: DefinitionTopicTreatment
    /// </summary>
    public const string LiteralDefinitionTopicTreatment = "http://terminology.hl7.org/CodeSystem/definition-topic#treatment";

    /// <summary>
    /// Dictionary for looking up DefinitionTopic Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "assessment", Assessment }, 
      { "http://terminology.hl7.org/CodeSystem/definition-topic#assessment", Assessment }, 
      { "education", Education }, 
      { "http://terminology.hl7.org/CodeSystem/definition-topic#education", Education }, 
      { "treatment", Treatment }, 
      { "http://terminology.hl7.org/CodeSystem/definition-topic#treatment", Treatment }, 
    };
  };
}
