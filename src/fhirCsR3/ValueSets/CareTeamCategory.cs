// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// Indicates the type of care team.
  /// </summary>
  public static class CareTeamCategoryCodes
  {
    /// <summary>
    /// This type of team is responsible for establishing, conducting, coordinating and monitoring the outcomes of clinical trials. The team focuses on research, clinical care and education.
    /// </summary>
    public static readonly Coding ClinicalResearch = new Coding
    {
      Code = "clinical-research",
      Display = "Clinical Research",
      System = "http://hl7.org/fhir/care-team-category"
    };
    /// <summary>
    /// This type of team focuses on one specific condition. The condition is determined by the context of use.  For example, a disease management team focused on one condition (e.g. diabetes).
    /// </summary>
    public static readonly Coding Condition = new Coding
    {
      Code = "condition",
      Display = "Condition",
      System = "http://hl7.org/fhir/care-team-category"
    };
    /// <summary>
    /// This type of team focuses on one specific encounter. The encounter is determined by the context of use.  For example, during an inpatient encounter, the nutrition support care team
    /// </summary>
    public static readonly Coding Encounter = new Coding
    {
      Code = "encounter",
      Display = "Encounter",
      System = "http://hl7.org/fhir/care-team-category"
    };
    /// <summary>
    /// This type of team focuses on one specific episode of care with a defined time period or self-limiting process (e.g. 10 visits). The episode of care is determined by the context of use.  For example, a maternity care team over 9 months.
    /// </summary>
    public static readonly Coding Episode = new Coding
    {
      Code = "episode",
      Display = "Episode",
      System = "http://hl7.org/fhir/care-team-category"
    };
    /// <summary>
    /// This type of team focuses on one specific type of incident, which is non-patient specific. The incident is determined by the context of use.  For example, code team (code red, code blue, medical emergency treatment) or the PICC line team.
    /// </summary>
    public static readonly Coding Event = new Coding
    {
      Code = "event",
      Display = "Event",
      System = "http://hl7.org/fhir/care-team-category"
    };
    /// <summary>
    /// This type of team focuses on overall care coordination managing one or more conditions across the continuum of care ensuring there are smooth transitions of care. The members of the team are determined or selected by an individual or organization. When determined by an organization, the team may be assigned or based on the person's enrollment in a particular program. For example, disease management team or patient centered medical home team.
    /// </summary>
    public static readonly Coding LongitudinalCareCoordination = new Coding
    {
      Code = "longitudinal",
      Display = "Longitudinal Care Coordination",
      System = "http://hl7.org/fhir/care-team-category"
    };

    /// <summary>
    /// Literal for code: ClinicalResearch
    /// </summary>
    public const string LiteralClinicalResearch = "clinical-research";

    /// <summary>
    /// Literal for code: CareTeamCategoryClinicalResearch
    /// </summary>
    public const string LiteralCareTeamCategoryClinicalResearch = "http://hl7.org/fhir/care-team-category#clinical-research";

    /// <summary>
    /// Literal for code: Condition
    /// </summary>
    public const string LiteralCondition = "condition";

    /// <summary>
    /// Literal for code: CareTeamCategoryCondition
    /// </summary>
    public const string LiteralCareTeamCategoryCondition = "http://hl7.org/fhir/care-team-category#condition";

    /// <summary>
    /// Literal for code: Encounter
    /// </summary>
    public const string LiteralEncounter = "encounter";

    /// <summary>
    /// Literal for code: CareTeamCategoryEncounter
    /// </summary>
    public const string LiteralCareTeamCategoryEncounter = "http://hl7.org/fhir/care-team-category#encounter";

    /// <summary>
    /// Literal for code: Episode
    /// </summary>
    public const string LiteralEpisode = "episode";

    /// <summary>
    /// Literal for code: CareTeamCategoryEpisode
    /// </summary>
    public const string LiteralCareTeamCategoryEpisode = "http://hl7.org/fhir/care-team-category#episode";

    /// <summary>
    /// Literal for code: Event
    /// </summary>
    public const string LiteralEvent = "event";

    /// <summary>
    /// Literal for code: CareTeamCategoryEvent
    /// </summary>
    public const string LiteralCareTeamCategoryEvent = "http://hl7.org/fhir/care-team-category#event";

    /// <summary>
    /// Literal for code: LongitudinalCareCoordination
    /// </summary>
    public const string LiteralLongitudinalCareCoordination = "longitudinal";

    /// <summary>
    /// Literal for code: CareTeamCategoryLongitudinalCareCoordination
    /// </summary>
    public const string LiteralCareTeamCategoryLongitudinalCareCoordination = "http://hl7.org/fhir/care-team-category#longitudinal";

    /// <summary>
    /// Dictionary for looking up CareTeamCategory Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "clinical-research", ClinicalResearch }, 
      { "http://hl7.org/fhir/care-team-category#clinical-research", ClinicalResearch }, 
      { "condition", Condition }, 
      { "http://hl7.org/fhir/care-team-category#condition", Condition }, 
      { "encounter", Encounter }, 
      { "http://hl7.org/fhir/care-team-category#encounter", Encounter }, 
      { "episode", Episode }, 
      { "http://hl7.org/fhir/care-team-category#episode", Episode }, 
      { "event", Event }, 
      { "http://hl7.org/fhir/care-team-category#event", Event }, 
      { "longitudinal", LongitudinalCareCoordination }, 
      { "http://hl7.org/fhir/care-team-category#longitudinal", LongitudinalCareCoordination }, 
    };
  };
}
