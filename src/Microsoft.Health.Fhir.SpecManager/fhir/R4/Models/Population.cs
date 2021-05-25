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
  /// A populatioof people with some set of grouping criteria.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<Population>))]
  public class Population : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The age of the specific population.
    /// </summary>
    public Range AgeRange { get; set; }
    /// <summary>
    /// The age of the specific population.
    /// </summary>
    public CodeableConcept AgeCodeableConcept { get; set; }
    /// <summary>
    /// The gender of the specific population.
    /// </summary>
    public CodeableConcept Gender { get; set; }
    /// <summary>
    /// The existing physiological conditions of the specific population to which this applies.
    /// </summary>
    public CodeableConcept PhysiologicalCondition { get; set; }
    /// <summary>
    /// Race of the specific population.
    /// </summary>
    public CodeableConcept Race { get; set; }
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

      if (AgeRange != null)
      {
        writer.WritePropertyName("ageRange");
        AgeRange.SerializeJson(writer, options);
      }

      if (AgeCodeableConcept != null)
      {
        writer.WritePropertyName("ageCodeableConcept");
        AgeCodeableConcept.SerializeJson(writer, options);
      }

      if (Gender != null)
      {
        writer.WritePropertyName("gender");
        Gender.SerializeJson(writer, options);
      }

      if (Race != null)
      {
        writer.WritePropertyName("race");
        Race.SerializeJson(writer, options);
      }

      if (PhysiologicalCondition != null)
      {
        writer.WritePropertyName("physiologicalCondition");
        PhysiologicalCondition.SerializeJson(writer, options);
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
        case "ageRange":
          AgeRange = new fhirCsR4.Models.Range();
          AgeRange.DeserializeJson(ref reader, options);
          break;

        case "ageCodeableConcept":
          AgeCodeableConcept = new fhirCsR4.Models.CodeableConcept();
          AgeCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "gender":
          Gender = new fhirCsR4.Models.CodeableConcept();
          Gender.DeserializeJson(ref reader, options);
          break;

        case "physiologicalCondition":
          PhysiologicalCondition = new fhirCsR4.Models.CodeableConcept();
          PhysiologicalCondition.DeserializeJson(ref reader, options);
          break;

        case "race":
          Race = new fhirCsR4.Models.CodeableConcept();
          Race.DeserializeJson(ref reader, options);
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
}
