// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Set of handling instructions prior testing of the specimen.
  /// </summary>
  public static class HandlingConditionCodes
  {
    /// <summary>
    /// frozen temperature.
    /// </summary>
    public static readonly Coding Frozen = new Coding
    {
      Code = "frozen",
      Display = "frozen",
      System = "http://terminology.hl7.org/CodeSystem/handling-condition"
    };
    /// <summary>
    /// refrigerated temperature.
    /// </summary>
    public static readonly Coding Refrigerated = new Coding
    {
      Code = "refrigerated",
      Display = "refrigerated",
      System = "http://terminology.hl7.org/CodeSystem/handling-condition"
    };
    /// <summary>
    /// room temperature.
    /// </summary>
    public static readonly Coding RoomTemperature = new Coding
    {
      Code = "room",
      Display = "room temperature",
      System = "http://terminology.hl7.org/CodeSystem/handling-condition"
    };
  };
}
