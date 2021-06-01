// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set includes sample Payee Type codes.
  /// </summary>
  public static class PayeetypeCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Provider = new Coding
    {
      Code = "other",
      Display = "Provider",
      System = "http://terminology.hl7.org/CodeSystem/payeetype"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Provider_2 = new Coding
    {
      Code = "provider",
      Display = "Provider",
      System = "http://terminology.hl7.org/CodeSystem/payeetype"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Subscriber = new Coding
    {
      Code = "subscriber",
      Display = "Subscriber",
      System = "http://terminology.hl7.org/CodeSystem/payeetype"
    };
  };
}
