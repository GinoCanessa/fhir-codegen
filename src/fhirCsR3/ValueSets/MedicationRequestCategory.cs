// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// A coded concept identifying where the medication ordered is expected to be consumed or administered
  /// </summary>
  public static class MedicationRequestCategoryCodes
  {
    /// <summary>
    /// Includes orders for medications to be administered or consumed by the patient in their home (this would include long term care or nursing homes, hospices, etc)
    /// </summary>
    public static readonly Coding Community = new Coding
    {
      Code = "community",
      Display = "Community",
      System = "http://hl7.org/fhir/medication-request-category"
    };
    /// <summary>
    /// Includes orders for medications to be administered or consumed in an inpatient or acute care setting
    /// </summary>
    public static readonly Coding Inpatient = new Coding
    {
      Code = "inpatient",
      Display = "Inpatient",
      System = "http://hl7.org/fhir/medication-request-category"
    };
    /// <summary>
    /// Includes orders for medications to be administered or consumed in an outpatient setting (for example, Emergency Department, Outpatient Clinic, Outpatient Surgery, Doctor's office)
    /// </summary>
    public static readonly Coding Outpatient = new Coding
    {
      Code = "outpatient",
      Display = "Outpatient",
      System = "http://hl7.org/fhir/medication-request-category"
    };

    /// <summary>
    /// Literal for code: Community
    /// </summary>
    public const string LiteralCommunity = "community";

    /// <summary>
    /// Literal for code: MedicationRequestCategoryCommunity
    /// </summary>
    public const string LiteralMedicationRequestCategoryCommunity = "http://hl7.org/fhir/medication-request-category#community";

    /// <summary>
    /// Literal for code: Inpatient
    /// </summary>
    public const string LiteralInpatient = "inpatient";

    /// <summary>
    /// Literal for code: MedicationRequestCategoryInpatient
    /// </summary>
    public const string LiteralMedicationRequestCategoryInpatient = "http://hl7.org/fhir/medication-request-category#inpatient";

    /// <summary>
    /// Literal for code: Outpatient
    /// </summary>
    public const string LiteralOutpatient = "outpatient";

    /// <summary>
    /// Literal for code: MedicationRequestCategoryOutpatient
    /// </summary>
    public const string LiteralMedicationRequestCategoryOutpatient = "http://hl7.org/fhir/medication-request-category#outpatient";

    /// <summary>
    /// Dictionary for looking up MedicationRequestCategory Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "community", Community }, 
      { "http://hl7.org/fhir/medication-request-category#community", Community }, 
      { "inpatient", Inpatient }, 
      { "http://hl7.org/fhir/medication-request-category#inpatient", Inpatient }, 
      { "outpatient", Outpatient }, 
      { "http://hl7.org/fhir/medication-request-category#outpatient", Outpatient }, 
    };
  };
}
