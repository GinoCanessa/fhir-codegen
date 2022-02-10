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
  /// The history of statuses that the EpisodeOfCare has been through (without requiring processing the history of the resource).
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<EpisodeOfCareStatusHistory>))]
  public class EpisodeOfCareStatusHistory : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The period during this EpisodeOfCare that the specific status applied.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// planned | waitlist | active | onhold | finished | cancelled.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
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
        case "period":
          Period = new fhirCsR3.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR3.Models.Element();
          _Status.DeserializeJson(ref reader, options);
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
  /// Code Values for the EpisodeOfCare.statusHistory.status field
  /// </summary>
  public static class EpisodeOfCareStatusHistoryStatusCodes {
    public const string PLANNED = "planned";
    public const string WAITLIST = "waitlist";
    public const string ACTIVE = "active";
    public const string ONHOLD = "onhold";
    public const string FINISHED = "finished";
    public const string CANCELLED = "cancelled";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public static HashSet<string> Values = new HashSet<string>() {
      "planned",
      "waitlist",
      "active",
      "onhold",
      "finished",
      "cancelled",
      "entered-in-error",
    };
  }
  /// <summary>
  /// The list of diagnosis relevant to this episode of care.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<EpisodeOfCareDiagnosis>))]
  public class EpisodeOfCareDiagnosis : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A list of conditions/problems/diagnoses that this episode of care is intended to be providing care for.
    /// </summary>
    public Reference Condition { get; set; }
    /// <summary>
    /// Ranking of the diagnosis (for each role type).
    /// </summary>
    public uint? Rank { get; set; }
    /// <summary>
    /// Role that this diagnosis has within the episode of care (e.g. admission, billing, discharge …).
    /// </summary>
    public CodeableConcept Role { get; set; }
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

      if (Condition != null)
      {
        writer.WritePropertyName("condition");
        Condition.SerializeJson(writer, options);
      }

      if (Role != null)
      {
        writer.WritePropertyName("role");
        Role.SerializeJson(writer, options);
      }

      if (Rank != null)
      {
        writer.WriteNumber("rank", (uint)Rank!);
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
        case "condition":
          Condition = new fhirCsR3.Models.Reference();
          Condition.DeserializeJson(ref reader, options);
          break;

        case "rank":
          Rank = reader.GetUInt32();
          break;

        case "role":
          Role = new fhirCsR3.Models.CodeableConcept();
          Role.DeserializeJson(ref reader, options);
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
  /// An association between a patient and an organization / healthcare provider(s) during which time encounters may occur. The managing organization assumes a level of responsibility for the patient during this time.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<EpisodeOfCare>))]
  public class EpisodeOfCare : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "EpisodeOfCare";
    /// <summary>
    /// The billing system may choose to allocate billable items associated with the EpisodeOfCare to different referenced Accounts based on internal business rules.
    /// </summary>
    public List<Reference> Account { get; set; }
    /// <summary>
    /// The practitioner that is the care manager/care co-ordinator for this patient.
    /// </summary>
    public Reference CareManager { get; set; }
    /// <summary>
    /// The list of diagnosis relevant to this episode of care.
    /// </summary>
    public List<EpisodeOfCareDiagnosis> Diagnosis { get; set; }
    /// <summary>
    /// The EpisodeOfCare may be known by different identifiers for different contexts of use, such as when an external agency is tracking the Episode for funding purposes.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The organization that has assumed the specific responsibilities for the specified duration.
    /// </summary>
    public Reference ManagingOrganization { get; set; }
    /// <summary>
    /// The patient who is the focus of this episode of care.
    /// </summary>
    public Reference Patient { get; set; }
    /// <summary>
    /// The interval during which the managing organization assumes the defined responsibility.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// Referral Request(s) that are fulfilled by this EpisodeOfCare, incoming referrals.
    /// </summary>
    public List<Reference> ReferralRequest { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains codes that mark the episode as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The history of statuses that the EpisodeOfCare has been through (without requiring processing the history of the resource).
    /// </summary>
    public List<EpisodeOfCareStatusHistory> StatusHistory { get; set; }
    /// <summary>
    /// The list of practitioners that may be facilitating this episode of care for specific purposes.
    /// </summary>
    public List<Reference> Team { get; set; }
    /// <summary>
    /// The type can be very important in processing as this could be used in determining if the EpisodeOfCare is relevant to specific government reporting, or other types of classifications.
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

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if ((StatusHistory != null) && (StatusHistory.Count != 0))
      {
        writer.WritePropertyName("statusHistory");
        writer.WriteStartArray();

        foreach (EpisodeOfCareStatusHistory valStatusHistory in StatusHistory)
        {
          valStatusHistory.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

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

      if ((Diagnosis != null) && (Diagnosis.Count != 0))
      {
        writer.WritePropertyName("diagnosis");
        writer.WriteStartArray();

        foreach (EpisodeOfCareDiagnosis valDiagnosis in Diagnosis)
        {
          valDiagnosis.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Patient != null)
      {
        writer.WritePropertyName("patient");
        Patient.SerializeJson(writer, options);
      }

      if (ManagingOrganization != null)
      {
        writer.WritePropertyName("managingOrganization");
        ManagingOrganization.SerializeJson(writer, options);
      }

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(writer, options);
      }

      if ((ReferralRequest != null) && (ReferralRequest.Count != 0))
      {
        writer.WritePropertyName("referralRequest");
        writer.WriteStartArray();

        foreach (Reference valReferralRequest in ReferralRequest)
        {
          valReferralRequest.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (CareManager != null)
      {
        writer.WritePropertyName("careManager");
        CareManager.SerializeJson(writer, options);
      }

      if ((Team != null) && (Team.Count != 0))
      {
        writer.WritePropertyName("team");
        writer.WriteStartArray();

        foreach (Reference valTeam in Team)
        {
          valTeam.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Account != null) && (Account.Count != 0))
      {
        writer.WritePropertyName("account");
        writer.WriteStartArray();

        foreach (Reference valAccount in Account)
        {
          valAccount.SerializeJson(writer, options, true);
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
        case "account":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Account = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objAccount = new fhirCsR3.Models.Reference();
            objAccount.DeserializeJson(ref reader, options);
            Account.Add(objAccount);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Account.Count == 0)
          {
            Account = null;
          }

          break;

        case "careManager":
          CareManager = new fhirCsR3.Models.Reference();
          CareManager.DeserializeJson(ref reader, options);
          break;

        case "diagnosis":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Diagnosis = new List<EpisodeOfCareDiagnosis>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.EpisodeOfCareDiagnosis objDiagnosis = new fhirCsR3.Models.EpisodeOfCareDiagnosis();
            objDiagnosis.DeserializeJson(ref reader, options);
            Diagnosis.Add(objDiagnosis);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Diagnosis.Count == 0)
          {
            Diagnosis = null;
          }

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

        case "managingOrganization":
          ManagingOrganization = new fhirCsR3.Models.Reference();
          ManagingOrganization.DeserializeJson(ref reader, options);
          break;

        case "patient":
          Patient = new fhirCsR3.Models.Reference();
          Patient.DeserializeJson(ref reader, options);
          break;

        case "period":
          Period = new fhirCsR3.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "referralRequest":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReferralRequest = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objReferralRequest = new fhirCsR3.Models.Reference();
            objReferralRequest.DeserializeJson(ref reader, options);
            ReferralRequest.Add(objReferralRequest);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReferralRequest.Count == 0)
          {
            ReferralRequest = null;
          }

          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR3.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "statusHistory":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          StatusHistory = new List<EpisodeOfCareStatusHistory>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.EpisodeOfCareStatusHistory objStatusHistory = new fhirCsR3.Models.EpisodeOfCareStatusHistory();
            objStatusHistory.DeserializeJson(ref reader, options);
            StatusHistory.Add(objStatusHistory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (StatusHistory.Count == 0)
          {
            StatusHistory = null;
          }

          break;

        case "team":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Team = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objTeam = new fhirCsR3.Models.Reference();
            objTeam.DeserializeJson(ref reader, options);
            Team.Add(objTeam);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Team.Count == 0)
          {
            Team = null;
          }

          break;

        case "type":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Type = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.CodeableConcept objType = new fhirCsR3.Models.CodeableConcept();
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
  /// Code Values for the EpisodeOfCare.status field
  /// </summary>
  public static class EpisodeOfCareStatusCodes {
    public const string PLANNED = "planned";
    public const string WAITLIST = "waitlist";
    public const string ACTIVE = "active";
    public const string ONHOLD = "onhold";
    public const string FINISHED = "finished";
    public const string CANCELLED = "cancelled";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public static HashSet<string> Values = new HashSet<string>() {
      "planned",
      "waitlist",
      "active",
      "onhold",
      "finished",
      "cancelled",
      "entered-in-error",
    };
  }
}
