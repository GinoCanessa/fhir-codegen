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
  /// A resource that includes narrative, extensions, and contained resources.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamResourceConverter))]
  public class DomainResource : Resource,  IFhirJsonSerializable {
    /// <summary>
    /// This should never be done when the content can be identified properly, as once identification is lost, it is extremely difficult (and context dependent) to restore it again. Contained resources may have profiles and tags In their meta elements, but SHALL NOT have security labels.
    /// </summary>
    public List<Resource> Contained { get; set; }
    /// <summary>
    /// There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.
    /// </summary>
    public List<Extension> Extension { get; set; }
    /// <summary>
    /// There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.
    /// </summary>
    public List<Extension> ModifierExtension { get; set; }
    /// <summary>
    /// Contained resources do not have a narrative. Resources that are not contained SHOULD have a narrative. In some cases, a resource may only have text with little or no additional discrete data (as long as all minOccurs=1 elements are satisfied).  This may be necessary for data from legacy systems where information is captured as a "text blob" or where text is additionally entered raw or narrated and encoded information is added later.
    /// </summary>
    public Narrative Text { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.Resource)this).SerializeJson(writer, options, false);

      if (Text != null)
      {
        writer.WritePropertyName("text");
        Text.SerializeJson(writer, options);
      }

      if ((Contained != null) && (Contained.Count != 0))
      {
        writer.WritePropertyName("contained");
        writer.WriteStartArray();

        foreach (dynamic resource in Contained)
        {
          resource.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
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

      if ((ModifierExtension != null) && (ModifierExtension.Count != 0))
      {
        writer.WritePropertyName("modifierExtension");
        writer.WriteStartArray();

        foreach (Extension valModifierExtension in ModifierExtension)
        {
          valModifierExtension.SerializeJson(writer, options, true);
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
        case "contained":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Contained = new List<Resource>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Resource resource = JsonSerializer.Deserialize<fhirCsR5.Models.Resource>(ref reader, options);
            Contained.Add(resource);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Contained.Count == 0)
          {
            Contained = null;
          }

          break;

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

        case "modifierExtension":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ModifierExtension = new List<Extension>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Extension objModifierExtension = new fhirCsR5.Models.Extension();
            objModifierExtension.DeserializeJson(ref reader, options);
            ModifierExtension.Add(objModifierExtension);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ModifierExtension.Count == 0)
          {
            ModifierExtension = null;
          }

          break;

        case "text":
          Text = new fhirCsR5.Models.Narrative();
          Text.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.Resource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
