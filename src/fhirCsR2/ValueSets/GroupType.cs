// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// Types of resources that are part of group
  /// </summary>
  public static class GroupTypeCodes
  {
    /// <summary>
    /// Group contains "animal" Patient resources
    /// </summary>
    public static readonly Coding Animal = new Coding
    {
      Code = "animal",
      Display = "Animal",
      System = "http://hl7.org/fhir/group-type"
    };
    /// <summary>
    /// Group contains Device resources
    /// </summary>
    public static readonly Coding Device = new Coding
    {
      Code = "device",
      Display = "Device",
      System = "http://hl7.org/fhir/group-type"
    };
    /// <summary>
    /// Group contains Medication resources
    /// </summary>
    public static readonly Coding Medication = new Coding
    {
      Code = "medication",
      Display = "Medication",
      System = "http://hl7.org/fhir/group-type"
    };
    /// <summary>
    /// Group contains "person" Patient resources
    /// </summary>
    public static readonly Coding Person = new Coding
    {
      Code = "person",
      Display = "Person",
      System = "http://hl7.org/fhir/group-type"
    };
    /// <summary>
    /// Group contains healthcare practitioner resources
    /// </summary>
    public static readonly Coding Practitioner = new Coding
    {
      Code = "practitioner",
      Display = "Practitioner",
      System = "http://hl7.org/fhir/group-type"
    };
    /// <summary>
    /// Group contains Substance resources
    /// </summary>
    public static readonly Coding Substance = new Coding
    {
      Code = "substance",
      Display = "Substance",
      System = "http://hl7.org/fhir/group-type"
    };

    /// <summary>
    /// Literal for code: Animal
    /// </summary>
    public const string LiteralAnimal = "animal";

    /// <summary>
    /// Literal for code: GroupTypeAnimal
    /// </summary>
    public const string LiteralGroupTypeAnimal = "http://hl7.org/fhir/group-type#animal";

    /// <summary>
    /// Literal for code: Device
    /// </summary>
    public const string LiteralDevice = "device";

    /// <summary>
    /// Literal for code: GroupTypeDevice
    /// </summary>
    public const string LiteralGroupTypeDevice = "http://hl7.org/fhir/group-type#device";

    /// <summary>
    /// Literal for code: Medication
    /// </summary>
    public const string LiteralMedication = "medication";

    /// <summary>
    /// Literal for code: GroupTypeMedication
    /// </summary>
    public const string LiteralGroupTypeMedication = "http://hl7.org/fhir/group-type#medication";

    /// <summary>
    /// Literal for code: Person
    /// </summary>
    public const string LiteralPerson = "person";

    /// <summary>
    /// Literal for code: GroupTypePerson
    /// </summary>
    public const string LiteralGroupTypePerson = "http://hl7.org/fhir/group-type#person";

    /// <summary>
    /// Literal for code: Practitioner
    /// </summary>
    public const string LiteralPractitioner = "practitioner";

    /// <summary>
    /// Literal for code: GroupTypePractitioner
    /// </summary>
    public const string LiteralGroupTypePractitioner = "http://hl7.org/fhir/group-type#practitioner";

    /// <summary>
    /// Literal for code: Substance
    /// </summary>
    public const string LiteralSubstance = "substance";

    /// <summary>
    /// Literal for code: GroupTypeSubstance
    /// </summary>
    public const string LiteralGroupTypeSubstance = "http://hl7.org/fhir/group-type#substance";

    /// <summary>
    /// Dictionary for looking up GroupType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "animal", Animal }, 
      { "http://hl7.org/fhir/group-type#animal", Animal }, 
      { "device", Device }, 
      { "http://hl7.org/fhir/group-type#device", Device }, 
      { "medication", Medication }, 
      { "http://hl7.org/fhir/group-type#medication", Medication }, 
      { "person", Person }, 
      { "http://hl7.org/fhir/group-type#person", Person }, 
      { "practitioner", Practitioner }, 
      { "http://hl7.org/fhir/group-type#practitioner", Practitioner }, 
      { "substance", Substance }, 
      { "http://hl7.org/fhir/group-type#substance", Substance }, 
    };
  };
}
