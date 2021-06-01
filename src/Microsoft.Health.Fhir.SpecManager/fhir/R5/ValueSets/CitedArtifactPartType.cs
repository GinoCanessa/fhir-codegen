// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// To describe the reason for the variant citation, such as version number or subpart specification.
  /// </summary>
  public static class CitedArtifactPartTypeCodes
  {
    /// <summary>
    /// Used to distinguish an individual article within an article set where the article set is a base citation.
    /// </summary>
    public static readonly Coding PartOfAnArticleSet = new Coding
    {
      Code = "article-set",
      Display = "Part of an article set",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
    /// <summary>
    /// Denotes specific figure or figures of an article or artifact.
    /// </summary>
    public static readonly Coding Figures = new Coding
    {
      Code = "figures",
      Display = "figures",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
    /// <summary>
    /// Denotes specific line or lines of an article or artifact.
    /// </summary>
    public static readonly Coding Lines = new Coding
    {
      Code = "lines",
      Display = "lines",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
    /// <summary>
    /// Denotes specific page or pages of an article or artifact.
    /// </summary>
    public static readonly Coding Pages = new Coding
    {
      Code = "pages",
      Display = "pages",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
    /// <summary>
    /// Denotes specific paragraph or paragraphs of an article or artifact.
    /// </summary>
    public static readonly Coding Paragraphs = new Coding
    {
      Code = "paragraphs",
      Display = "paragraphs",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
    /// <summary>
    /// Denotes specific section or sections of an article or artifact.
    /// </summary>
    public static readonly Coding Sections = new Coding
    {
      Code = "sections",
      Display = "sections",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
    /// <summary>
    /// Used to denote a supplementary file, appendix, or additional part that is not a subpart of the primary article.
    /// </summary>
    public static readonly Coding SupplementOrAppendix = new Coding
    {
      Code = "supplement",
      Display = "Supplement or Appendix",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
    /// <summary>
    /// Used to denote a subpart within a supplementary file or appendix.
    /// </summary>
    public static readonly Coding SupplementOrAppendixSubpart = new Coding
    {
      Code = "supplement-subpart",
      Display = "Supplement or Appendix Subpart",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
    /// <summary>
    /// Denotes specific table or tables of an article or artifact.
    /// </summary>
    public static readonly Coding Tables = new Coding
    {
      Code = "tables",
      Display = "tables",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
  };
}
