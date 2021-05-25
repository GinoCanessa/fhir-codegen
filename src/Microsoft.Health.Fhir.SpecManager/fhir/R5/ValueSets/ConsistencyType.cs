// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// FluidConsistencyType :  Codes used to represent the consistency of fluids and liquids provided to the patient. This value set includes concepts from [SNOMED CT](http://snomed.info/sct)(US Extension) where concept is a 435681000124103  (Dietary liquid consistency diet (regime/therapy)). It is provided as a suggestive example.
  /// </summary>
  public static class ConsistencyTypeCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NectarThickLiquid = new Coding
    {
      Code = "439021000124105",
      Display = "nectar thick liquid",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding HoneyThickLiquid = new Coding
    {
      Code = "439031000124108",
      Display = "honey thick liquid",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SpoonThickLiquid = new Coding
    {
      Code = "439041000124103",
      Display = "spoon thick liquid",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ThinLiquid = new Coding
    {
      Code = "439081000124109",
      Display = "thin liquid",
      System = "http://snomed.info/sct"
    };
  };
}
