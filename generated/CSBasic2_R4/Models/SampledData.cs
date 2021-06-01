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
  /// A series of measurements taken by a device, with upper and lower limits. There may be more than one dimension in the data.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<SampledData>))]
  public class SampledData : Element,  IFhirJsonSerializable {
    /// <summary>
    /// Data may be missing if it is omitted for summarization purposes. In general, data is required for any actual use of a SampledData.
    /// </summary>
    public string Data { get; set; }
    /// <summary>
    /// Extension container element for Data
    /// </summary>
    public Element _Data { get; set; }
    /// <summary>
    /// If there is more than one dimension, the code for the type of data will define the meaning of the dimensions (typically ECG data).
    /// </summary>
    public uint Dimensions { get; set; }
    /// <summary>
    /// A correction factor that is applied to the sampled data points before they are added to the origin.
    /// </summary>
    public decimal? Factor { get; set; }
    /// <summary>
    /// Extension container element for Factor
    /// </summary>
    public Element _Factor { get; set; }
    /// <summary>
    /// The lower limit of detection of the measured points. This is needed if any of the data points have the value "L" (lower than detection limit).
    /// </summary>
    public decimal? LowerLimit { get; set; }
    /// <summary>
    /// Extension container element for LowerLimit
    /// </summary>
    public Element _LowerLimit { get; set; }
    /// <summary>
    /// The base quantity that a measured value of zero represents. In addition, this provides the units of the entire measurement series.
    /// </summary>
    public Quantity Origin { get; set; }
    /// <summary>
    /// This is usually a whole number.
    /// </summary>
    public decimal Period { get; set; }
    /// <summary>
    /// Extension container element for Period
    /// </summary>
    public Element _Period { get; set; }
    /// <summary>
    /// The upper limit of detection of the measured points. This is needed if any of the data points have the value "U" (higher than detection limit).
    /// </summary>
    public decimal? UpperLimit { get; set; }
    /// <summary>
    /// Extension container element for UpperLimit
    /// </summary>
    public Element _UpperLimit { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4.Models.Element)this).SerializeJson(writer, options, false);

      if (Origin != null)
      {
        writer.WritePropertyName("origin");
        Origin.SerializeJson(writer, options);
      }

      writer.WriteNumber("period", Period);

      if (_Period != null)
      {
        writer.WritePropertyName("_period");
        _Period.SerializeJson(writer, options);
      }

      if (Factor != null)
      {
        writer.WriteNumber("factor", (decimal)Factor!);
      }

      if (_Factor != null)
      {
        writer.WritePropertyName("_factor");
        _Factor.SerializeJson(writer, options);
      }

      if (LowerLimit != null)
      {
        writer.WriteNumber("lowerLimit", (decimal)LowerLimit!);
      }

      if (_LowerLimit != null)
      {
        writer.WritePropertyName("_lowerLimit");
        _LowerLimit.SerializeJson(writer, options);
      }

      if (UpperLimit != null)
      {
        writer.WriteNumber("upperLimit", (decimal)UpperLimit!);
      }

      if (_UpperLimit != null)
      {
        writer.WritePropertyName("_upperLimit");
        _UpperLimit.SerializeJson(writer, options);
      }

      writer.WriteNumber("dimensions", Dimensions);

      if (!string.IsNullOrEmpty(Data))
      {
        writer.WriteString("data", (string)Data!);
      }

      if (_Data != null)
      {
        writer.WritePropertyName("_data");
        _Data.SerializeJson(writer, options);
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
          Data = reader.GetString();
          break;

        case "_data":
          _Data = new fhirCsR4.Models.Element();
          _Data.DeserializeJson(ref reader, options);
          break;

        case "dimensions":
          Dimensions = reader.GetUInt32();
          break;

        case "factor":
          Factor = reader.GetDecimal();
          break;

        case "_factor":
          _Factor = new fhirCsR4.Models.Element();
          _Factor.DeserializeJson(ref reader, options);
          break;

        case "lowerLimit":
          LowerLimit = reader.GetDecimal();
          break;

        case "_lowerLimit":
          _LowerLimit = new fhirCsR4.Models.Element();
          _LowerLimit.DeserializeJson(ref reader, options);
          break;

        case "origin":
          Origin = new fhirCsR4.Models.Quantity();
          Origin.DeserializeJson(ref reader, options);
          break;

        case "period":
          Period = reader.GetDecimal();
          break;

        case "_period":
          _Period = new fhirCsR4.Models.Element();
          _Period.DeserializeJson(ref reader, options);
          break;

        case "upperLimit":
          UpperLimit = reader.GetDecimal();
          break;

        case "_upperLimit":
          _UpperLimit = new fhirCsR4.Models.Element();
          _UpperLimit.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4.Models.Element)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
