// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The type of coordinates describing an image region.
  /// </summary>
  public static class ImagingselectionCoordinatetypeCodes
  {
    /// <summary>
    /// The selected image region is defined in a 2D coordinate system.
    /// </summary>
    public static readonly Coding VAL2D = new Coding
    {
      Code = "2d",
      Display = "2D",
      System = "http://hl7.org/fhir/imagingselection-coordinatetype"
    };
    /// <summary>
    /// The selected image region is defined in a 3D coordinate system.
    /// </summary>
    public static readonly Coding VAL3D = new Coding
    {
      Code = "3d",
      Display = "3D",
      System = "http://hl7.org/fhir/imagingselection-coordinatetype"
    };

    /// <summary>
    /// Literal for code: VAL2D
    /// </summary>
    public const string LiteralVAL2D = "2d";

    /// <summary>
    /// Literal for code: ImagingselectionCoordinatetypeVAL2D
    /// </summary>
    public const string LiteralImagingselectionCoordinatetypeVAL2D = "http://hl7.org/fhir/imagingselection-coordinatetype#2d";

    /// <summary>
    /// Literal for code: VAL3D
    /// </summary>
    public const string LiteralVAL3D = "3d";

    /// <summary>
    /// Literal for code: ImagingselectionCoordinatetypeVAL3D
    /// </summary>
    public const string LiteralImagingselectionCoordinatetypeVAL3D = "http://hl7.org/fhir/imagingselection-coordinatetype#3d";

    /// <summary>
    /// Dictionary for looking up ImagingselectionCoordinatetype Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "2d", VAL2D }, 
      { "http://hl7.org/fhir/imagingselection-coordinatetype#2d", VAL2D }, 
      { "3d", VAL3D }, 
      { "http://hl7.org/fhir/imagingselection-coordinatetype#3d", VAL3D }, 
    };
  };
}
