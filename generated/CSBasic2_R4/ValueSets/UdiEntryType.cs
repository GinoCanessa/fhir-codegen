// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Codes to identify how UDI data was entered.
  /// </summary>
  public static class UdiEntryTypeCodes
  {
    /// <summary>
    /// a barcodescanner captured the data from the device label.
    /// </summary>
    public static readonly Coding Barcode = new Coding
    {
      Code = "barcode",
      Display = "Barcode",
      System = "http://hl7.org/fhir/udi-entry-type"
    };
    /// <summary>
    /// The data originated from a patient's implant card and was read by an operator.
    /// </summary>
    public static readonly Coding Card = new Coding
    {
      Code = "card",
      Display = "Card",
      System = "http://hl7.org/fhir/udi-entry-type"
    };
    /// <summary>
    /// The data was read from the label by a person and manually entered. (e.g.  via a keyboard).
    /// </summary>
    public static readonly Coding Manual = new Coding
    {
      Code = "manual",
      Display = "Manual",
      System = "http://hl7.org/fhir/udi-entry-type"
    };
    /// <summary>
    /// An RFID chip reader captured the data from the device label.
    /// </summary>
    public static readonly Coding RFID = new Coding
    {
      Code = "rfid",
      Display = "RFID",
      System = "http://hl7.org/fhir/udi-entry-type"
    };
    /// <summary>
    /// The data originated from a patient source and was not directly scanned or read from a label or card.
    /// </summary>
    public static readonly Coding SelfReported = new Coding
    {
      Code = "self-reported",
      Display = "Self Reported",
      System = "http://hl7.org/fhir/udi-entry-type"
    };
    /// <summary>
    /// The method of data capture has not been determined.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/udi-entry-type"
    };
  };
}
