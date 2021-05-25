// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The use of an address.
  /// </summary>
  public static class AddressUseCodes
  {
    /// <summary>
    /// An address to be used to send bills, invoices, receipts etc.
    /// </summary>
    public static readonly Coding Billing = new Coding
    {
      Code = "billing",
      Display = "Billing",
      System = "http://hl7.org/fhir/address-use"
    };
    /// <summary>
    /// A communication address at a home.
    /// </summary>
    public static readonly Coding Home = new Coding
    {
      Code = "home",
      Display = "Home",
      System = "http://hl7.org/fhir/address-use"
    };
    /// <summary>
    /// This address is no longer in use (or was never correct but retained for records).
    /// </summary>
    public static readonly Coding OldIncorrect = new Coding
    {
      Code = "old",
      Display = "Old / Incorrect",
      System = "http://hl7.org/fhir/address-use"
    };
    /// <summary>
    /// A temporary address. The period can provide more detailed information.
    /// </summary>
    public static readonly Coding Temporary = new Coding
    {
      Code = "temp",
      Display = "Temporary",
      System = "http://hl7.org/fhir/address-use"
    };
    /// <summary>
    /// An office address. First choice for business related contacts during business hours.
    /// </summary>
    public static readonly Coding Work = new Coding
    {
      Code = "work",
      Display = "Work",
      System = "http://hl7.org/fhir/address-use"
    };
  };
}
