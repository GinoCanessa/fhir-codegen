// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// Defines the kinds of conditions that can appear on actions
  /// </summary>
  public static class ActionConditionKindCodes
  {
    /// <summary>
    /// The condition describes whether or not a given action is applicable
    /// </summary>
    public static readonly Coding Applicability = new Coding
    {
      Code = "applicability",
      Display = "Applicability",
      System = "http://hl7.org/fhir/action-condition-kind"
    };
    /// <summary>
    /// The condition is a starting condition for the action
    /// </summary>
    public static readonly Coding Start = new Coding
    {
      Code = "start",
      Display = "Start",
      System = "http://hl7.org/fhir/action-condition-kind"
    };
    /// <summary>
    /// The condition is a stop, or exit condition for the action
    /// </summary>
    public static readonly Coding Stop = new Coding
    {
      Code = "stop",
      Display = "Stop",
      System = "http://hl7.org/fhir/action-condition-kind"
    };

    /// <summary>
    /// Literal for code: Applicability
    /// </summary>
    public const string LiteralApplicability = "applicability";

    /// <summary>
    /// Literal for code: ActionConditionKindApplicability
    /// </summary>
    public const string LiteralActionConditionKindApplicability = "http://hl7.org/fhir/action-condition-kind#applicability";

    /// <summary>
    /// Literal for code: Start
    /// </summary>
    public const string LiteralStart = "start";

    /// <summary>
    /// Literal for code: ActionConditionKindStart
    /// </summary>
    public const string LiteralActionConditionKindStart = "http://hl7.org/fhir/action-condition-kind#start";

    /// <summary>
    /// Literal for code: Stop
    /// </summary>
    public const string LiteralStop = "stop";

    /// <summary>
    /// Literal for code: ActionConditionKindStop
    /// </summary>
    public const string LiteralActionConditionKindStop = "http://hl7.org/fhir/action-condition-kind#stop";

    /// <summary>
    /// Dictionary for looking up ActionConditionKind Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "applicability", Applicability }, 
      { "http://hl7.org/fhir/action-condition-kind#applicability", Applicability }, 
      { "start", Start }, 
      { "http://hl7.org/fhir/action-condition-kind#start", Start }, 
      { "stop", Stop }, 
      { "http://hl7.org/fhir/action-condition-kind#stop", Stop }, 
    };
  };
}
