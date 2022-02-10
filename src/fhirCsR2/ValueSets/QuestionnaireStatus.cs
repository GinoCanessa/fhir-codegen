// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// Lifecycle status of the questionnaire.
  /// </summary>
  public static class QuestionnaireStatusCodes
  {
    /// <summary>
    /// This Questionnaire is not ready for official use.
    /// </summary>
    public static readonly Coding Draft = new Coding
    {
      Code = "draft",
      Display = "Draft",
      System = "http://hl7.org/fhir/questionnaire-status"
    };
    /// <summary>
    /// This Questionnaire is ready for use.
    /// </summary>
    public static readonly Coding Published = new Coding
    {
      Code = "published",
      Display = "Published",
      System = "http://hl7.org/fhir/questionnaire-status"
    };
    /// <summary>
    /// This Questionnaire should no longer be used to gather data.
    /// </summary>
    public static readonly Coding Retired = new Coding
    {
      Code = "retired",
      Display = "Retired",
      System = "http://hl7.org/fhir/questionnaire-status"
    };

    /// <summary>
    /// Literal for code: Draft
    /// </summary>
    public const string LiteralDraft = "draft";

    /// <summary>
    /// Literal for code: QuestionnaireStatusDraft
    /// </summary>
    public const string LiteralQuestionnaireStatusDraft = "http://hl7.org/fhir/questionnaire-status#draft";

    /// <summary>
    /// Literal for code: Published
    /// </summary>
    public const string LiteralPublished = "published";

    /// <summary>
    /// Literal for code: QuestionnaireStatusPublished
    /// </summary>
    public const string LiteralQuestionnaireStatusPublished = "http://hl7.org/fhir/questionnaire-status#published";

    /// <summary>
    /// Literal for code: Retired
    /// </summary>
    public const string LiteralRetired = "retired";

    /// <summary>
    /// Literal for code: QuestionnaireStatusRetired
    /// </summary>
    public const string LiteralQuestionnaireStatusRetired = "http://hl7.org/fhir/questionnaire-status#retired";

    /// <summary>
    /// Dictionary for looking up QuestionnaireStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "draft", Draft }, 
      { "http://hl7.org/fhir/questionnaire-status#draft", Draft }, 
      { "published", Published }, 
      { "http://hl7.org/fhir/questionnaire-status#published", Published }, 
      { "retired", Retired }, 
      { "http://hl7.org/fhir/questionnaire-status#retired", Retired }, 
    };
  };
}
