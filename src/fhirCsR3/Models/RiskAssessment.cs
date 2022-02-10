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
  /// Multiple repetitions can be used to identify the same type of outcome in different timeframes as well as different types of outcomes.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<RiskAssessmentPrediction>))]
  public class RiskAssessmentPrediction : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// One of the potential outcomes for the patient (e.g. remission, death,  a particular condition).
    /// </summary>
    public CodeableConcept Outcome { get; set; }
    /// <summary>
    /// If range is used, it represents the lower and upper bounds of certainty; e.g. 40-60%  Decimal values are expressed as percentages as well (max = 100).
    /// </summary>
    public decimal? ProbabilityDecimal { get; set; }
    /// <summary>
    /// Extension container element for ProbabilityDecimal
    /// </summary>
    public Element _ProbabilityDecimal { get; set; }
    /// <summary>
    /// If range is used, it represents the lower and upper bounds of certainty; e.g. 40-60%  Decimal values are expressed as percentages as well (max = 100).
    /// </summary>
    public Range ProbabilityRange { get; set; }
    /// <summary>
    /// How likely is the outcome (in the specified timeframe), expressed as a qualitative value (e.g. low, medium, high).
    /// </summary>
    public CodeableConcept QualitativeRisk { get; set; }
    /// <summary>
    /// Additional information explaining the basis for the prediction.
    /// </summary>
    public string Rationale { get; set; }
    /// <summary>
    /// Extension container element for Rationale
    /// </summary>
    public Element _Rationale { get; set; }
    /// <summary>
    /// Indicates the risk for this particular subject (with their specific characteristics) divided by the risk of the population in general.  (Numbers greater than 1 = higher risk than the population, numbers less than 1 = lower risk.).
    /// </summary>
    public decimal? RelativeRisk { get; set; }
    /// <summary>
    /// Extension container element for RelativeRisk
    /// </summary>
    public Element _RelativeRisk { get; set; }
    /// <summary>
    /// If not specified, the risk applies "over the subject's lifespan".
    /// </summary>
    public Period WhenPeriod { get; set; }
    /// <summary>
    /// If not specified, the risk applies "over the subject's lifespan".
    /// </summary>
    public Range WhenRange { get; set; }
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

      if (Outcome != null)
      {
        writer.WritePropertyName("outcome");
        Outcome.SerializeJson(writer, options);
      }

      if (ProbabilityDecimal != null)
      {
        writer.WriteNumber("probabilityDecimal", (decimal)ProbabilityDecimal!);
      }

      if (_ProbabilityDecimal != null)
      {
        writer.WritePropertyName("_probabilityDecimal");
        _ProbabilityDecimal.SerializeJson(writer, options);
      }

      if (ProbabilityRange != null)
      {
        writer.WritePropertyName("probabilityRange");
        ProbabilityRange.SerializeJson(writer, options);
      }

      if (QualitativeRisk != null)
      {
        writer.WritePropertyName("qualitativeRisk");
        QualitativeRisk.SerializeJson(writer, options);
      }

      if (RelativeRisk != null)
      {
        writer.WriteNumber("relativeRisk", (decimal)RelativeRisk!);
      }

      if (_RelativeRisk != null)
      {
        writer.WritePropertyName("_relativeRisk");
        _RelativeRisk.SerializeJson(writer, options);
      }

      if (WhenPeriod != null)
      {
        writer.WritePropertyName("whenPeriod");
        WhenPeriod.SerializeJson(writer, options);
      }

      if (WhenRange != null)
      {
        writer.WritePropertyName("whenRange");
        WhenRange.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Rationale))
      {
        writer.WriteString("rationale", (string)Rationale!);
      }

      if (_Rationale != null)
      {
        writer.WritePropertyName("_rationale");
        _Rationale.SerializeJson(writer, options);
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
        case "outcome":
          Outcome = new fhirCsR3.Models.CodeableConcept();
          Outcome.DeserializeJson(ref reader, options);
          break;

        case "probabilityDecimal":
          ProbabilityDecimal = reader.GetDecimal();
          break;

        case "_probabilityDecimal":
          _ProbabilityDecimal = new fhirCsR3.Models.Element();
          _ProbabilityDecimal.DeserializeJson(ref reader, options);
          break;

        case "probabilityRange":
          ProbabilityRange = new fhirCsR3.Models.Range();
          ProbabilityRange.DeserializeJson(ref reader, options);
          break;

        case "qualitativeRisk":
          QualitativeRisk = new fhirCsR3.Models.CodeableConcept();
          QualitativeRisk.DeserializeJson(ref reader, options);
          break;

        case "rationale":
          Rationale = reader.GetString();
          break;

        case "_rationale":
          _Rationale = new fhirCsR3.Models.Element();
          _Rationale.DeserializeJson(ref reader, options);
          break;

        case "relativeRisk":
          RelativeRisk = reader.GetDecimal();
          break;

        case "_relativeRisk":
          _RelativeRisk = new fhirCsR3.Models.Element();
          _RelativeRisk.DeserializeJson(ref reader, options);
          break;

        case "whenPeriod":
          WhenPeriod = new fhirCsR3.Models.Period();
          WhenPeriod.DeserializeJson(ref reader, options);
          break;

        case "whenRange":
          WhenRange = new fhirCsR3.Models.Range();
          WhenRange.DeserializeJson(ref reader, options);
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
  /// An assessment of the likely outcome(s) for a patient or other subject as well as the likelihood of each outcome.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<RiskAssessment>))]
  public class RiskAssessment : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "RiskAssessment";
    /// <summary>
    /// A reference to the request that is fulfilled by this risk assessment.
    /// </summary>
    public Reference BasedOn { get; set; }
    /// <summary>
    /// Indicates the source data considered as part of the assessment (FamilyHistory, Observations, Procedures, Conditions, etc.).
    /// </summary>
    public List<Reference> Basis { get; set; }
    /// <summary>
    /// The type of the risk assessment performed.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// Additional comments about the risk assessment.
    /// </summary>
    public string Comment { get; set; }
    /// <summary>
    /// Extension container element for Comment
    /// </summary>
    public Element _Comment { get; set; }
    /// <summary>
    /// For assessments or prognosis specific to a particular condition, indicates the condition being assessed.
    /// </summary>
    public Reference Condition { get; set; }
    /// <summary>
    /// The encounter where the assessment was performed.
    /// </summary>
    public Reference Context { get; set; }
    /// <summary>
    /// Business identifier assigned to the risk assessment.
    /// </summary>
    public Identifier Identifier { get; set; }
    /// <summary>
    /// The algorithm, process or mechanism used to evaluate the risk.
    /// </summary>
    public CodeableConcept Method { get; set; }
    /// <summary>
    /// A description of the steps that might be taken to reduce the identified risk(s).
    /// </summary>
    public string Mitigation { get; set; }
    /// <summary>
    /// Extension container element for Mitigation
    /// </summary>
    public Element _Mitigation { get; set; }
    /// <summary>
    /// The date (and possibly time) the risk assessment was performed.
    /// </summary>
    public string OccurrenceDateTime { get; set; }
    /// <summary>
    /// Extension container element for OccurrenceDateTime
    /// </summary>
    public Element _OccurrenceDateTime { get; set; }
    /// <summary>
    /// The date (and possibly time) the risk assessment was performed.
    /// </summary>
    public Period OccurrencePeriod { get; set; }
    /// <summary>
    /// A reference to a resource that this risk assessment is part of, such as a Procedure.
    /// </summary>
    public Reference Parent { get; set; }
    /// <summary>
    /// The provider or software application that performed the assessment.
    /// </summary>
    public Reference Performer { get; set; }
    /// <summary>
    /// Multiple repetitions can be used to identify the same type of outcome in different timeframes as well as different types of outcomes.
    /// </summary>
    public List<RiskAssessmentPrediction> Prediction { get; set; }
    /// <summary>
    /// The reason the risk assessment was performed.
    /// </summary>
    public CodeableConcept ReasonCodeableConcept { get; set; }
    /// <summary>
    /// The reason the risk assessment was performed.
    /// </summary>
    public Reference ReasonReference { get; set; }
    /// <summary>
    /// The status of the RiskAssessment, using the same statuses as an Observation.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The patient or group the risk assessment applies to.
    /// </summary>
    public Reference Subject { get; set; }
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

      if (Identifier != null)
      {
        writer.WritePropertyName("identifier");
        Identifier.SerializeJson(writer, options);
      }

      if (BasedOn != null)
      {
        writer.WritePropertyName("basedOn");
        BasedOn.SerializeJson(writer, options);
      }

      if (Parent != null)
      {
        writer.WritePropertyName("parent");
        Parent.SerializeJson(writer, options);
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

      if (Method != null)
      {
        writer.WritePropertyName("method");
        Method.SerializeJson(writer, options);
      }

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
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

      if (Condition != null)
      {
        writer.WritePropertyName("condition");
        Condition.SerializeJson(writer, options);
      }

      if (Performer != null)
      {
        writer.WritePropertyName("performer");
        Performer.SerializeJson(writer, options);
      }

      if (ReasonCodeableConcept != null)
      {
        writer.WritePropertyName("reasonCodeableConcept");
        ReasonCodeableConcept.SerializeJson(writer, options);
      }

      if (ReasonReference != null)
      {
        writer.WritePropertyName("reasonReference");
        ReasonReference.SerializeJson(writer, options);
      }

      if ((Basis != null) && (Basis.Count != 0))
      {
        writer.WritePropertyName("basis");
        writer.WriteStartArray();

        foreach (Reference valBasis in Basis)
        {
          valBasis.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Prediction != null) && (Prediction.Count != 0))
      {
        writer.WritePropertyName("prediction");
        writer.WriteStartArray();

        foreach (RiskAssessmentPrediction valPrediction in Prediction)
        {
          valPrediction.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Mitigation))
      {
        writer.WriteString("mitigation", (string)Mitigation!);
      }

      if (_Mitigation != null)
      {
        writer.WritePropertyName("_mitigation");
        _Mitigation.SerializeJson(writer, options);
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
        case "basedOn":
          BasedOn = new fhirCsR3.Models.Reference();
          BasedOn.DeserializeJson(ref reader, options);
          break;

        case "basis":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Basis = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objBasis = new fhirCsR3.Models.Reference();
            objBasis.DeserializeJson(ref reader, options);
            Basis.Add(objBasis);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Basis.Count == 0)
          {
            Basis = null;
          }

          break;

        case "code":
          Code = new fhirCsR3.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "comment":
          Comment = reader.GetString();
          break;

        case "_comment":
          _Comment = new fhirCsR3.Models.Element();
          _Comment.DeserializeJson(ref reader, options);
          break;

        case "condition":
          Condition = new fhirCsR3.Models.Reference();
          Condition.DeserializeJson(ref reader, options);
          break;

        case "context":
          Context = new fhirCsR3.Models.Reference();
          Context.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          Identifier = new fhirCsR3.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
          break;

        case "method":
          Method = new fhirCsR3.Models.CodeableConcept();
          Method.DeserializeJson(ref reader, options);
          break;

        case "mitigation":
          Mitigation = reader.GetString();
          break;

        case "_mitigation":
          _Mitigation = new fhirCsR3.Models.Element();
          _Mitigation.DeserializeJson(ref reader, options);
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

        case "parent":
          Parent = new fhirCsR3.Models.Reference();
          Parent.DeserializeJson(ref reader, options);
          break;

        case "performer":
          Performer = new fhirCsR3.Models.Reference();
          Performer.DeserializeJson(ref reader, options);
          break;

        case "prediction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Prediction = new List<RiskAssessmentPrediction>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.RiskAssessmentPrediction objPrediction = new fhirCsR3.Models.RiskAssessmentPrediction();
            objPrediction.DeserializeJson(ref reader, options);
            Prediction.Add(objPrediction);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Prediction.Count == 0)
          {
            Prediction = null;
          }

          break;

        case "reasonCodeableConcept":
          ReasonCodeableConcept = new fhirCsR3.Models.CodeableConcept();
          ReasonCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "reasonReference":
          ReasonReference = new fhirCsR3.Models.Reference();
          ReasonReference.DeserializeJson(ref reader, options);
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
  /// Code Values for the RiskAssessment.status field
  /// </summary>
  public static class RiskAssessmentStatusCodes {
    public const string REGISTERED = "registered";
    public const string PRELIMINARY = "preliminary";
    public const string FINAL = "final";
    public const string AMENDED = "amended";
    public const string CORRECTED = "corrected";
    public const string CANCELLED = "cancelled";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public const string UNKNOWN = "unknown";
    public static HashSet<string> Values = new HashSet<string>() {
      "registered",
      "preliminary",
      "final",
      "amended",
      "corrected",
      "cancelled",
      "entered-in-error",
      "unknown",
    };
  }
}
