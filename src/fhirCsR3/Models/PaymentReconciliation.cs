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
  /// List of individual settlement amounts and the corresponding transaction.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<PaymentReconciliationDetail>))]
  public class PaymentReconciliationDetail : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Amount paid for this detail.
    /// </summary>
    public Money Amount { get; set; }
    /// <summary>
    /// The date of the invoice or financial resource.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// The organization which is receiving the payment.
    /// </summary>
    public Reference Payee { get; set; }
    /// <summary>
    /// The claim or financial resource.
    /// </summary>
    public Reference Request { get; set; }
    /// <summary>
    /// The claim response resource.
    /// </summary>
    public Reference Response { get; set; }
    /// <summary>
    /// The Organization which submitted the claim or financial transaction.
    /// </summary>
    public Reference Submitter { get; set; }
    /// <summary>
    /// Code to indicate the nature of the payment, adjustment, funds advance, etc.
    /// </summary>
    public CodeableConcept Type { get; set; }
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

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (Request != null)
      {
        writer.WritePropertyName("request");
        Request.SerializeJson(writer, options);
      }

      if (Response != null)
      {
        writer.WritePropertyName("response");
        Response.SerializeJson(writer, options);
      }

      if (Submitter != null)
      {
        writer.WritePropertyName("submitter");
        Submitter.SerializeJson(writer, options);
      }

      if (Payee != null)
      {
        writer.WritePropertyName("payee");
        Payee.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Date))
      {
        writer.WriteString("date", (string)Date!);
      }

      if (_Date != null)
      {
        writer.WritePropertyName("_date");
        _Date.SerializeJson(writer, options);
      }

      if (Amount != null)
      {
        writer.WritePropertyName("amount");
        Amount.SerializeJson(writer, options);
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
        case "amount":
          Amount = new fhirCsR3.Models.Money();
          Amount.DeserializeJson(ref reader, options);
          break;

        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new fhirCsR3.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "payee":
          Payee = new fhirCsR3.Models.Reference();
          Payee.DeserializeJson(ref reader, options);
          break;

        case "request":
          Request = new fhirCsR3.Models.Reference();
          Request.DeserializeJson(ref reader, options);
          break;

        case "response":
          Response = new fhirCsR3.Models.Reference();
          Response.DeserializeJson(ref reader, options);
          break;

        case "submitter":
          Submitter = new fhirCsR3.Models.Reference();
          Submitter.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new fhirCsR3.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
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
  /// Suite of notes.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<PaymentReconciliationProcessNote>))]
  public class PaymentReconciliationProcessNote : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The note text.
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Extension container element for Text
    /// </summary>
    public Element _Text { get; set; }
    /// <summary>
    /// The note purpose: Print/Display.
    /// </summary>
    public CodeableConcept Type { get; set; }
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

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Text))
      {
        writer.WriteString("text", (string)Text!);
      }

      if (_Text != null)
      {
        writer.WritePropertyName("_text");
        _Text.SerializeJson(writer, options);
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
        case "text":
          Text = reader.GetString();
          break;

        case "_text":
          _Text = new fhirCsR3.Models.Element();
          _Text.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new fhirCsR3.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
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
  /// This resource provides payment details and claim references supporting a bulk payment.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<PaymentReconciliation>))]
  public class PaymentReconciliation : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "PaymentReconciliation";
    /// <summary>
    /// The date when the enclosed suite of services were performed or completed.
    /// </summary>
    public string Created { get; set; }
    /// <summary>
    /// Extension container element for Created
    /// </summary>
    public Element _Created { get; set; }
    /// <summary>
    /// List of individual settlement amounts and the corresponding transaction.
    /// </summary>
    public List<PaymentReconciliationDetail> Detail { get; set; }
    /// <summary>
    /// A description of the status of the adjudication.
    /// </summary>
    public string Disposition { get; set; }
    /// <summary>
    /// Extension container element for Disposition
    /// </summary>
    public Element _Disposition { get; set; }
    /// <summary>
    /// The form to be used for printing the content.
    /// </summary>
    public CodeableConcept Form { get; set; }
    /// <summary>
    /// The Response business identifier.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The Insurer who produced this adjudicated response.
    /// </summary>
    public Reference Organization { get; set; }
    /// <summary>
    /// Transaction status: error, complete.
    /// </summary>
    public CodeableConcept Outcome { get; set; }
    /// <summary>
    /// The period of time for which payments have been gathered into this bulk payment for settlement.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// Suite of notes.
    /// </summary>
    public List<PaymentReconciliationProcessNote> ProcessNote { get; set; }
    /// <summary>
    /// Original request resource reference.
    /// </summary>
    public Reference Request { get; set; }
    /// <summary>
    /// The organization which is responsible for the services rendered to the patient.
    /// </summary>
    public Reference RequestOrganization { get; set; }
    /// <summary>
    /// The practitioner who is responsible for the services rendered to the patient.
    /// </summary>
    public Reference RequestProvider { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Total payment amount.
    /// </summary>
    public Money Total { get; set; }
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

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(writer, options);
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

      if (Organization != null)
      {
        writer.WritePropertyName("organization");
        Organization.SerializeJson(writer, options);
      }

      if (Request != null)
      {
        writer.WritePropertyName("request");
        Request.SerializeJson(writer, options);
      }

      if (Outcome != null)
      {
        writer.WritePropertyName("outcome");
        Outcome.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Disposition))
      {
        writer.WriteString("disposition", (string)Disposition!);
      }

      if (_Disposition != null)
      {
        writer.WritePropertyName("_disposition");
        _Disposition.SerializeJson(writer, options);
      }

      if (RequestProvider != null)
      {
        writer.WritePropertyName("requestProvider");
        RequestProvider.SerializeJson(writer, options);
      }

      if (RequestOrganization != null)
      {
        writer.WritePropertyName("requestOrganization");
        RequestOrganization.SerializeJson(writer, options);
      }

      if ((Detail != null) && (Detail.Count != 0))
      {
        writer.WritePropertyName("detail");
        writer.WriteStartArray();

        foreach (PaymentReconciliationDetail valDetail in Detail)
        {
          valDetail.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Form != null)
      {
        writer.WritePropertyName("form");
        Form.SerializeJson(writer, options);
      }

      if (Total != null)
      {
        writer.WritePropertyName("total");
        Total.SerializeJson(writer, options);
      }

      if ((ProcessNote != null) && (ProcessNote.Count != 0))
      {
        writer.WritePropertyName("processNote");
        writer.WriteStartArray();

        foreach (PaymentReconciliationProcessNote valProcessNote in ProcessNote)
        {
          valProcessNote.SerializeJson(writer, options, true);
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
        case "created":
          Created = reader.GetString();
          break;

        case "_created":
          _Created = new fhirCsR3.Models.Element();
          _Created.DeserializeJson(ref reader, options);
          break;

        case "detail":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Detail = new List<PaymentReconciliationDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.PaymentReconciliationDetail objDetail = new fhirCsR3.Models.PaymentReconciliationDetail();
            objDetail.DeserializeJson(ref reader, options);
            Detail.Add(objDetail);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Detail.Count == 0)
          {
            Detail = null;
          }

          break;

        case "disposition":
          Disposition = reader.GetString();
          break;

        case "_disposition":
          _Disposition = new fhirCsR3.Models.Element();
          _Disposition.DeserializeJson(ref reader, options);
          break;

        case "form":
          Form = new fhirCsR3.Models.CodeableConcept();
          Form.DeserializeJson(ref reader, options);
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

        case "organization":
          Organization = new fhirCsR3.Models.Reference();
          Organization.DeserializeJson(ref reader, options);
          break;

        case "outcome":
          Outcome = new fhirCsR3.Models.CodeableConcept();
          Outcome.DeserializeJson(ref reader, options);
          break;

        case "period":
          Period = new fhirCsR3.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "processNote":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ProcessNote = new List<PaymentReconciliationProcessNote>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.PaymentReconciliationProcessNote objProcessNote = new fhirCsR3.Models.PaymentReconciliationProcessNote();
            objProcessNote.DeserializeJson(ref reader, options);
            ProcessNote.Add(objProcessNote);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ProcessNote.Count == 0)
          {
            ProcessNote = null;
          }

          break;

        case "request":
          Request = new fhirCsR3.Models.Reference();
          Request.DeserializeJson(ref reader, options);
          break;

        case "requestOrganization":
          RequestOrganization = new fhirCsR3.Models.Reference();
          RequestOrganization.DeserializeJson(ref reader, options);
          break;

        case "requestProvider":
          RequestProvider = new fhirCsR3.Models.Reference();
          RequestProvider.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR3.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "total":
          Total = new fhirCsR3.Models.Money();
          Total.DeserializeJson(ref reader, options);
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
  /// Code Values for the PaymentReconciliation.status field
  /// </summary>
  public static class PaymentReconciliationStatusCodes {
    public const string ACTIVE = "active";
    public const string CANCELLED = "cancelled";
    public const string DRAFT = "draft";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public static HashSet<string> Values = new HashSet<string>() {
      "active",
      "cancelled",
      "draft",
      "entered-in-error",
    };
  }
}
