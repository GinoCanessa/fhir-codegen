// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes CoverageEligibilityResponse Auth Support codes.
  /// </summary>
  public static class CoverageeligibilityresponseExAuthSupportCodes
  {
    /// <summary>
    /// A formal accident report as would be filed with police or a simlar official body.
    /// </summary>
    public static readonly Coding AccidentReport = new Coding
    {
      Code = "accidentreport",
      Display = "Accident Report",
      System = "http://terminology.hl7.org/CodeSystem/coverageeligibilityresponse-ex-auth-support"
    };
    /// <summary>
    /// A request or authorization for diagnostic imaging.
    /// </summary>
    public static readonly Coding DiagnosticImageOrder = new Coding
    {
      Code = "diagnosticimageorder",
      Display = "Diagnostic Image Order",
      System = "http://terminology.hl7.org/CodeSystem/coverageeligibilityresponse-ex-auth-support"
    };
    /// <summary>
    /// A report on diagnostic image(s).
    /// </summary>
    public static readonly Coding DiagnosticImageReport = new Coding
    {
      Code = "diagnosticimagereport",
      Display = "Diagnostic Image Report",
      System = "http://terminology.hl7.org/CodeSystem/coverageeligibilityresponse-ex-auth-support"
    };
    /// <summary>
    /// A request or authorization for laboratory diagnostic tests.
    /// </summary>
    public static readonly Coding LabOrder = new Coding
    {
      Code = "laborder",
      Display = "Lab Order",
      System = "http://terminology.hl7.org/CodeSystem/coverageeligibilityresponse-ex-auth-support"
    };
    /// <summary>
    /// A report on laboratory diagnostic test(s).
    /// </summary>
    public static readonly Coding LabReport = new Coding
    {
      Code = "labreport",
      Display = "Lab Report",
      System = "http://terminology.hl7.org/CodeSystem/coverageeligibilityresponse-ex-auth-support"
    };
    /// <summary>
    /// A physical model of the affected area.
    /// </summary>
    public static readonly Coding Model = new Coding
    {
      Code = "model",
      Display = "Model",
      System = "http://terminology.hl7.org/CodeSystem/coverageeligibilityresponse-ex-auth-support"
    };
    /// <summary>
    /// A photograph of the affected area.
    /// </summary>
    public static readonly Coding Picture = new Coding
    {
      Code = "picture",
      Display = "Picture",
      System = "http://terminology.hl7.org/CodeSystem/coverageeligibilityresponse-ex-auth-support"
    };
    /// <summary>
    /// A report from a licensed professional regarding the siutation, condition or proposed treatment.
    /// </summary>
    public static readonly Coding ProfessionalReport = new Coding
    {
      Code = "professionalreport",
      Display = "Professional Report",
      System = "http://terminology.hl7.org/CodeSystem/coverageeligibilityresponse-ex-auth-support"
    };
  };
}
