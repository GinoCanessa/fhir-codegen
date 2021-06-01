// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The meaning of the hierarchy of concepts in a code system.
  /// </summary>
  public static class CodesystemHierarchyMeaningCodes
  {
    /// <summary>
    /// Child concepts in the hierarchy may have only one parent, and there is a presumption that the code system is a "closed world" meaning all things must be in the hierarchy. This results in concepts such as "not otherwise classified.".
    /// </summary>
    public static readonly Coding ClassifiedWith = new Coding
    {
      Code = "classified-with",
      Display = "Classified With",
      System = "http://hl7.org/fhir/codesystem-hierarchy-meaning"
    };
    /// <summary>
    /// No particular relationship between the concepts can be assumed, except what can be determined by inspection of the definitions of the elements (possible reasons to use this: importing from a source where this is not defined, or where various parts of the hierarchy have different meanings).
    /// </summary>
    public static readonly Coding GroupedBy = new Coding
    {
      Code = "grouped-by",
      Display = "Grouped By",
      System = "http://hl7.org/fhir/codesystem-hierarchy-meaning"
    };
    /// <summary>
    /// A hierarchy where the child concepts have an IS-A relationship with the parents - that is, all the properties of the parent are also true for its child concepts. Not that is-a is a property of the concepts, so additional subsumption relationships may be defined using properties or the [subsumes](extension-codesystem-subsumes.html) extension.
    /// </summary>
    public static readonly Coding IsA = new Coding
    {
      Code = "is-a",
      Display = "Is-A",
      System = "http://hl7.org/fhir/codesystem-hierarchy-meaning"
    };
    /// <summary>
    /// Child elements list the individual parts of a composite whole (e.g. body site).
    /// </summary>
    public static readonly Coding PartOf = new Coding
    {
      Code = "part-of",
      Display = "Part Of",
      System = "http://hl7.org/fhir/codesystem-hierarchy-meaning"
    };
  };
}
