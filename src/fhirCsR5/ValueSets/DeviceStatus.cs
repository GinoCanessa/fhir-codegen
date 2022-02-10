// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The availability status of the device.
  /// </summary>
  public static class DeviceStatusCodes
  {
    /// <summary>
    /// The device is available for use.  Note: For *implanted devices*  this means that the device is implanted in the patient.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/device-status"
    };
    /// <summary>
    /// The device was entered in error and voided.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/device-status"
    };
    /// <summary>
    /// The device is no longer available for use (e.g. lost, expired, damaged).  Note: For *implanted devices*  this means that the device has been removed from the patient.
    /// </summary>
    public static readonly Coding Inactive = new Coding
    {
      Code = "inactive",
      Display = "Inactive",
      System = "http://hl7.org/fhir/device-status"
    };

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: DeviceStatusActive
    /// </summary>
    public const string LiteralDeviceStatusActive = "http://hl7.org/fhir/device-status#active";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: DeviceStatusEnteredInError
    /// </summary>
    public const string LiteralDeviceStatusEnteredInError = "http://hl7.org/fhir/device-status#entered-in-error";

    /// <summary>
    /// Literal for code: Inactive
    /// </summary>
    public const string LiteralInactive = "inactive";

    /// <summary>
    /// Literal for code: DeviceStatusInactive
    /// </summary>
    public const string LiteralDeviceStatusInactive = "http://hl7.org/fhir/device-status#inactive";

    /// <summary>
    /// Dictionary for looking up DeviceStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "active", Active }, 
      { "http://hl7.org/fhir/device-status#active", Active }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/device-status#entered-in-error", EnteredInError }, 
      { "inactive", Inactive }, 
      { "http://hl7.org/fhir/device-status#inactive", Inactive }, 
    };
  };
}
