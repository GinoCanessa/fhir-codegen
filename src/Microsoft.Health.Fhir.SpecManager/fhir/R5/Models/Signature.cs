// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR5.Serialization;

namespace fhirCsR5.Models
{
  /// <summary>
  /// A signature along with supporting context. The signature may be a digital signature that is cryptographic in nature, or some other signature acceptable to the domain. This other signature may be as simple as a graphical image representing a hand-written signature, or a signature ceremony Different signature approaches have different utilities.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<Signature>))]
  public class Signature : DataType,  IFhirJsonSerializable {
    /// <summary>
    /// Where the signature type is an XML DigSig, the signed content is a FHIR Resource(s), the signature is of the XML form of the Resource(s) using  XML-Signature (XMLDIG) "Detached Signature" form.
    /// </summary>
    public byte[] Data { get; set; }
    /// <summary>
    /// The party that can't sign. For example a child.
    /// </summary>
    public Reference OnBehalfOf { get; set; }
    /// <summary>
    /// A mime type that indicates the technical format of the signature. Important mime types are application/signature+xml for X ML DigSig, application/jose for JWS, and image/* for a graphical image of a signature, etc.
    /// </summary>
    public string SigFormat { get; set; }
    /// <summary>
    /// Extension container element for SigFormat
    /// </summary>
    public Element _SigFormat { get; set; }
    /// <summary>
    /// "xml", "json" and "ttl" are allowed, which describe the simple encodings described in the specification (and imply appropriate bundle support). Otherwise, mime types are legal here.
    /// </summary>
    public string TargetFormat { get; set; }
    /// <summary>
    /// Extension container element for TargetFormat
    /// </summary>
    public Element _TargetFormat { get; set; }
    /// <summary>
    /// Examples include attesting to: authorship, correct transcription, and witness of specific event. Also known as a &amp;quot;Commitment Type Indication&amp;quot;.
    /// </summary>
    public List<Coding> Type { get; set; }
    /// <summary>
    /// This should agree with the information in the signature.
    /// </summary>
    public string When { get; set; }
    /// <summary>
    /// Extension container element for When
    /// </summary>
    public Element _When { get; set; }
    /// <summary>
    /// This should agree with the information in the signature.
    /// </summary>
    public Reference Who { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.DataType)this).SerializeJson(writer, options, false);

      if ((Type != null) && (Type.Count != 0))
      {
        writer.WritePropertyName("type");
        writer.WriteStartArray();

        foreach (Coding valType in Type)
        {
          valType.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(When))
      {
        writer.WriteString("when", (string)When!);
      }

      if (_When != null)
      {
        writer.WritePropertyName("_when");
        _When.SerializeJson(writer, options);
      }

      if (Who != null)
      {
        writer.WritePropertyName("who");
        Who.SerializeJson(writer, options);
      }

      if (OnBehalfOf != null)
      {
        writer.WritePropertyName("onBehalfOf");
        OnBehalfOf.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(TargetFormat))
      {
        writer.WriteString("targetFormat", (string)TargetFormat!);
      }

      if (_TargetFormat != null)
      {
        writer.WritePropertyName("_targetFormat");
        _TargetFormat.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(SigFormat))
      {
        writer.WriteString("sigFormat", (string)SigFormat!);
      }

      if (_SigFormat != null)
      {
        writer.WritePropertyName("_sigFormat");
        _SigFormat.SerializeJson(writer, options);
      }

      if (Data != null)
      {
        writer.WriteBase64String("data", (byte[])Data!);
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
        case "data":
          Data = reader.GetBytesFromBase64();
          break;

        case "onBehalfOf":
          OnBehalfOf = new fhirCsR5.Models.Reference();
          OnBehalfOf.DeserializeJson(ref reader, options);
          break;

        case "sigFormat":
          SigFormat = reader.GetString();
          break;

        case "_sigFormat":
          _SigFormat = new fhirCsR5.Models.Element();
          _SigFormat.DeserializeJson(ref reader, options);
          break;

        case "targetFormat":
          TargetFormat = reader.GetString();
          break;

        case "_targetFormat":
          _TargetFormat = new fhirCsR5.Models.Element();
          _TargetFormat.DeserializeJson(ref reader, options);
          break;

        case "type":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Type = new List<Coding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Coding objType = new fhirCsR5.Models.Coding();
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

        case "when":
          When = reader.GetString();
          break;

        case "_when":
          _When = new fhirCsR5.Models.Element();
          _When.DeserializeJson(ref reader, options);
          break;

        case "who":
          Who = new fhirCsR5.Models.Reference();
          Who.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.DataType)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
}
