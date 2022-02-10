// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The type of participant for the action.
  /// </summary>
  public static class ActionParticipantTypeCodes
  {
    /// <summary>
    /// The participant is a system or device used in the care of the patient.
    /// </summary>
    public static readonly Coding Device = new Coding
    {
      Code = "device",
      Display = "Device",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is the patient under evaluation.
    /// </summary>
    public static readonly Coding Patient = new Coding
    {
      Code = "patient",
      Display = "Patient",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is a practitioner involved in the patient's care.
    /// </summary>
    public static readonly Coding Practitioner = new Coding
    {
      Code = "practitioner",
      Display = "Practitioner",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is a person related to the patient.
    /// </summary>
    public static readonly Coding RelatedPerson = new Coding
    {
      Code = "related-person",
      Display = "Related Person",
      System = "http://hl7.org/fhir/action-participant-type"
    };

    /// <summary>
    /// Literal for code: Device
    /// </summary>
    public const string LiteralDevice = "device";

    /// <summary>
    /// Literal for code: ActionParticipantTypeDevice
    /// </summary>
    public const string LiteralActionParticipantTypeDevice = "http://hl7.org/fhir/action-participant-type#device";

    /// <summary>
    /// Literal for code: Patient
    /// </summary>
    public const string LiteralPatient = "patient";

    /// <summary>
    /// Literal for code: ActionParticipantTypePatient
    /// </summary>
    public const string LiteralActionParticipantTypePatient = "http://hl7.org/fhir/action-participant-type#patient";

    /// <summary>
    /// Literal for code: Practitioner
    /// </summary>
    public const string LiteralPractitioner = "practitioner";

    /// <summary>
    /// Literal for code: ActionParticipantTypePractitioner
    /// </summary>
    public const string LiteralActionParticipantTypePractitioner = "http://hl7.org/fhir/action-participant-type#practitioner";

    /// <summary>
    /// Literal for code: RelatedPerson
    /// </summary>
    public const string LiteralRelatedPerson = "related-person";

    /// <summary>
    /// Literal for code: ActionParticipantTypeRelatedPerson
    /// </summary>
    public const string LiteralActionParticipantTypeRelatedPerson = "http://hl7.org/fhir/action-participant-type#related-person";

    /// <summary>
    /// Dictionary for looking up ActionParticipantType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "device", Device }, 
      { "http://hl7.org/fhir/action-participant-type#device", Device }, 
      { "patient", Patient }, 
      { "http://hl7.org/fhir/action-participant-type#patient", Patient }, 
      { "practitioner", Practitioner }, 
      { "http://hl7.org/fhir/action-participant-type#practitioner", Practitioner }, 
      { "related-person", RelatedPerson }, 
      { "http://hl7.org/fhir/action-participant-type#related-person", RelatedPerson }, 
    };
  };
}
