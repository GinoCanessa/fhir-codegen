// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Controls how multiple enableWhen values are interpreted -  whether all or any must be true.
  /// </summary>
  public static class QuestionnaireEnableBehaviorCodes
  {
    /// <summary>
    /// Enable the question when all the enableWhen criteria are satisfied.
    /// </summary>
    public static readonly Coding All = new Coding
    {
      Code = "all",
      Display = "All",
      System = "http://hl7.org/fhir/questionnaire-enable-behavior"
    };
    /// <summary>
    /// Enable the question when any of the enableWhen criteria are satisfied.
    /// </summary>
    public static readonly Coding Any = new Coding
    {
      Code = "any",
      Display = "Any",
      System = "http://hl7.org/fhir/questionnaire-enable-behavior"
    };
  };
}
