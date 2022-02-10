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
  /// The significant Conditions (or condition) that the family member had. This is a repeating section to allow a system to represent more than one condition per resource, though there is nothing stopping multiple resources - one per condition.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<FamilyMemberHistoryCondition>))]
  public class FamilyMemberHistoryCondition : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The actual condition specified. Could be a coded condition (like MI or Diabetes) or a less specific string like 'cancer' depending on how much is known about the condition and the capabilities of the creating system.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// This condition contributed to the cause of death of the related person. If contributedToDeath is not populated, then it is unknown.
    /// </summary>
    public bool? ContributedToDeath { get; set; }
    /// <summary>
    /// Extension container element for ContributedToDeath
    /// </summary>
    public Element _ContributedToDeath { get; set; }
    /// <summary>
    /// An area where general notes can be placed about this specific condition.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// Either the age of onset, range of approximate age or descriptive string can be recorded.  For conditions with multiple occurrences, this describes the first known occurrence.
    /// </summary>
    public Age OnsetAge { get; set; }
    /// <summary>
    /// Either the age of onset, range of approximate age or descriptive string can be recorded.  For conditions with multiple occurrences, this describes the first known occurrence.
    /// </summary>
    public Range OnsetRange { get; set; }
    /// <summary>
    /// Either the age of onset, range of approximate age or descriptive string can be recorded.  For conditions with multiple occurrences, this describes the first known occurrence.
    /// </summary>
    public Period OnsetPeriod { get; set; }
    /// <summary>
    /// Either the age of onset, range of approximate age or descriptive string can be recorded.  For conditions with multiple occurrences, this describes the first known occurrence.
    /// </summary>
    public string OnsetString { get; set; }
    /// <summary>
    /// Extension container element for OnsetString
    /// </summary>
    public Element _OnsetString { get; set; }
    /// <summary>
    /// Indicates what happened following the condition.  If the condition resulted in death, deceased date is captured on the relation.
    /// </summary>
    public CodeableConcept Outcome { get; set; }
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

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if (Outcome != null)
      {
        writer.WritePropertyName("outcome");
        Outcome.SerializeJson(writer, options);
      }

      if (ContributedToDeath != null)
      {
        writer.WriteBoolean("contributedToDeath", (bool)ContributedToDeath!);
      }

      if (_ContributedToDeath != null)
      {
        writer.WritePropertyName("_contributedToDeath");
        _ContributedToDeath.SerializeJson(writer, options);
      }

      if (OnsetAge != null)
      {
        writer.WritePropertyName("onsetAge");
        OnsetAge.SerializeJson(writer, options);
      }

      if (OnsetRange != null)
      {
        writer.WritePropertyName("onsetRange");
        OnsetRange.SerializeJson(writer, options);
      }

      if (OnsetPeriod != null)
      {
        writer.WritePropertyName("onsetPeriod");
        OnsetPeriod.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(OnsetString))
      {
        writer.WriteString("onsetString", (string)OnsetString!);
      }

      if (_OnsetString != null)
      {
        writer.WritePropertyName("_onsetString");
        _OnsetString.SerializeJson(writer, options);
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
        case "code":
          Code = new fhirCsR4.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "contributedToDeath":
          ContributedToDeath = reader.GetBoolean();
          break;

        case "_contributedToDeath":
          _ContributedToDeath = new fhirCsR4.Models.Element();
          _ContributedToDeath.DeserializeJson(ref reader, options);
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Annotation objNote = new fhirCsR4.Models.Annotation();
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

        case "onsetAge":
          OnsetAge = new fhirCsR4.Models.Age();
          OnsetAge.DeserializeJson(ref reader, options);
          break;

        case "onsetRange":
          OnsetRange = new fhirCsR4.Models.Range();
          OnsetRange.DeserializeJson(ref reader, options);
          break;

        case "onsetPeriod":
          OnsetPeriod = new fhirCsR4.Models.Period();
          OnsetPeriod.DeserializeJson(ref reader, options);
          break;

        case "onsetString":
          OnsetString = reader.GetString();
          break;

        case "_onsetString":
          _OnsetString = new fhirCsR4.Models.Element();
          _OnsetString.DeserializeJson(ref reader, options);
          break;

        case "outcome":
          Outcome = new fhirCsR4.Models.CodeableConcept();
          Outcome.DeserializeJson(ref reader, options);
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
  /// Significant health conditions for a person related to the patient relevant in the context of care for the patient.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<FamilyMemberHistory>))]
  public class FamilyMemberHistory : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "FamilyMemberHistory";
    /// <summary>
    /// use estimatedAge to indicate whether the age is actual or not.
    /// </summary>
    public Age AgeAge { get; set; }
    /// <summary>
    /// use estimatedAge to indicate whether the age is actual or not.
    /// </summary>
    public Range AgeRange { get; set; }
    /// <summary>
    /// use estimatedAge to indicate whether the age is actual or not.
    /// </summary>
    public string AgeString { get; set; }
    /// <summary>
    /// Extension container element for AgeString
    /// </summary>
    public Element _AgeString { get; set; }
    /// <summary>
    /// The actual or approximate date of birth of the relative.
    /// </summary>
    public Period BornPeriod { get; set; }
    /// <summary>
    /// The actual or approximate date of birth of the relative.
    /// </summary>
    public string BornDate { get; set; }
    /// <summary>
    /// Extension container element for BornDate
    /// </summary>
    public Element _BornDate { get; set; }
    /// <summary>
    /// The actual or approximate date of birth of the relative.
    /// </summary>
    public string BornString { get; set; }
    /// <summary>
    /// Extension container element for BornString
    /// </summary>
    public Element _BornString { get; set; }
    /// <summary>
    /// The significant Conditions (or condition) that the family member had. This is a repeating section to allow a system to represent more than one condition per resource, though there is nothing stopping multiple resources - one per condition.
    /// </summary>
    public List<FamilyMemberHistoryCondition> Condition { get; set; }
    /// <summary>
    /// Describes why the family member's history is not available.
    /// </summary>
    public CodeableConcept DataAbsentReason { get; set; }
    /// <summary>
    /// This should be captured even if the same as the date on the List aggregating the full family history.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// Deceased flag or the actual or approximate age of the relative at the time of death for the family member history record.
    /// </summary>
    public bool? DeceasedBoolean { get; set; }
    /// <summary>
    /// Extension container element for DeceasedBoolean
    /// </summary>
    public Element _DeceasedBoolean { get; set; }
    /// <summary>
    /// Deceased flag or the actual or approximate age of the relative at the time of death for the family member history record.
    /// </summary>
    public Age DeceasedAge { get; set; }
    /// <summary>
    /// Deceased flag or the actual or approximate age of the relative at the time of death for the family member history record.
    /// </summary>
    public Range DeceasedRange { get; set; }
    /// <summary>
    /// Deceased flag or the actual or approximate age of the relative at the time of death for the family member history record.
    /// </summary>
    public string DeceasedDate { get; set; }
    /// <summary>
    /// Extension container element for DeceasedDate
    /// </summary>
    public Element _DeceasedDate { get; set; }
    /// <summary>
    /// Deceased flag or the actual or approximate age of the relative at the time of death for the family member history record.
    /// </summary>
    public string DeceasedString { get; set; }
    /// <summary>
    /// Extension container element for DeceasedString
    /// </summary>
    public Element _DeceasedString { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the fact that age is estimated can/should change the results of any algorithm that calculates based on the specified age.
    /// </summary>
    public bool? EstimatedAge { get; set; }
    /// <summary>
    /// Extension container element for EstimatedAge
    /// </summary>
    public Element _EstimatedAge { get; set; }
    /// <summary>
    /// This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The URL pointing to a FHIR-defined protocol, guideline, orderset or other definition that is adhered to in whole or in part by this FamilyMemberHistory.
    /// </summary>
    public List<string> InstantiatesCanonical { get; set; }
    /// <summary>
    /// Extension container element for InstantiatesCanonical
    /// </summary>
    public List<Element> _InstantiatesCanonical { get; set; }
    /// <summary>
    /// This might be an HTML page, PDF, etc. or could just be a non-resolvable URI identifier.
    /// </summary>
    public List<string> InstantiatesUri { get; set; }
    /// <summary>
    /// Extension container element for InstantiatesUri
    /// </summary>
    public List<Element> _InstantiatesUri { get; set; }
    /// <summary>
    /// This will either be a name or a description; e.g. "Aunt Susan", "my cousin with the red hair".
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Extension container element for Name
    /// </summary>
    public Element _Name { get; set; }
    /// <summary>
    /// This property allows a non condition-specific note to the made about the related person. Ideally, the note would be in the condition property, but this is not always possible.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// The person who this history concerns.
    /// </summary>
    public Reference Patient { get; set; }
    /// <summary>
    /// Textual reasons can be captured using reasonCode.text.
    /// </summary>
    public List<CodeableConcept> ReasonCode { get; set; }
    /// <summary>
    /// Indicates a Condition, Observation, AllergyIntolerance, or QuestionnaireResponse that justifies this family member history event.
    /// </summary>
    public List<Reference> ReasonReference { get; set; }
    /// <summary>
    /// The type of relationship this person has to the patient (father, mother, brother etc.).
    /// </summary>
    public CodeableConcept Relationship { get; set; }
    /// <summary>
    /// This element should ideally reflect whether the individual is genetically male or female.  However, as reported information based on the knowledge of the patient or reporting friend/relative, there may be situations where the reported sex might not be totally accurate.  E.g. 'Aunt Sue' might be XY rather than XX.  Questions soliciting this information should be phrased to encourage capture of genetic sex where known.  However, systems performing analysis should also allow for the possibility of imprecision with this element.
    /// </summary>
    public CodeableConcept Sex { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.
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

      if ((InstantiatesCanonical != null) && (InstantiatesCanonical.Count != 0))
      {
        writer.WritePropertyName("instantiatesCanonical");
        writer.WriteStartArray();

        foreach (string valInstantiatesCanonical in InstantiatesCanonical)
        {
          writer.WriteStringValue(valInstantiatesCanonical);
        }

        writer.WriteEndArray();
      }

      if ((_InstantiatesCanonical != null) && (_InstantiatesCanonical.Count != 0))
      {
        writer.WritePropertyName("_instantiatesCanonical");
        writer.WriteStartArray();

        foreach (Element val_InstantiatesCanonical in _InstantiatesCanonical)
        {
          val_InstantiatesCanonical.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((InstantiatesUri != null) && (InstantiatesUri.Count != 0))
      {
        writer.WritePropertyName("instantiatesUri");
        writer.WriteStartArray();

        foreach (string valInstantiatesUri in InstantiatesUri)
        {
          writer.WriteStringValue(valInstantiatesUri);
        }

        writer.WriteEndArray();
      }

      if ((_InstantiatesUri != null) && (_InstantiatesUri.Count != 0))
      {
        writer.WritePropertyName("_instantiatesUri");
        writer.WriteStartArray();

        foreach (Element val_InstantiatesUri in _InstantiatesUri)
        {
          val_InstantiatesUri.SerializeJson(writer, options, true);
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

      if (DataAbsentReason != null)
      {
        writer.WritePropertyName("dataAbsentReason");
        DataAbsentReason.SerializeJson(writer, options);
      }

      if (Patient != null)
      {
        writer.WritePropertyName("patient");
        Patient.SerializeJson(writer, options);
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

      if (!string.IsNullOrEmpty(Name))
      {
        writer.WriteString("name", (string)Name!);
      }

      if (_Name != null)
      {
        writer.WritePropertyName("_name");
        _Name.SerializeJson(writer, options);
      }

      if (Relationship != null)
      {
        writer.WritePropertyName("relationship");
        Relationship.SerializeJson(writer, options);
      }

      if (Sex != null)
      {
        writer.WritePropertyName("sex");
        Sex.SerializeJson(writer, options);
      }

      if (BornPeriod != null)
      {
        writer.WritePropertyName("bornPeriod");
        BornPeriod.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(BornDate))
      {
        writer.WriteString("bornDate", (string)BornDate!);
      }

      if (_BornDate != null)
      {
        writer.WritePropertyName("_bornDate");
        _BornDate.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(BornString))
      {
        writer.WriteString("bornString", (string)BornString!);
      }

      if (_BornString != null)
      {
        writer.WritePropertyName("_bornString");
        _BornString.SerializeJson(writer, options);
      }

      if (AgeAge != null)
      {
        writer.WritePropertyName("ageAge");
        AgeAge.SerializeJson(writer, options);
      }

      if (AgeRange != null)
      {
        writer.WritePropertyName("ageRange");
        AgeRange.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(AgeString))
      {
        writer.WriteString("ageString", (string)AgeString!);
      }

      if (_AgeString != null)
      {
        writer.WritePropertyName("_ageString");
        _AgeString.SerializeJson(writer, options);
      }

      if (EstimatedAge != null)
      {
        writer.WriteBoolean("estimatedAge", (bool)EstimatedAge!);
      }

      if (_EstimatedAge != null)
      {
        writer.WritePropertyName("_estimatedAge");
        _EstimatedAge.SerializeJson(writer, options);
      }

      if (DeceasedBoolean != null)
      {
        writer.WriteBoolean("deceasedBoolean", (bool)DeceasedBoolean!);
      }

      if (_DeceasedBoolean != null)
      {
        writer.WritePropertyName("_deceasedBoolean");
        _DeceasedBoolean.SerializeJson(writer, options);
      }

      if (DeceasedAge != null)
      {
        writer.WritePropertyName("deceasedAge");
        DeceasedAge.SerializeJson(writer, options);
      }

      if (DeceasedRange != null)
      {
        writer.WritePropertyName("deceasedRange");
        DeceasedRange.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(DeceasedDate))
      {
        writer.WriteString("deceasedDate", (string)DeceasedDate!);
      }

      if (_DeceasedDate != null)
      {
        writer.WritePropertyName("_deceasedDate");
        _DeceasedDate.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(DeceasedString))
      {
        writer.WriteString("deceasedString", (string)DeceasedString!);
      }

      if (_DeceasedString != null)
      {
        writer.WritePropertyName("_deceasedString");
        _DeceasedString.SerializeJson(writer, options);
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

      if ((Condition != null) && (Condition.Count != 0))
      {
        writer.WritePropertyName("condition");
        writer.WriteStartArray();

        foreach (FamilyMemberHistoryCondition valCondition in Condition)
        {
          valCondition.SerializeJson(writer, options, true);
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
        case "ageAge":
          AgeAge = new fhirCsR4.Models.Age();
          AgeAge.DeserializeJson(ref reader, options);
          break;

        case "ageRange":
          AgeRange = new fhirCsR4.Models.Range();
          AgeRange.DeserializeJson(ref reader, options);
          break;

        case "ageString":
          AgeString = reader.GetString();
          break;

        case "_ageString":
          _AgeString = new fhirCsR4.Models.Element();
          _AgeString.DeserializeJson(ref reader, options);
          break;

        case "bornPeriod":
          BornPeriod = new fhirCsR4.Models.Period();
          BornPeriod.DeserializeJson(ref reader, options);
          break;

        case "bornDate":
          BornDate = reader.GetString();
          break;

        case "_bornDate":
          _BornDate = new fhirCsR4.Models.Element();
          _BornDate.DeserializeJson(ref reader, options);
          break;

        case "bornString":
          BornString = reader.GetString();
          break;

        case "_bornString":
          _BornString = new fhirCsR4.Models.Element();
          _BornString.DeserializeJson(ref reader, options);
          break;

        case "condition":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Condition = new List<FamilyMemberHistoryCondition>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.FamilyMemberHistoryCondition objCondition = new fhirCsR4.Models.FamilyMemberHistoryCondition();
            objCondition.DeserializeJson(ref reader, options);
            Condition.Add(objCondition);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Condition.Count == 0)
          {
            Condition = null;
          }

          break;

        case "dataAbsentReason":
          DataAbsentReason = new fhirCsR4.Models.CodeableConcept();
          DataAbsentReason.DeserializeJson(ref reader, options);
          break;

        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new fhirCsR4.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "deceasedBoolean":
          DeceasedBoolean = reader.GetBoolean();
          break;

        case "_deceasedBoolean":
          _DeceasedBoolean = new fhirCsR4.Models.Element();
          _DeceasedBoolean.DeserializeJson(ref reader, options);
          break;

        case "deceasedAge":
          DeceasedAge = new fhirCsR4.Models.Age();
          DeceasedAge.DeserializeJson(ref reader, options);
          break;

        case "deceasedRange":
          DeceasedRange = new fhirCsR4.Models.Range();
          DeceasedRange.DeserializeJson(ref reader, options);
          break;

        case "deceasedDate":
          DeceasedDate = reader.GetString();
          break;

        case "_deceasedDate":
          _DeceasedDate = new fhirCsR4.Models.Element();
          _DeceasedDate.DeserializeJson(ref reader, options);
          break;

        case "deceasedString":
          DeceasedString = reader.GetString();
          break;

        case "_deceasedString":
          _DeceasedString = new fhirCsR4.Models.Element();
          _DeceasedString.DeserializeJson(ref reader, options);
          break;

        case "estimatedAge":
          EstimatedAge = reader.GetBoolean();
          break;

        case "_estimatedAge":
          _EstimatedAge = new fhirCsR4.Models.Element();
          _EstimatedAge.DeserializeJson(ref reader, options);
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

        case "instantiatesCanonical":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          InstantiatesCanonical = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            InstantiatesCanonical.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (InstantiatesCanonical.Count == 0)
          {
            InstantiatesCanonical = null;
          }

          break;

        case "_instantiatesCanonical":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _InstantiatesCanonical = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Element obj_InstantiatesCanonical = new fhirCsR4.Models.Element();
            obj_InstantiatesCanonical.DeserializeJson(ref reader, options);
            _InstantiatesCanonical.Add(obj_InstantiatesCanonical);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_InstantiatesCanonical.Count == 0)
          {
            _InstantiatesCanonical = null;
          }

          break;

        case "instantiatesUri":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          InstantiatesUri = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            InstantiatesUri.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (InstantiatesUri.Count == 0)
          {
            InstantiatesUri = null;
          }

          break;

        case "_instantiatesUri":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _InstantiatesUri = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Element obj_InstantiatesUri = new fhirCsR4.Models.Element();
            obj_InstantiatesUri.DeserializeJson(ref reader, options);
            _InstantiatesUri.Add(obj_InstantiatesUri);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_InstantiatesUri.Count == 0)
          {
            _InstantiatesUri = null;
          }

          break;

        case "name":
          Name = reader.GetString();
          break;

        case "_name":
          _Name = new fhirCsR4.Models.Element();
          _Name.DeserializeJson(ref reader, options);
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Annotation objNote = new fhirCsR4.Models.Annotation();
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

        case "patient":
          Patient = new fhirCsR4.Models.Reference();
          Patient.DeserializeJson(ref reader, options);
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

        case "relationship":
          Relationship = new fhirCsR4.Models.CodeableConcept();
          Relationship.DeserializeJson(ref reader, options);
          break;

        case "sex":
          Sex = new fhirCsR4.Models.CodeableConcept();
          Sex.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
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
  /// Code Values for the FamilyMemberHistory.status field
  /// </summary>
  public static class FamilyMemberHistoryStatusCodes {
    public const string PARTIAL = "partial";
    public const string COMPLETED = "completed";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public const string HEALTH_UNKNOWN = "health-unknown";
    public static HashSet<string> Values = new HashSet<string>() {
      "partial",
      "completed",
      "entered-in-error",
      "health-unknown",
    };
  }
}
