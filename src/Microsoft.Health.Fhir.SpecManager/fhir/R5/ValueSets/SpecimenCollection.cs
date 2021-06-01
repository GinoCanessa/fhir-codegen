// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Actions that can be taken for the collection of specimen from a subject.
  /// </summary>
  public static class SpecimenCollectionCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PunctureAction = new Coding
    {
      Code = "129300006",
      Display = "Puncture - action",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ExcisionAction = new Coding
    {
      Code = "129304002",
      Display = "Excision - action",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding BiopsyAction = new Coding
    {
      Code = "129314006",
      Display = "Biopsy - action",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AspirationAction = new Coding
    {
      Code = "129316008",
      Display = "Aspiration - action",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ScrapingAction = new Coding
    {
      Code = "129323009",
      Display = "Scraping - action",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding TimedUrineCollection = new Coding
    {
      Code = "225113003",
      Display = "Timed urine collection",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding FingerPrickSampling = new Coding
    {
      Code = "278450005",
      Display = "Finger-prick sampling",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CollectionOfCoughedSputum = new Coding
    {
      Code = "386089008",
      Display = "Collection of coughed sputum",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding UrineSpecimenCollectionCatheterized = new Coding
    {
      Code = "70777001",
      Display = "Urine specimen collection, catheterized",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding UrineSpecimenCollectionCleanCatch = new Coding
    {
      Code = "73416001",
      Display = "Urine specimen collection, clean catch",
      System = "http://snomed.info/sct"
    };
  };
}
