// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// The type of actor - system or human.
  /// </summary>
  public static class ExamplescenarioActorTypeCodes
  {
    /// <summary>
    /// A system.
    /// </summary>
    public static readonly Coding System = new Coding
    {
      Code = "entity",
      Display = "System",
      System = "http://hl7.org/fhir/examplescenario-actor-type"
    };
    /// <summary>
    /// A person.
    /// </summary>
    public static readonly Coding Person = new Coding
    {
      Code = "person",
      Display = "Person",
      System = "http://hl7.org/fhir/examplescenario-actor-type"
    };

    /// <summary>
    /// Literal for code: System
    /// </summary>
    public const string LiteralSystem = "entity";

    /// <summary>
    /// Literal for code: ExamplescenarioActorTypeSystem
    /// </summary>
    public const string LiteralExamplescenarioActorTypeSystem = "http://hl7.org/fhir/examplescenario-actor-type#entity";

    /// <summary>
    /// Literal for code: Person
    /// </summary>
    public const string LiteralPerson = "person";

    /// <summary>
    /// Literal for code: ExamplescenarioActorTypePerson
    /// </summary>
    public const string LiteralExamplescenarioActorTypePerson = "http://hl7.org/fhir/examplescenario-actor-type#person";

    /// <summary>
    /// Dictionary for looking up ExamplescenarioActorType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "entity", System }, 
      { "http://hl7.org/fhir/examplescenario-actor-type#entity", System }, 
      { "person", Person }, 
      { "http://hl7.org/fhir/examplescenario-actor-type#person", Person }, 
    };
  };
}
