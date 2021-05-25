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
  /// Base definition for all elements in a resource.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<Element>))]
  public class Element : IFhirJsonSerializable {
    /// <summary>
    /// There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.
    /// </summary>
    public List<Extension> Extension { get; set; }
    /// <summary>
    /// Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Extension container element for Id
    /// </summary>
    public Element _Id { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(Id))
      {
        writer.WriteString("id", (string)Id!);
      }

      if (_Id != null)
      {
        writer.WritePropertyName("_id");
        _Id.SerializeJson(writer, options);
      }

      if ((Extension != null) && (Extension.Count != 0))
      {
        writer.WritePropertyName("extension");
        writer.WriteStartArray();

        foreach (Extension valExtension in Extension)
        {
          valExtension.SerializeJson(writer, options, true);
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
    public void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "extension":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Extension = new List<Extension>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Extension objExtension = new fhirCsR5.Models.Extension();
            objExtension.DeserializeJson(ref reader, options);
            Extension.Add(objExtension);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Extension.Count == 0)
          {
            Extension = null;
          }

          break;

        case "id":
          Id = reader.GetString();
          break;

        case "_id":
          _Id = new fhirCsR5.Models.Element();
          _Id.DeserializeJson(ref reader, options);
          break;

      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
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
