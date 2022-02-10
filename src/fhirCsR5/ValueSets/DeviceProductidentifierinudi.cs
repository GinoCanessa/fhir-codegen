// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Device Production Identifier in UDI
  /// </summary>
  public static class DeviceProductidentifierinudiCodes
  {
    /// <summary>
    /// The label includes the biological source identifier.
    /// </summary>
    public static readonly Coding BiologicalSource = new Coding
    {
      Code = "biological-source",
      Display = "Biological source",
      System = "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi"
    };
    /// <summary>
    /// The label includes the expiration date.
    /// </summary>
    public static readonly Coding ExpirationDate = new Coding
    {
      Code = "expiration-date",
      Display = "Expiration date",
      System = "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi"
    };
    /// <summary>
    /// The label includes the lot number.
    /// </summary>
    public static readonly Coding LotNumber = new Coding
    {
      Code = "lot-number",
      Display = "Lot Number",
      System = "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi"
    };
    /// <summary>
    /// The label includes the manufacture date.
    /// </summary>
    public static readonly Coding ManufacturedDate = new Coding
    {
      Code = "manufactured-date",
      Display = "Manufactured date",
      System = "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi"
    };
    /// <summary>
    /// The label includes the serial number.
    /// </summary>
    public static readonly Coding SerialNumber = new Coding
    {
      Code = "serial-number",
      Display = "Serial Number",
      System = "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi"
    };
    /// <summary>
    /// The label includes the software version.
    /// </summary>
    public static readonly Coding SoftwareVersion = new Coding
    {
      Code = "software-version",
      Display = "Software Version",
      System = "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi"
    };

    /// <summary>
    /// Literal for code: BiologicalSource
    /// </summary>
    public const string LiteralBiologicalSource = "biological-source";

    /// <summary>
    /// Literal for code: DeviceProductidentifierinudiBiologicalSource
    /// </summary>
    public const string LiteralDeviceProductidentifierinudiBiologicalSource = "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi#biological-source";

    /// <summary>
    /// Literal for code: ExpirationDate
    /// </summary>
    public const string LiteralExpirationDate = "expiration-date";

    /// <summary>
    /// Literal for code: DeviceProductidentifierinudiExpirationDate
    /// </summary>
    public const string LiteralDeviceProductidentifierinudiExpirationDate = "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi#expiration-date";

    /// <summary>
    /// Literal for code: LotNumber
    /// </summary>
    public const string LiteralLotNumber = "lot-number";

    /// <summary>
    /// Literal for code: DeviceProductidentifierinudiLotNumber
    /// </summary>
    public const string LiteralDeviceProductidentifierinudiLotNumber = "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi#lot-number";

    /// <summary>
    /// Literal for code: ManufacturedDate
    /// </summary>
    public const string LiteralManufacturedDate = "manufactured-date";

    /// <summary>
    /// Literal for code: DeviceProductidentifierinudiManufacturedDate
    /// </summary>
    public const string LiteralDeviceProductidentifierinudiManufacturedDate = "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi#manufactured-date";

    /// <summary>
    /// Literal for code: SerialNumber
    /// </summary>
    public const string LiteralSerialNumber = "serial-number";

    /// <summary>
    /// Literal for code: DeviceProductidentifierinudiSerialNumber
    /// </summary>
    public const string LiteralDeviceProductidentifierinudiSerialNumber = "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi#serial-number";

    /// <summary>
    /// Literal for code: SoftwareVersion
    /// </summary>
    public const string LiteralSoftwareVersion = "software-version";

    /// <summary>
    /// Literal for code: DeviceProductidentifierinudiSoftwareVersion
    /// </summary>
    public const string LiteralDeviceProductidentifierinudiSoftwareVersion = "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi#software-version";

    /// <summary>
    /// Dictionary for looking up DeviceProductidentifierinudi Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "biological-source", BiologicalSource }, 
      { "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi#biological-source", BiologicalSource }, 
      { "expiration-date", ExpirationDate }, 
      { "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi#expiration-date", ExpirationDate }, 
      { "lot-number", LotNumber }, 
      { "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi#lot-number", LotNumber }, 
      { "manufactured-date", ManufacturedDate }, 
      { "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi#manufactured-date", ManufacturedDate }, 
      { "serial-number", SerialNumber }, 
      { "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi#serial-number", SerialNumber }, 
      { "software-version", SoftwareVersion }, 
      { "http://terminology.hl7.org/CodeSystem/device-productidentifierinudi#software-version", SoftwareVersion }, 
    };
  };
}
