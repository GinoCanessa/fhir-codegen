// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The current status of the test report.
  /// </summary>
  public static class ReportStatusCodesCodes
  {
    /// <summary>
    /// All test operations have completed.
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://hl7.org/fhir/report-status-codes"
    };
    /// <summary>
    /// This test report was entered or created in error.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered In Error",
      System = "http://hl7.org/fhir/report-status-codes"
    };
    /// <summary>
    /// A test operations is currently executing.
    /// </summary>
    public static readonly Coding InProgress = new Coding
    {
      Code = "in-progress",
      Display = "In Progress",
      System = "http://hl7.org/fhir/report-status-codes"
    };
    /// <summary>
    /// The test script execution was manually stopped.
    /// </summary>
    public static readonly Coding Stopped = new Coding
    {
      Code = "stopped",
      Display = "Stopped",
      System = "http://hl7.org/fhir/report-status-codes"
    };
    /// <summary>
    /// A test operation is waiting for an external client request.
    /// </summary>
    public static readonly Coding Waiting = new Coding
    {
      Code = "waiting",
      Display = "Waiting",
      System = "http://hl7.org/fhir/report-status-codes"
    };
  };
}
