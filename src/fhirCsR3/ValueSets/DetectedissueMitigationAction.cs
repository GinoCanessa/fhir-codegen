// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// Kinds of mitigating actions and observations that can be associated with a detected issue or contraindication, such as 'added concurrent therapy', 'prior therapy documented', etc.
  /// </summary>
  public static class DetectedissueMitigationActionCodes
  {
    /// <summary>
    /// Codes dealing with the management of Detected Issue observations for the administrative and patient administrative acts domains.
    /// </summary>
    public static readonly Coding ActAdministrativeDetectedIssueManagementCode = new Coding
    {
      Code = "_ActAdministrativeDetectedIssueManagementCode",
      Display = "ActAdministrativeDetectedIssueManagementCode",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Codes dealing with the management of Detected Issue observations
    /// </summary>
    public static readonly Coding ActDetectedIssueManagementCode = new Coding
    {
      Code = "_ActDetectedIssueManagementCode",
      Display = "ActDetectedIssueManagementCode",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Authorization Issue Management Code
    /// </summary>
    public static readonly Coding AuthorizationIssueManagementCode = new Coding
    {
      Code = "_AuthorizationIssueManagementCode",
      Display = "Authorization Issue Management Code",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Confirmed drug therapy appropriate
    /// </summary>
    public static readonly Coding TherapyAppropriate = new Coding
    {
      Code = "1",
      Display = "Therapy Appropriate",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Provided education or training to the patient on appropriate therapy use
    /// </summary>
    public static readonly Coding ProvidedPatientEducation = new Coding
    {
      Code = "10",
      Display = "Provided Patient Education",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Instituted an additional therapy to mitigate potential negative effects
    /// </summary>
    public static readonly Coding AddedConcurrentTherapy = new Coding
    {
      Code = "11",
      Display = "Added Concurrent Therapy",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Suspended existing therapy that triggered interaction for the duration of this therapy
    /// </summary>
    public static readonly Coding TemporarilySuspendedConcurrentTherapy = new Coding
    {
      Code = "12",
      Display = "Temporarily Suspended Concurrent Therapy",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Aborted existing therapy that triggered interaction.
    /// </summary>
    public static readonly Coding StoppedConcurrentTherapy = new Coding
    {
      Code = "13",
      Display = "Stopped Concurrent Therapy",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Confirmed supply action appropriate
    /// </summary>
    public static readonly Coding SupplyAppropriate = new Coding
    {
      Code = "14",
      Display = "Supply Appropriate",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Patient's existing supply was lost/wasted
    /// </summary>
    public static readonly Coding Replacement = new Coding
    {
      Code = "15",
      Display = "Replacement",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Supply date is due to patient vacation
    /// </summary>
    public static readonly Coding VacationSupply = new Coding
    {
      Code = "16",
      Display = "Vacation Supply",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Supply date is intended to carry patient over weekend
    /// </summary>
    public static readonly Coding WeekendSupply = new Coding
    {
      Code = "17",
      Display = "Weekend Supply",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Supply is intended for use during a leave of absence from an institution.
    /// </summary>
    public static readonly Coding LeaveOfAbsence = new Coding
    {
      Code = "18",
      Display = "Leave of Absence",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Consulted other supplier/pharmacy, therapy confirmed
    /// </summary>
    public static readonly Coding ConsultedSupplier = new Coding
    {
      Code = "19",
      Display = "Consulted Supplier",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Assessed patient, therapy is appropriate
    /// </summary>
    public static readonly Coding AssessedPatient = new Coding
    {
      Code = "2",
      Display = "Assessed Patient",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Description: Supply is different than expected as an additional quantity has been supplied in a separate dispense.
    /// </summary>
    public static readonly Coding AdditionalQuantityOnSeparateDispense = new Coding
    {
      Code = "20",
      Display = "additional quantity on separate dispense",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Description: Indicates that the permissions have been externally verified and the request should be processed.
    /// </summary>
    public static readonly Coding AuthorizationConfirmed = new Coding
    {
      Code = "21",
      Display = "authorization confirmed",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Description: The patient has the appropriate indication or diagnosis for the action to be taken.
    /// </summary>
    public static readonly Coding AppropriateIndicationOrDiagnosis = new Coding
    {
      Code = "22",
      Display = "appropriate indication or diagnosis",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Description: It has been confirmed that the appropriate pre-requisite therapy has been tried.
    /// </summary>
    public static readonly Coding PriorTherapyDocumented = new Coding
    {
      Code = "23",
      Display = "prior therapy documented",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Patient gave adequate explanation
    /// </summary>
    public static readonly Coding PatientExplanation = new Coding
    {
      Code = "3",
      Display = "Patient Explanation",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Consulted other supply source, therapy still appropriate
    /// </summary>
    public static readonly Coding ConsultedOtherSource = new Coding
    {
      Code = "4",
      Display = "Consulted Other Source",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Consulted prescriber, therapy confirmed
    /// </summary>
    public static readonly Coding ConsultedPrescriber = new Coding
    {
      Code = "5",
      Display = "Consulted Prescriber",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Consulted prescriber and recommended change, prescriber declined
    /// </summary>
    public static readonly Coding PrescriberDeclinedChange = new Coding
    {
      Code = "6",
      Display = "Prescriber Declined Change",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Concurrent therapy triggering alert is no longer on-going or planned
    /// </summary>
    public static readonly Coding InteractingTherapyNoLongerActivePlanned = new Coding
    {
      Code = "7",
      Display = "Interacting Therapy No Longer Active/Planned",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Order is performed as issued, but other action taken to mitigate potential adverse effects
    /// </summary>
    public static readonly Coding OtherActionTaken = new Coding
    {
      Code = "8",
      Display = "Other Action Taken",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Arranged to monitor patient for adverse effects
    /// </summary>
    public static readonly Coding InstitutedOngoingMonitoringProgram = new Coding
    {
      Code = "9",
      Display = "Instituted Ongoing Monitoring Program",
      System = "http://hl7.org/fhir/v3/ActCode"
    };
    /// <summary>
    /// Used to temporarily override normal authorization rules to gain access to data in a case of emergency. Use of this override code will typically be monitored, and a procedure to verify its proper use may be triggered when used.
    /// </summary>
    public static readonly Coding EmergencyAuthorizationOverride = new Coding
    {
      Code = "EMAUTH",
      Display = "emergency authorization override",
      System = "http://hl7.org/fhir/v3/ActCode"
    };

    /// <summary>
    /// Literal for code: ActAdministrativeDetectedIssueManagementCode
    /// </summary>
    public const string LiteralActAdministrativeDetectedIssueManagementCode = "_ActAdministrativeDetectedIssueManagementCode";

    /// <summary>
    /// Literal for code: V3ActCodeActAdministrativeDetectedIssueManagementCode
    /// </summary>
    public const string LiteralV3ActCodeActAdministrativeDetectedIssueManagementCode = "http://hl7.org/fhir/v3/ActCode#_ActAdministrativeDetectedIssueManagementCode";

    /// <summary>
    /// Literal for code: ActDetectedIssueManagementCode
    /// </summary>
    public const string LiteralActDetectedIssueManagementCode = "_ActDetectedIssueManagementCode";

    /// <summary>
    /// Literal for code: V3ActCodeActDetectedIssueManagementCode
    /// </summary>
    public const string LiteralV3ActCodeActDetectedIssueManagementCode = "http://hl7.org/fhir/v3/ActCode#_ActDetectedIssueManagementCode";

    /// <summary>
    /// Literal for code: AuthorizationIssueManagementCode
    /// </summary>
    public const string LiteralAuthorizationIssueManagementCode = "_AuthorizationIssueManagementCode";

    /// <summary>
    /// Literal for code: V3ActCodeAuthorizationIssueManagementCode
    /// </summary>
    public const string LiteralV3ActCodeAuthorizationIssueManagementCode = "http://hl7.org/fhir/v3/ActCode#_AuthorizationIssueManagementCode";

    /// <summary>
    /// Literal for code: TherapyAppropriate
    /// </summary>
    public const string LiteralTherapyAppropriate = "1";

    /// <summary>
    /// Literal for code: V3ActCodeTherapyAppropriate
    /// </summary>
    public const string LiteralV3ActCodeTherapyAppropriate = "http://hl7.org/fhir/v3/ActCode#1";

    /// <summary>
    /// Literal for code: ProvidedPatientEducation
    /// </summary>
    public const string LiteralProvidedPatientEducation = "10";

    /// <summary>
    /// Literal for code: V3ActCodeProvidedPatientEducation
    /// </summary>
    public const string LiteralV3ActCodeProvidedPatientEducation = "http://hl7.org/fhir/v3/ActCode#10";

    /// <summary>
    /// Literal for code: AddedConcurrentTherapy
    /// </summary>
    public const string LiteralAddedConcurrentTherapy = "11";

    /// <summary>
    /// Literal for code: V3ActCodeAddedConcurrentTherapy
    /// </summary>
    public const string LiteralV3ActCodeAddedConcurrentTherapy = "http://hl7.org/fhir/v3/ActCode#11";

    /// <summary>
    /// Literal for code: TemporarilySuspendedConcurrentTherapy
    /// </summary>
    public const string LiteralTemporarilySuspendedConcurrentTherapy = "12";

    /// <summary>
    /// Literal for code: V3ActCodeTemporarilySuspendedConcurrentTherapy
    /// </summary>
    public const string LiteralV3ActCodeTemporarilySuspendedConcurrentTherapy = "http://hl7.org/fhir/v3/ActCode#12";

    /// <summary>
    /// Literal for code: StoppedConcurrentTherapy
    /// </summary>
    public const string LiteralStoppedConcurrentTherapy = "13";

    /// <summary>
    /// Literal for code: V3ActCodeStoppedConcurrentTherapy
    /// </summary>
    public const string LiteralV3ActCodeStoppedConcurrentTherapy = "http://hl7.org/fhir/v3/ActCode#13";

    /// <summary>
    /// Literal for code: SupplyAppropriate
    /// </summary>
    public const string LiteralSupplyAppropriate = "14";

    /// <summary>
    /// Literal for code: V3ActCodeSupplyAppropriate
    /// </summary>
    public const string LiteralV3ActCodeSupplyAppropriate = "http://hl7.org/fhir/v3/ActCode#14";

    /// <summary>
    /// Literal for code: Replacement
    /// </summary>
    public const string LiteralReplacement = "15";

    /// <summary>
    /// Literal for code: V3ActCodeReplacement
    /// </summary>
    public const string LiteralV3ActCodeReplacement = "http://hl7.org/fhir/v3/ActCode#15";

    /// <summary>
    /// Literal for code: VacationSupply
    /// </summary>
    public const string LiteralVacationSupply = "16";

    /// <summary>
    /// Literal for code: V3ActCodeVacationSupply
    /// </summary>
    public const string LiteralV3ActCodeVacationSupply = "http://hl7.org/fhir/v3/ActCode#16";

    /// <summary>
    /// Literal for code: WeekendSupply
    /// </summary>
    public const string LiteralWeekendSupply = "17";

    /// <summary>
    /// Literal for code: V3ActCodeWeekendSupply
    /// </summary>
    public const string LiteralV3ActCodeWeekendSupply = "http://hl7.org/fhir/v3/ActCode#17";

    /// <summary>
    /// Literal for code: LeaveOfAbsence
    /// </summary>
    public const string LiteralLeaveOfAbsence = "18";

    /// <summary>
    /// Literal for code: V3ActCodeLeaveOfAbsence
    /// </summary>
    public const string LiteralV3ActCodeLeaveOfAbsence = "http://hl7.org/fhir/v3/ActCode#18";

    /// <summary>
    /// Literal for code: ConsultedSupplier
    /// </summary>
    public const string LiteralConsultedSupplier = "19";

    /// <summary>
    /// Literal for code: V3ActCodeConsultedSupplier
    /// </summary>
    public const string LiteralV3ActCodeConsultedSupplier = "http://hl7.org/fhir/v3/ActCode#19";

    /// <summary>
    /// Literal for code: AssessedPatient
    /// </summary>
    public const string LiteralAssessedPatient = "2";

    /// <summary>
    /// Literal for code: V3ActCodeAssessedPatient
    /// </summary>
    public const string LiteralV3ActCodeAssessedPatient = "http://hl7.org/fhir/v3/ActCode#2";

    /// <summary>
    /// Literal for code: AdditionalQuantityOnSeparateDispense
    /// </summary>
    public const string LiteralAdditionalQuantityOnSeparateDispense = "20";

    /// <summary>
    /// Literal for code: V3ActCodeAdditionalQuantityOnSeparateDispense
    /// </summary>
    public const string LiteralV3ActCodeAdditionalQuantityOnSeparateDispense = "http://hl7.org/fhir/v3/ActCode#20";

    /// <summary>
    /// Literal for code: AuthorizationConfirmed
    /// </summary>
    public const string LiteralAuthorizationConfirmed = "21";

    /// <summary>
    /// Literal for code: V3ActCodeAuthorizationConfirmed
    /// </summary>
    public const string LiteralV3ActCodeAuthorizationConfirmed = "http://hl7.org/fhir/v3/ActCode#21";

    /// <summary>
    /// Literal for code: AppropriateIndicationOrDiagnosis
    /// </summary>
    public const string LiteralAppropriateIndicationOrDiagnosis = "22";

    /// <summary>
    /// Literal for code: V3ActCodeAppropriateIndicationOrDiagnosis
    /// </summary>
    public const string LiteralV3ActCodeAppropriateIndicationOrDiagnosis = "http://hl7.org/fhir/v3/ActCode#22";

    /// <summary>
    /// Literal for code: PriorTherapyDocumented
    /// </summary>
    public const string LiteralPriorTherapyDocumented = "23";

    /// <summary>
    /// Literal for code: V3ActCodePriorTherapyDocumented
    /// </summary>
    public const string LiteralV3ActCodePriorTherapyDocumented = "http://hl7.org/fhir/v3/ActCode#23";

    /// <summary>
    /// Literal for code: PatientExplanation
    /// </summary>
    public const string LiteralPatientExplanation = "3";

    /// <summary>
    /// Literal for code: V3ActCodePatientExplanation
    /// </summary>
    public const string LiteralV3ActCodePatientExplanation = "http://hl7.org/fhir/v3/ActCode#3";

    /// <summary>
    /// Literal for code: ConsultedOtherSource
    /// </summary>
    public const string LiteralConsultedOtherSource = "4";

    /// <summary>
    /// Literal for code: V3ActCodeConsultedOtherSource
    /// </summary>
    public const string LiteralV3ActCodeConsultedOtherSource = "http://hl7.org/fhir/v3/ActCode#4";

    /// <summary>
    /// Literal for code: ConsultedPrescriber
    /// </summary>
    public const string LiteralConsultedPrescriber = "5";

    /// <summary>
    /// Literal for code: V3ActCodeConsultedPrescriber
    /// </summary>
    public const string LiteralV3ActCodeConsultedPrescriber = "http://hl7.org/fhir/v3/ActCode#5";

    /// <summary>
    /// Literal for code: PrescriberDeclinedChange
    /// </summary>
    public const string LiteralPrescriberDeclinedChange = "6";

    /// <summary>
    /// Literal for code: V3ActCodePrescriberDeclinedChange
    /// </summary>
    public const string LiteralV3ActCodePrescriberDeclinedChange = "http://hl7.org/fhir/v3/ActCode#6";

    /// <summary>
    /// Literal for code: InteractingTherapyNoLongerActivePlanned
    /// </summary>
    public const string LiteralInteractingTherapyNoLongerActivePlanned = "7";

    /// <summary>
    /// Literal for code: V3ActCodeInteractingTherapyNoLongerActivePlanned
    /// </summary>
    public const string LiteralV3ActCodeInteractingTherapyNoLongerActivePlanned = "http://hl7.org/fhir/v3/ActCode#7";

    /// <summary>
    /// Literal for code: OtherActionTaken
    /// </summary>
    public const string LiteralOtherActionTaken = "8";

    /// <summary>
    /// Literal for code: V3ActCodeOtherActionTaken
    /// </summary>
    public const string LiteralV3ActCodeOtherActionTaken = "http://hl7.org/fhir/v3/ActCode#8";

    /// <summary>
    /// Literal for code: InstitutedOngoingMonitoringProgram
    /// </summary>
    public const string LiteralInstitutedOngoingMonitoringProgram = "9";

    /// <summary>
    /// Literal for code: V3ActCodeInstitutedOngoingMonitoringProgram
    /// </summary>
    public const string LiteralV3ActCodeInstitutedOngoingMonitoringProgram = "http://hl7.org/fhir/v3/ActCode#9";

    /// <summary>
    /// Literal for code: EmergencyAuthorizationOverride
    /// </summary>
    public const string LiteralEmergencyAuthorizationOverride = "EMAUTH";

    /// <summary>
    /// Literal for code: V3ActCodeEmergencyAuthorizationOverride
    /// </summary>
    public const string LiteralV3ActCodeEmergencyAuthorizationOverride = "http://hl7.org/fhir/v3/ActCode#EMAUTH";

    /// <summary>
    /// Dictionary for looking up DetectedissueMitigationAction Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "_ActAdministrativeDetectedIssueManagementCode", ActAdministrativeDetectedIssueManagementCode }, 
      { "http://hl7.org/fhir/v3/ActCode#_ActAdministrativeDetectedIssueManagementCode", ActAdministrativeDetectedIssueManagementCode }, 
      { "_ActDetectedIssueManagementCode", ActDetectedIssueManagementCode }, 
      { "http://hl7.org/fhir/v3/ActCode#_ActDetectedIssueManagementCode", ActDetectedIssueManagementCode }, 
      { "_AuthorizationIssueManagementCode", AuthorizationIssueManagementCode }, 
      { "http://hl7.org/fhir/v3/ActCode#_AuthorizationIssueManagementCode", AuthorizationIssueManagementCode }, 
      { "1", TherapyAppropriate }, 
      { "http://hl7.org/fhir/v3/ActCode#1", TherapyAppropriate }, 
      { "10", ProvidedPatientEducation }, 
      { "http://hl7.org/fhir/v3/ActCode#10", ProvidedPatientEducation }, 
      { "11", AddedConcurrentTherapy }, 
      { "http://hl7.org/fhir/v3/ActCode#11", AddedConcurrentTherapy }, 
      { "12", TemporarilySuspendedConcurrentTherapy }, 
      { "http://hl7.org/fhir/v3/ActCode#12", TemporarilySuspendedConcurrentTherapy }, 
      { "13", StoppedConcurrentTherapy }, 
      { "http://hl7.org/fhir/v3/ActCode#13", StoppedConcurrentTherapy }, 
      { "14", SupplyAppropriate }, 
      { "http://hl7.org/fhir/v3/ActCode#14", SupplyAppropriate }, 
      { "15", Replacement }, 
      { "http://hl7.org/fhir/v3/ActCode#15", Replacement }, 
      { "16", VacationSupply }, 
      { "http://hl7.org/fhir/v3/ActCode#16", VacationSupply }, 
      { "17", WeekendSupply }, 
      { "http://hl7.org/fhir/v3/ActCode#17", WeekendSupply }, 
      { "18", LeaveOfAbsence }, 
      { "http://hl7.org/fhir/v3/ActCode#18", LeaveOfAbsence }, 
      { "19", ConsultedSupplier }, 
      { "http://hl7.org/fhir/v3/ActCode#19", ConsultedSupplier }, 
      { "2", AssessedPatient }, 
      { "http://hl7.org/fhir/v3/ActCode#2", AssessedPatient }, 
      { "20", AdditionalQuantityOnSeparateDispense }, 
      { "http://hl7.org/fhir/v3/ActCode#20", AdditionalQuantityOnSeparateDispense }, 
      { "21", AuthorizationConfirmed }, 
      { "http://hl7.org/fhir/v3/ActCode#21", AuthorizationConfirmed }, 
      { "22", AppropriateIndicationOrDiagnosis }, 
      { "http://hl7.org/fhir/v3/ActCode#22", AppropriateIndicationOrDiagnosis }, 
      { "23", PriorTherapyDocumented }, 
      { "http://hl7.org/fhir/v3/ActCode#23", PriorTherapyDocumented }, 
      { "3", PatientExplanation }, 
      { "http://hl7.org/fhir/v3/ActCode#3", PatientExplanation }, 
      { "4", ConsultedOtherSource }, 
      { "http://hl7.org/fhir/v3/ActCode#4", ConsultedOtherSource }, 
      { "5", ConsultedPrescriber }, 
      { "http://hl7.org/fhir/v3/ActCode#5", ConsultedPrescriber }, 
      { "6", PrescriberDeclinedChange }, 
      { "http://hl7.org/fhir/v3/ActCode#6", PrescriberDeclinedChange }, 
      { "7", InteractingTherapyNoLongerActivePlanned }, 
      { "http://hl7.org/fhir/v3/ActCode#7", InteractingTherapyNoLongerActivePlanned }, 
      { "8", OtherActionTaken }, 
      { "http://hl7.org/fhir/v3/ActCode#8", OtherActionTaken }, 
      { "9", InstitutedOngoingMonitoringProgram }, 
      { "http://hl7.org/fhir/v3/ActCode#9", InstitutedOngoingMonitoringProgram }, 
      { "EMAUTH", EmergencyAuthorizationOverride }, 
      { "http://hl7.org/fhir/v3/ActCode#EMAUTH", EmergencyAuthorizationOverride }, 
    };
  };
}
