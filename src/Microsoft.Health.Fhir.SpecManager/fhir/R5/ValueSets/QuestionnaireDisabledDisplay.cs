// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Codes that guide the display of disabled questionnaire items
  /// </summary>
  public static class QuestionnaireDisabledDisplayCodes
  {
    /// <summary>
    /// The item (and its children) should not be visible to the user at all.
    /// </summary>
    public static readonly Coding Hidden = new Coding
    {
      Code = "hidden",
      Display = "Hidden",
      System = "http://hl7.org/fhir/questionnaire-disabled-display"
    };
    /// <summary>
    /// The item (and possibly its children) should not be selectable or editable but should still be visible - to allow the user to see what questions *could* have been completed had other answers caused the item to be enabled.
    /// </summary>
    public static readonly Coding Protected = new Coding
    {
      Code = "protected",
      Display = "Protected",
      System = "http://hl7.org/fhir/questionnaire-disabled-display"
    };
  };
}
