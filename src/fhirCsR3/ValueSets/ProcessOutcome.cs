// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This value set includes sample Process Outcome codes.
  /// </summary>
  public static class ProcessOutcomeCodes
  {
    /// <summary>
    /// The requested processing has completed.
    /// </summary>
    public static readonly Coding Complete = new Coding
    {
      Code = "complete",
      Display = "Complete",
      System = "http://hl7.org/fhir/processoutcomecodes"
    };
    /// <summary>
    /// The requested processing has terminated with some errors being found.
    /// </summary>
    public static readonly Coding Error = new Coding
    {
      Code = "error",
      Display = "Error",
      System = "http://hl7.org/fhir/processoutcomecodes"
    };
    /// <summary>
    /// The requested processing has been suspended.
    /// </summary>
    public static readonly Coding Pended = new Coding
    {
      Code = "pended",
      Display = "Pended",
      System = "http://hl7.org/fhir/processoutcomecodes"
    };

    /// <summary>
    /// Literal for code: Complete
    /// </summary>
    public const string LiteralComplete = "complete";

    /// <summary>
    /// Literal for code: ProcessOutcomeComplete
    /// </summary>
    public const string LiteralProcessOutcomeComplete = "http://hl7.org/fhir/processoutcomecodes#complete";

    /// <summary>
    /// Literal for code: Error
    /// </summary>
    public const string LiteralError = "error";

    /// <summary>
    /// Literal for code: ProcessOutcomeError
    /// </summary>
    public const string LiteralProcessOutcomeError = "http://hl7.org/fhir/processoutcomecodes#error";

    /// <summary>
    /// Literal for code: Pended
    /// </summary>
    public const string LiteralPended = "pended";

    /// <summary>
    /// Literal for code: ProcessOutcomePended
    /// </summary>
    public const string LiteralProcessOutcomePended = "http://hl7.org/fhir/processoutcomecodes#pended";

    /// <summary>
    /// Dictionary for looking up ProcessOutcome Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "complete", Complete }, 
      { "http://hl7.org/fhir/processoutcomecodes#complete", Complete }, 
      { "error", Error }, 
      { "http://hl7.org/fhir/processoutcomecodes#error", Error }, 
      { "pended", Pended }, 
      { "http://hl7.org/fhir/processoutcomecodes#pended", Pended }, 
    };
  };
}
