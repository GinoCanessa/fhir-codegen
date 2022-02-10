// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR4.Serialization;

namespace fhirCsR4.Models
{
  /// <summary>
  /// List of participants involved in the appointment.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<AppointmentParticipant>))]
  public class AppointmentParticipant : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A Person, Location/HealthcareService or Device that is participating in the appointment.
    /// </summary>
    public Reference Actor { get; set; }
    /// <summary>
    /// Participation period of the actor.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// Whether this participant is required to be present at the meeting. This covers a use-case where two doctors need to meet to discuss the results for a specific patient, and the patient is not required to be present.
    /// </summary>
    public string Required { get; set; }
    /// <summary>
    /// Extension container element for Required
    /// </summary>
    public Element _Required { get; set; }
    /// <summary>
    /// Participation status of the actor.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The role of the participant can be used to declare what the actor will be doing in the scope of this appointment.
    /// If the actor is not specified, then it is expected that the actor will be filled in at a later stage of planning.
    /// This value SHALL be the same when creating an AppointmentResponse so that they can be matched, and subsequently update the Appointment.
    /// </summary>
    public List<CodeableConcept> Type { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if ((Type != null) && (Type.Count != 0))
      {
        writer.WritePropertyName("type");
        writer.WriteStartArray();

        foreach (CodeableConcept valType in Type)
        {
          valType.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Actor != null)
      {
        writer.WritePropertyName("actor");
        Actor.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Required))
      {
        writer.WriteString("required", (string)Required!);
      }

      if (_Required != null)
      {
        writer.WritePropertyName("_required");
        _Required.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "actor":
          Actor = new fhirCsR4.Models.Reference();
          Actor.DeserializeJson(ref reader, options);
          break;

        case "period":
          Period = new fhirCsR4.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "required":
          Required = reader.GetString();
          break;

        case "_required":
          _Required = new fhirCsR4.Models.Element();
          _Required.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "type":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Type = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.CodeableConcept objType = new fhirCsR4.Models.CodeableConcept();
            objType.DeserializeJson(ref reader, options);
            Type.Add(objType);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Type.Count == 0)
          {
            Type = null;
          }

          break;

        default:
          ((fhirCsR4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Code Values for the Appointment.participant.required field
  /// </summary>
  public static class AppointmentParticipantRequiredCodes {
    public const string REQUIRED = "required";
    public const string OPTIONAL = "optional";
    public const string INFORMATION_ONLY = "information-only";
    public static HashSet<string> Values = new HashSet<string>() {
      "required",
      "optional",
      "information-only",
    };
  }
  /// <summary>
  /// Code Values for the Appointment.participant.status field
  /// </summary>
  public static class AppointmentParticipantStatusCodes {
    public const string ACCEPTED = "accepted";
    public const string DECLINED = "declined";
    public const string TENTATIVE = "tentative";
    public const string NEEDS_ACTION = "needs-action";
    public static HashSet<string> Values = new HashSet<string>() {
      "accepted",
      "declined",
      "tentative",
      "needs-action",
    };
  }
  /// <summary>
  /// A booking of a healthcare event among patient(s), practitioner(s), related person(s) and/or device(s) for a specific date/time. This may result in one or more Encounter(s).
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<Appointment>))]
  public class Appointment : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Appointment";
    /// <summary>
    /// The style of appointment or patient that has been booked in the slot (not service type).
    /// </summary>
    public CodeableConcept AppointmentType { get; set; }
    /// <summary>
    /// The service request this appointment is allocated to assess (e.g. incoming referral or procedure request).
    /// </summary>
    public List<Reference> BasedOn { get; set; }
    /// <summary>
    /// The coded reason for the appointment being cancelled. This is often used in reporting/billing/futher processing to determine if further actions are required, or specific fees apply.
    /// </summary>
    public CodeableConcept CancelationReason { get; set; }
    /// <summary>
    /// Additional text to aid in facilitating the appointment. For instance, a comment might be, "patient should proceed immediately to infusion room upon arrival"
    /// Where this is a planned appointment and the start/end dates are not set then this field can be used to provide additional guidance on the details of the appointment request, including any restrictions on when to book it.
    /// </summary>
    public string Comment { get; set; }
    /// <summary>
    /// Extension container element for Comment
    /// </summary>
    public Element _Comment { get; set; }
    /// <summary>
    /// This property is required for many use cases where the age of an appointment is considered in processing workflows for scheduling and billing of appointments.
    /// </summary>
    public string Created { get; set; }
    /// <summary>
    /// Extension container element for Created
    /// </summary>
    public Element _Created { get; set; }
    /// <summary>
    /// The brief description of the appointment as would be shown on a subject line in a meeting request, or appointment list. Detailed or expanded information should be put in the comment field.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// Date/Time that the appointment is to conclude.
    /// </summary>
    public string End { get; set; }
    /// <summary>
    /// Extension container element for End
    /// </summary>
    public Element _End { get; set; }
    /// <summary>
    /// This records identifiers associated with this appointment concern that are defined by business processes and/or used to refer to it when a direct URL reference to the resource itself is not appropriate (e.g. in CDA documents, or in written / printed documentation).
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Number of minutes that the appointment is to take. This can be less than the duration between the start and end times.  For example, where the actual time of appointment is only an estimate or if a 30 minute appointment is being requested, but any time would work.  Also, if there is, for example, a planned 15 minute break in the middle of a long appointment, the duration may be 15 minutes less than the difference between the start and end.
    /// </summary>
    public uint? MinutesDuration { get; set; }
    /// <summary>
    /// List of participants involved in the appointment.
    /// </summary>
    public List<AppointmentParticipant> Participant { get; set; }
    /// <summary>
    /// While Appointment.comment contains information for internal use, Appointment.patientInstructions is used to capture patient facing information about the Appointment (e.g. please bring your referral or fast from 8pm night before).
    /// </summary>
    public string PatientInstruction { get; set; }
    /// <summary>
    /// Extension container element for PatientInstruction
    /// </summary>
    public Element _PatientInstruction { get; set; }
    /// <summary>
    /// Seeking implementer feedback on this property and how interoperable it is.
    /// Using an extension to record a CodeableConcept for named values may be tested at a future connectathon.
    /// </summary>
    public uint? Priority { get; set; }
    /// <summary>
    /// The coded reason that this appointment is being scheduled. This is more clinical than administrative.
    /// </summary>
    public List<CodeableConcept> ReasonCode { get; set; }
    /// <summary>
    /// Reason the appointment has been scheduled to take place, as specified using information from another resource. When the patient arrives and the encounter begins it may be used as the admission diagnosis. The indication will typically be a Condition (with other resources referenced in the evidence.detail), or a Procedure.
    /// </summary>
    public List<Reference> ReasonReference { get; set; }
    /// <summary>
    /// This does not introduce a capacity for recurring appointments.
    /// </summary>
    public List<Period> RequestedPeriod { get; set; }
    /// <summary>
    /// A broad categorization of the service that is to be performed during this appointment.
    /// </summary>
    public List<CodeableConcept> ServiceCategory { get; set; }
    /// <summary>
    /// For a provider to provider appointment the code "FOLLOWUP" may be appropriate, as this is expected to be discussing some patient that was seen in the past.
    /// </summary>
    public List<CodeableConcept> ServiceType { get; set; }
    /// <summary>
    /// The slots from the participants' schedules that will be filled by the appointment.
    /// </summary>
    public List<Reference> Slot { get; set; }
    /// <summary>
    /// The specialty of a practitioner that would be required to perform the service requested in this appointment.
    /// </summary>
    public List<CodeableConcept> Specialty { get; set; }
    /// <summary>
    /// Date/Time that the appointment is to take place.
    /// </summary>
    public string Start { get; set; }
    /// <summary>
    /// Extension container element for Start
    /// </summary>
    public Element _Start { get; set; }
    /// <summary>
    /// If the Appointment's status is "cancelled" then all participants are expected to have their calendars released for the appointment period, and as such any Slots that were marked as BUSY can be re-set to FREE.
    /// This element is labeled as a modifier because the status contains the code entered-in-error that mark the Appointment as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Additional information to support the appointment provided when making the appointment.
    /// </summary>
    public List<Reference> SupportingInformation { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((fhirCsR4.Models.DomainResource)this).SerializeJson(writer, options, false);

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (CancelationReason != null)
      {
        writer.WritePropertyName("cancelationReason");
        CancelationReason.SerializeJson(writer, options);
      }

      if ((ServiceCategory != null) && (ServiceCategory.Count != 0))
      {
        writer.WritePropertyName("serviceCategory");
        writer.WriteStartArray();

        foreach (CodeableConcept valServiceCategory in ServiceCategory)
        {
          valServiceCategory.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ServiceType != null) && (ServiceType.Count != 0))
      {
        writer.WritePropertyName("serviceType");
        writer.WriteStartArray();

        foreach (CodeableConcept valServiceType in ServiceType)
        {
          valServiceType.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Specialty != null) && (Specialty.Count != 0))
      {
        writer.WritePropertyName("specialty");
        writer.WriteStartArray();

        foreach (CodeableConcept valSpecialty in Specialty)
        {
          valSpecialty.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (AppointmentType != null)
      {
        writer.WritePropertyName("appointmentType");
        AppointmentType.SerializeJson(writer, options);
      }

      if ((ReasonCode != null) && (ReasonCode.Count != 0))
      {
        writer.WritePropertyName("reasonCode");
        writer.WriteStartArray();

        foreach (CodeableConcept valReasonCode in ReasonCode)
        {
          valReasonCode.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ReasonReference != null) && (ReasonReference.Count != 0))
      {
        writer.WritePropertyName("reasonReference");
        writer.WriteStartArray();

        foreach (Reference valReasonReference in ReasonReference)
        {
          valReasonReference.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Priority != null)
      {
        writer.WriteNumber("priority", (uint)Priority!);
      }

      if (!string.IsNullOrEmpty(Description))
      {
        writer.WriteString("description", (string)Description!);
      }

      if (_Description != null)
      {
        writer.WritePropertyName("_description");
        _Description.SerializeJson(writer, options);
      }

      if ((SupportingInformation != null) && (SupportingInformation.Count != 0))
      {
        writer.WritePropertyName("supportingInformation");
        writer.WriteStartArray();

        foreach (Reference valSupportingInformation in SupportingInformation)
        {
          valSupportingInformation.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Start))
      {
        writer.WriteString("start", (string)Start!);
      }

      if (_Start != null)
      {
        writer.WritePropertyName("_start");
        _Start.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(End))
      {
        writer.WriteString("end", (string)End!);
      }

      if (_End != null)
      {
        writer.WritePropertyName("_end");
        _End.SerializeJson(writer, options);
      }

      if (MinutesDuration != null)
      {
        writer.WriteNumber("minutesDuration", (uint)MinutesDuration!);
      }

      if ((Slot != null) && (Slot.Count != 0))
      {
        writer.WritePropertyName("slot");
        writer.WriteStartArray();

        foreach (Reference valSlot in Slot)
        {
          valSlot.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Created))
      {
        writer.WriteString("created", (string)Created!);
      }

      if (_Created != null)
      {
        writer.WritePropertyName("_created");
        _Created.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Comment))
      {
        writer.WriteString("comment", (string)Comment!);
      }

      if (_Comment != null)
      {
        writer.WritePropertyName("_comment");
        _Comment.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(PatientInstruction))
      {
        writer.WriteString("patientInstruction", (string)PatientInstruction!);
      }

      if (_PatientInstruction != null)
      {
        writer.WritePropertyName("_patientInstruction");
        _PatientInstruction.SerializeJson(writer, options);
      }

      if ((BasedOn != null) && (BasedOn.Count != 0))
      {
        writer.WritePropertyName("basedOn");
        writer.WriteStartArray();

        foreach (Reference valBasedOn in BasedOn)
        {
          valBasedOn.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Participant != null) && (Participant.Count != 0))
      {
        writer.WritePropertyName("participant");
        writer.WriteStartArray();

        foreach (AppointmentParticipant valParticipant in Participant)
        {
          valParticipant.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((RequestedPeriod != null) && (RequestedPeriod.Count != 0))
      {
        writer.WritePropertyName("requestedPeriod");
        writer.WriteStartArray();

        foreach (Period valRequestedPeriod in RequestedPeriod)
        {
          valRequestedPeriod.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "appointmentType":
          AppointmentType = new fhirCsR4.Models.CodeableConcept();
          AppointmentType.DeserializeJson(ref reader, options);
          break;

        case "basedOn":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          BasedOn = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objBasedOn = new fhirCsR4.Models.Reference();
            objBasedOn.DeserializeJson(ref reader, options);
            BasedOn.Add(objBasedOn);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (BasedOn.Count == 0)
          {
            BasedOn = null;
          }

          break;

        case "cancelationReason":
          CancelationReason = new fhirCsR4.Models.CodeableConcept();
          CancelationReason.DeserializeJson(ref reader, options);
          break;

        case "comment":
          Comment = reader.GetString();
          break;

        case "_comment":
          _Comment = new fhirCsR4.Models.Element();
          _Comment.DeserializeJson(ref reader, options);
          break;

        case "created":
          Created = reader.GetString();
          break;

        case "_created":
          _Created = new fhirCsR4.Models.Element();
          _Created.DeserializeJson(ref reader, options);
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new fhirCsR4.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "end":
          End = reader.GetString();
          break;

        case "_end":
          _End = new fhirCsR4.Models.Element();
          _End.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Identifier objIdentifier = new fhirCsR4.Models.Identifier();
            objIdentifier.DeserializeJson(ref reader, options);
            Identifier.Add(objIdentifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Identifier.Count == 0)
          {
            Identifier = null;
          }

          break;

        case "minutesDuration":
          MinutesDuration = reader.GetUInt32();
          break;

        case "participant":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Participant = new List<AppointmentParticipant>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.AppointmentParticipant objParticipant = new fhirCsR4.Models.AppointmentParticipant();
            objParticipant.DeserializeJson(ref reader, options);
            Participant.Add(objParticipant);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Participant.Count == 0)
          {
            Participant = null;
          }

          break;

        case "patientInstruction":
          PatientInstruction = reader.GetString();
          break;

        case "_patientInstruction":
          _PatientInstruction = new fhirCsR4.Models.Element();
          _PatientInstruction.DeserializeJson(ref reader, options);
          break;

        case "priority":
          Priority = reader.GetUInt32();
          break;

        case "reasonCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReasonCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.CodeableConcept objReasonCode = new fhirCsR4.Models.CodeableConcept();
            objReasonCode.DeserializeJson(ref reader, options);
            ReasonCode.Add(objReasonCode);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReasonCode.Count == 0)
          {
            ReasonCode = null;
          }

          break;

        case "reasonReference":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReasonReference = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objReasonReference = new fhirCsR4.Models.Reference();
            objReasonReference.DeserializeJson(ref reader, options);
            ReasonReference.Add(objReasonReference);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReasonReference.Count == 0)
          {
            ReasonReference = null;
          }

          break;

        case "requestedPeriod":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          RequestedPeriod = new List<Period>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Period objRequestedPeriod = new fhirCsR4.Models.Period();
            objRequestedPeriod.DeserializeJson(ref reader, options);
            RequestedPeriod.Add(objRequestedPeriod);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (RequestedPeriod.Count == 0)
          {
            RequestedPeriod = null;
          }

          break;

        case "serviceCategory":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ServiceCategory = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.CodeableConcept objServiceCategory = new fhirCsR4.Models.CodeableConcept();
            objServiceCategory.DeserializeJson(ref reader, options);
            ServiceCategory.Add(objServiceCategory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ServiceCategory.Count == 0)
          {
            ServiceCategory = null;
          }

          break;

        case "serviceType":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ServiceType = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.CodeableConcept objServiceType = new fhirCsR4.Models.CodeableConcept();
            objServiceType.DeserializeJson(ref reader, options);
            ServiceType.Add(objServiceType);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ServiceType.Count == 0)
          {
            ServiceType = null;
          }

          break;

        case "slot":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Slot = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objSlot = new fhirCsR4.Models.Reference();
            objSlot.DeserializeJson(ref reader, options);
            Slot.Add(objSlot);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Slot.Count == 0)
          {
            Slot = null;
          }

          break;

        case "specialty":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Specialty = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.CodeableConcept objSpecialty = new fhirCsR4.Models.CodeableConcept();
            objSpecialty.DeserializeJson(ref reader, options);
            Specialty.Add(objSpecialty);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Specialty.Count == 0)
          {
            Specialty = null;
          }

          break;

        case "start":
          Start = reader.GetString();
          break;

        case "_start":
          _Start = new fhirCsR4.Models.Element();
          _Start.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "supportingInformation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SupportingInformation = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objSupportingInformation = new fhirCsR4.Models.Reference();
            objSupportingInformation.DeserializeJson(ref reader, options);
            SupportingInformation.Add(objSupportingInformation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SupportingInformation.Count == 0)
          {
            SupportingInformation = null;
          }

          break;

        default:
          ((fhirCsR4.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Code Values for the Appointment.status field
  /// </summary>
  public static class AppointmentStatusCodes {
    public const string PROPOSED = "proposed";
    public const string PENDING = "pending";
    public const string BOOKED = "booked";
    public const string ARRIVED = "arrived";
    public const string FULFILLED = "fulfilled";
    public const string CANCELLED = "cancelled";
    public const string NOSHOW = "noshow";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public const string CHECKED_IN = "checked-in";
    public const string WAITLIST = "waitlist";
    public static HashSet<string> Values = new HashSet<string>() {
      "proposed",
      "pending",
      "booked",
      "arrived",
      "fulfilled",
      "cancelled",
      "noshow",
      "entered-in-error",
      "checked-in",
      "waitlist",
    };
  }
}
