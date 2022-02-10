// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Example value set for investigation type.
  /// </summary>
  public static class InvestigationSetsCodes
  {
    /// <summary>
    /// History/symptoms
    /// </summary>
    public static readonly Coding HistorySymptoms = new Coding
    {
      Code = "160237006",
      Display = "History/symptoms",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// Examination / signs
    /// </summary>
    public static readonly Coding ExaminationSigns = new Coding
    {
      Code = "271336007",
      Display = "Examination / signs",
      System = "http://snomed.info/sct"
    };

    /// <summary>
    /// Literal for code: HistorySymptoms
    /// </summary>
    public const string LiteralHistorySymptoms = "160237006";

    /// <summary>
    /// Literal for code: NONEHistorySymptoms
    /// </summary>
    public const string LiteralNONEHistorySymptoms = "http://snomed.info/sct#160237006";

    /// <summary>
    /// Literal for code: ExaminationSigns
    /// </summary>
    public const string LiteralExaminationSigns = "271336007";

    /// <summary>
    /// Literal for code: NONEExaminationSigns
    /// </summary>
    public const string LiteralNONEExaminationSigns = "http://snomed.info/sct#271336007";

    /// <summary>
    /// Dictionary for looking up InvestigationSets Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "160237006", HistorySymptoms }, 
      { "http://snomed.info/sct#160237006", HistorySymptoms }, 
      { "271336007", ExaminationSigns }, 
      { "http://snomed.info/sct#271336007", ExaminationSigns }, 
    };
  };
}
