// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// Containers which may hold specimens or specimen containers. Include codes  SNOMED CT(http://snomed.info/sct) where concept is-a 434711009 (Specimen container (physical object))
  /// </summary>
  public static class SpecimenContainerTypeCodes
  {
    /// <summary>
    /// Specimen vial
    /// </summary>
    public static readonly Coding SpecimenVial = new Coding
    {
      Code = "434746001",
      Display = "Specimen vial",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// Specimen well
    /// </summary>
    public static readonly Coding SpecimenWell = new Coding
    {
      Code = "434822004",
      Display = "Specimen well",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// Breath specimen container
    /// </summary>
    public static readonly Coding BreathSpecimenContainer = new Coding
    {
      Code = "713791004",
      Display = "Breath specimen container",
      System = "http://snomed.info/sct"
    };

    /// <summary>
    /// Literal for code: SpecimenVial
    /// </summary>
    public const string LiteralSpecimenVial = "434746001";

    /// <summary>
    /// Literal for code: NONESpecimenVial
    /// </summary>
    public const string LiteralNONESpecimenVial = "http://snomed.info/sct#434746001";

    /// <summary>
    /// Literal for code: SpecimenWell
    /// </summary>
    public const string LiteralSpecimenWell = "434822004";

    /// <summary>
    /// Literal for code: NONESpecimenWell
    /// </summary>
    public const string LiteralNONESpecimenWell = "http://snomed.info/sct#434822004";

    /// <summary>
    /// Literal for code: BreathSpecimenContainer
    /// </summary>
    public const string LiteralBreathSpecimenContainer = "713791004";

    /// <summary>
    /// Literal for code: NONEBreathSpecimenContainer
    /// </summary>
    public const string LiteralNONEBreathSpecimenContainer = "http://snomed.info/sct#713791004";

    /// <summary>
    /// Dictionary for looking up SpecimenContainerType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "434746001", SpecimenVial }, 
      { "http://snomed.info/sct#434746001", SpecimenVial }, 
      { "434822004", SpecimenWell }, 
      { "http://snomed.info/sct#434822004", SpecimenWell }, 
      { "713791004", BreathSpecimenContainer }, 
      { "http://snomed.info/sct#713791004", BreathSpecimenContainer }, 
    };
  };
}
