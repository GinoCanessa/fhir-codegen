// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR3.Serialization;

namespace fhirCsR3.Models
{
  /// <summary>
  /// The individual who initiated the request and has responsibility for its activation.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<DeviceRequestRequester>))]
  public class DeviceRequestRequester : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The device, practitioner, etc. who initiated the request.
    /// </summary>
    public Reference Agent { get; set; }
    /// <summary>
    /// The organization the device or practitioner was acting on behalf of.
    /// </summary>
    public Reference OnBehalfOf { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR3.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Agent != null)
      {
        writer.WritePropertyName("agent");
        Agent.SerializeJson(writer, options);
      }

      if (OnBehalfOf != null)
      {
        writer.WritePropertyName("onBehalfOf");
        OnBehalfOf.SerializeJson(writer, options);
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
        case "agent":
          Agent = new fhirCsR3.Models.Reference();
          Agent.DeserializeJson(ref reader, options);
          break;

        case "onBehalfOf":
          OnBehalfOf = new fhirCsR3.Models.Reference();
          OnBehalfOf.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR3.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Represents a request for a patient to employ a medical device. The device may be an implantable device, or an external assistive device, such as a walker.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<DeviceRequest>))]
  public class DeviceRequest : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "DeviceRequest";
    /// <summary>
    /// When the request transitioned to being actionable.
    /// </summary>
    public string AuthoredOn { get; set; }
    /// <summary>
    /// Extension container element for AuthoredOn
    /// </summary>
    public Element _AuthoredOn { get; set; }
    /// <summary>
    /// Plan/proposal/order fulfilled by this request.
    /// </summary>
    public List<Reference> BasedOn { get; set; }
    /// <summary>
    /// The details of the device to be used.
    /// </summary>
    public Reference CodeReference { get; set; }
    /// <summary>
    /// The details of the device to be used.
    /// </summary>
    public CodeableConcept CodeCodeableConcept { get; set; }
    /// <summary>
    /// An encounter that provides additional context in which this request is made.
    /// </summary>
    public Reference Context { get; set; }
    /// <summary>
    /// Protocol or definition followed by this request. For example: The proposed act must be performed if the indicated conditions occur, e.g.., shortness of breath, SpO2 less than x%.
    /// </summary>
    public List<Reference> Definition { get; set; }
    /// <summary>
    /// Composite request this is part of.
    /// </summary>
    public Identifier GroupIdentifier { get; set; }
    /// <summary>
    /// Identifiers assigned to this order by the orderer or by the receiver.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Whether the request is a proposal, plan, an original order or a reflex order.
    /// </summary>
    public CodeableConcept Intent { get; set; }
    /// <summary>
    /// Details about this request that were not represented at all or sufficiently in one of the attributes provided in a class. These may include for example a comment, an instruction, or a note associated with the statement.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// The timing schedule for the use of the device. The Schedule data type allows many different expressions, for example. "Every 8 hours"; "Three times a day"; "1/2 an hour before breakfast for 10 days from 23-Dec 2011:"; "15 Oct 2013, 17 Oct 2013 and 1 Nov 2013".
    /// </summary>
    public string OccurrenceDateTime { get; set; }
    /// <summary>
    /// Extension container element for OccurrenceDateTime
    /// </summary>
    public Element _OccurrenceDateTime { get; set; }
    /// <summary>
    /// The timing schedule for the use of the device. The Schedule data type allows many different expressions, for example. "Every 8 hours"; "Three times a day"; "1/2 an hour before breakfast for 10 days from 23-Dec 2011:"; "15 Oct 2013, 17 Oct 2013 and 1 Nov 2013".
    /// </summary>
    public Period OccurrencePeriod { get; set; }
    /// <summary>
    /// The timing schedule for the use of the device. The Schedule data type allows many different expressions, for example. "Every 8 hours"; "Three times a day"; "1/2 an hour before breakfast for 10 days from 23-Dec 2011:"; "15 Oct 2013, 17 Oct 2013 and 1 Nov 2013".
    /// </summary>
    public Timing OccurrenceTiming { get; set; }
    /// <summary>
    /// The desired perfomer for doing the diagnostic testing.
    /// </summary>
    public Reference Performer { get; set; }
    /// <summary>
    /// Desired type of performer for doing the diagnostic testing.
    /// </summary>
    public CodeableConcept PerformerType { get; set; }
    /// <summary>
    /// Indicates how quickly the {{title}} should be addressed with respect to other requests.
    /// </summary>
    public string Priority { get; set; }
    /// <summary>
    /// Extension container element for Priority
    /// </summary>
    public Element _Priority { get; set; }
    /// <summary>
    /// The request takes the place of the referenced completed or terminated request(s).
    /// </summary>
    public List<Reference> PriorRequest { get; set; }
    /// <summary>
    /// Reason or justification for the use of this device.
    /// </summary>
    public List<CodeableConcept> ReasonCode { get; set; }
    /// <summary>
    /// Reason or justification for the use of this device.
    /// </summary>
    public List<Reference> ReasonReference { get; set; }
    /// <summary>
    /// This may not include provenances for all versions of the request – only those deemed “relevant” or important.
    /// This SHALL NOT include the Provenance associated with this current version of the resource.  (If that provenance is deemed to be a “relevant” change, it will need to be added as part of a later update.  Until then, it can be queried directly as the Provenance that points to this version using _revinclude
    /// All Provenances should have some historical version of this Request as their subject.
    /// </summary>
    public List<Reference> RelevantHistory { get; set; }
    /// <summary>
    /// The individual who initiated the request and has responsibility for its activation.
    /// </summary>
    public DeviceRequestRequester Requester { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains the codes cancelled and entered-in-error that mark the request as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The patient who will use the device.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// Additional clinical information about the patient that may influence the request fulfilment.  For example, this may includes body where on the subject's the device will be used ( i.e. the target site).
    /// </summary>
    public List<Reference> SupportingInfo { get; set; }
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


      ((fhirCsR3.Models.DomainResource)this).SerializeJson(writer, options, false);

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

      if ((Definition != null) && (Definition.Count != 0))
      {
        writer.WritePropertyName("definition");
        writer.WriteStartArray();

        foreach (Reference valDefinition in Definition)
        {
          valDefinition.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
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

      if ((PriorRequest != null) && (PriorRequest.Count != 0))
      {
        writer.WritePropertyName("priorRequest");
        writer.WriteStartArray();

        foreach (Reference valPriorRequest in PriorRequest)
        {
          valPriorRequest.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (GroupIdentifier != null)
      {
        writer.WritePropertyName("groupIdentifier");
        GroupIdentifier.SerializeJson(writer, options);
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

      if (Intent != null)
      {
        writer.WritePropertyName("intent");
        Intent.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Priority))
      {
        writer.WriteString("priority", (string)Priority!);
      }

      if (_Priority != null)
      {
        writer.WritePropertyName("_priority");
        _Priority.SerializeJson(writer, options);
      }

      if (CodeReference != null)
      {
        writer.WritePropertyName("codeReference");
        CodeReference.SerializeJson(writer, options);
      }

      if (CodeCodeableConcept != null)
      {
        writer.WritePropertyName("codeCodeableConcept");
        CodeCodeableConcept.SerializeJson(writer, options);
      }

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (Context != null)
      {
        writer.WritePropertyName("context");
        Context.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(OccurrenceDateTime))
      {
        writer.WriteString("occurrenceDateTime", (string)OccurrenceDateTime!);
      }

      if (_OccurrenceDateTime != null)
      {
        writer.WritePropertyName("_occurrenceDateTime");
        _OccurrenceDateTime.SerializeJson(writer, options);
      }

      if (OccurrencePeriod != null)
      {
        writer.WritePropertyName("occurrencePeriod");
        OccurrencePeriod.SerializeJson(writer, options);
      }

      if (OccurrenceTiming != null)
      {
        writer.WritePropertyName("occurrenceTiming");
        OccurrenceTiming.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(AuthoredOn))
      {
        writer.WriteString("authoredOn", (string)AuthoredOn!);
      }

      if (_AuthoredOn != null)
      {
        writer.WritePropertyName("_authoredOn");
        _AuthoredOn.SerializeJson(writer, options);
      }

      if (Requester != null)
      {
        writer.WritePropertyName("requester");
        Requester.SerializeJson(writer, options);
      }

      if (PerformerType != null)
      {
        writer.WritePropertyName("performerType");
        PerformerType.SerializeJson(writer, options);
      }

      if (Performer != null)
      {
        writer.WritePropertyName("performer");
        Performer.SerializeJson(writer, options);
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

      if ((SupportingInfo != null) && (SupportingInfo.Count != 0))
      {
        writer.WritePropertyName("supportingInfo");
        writer.WriteStartArray();

        foreach (Reference valSupportingInfo in SupportingInfo)
        {
          valSupportingInfo.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Note != null) && (Note.Count != 0))
      {
        writer.WritePropertyName("note");
        writer.WriteStartArray();

        foreach (Annotation valNote in Note)
        {
          valNote.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((RelevantHistory != null) && (RelevantHistory.Count != 0))
      {
        writer.WritePropertyName("relevantHistory");
        writer.WriteStartArray();

        foreach (Reference valRelevantHistory in RelevantHistory)
        {
          valRelevantHistory.SerializeJson(writer, options, true);
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
        case "authoredOn":
          AuthoredOn = reader.GetString();
          break;

        case "_authoredOn":
          _AuthoredOn = new fhirCsR3.Models.Element();
          _AuthoredOn.DeserializeJson(ref reader, options);
          break;

        case "basedOn":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          BasedOn = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objBasedOn = new fhirCsR3.Models.Reference();
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

        case "codeReference":
          CodeReference = new fhirCsR3.Models.Reference();
          CodeReference.DeserializeJson(ref reader, options);
          break;

        case "codeCodeableConcept":
          CodeCodeableConcept = new fhirCsR3.Models.CodeableConcept();
          CodeCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "context":
          Context = new fhirCsR3.Models.Reference();
          Context.DeserializeJson(ref reader, options);
          break;

        case "definition":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Definition = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objDefinition = new fhirCsR3.Models.Reference();
            objDefinition.DeserializeJson(ref reader, options);
            Definition.Add(objDefinition);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Definition.Count == 0)
          {
            Definition = null;
          }

          break;

        case "groupIdentifier":
          GroupIdentifier = new fhirCsR3.Models.Identifier();
          GroupIdentifier.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Identifier objIdentifier = new fhirCsR3.Models.Identifier();
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

        case "intent":
          Intent = new fhirCsR3.Models.CodeableConcept();
          Intent.DeserializeJson(ref reader, options);
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Annotation objNote = new fhirCsR3.Models.Annotation();
            objNote.DeserializeJson(ref reader, options);
            Note.Add(objNote);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Note.Count == 0)
          {
            Note = null;
          }

          break;

        case "occurrenceDateTime":
          OccurrenceDateTime = reader.GetString();
          break;

        case "_occurrenceDateTime":
          _OccurrenceDateTime = new fhirCsR3.Models.Element();
          _OccurrenceDateTime.DeserializeJson(ref reader, options);
          break;

        case "occurrencePeriod":
          OccurrencePeriod = new fhirCsR3.Models.Period();
          OccurrencePeriod.DeserializeJson(ref reader, options);
          break;

        case "occurrenceTiming":
          OccurrenceTiming = new fhirCsR3.Models.Timing();
          OccurrenceTiming.DeserializeJson(ref reader, options);
          break;

        case "performer":
          Performer = new fhirCsR3.Models.Reference();
          Performer.DeserializeJson(ref reader, options);
          break;

        case "performerType":
          PerformerType = new fhirCsR3.Models.CodeableConcept();
          PerformerType.DeserializeJson(ref reader, options);
          break;

        case "priority":
          Priority = reader.GetString();
          break;

        case "_priority":
          _Priority = new fhirCsR3.Models.Element();
          _Priority.DeserializeJson(ref reader, options);
          break;

        case "priorRequest":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          PriorRequest = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objPriorRequest = new fhirCsR3.Models.Reference();
            objPriorRequest.DeserializeJson(ref reader, options);
            PriorRequest.Add(objPriorRequest);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (PriorRequest.Count == 0)
          {
            PriorRequest = null;
          }

          break;

        case "reasonCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReasonCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.CodeableConcept objReasonCode = new fhirCsR3.Models.CodeableConcept();
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
            fhirCsR3.Models.Reference objReasonReference = new fhirCsR3.Models.Reference();
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

        case "relevantHistory":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          RelevantHistory = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objRelevantHistory = new fhirCsR3.Models.Reference();
            objRelevantHistory.DeserializeJson(ref reader, options);
            RelevantHistory.Add(objRelevantHistory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (RelevantHistory.Count == 0)
          {
            RelevantHistory = null;
          }

          break;

        case "requester":
          Requester = new fhirCsR3.Models.DeviceRequestRequester();
          Requester.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR3.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new fhirCsR3.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "supportingInfo":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SupportingInfo = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objSupportingInfo = new fhirCsR3.Models.Reference();
            objSupportingInfo.DeserializeJson(ref reader, options);
            SupportingInfo.Add(objSupportingInfo);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SupportingInfo.Count == 0)
          {
            SupportingInfo = null;
          }

          break;

        default:
          ((fhirCsR3.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Code Values for the DeviceRequest.status field
  /// </summary>
  public static class DeviceRequestStatusCodes {
    public const string DRAFT = "draft";
    public const string ACTIVE = "active";
    public const string SUSPENDED = "suspended";
    public const string CANCELLED = "cancelled";
    public const string COMPLETED = "completed";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public const string UNKNOWN = "unknown";
    public static HashSet<string> Values = new HashSet<string>() {
      "draft",
      "active",
      "suspended",
      "cancelled",
      "completed",
      "entered-in-error",
      "unknown",
    };
  }
}
