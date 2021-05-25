// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// A supported modifier for a search parameter.
  /// </summary>
  public static class SearchModifierCodeCodes
  {
    /// <summary>
    /// The search parameter tests whether the value in a resource subsumes the specified value (is-a, or hierarchical relationships).
    /// </summary>
    public static readonly Coding Above = new Coding
    {
      Code = "above",
      Display = "Above",
      System = "http://hl7.org/fhir/search-modifier-code"
    };
    /// <summary>
    /// The search parameter tests whether the value in a resource is subsumed by the specified value (is-a, or hierarchical relationships).
    /// </summary>
    public static readonly Coding Below = new Coding
    {
      Code = "below",
      Display = "Below",
      System = "http://hl7.org/fhir/search-modifier-code"
    };
    /// <summary>
    /// The search parameter returns resources that include the supplied parameter value anywhere within the field being searched.
    /// </summary>
    public static readonly Coding Contains = new Coding
    {
      Code = "contains",
      Display = "Contains",
      System = "http://hl7.org/fhir/search-modifier-code"
    };
    /// <summary>
    /// The search parameter returns resources that have a value that exactly matches the supplied parameter (the whole string, including casing and accents).
    /// </summary>
    public static readonly Coding Exact = new Coding
    {
      Code = "exact",
      Display = "Exact",
      System = "http://hl7.org/fhir/search-modifier-code"
    };
    /// <summary>
    /// The search parameter applies to the identifier on the resource, not the reference.
    /// </summary>
    public static readonly Coding Identifier = new Coding
    {
      Code = "identifier",
      Display = "Identifier",
      System = "http://hl7.org/fhir/search-modifier-code"
    };
    /// <summary>
    /// The search parameter is a URI (relative or absolute) that identifies a value set, and the search parameter tests whether the coding is in the specified value set.
    /// </summary>
    public static readonly Coding In = new Coding
    {
      Code = "in",
      Display = "In",
      System = "http://hl7.org/fhir/search-modifier-code"
    };
    /// <summary>
    /// The search parameter returns resources that have a value or not.
    /// </summary>
    public static readonly Coding Missing = new Coding
    {
      Code = "missing",
      Display = "Missing",
      System = "http://hl7.org/fhir/search-modifier-code"
    };
    /// <summary>
    /// The search parameter returns resources that do not contain a match.
    /// </summary>
    public static readonly Coding Not = new Coding
    {
      Code = "not",
      Display = "Not",
      System = "http://hl7.org/fhir/search-modifier-code"
    };
    /// <summary>
    /// The search parameter is a URI (relative or absolute) that identifies a value set, and the search parameter tests whether the coding is not in the specified value set.
    /// </summary>
    public static readonly Coding NotIn = new Coding
    {
      Code = "not-in",
      Display = "Not In",
      System = "http://hl7.org/fhir/search-modifier-code"
    };
    /// <summary>
    /// The search parameter has the format system|code|value, where the system and code refer to an Identifier.type.coding.system and .code, and match if any of the type codes match. All 3 parts must be present.
    /// </summary>
    public static readonly Coding OfType = new Coding
    {
      Code = "ofType",
      Display = "Of Type",
      System = "http://hl7.org/fhir/search-modifier-code"
    };
    /// <summary>
    /// The search parameter is processed as a string that searches text associated with the code/value - either CodeableConcept.text, Coding.display, or Identifier.type.text.
    /// </summary>
    public static readonly Coding Text = new Coding
    {
      Code = "text",
      Display = "Text",
      System = "http://hl7.org/fhir/search-modifier-code"
    };
    /// <summary>
    /// The search parameter only applies to the Resource Type specified as a modifier (e.g. the modifier is not actually :type, but :Patient etc.).
    /// </summary>
    public static readonly Coding Type = new Coding
    {
      Code = "type",
      Display = "Type",
      System = "http://hl7.org/fhir/search-modifier-code"
    };
  };
}
