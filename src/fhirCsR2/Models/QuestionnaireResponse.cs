// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR2.Serialization;

namespace fhirCsR2.Models
{
  /// <summary>
  /// The respondent's answer(s) to the question.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<QuestionnaireResponseGroupQuestionAnswer>))]
  public class QuestionnaireResponseGroupQuestionAnswer : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// It is useful to have "sub-questions", questions which normally appear when certain answers are given and which collect additional details.
    /// </summary>
    public List<QuestionnaireResponseGroup> Group { get; set; }
    /// <summary>
    /// Ability to retain a single-valued answer to a question.
    /// </summary>
    public bool? ValueBoolean { get; set; }
    /// <summary>
    /// Extension container element for ValueBoolean
    /// </summary>
    public Element _ValueBoolean { get; set; }
    /// <summary>
    /// Ability to retain a single-valued answer to a question.
    /// </summary>
    public decimal? ValueDecimal { get; set; }
    /// <summary>
    /// Extension container element for ValueDecimal
    /// </summary>
    public Element _ValueDecimal { get; set; }
    /// <summary>
    /// Ability to retain a single-valued answer to a question.
    /// </summary>
    public int? ValueInteger { get; set; }
    /// <summary>
    /// Extension container element for ValueInteger
    /// </summary>
    public Element _ValueInteger { get; set; }
    /// <summary>
    /// Ability to retain a single-valued answer to a question.
    /// </summary>
    public string ValueDate { get; set; }
    /// <summary>
    /// Extension container element for ValueDate
    /// </summary>
    public Element _ValueDate { get; set; }
    /// <summary>
    /// Ability to retain a single-valued answer to a question.
    /// </summary>
    public string ValueDateTime { get; set; }
    /// <summary>
    /// Extension container element for ValueDateTime
    /// </summary>
    public Element _ValueDateTime { get; set; }
    /// <summary>
    /// Ability to retain a single-valued answer to a question.
    /// </summary>
    public string ValueInstant { get; set; }
    /// <summary>
    /// Extension container element for ValueInstant
    /// </summary>
    public Element _ValueInstant { get; set; }
    /// <summary>
    /// Ability to retain a single-valued answer to a question.
    /// </summary>
    public string ValueTime { get; set; }
    /// <summary>
    /// Extension container element for ValueTime
    /// </summary>
    public Element _ValueTime { get; set; }
    /// <summary>
    /// Ability to retain a single-valued answer to a question.
    /// </summary>
    public string ValueString { get; set; }
    /// <summary>
    /// Extension container element for ValueString
    /// </summary>
    public Element _ValueString { get; set; }
    /// <summary>
    /// Ability to retain a single-valued answer to a question.
    /// </summary>
    public string ValueUri { get; set; }
    /// <summary>
    /// Extension container element for ValueUri
    /// </summary>
    public Element _ValueUri { get; set; }
    /// <summary>
    /// Ability to retain a single-valued answer to a question.
    /// </summary>
    public Attachment ValueAttachment { get; set; }
    /// <summary>
    /// Ability to retain a single-valued answer to a question.
    /// </summary>
    public Coding ValueCoding { get; set; }
    /// <summary>
    /// Ability to retain a single-valued answer to a question.
    /// </summary>
    public Quantity ValueQuantity { get; set; }
    /// <summary>
    /// Ability to retain a single-valued answer to a question.
    /// </summary>
    public Reference ValueReference { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR2.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (ValueBoolean != null)
      {
        writer.WriteBoolean("valueBoolean", (bool)ValueBoolean!);
      }

      if (_ValueBoolean != null)
      {
        writer.WritePropertyName("_valueBoolean");
        _ValueBoolean.SerializeJson(writer, options);
      }

      if (ValueDecimal != null)
      {
        writer.WriteNumber("valueDecimal", (decimal)ValueDecimal!);
      }

      if (_ValueDecimal != null)
      {
        writer.WritePropertyName("_valueDecimal");
        _ValueDecimal.SerializeJson(writer, options);
      }

      if (ValueInteger != null)
      {
        writer.WriteNumber("valueInteger", (int)ValueInteger!);
      }

      if (_ValueInteger != null)
      {
        writer.WritePropertyName("_valueInteger");
        _ValueInteger.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ValueDate))
      {
        writer.WriteString("valueDate", (string)ValueDate!);
      }

      if (_ValueDate != null)
      {
        writer.WritePropertyName("_valueDate");
        _ValueDate.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ValueDateTime))
      {
        writer.WriteString("valueDateTime", (string)ValueDateTime!);
      }

      if (_ValueDateTime != null)
      {
        writer.WritePropertyName("_valueDateTime");
        _ValueDateTime.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ValueInstant))
      {
        writer.WriteString("valueInstant", (string)ValueInstant!);
      }

      if (_ValueInstant != null)
      {
        writer.WritePropertyName("_valueInstant");
        _ValueInstant.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ValueTime))
      {
        writer.WriteString("valueTime", (string)ValueTime!);
      }

      if (_ValueTime != null)
      {
        writer.WritePropertyName("_valueTime");
        _ValueTime.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ValueString))
      {
        writer.WriteString("valueString", (string)ValueString!);
      }

      if (_ValueString != null)
      {
        writer.WritePropertyName("_valueString");
        _ValueString.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ValueUri))
      {
        writer.WriteString("valueUri", (string)ValueUri!);
      }

      if (_ValueUri != null)
      {
        writer.WritePropertyName("_valueUri");
        _ValueUri.SerializeJson(writer, options);
      }

      if (ValueAttachment != null)
      {
        writer.WritePropertyName("valueAttachment");
        ValueAttachment.SerializeJson(writer, options);
      }

      if (ValueCoding != null)
      {
        writer.WritePropertyName("valueCoding");
        ValueCoding.SerializeJson(writer, options);
      }

      if (ValueQuantity != null)
      {
        writer.WritePropertyName("valueQuantity");
        ValueQuantity.SerializeJson(writer, options);
      }

      if (ValueReference != null)
      {
        writer.WritePropertyName("valueReference");
        ValueReference.SerializeJson(writer, options);
      }

      if ((Group != null) && (Group.Count != 0))
      {
        writer.WritePropertyName("group");
        writer.WriteStartArray();

        foreach (QuestionnaireResponseGroup valGroup in Group)
        {
          valGroup.SerializeJson(writer, options, true);
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
        case "group":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Group = new List<QuestionnaireResponseGroup>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.QuestionnaireResponseGroup objGroup = new fhirCsR2.Models.QuestionnaireResponseGroup();
            objGroup.DeserializeJson(ref reader, options);
            Group.Add(objGroup);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Group.Count == 0)
          {
            Group = null;
          }

          break;

        case "valueBoolean":
          ValueBoolean = reader.GetBoolean();
          break;

        case "_valueBoolean":
          _ValueBoolean = new fhirCsR2.Models.Element();
          _ValueBoolean.DeserializeJson(ref reader, options);
          break;

        case "valueDecimal":
          ValueDecimal = reader.GetDecimal();
          break;

        case "_valueDecimal":
          _ValueDecimal = new fhirCsR2.Models.Element();
          _ValueDecimal.DeserializeJson(ref reader, options);
          break;

        case "valueInteger":
          ValueInteger = reader.GetInt32();
          break;

        case "_valueInteger":
          _ValueInteger = new fhirCsR2.Models.Element();
          _ValueInteger.DeserializeJson(ref reader, options);
          break;

        case "valueDate":
          ValueDate = reader.GetString();
          break;

        case "_valueDate":
          _ValueDate = new fhirCsR2.Models.Element();
          _ValueDate.DeserializeJson(ref reader, options);
          break;

        case "valueDateTime":
          ValueDateTime = reader.GetString();
          break;

        case "_valueDateTime":
          _ValueDateTime = new fhirCsR2.Models.Element();
          _ValueDateTime.DeserializeJson(ref reader, options);
          break;

        case "valueInstant":
          ValueInstant = reader.GetString();
          break;

        case "_valueInstant":
          _ValueInstant = new fhirCsR2.Models.Element();
          _ValueInstant.DeserializeJson(ref reader, options);
          break;

        case "valueTime":
          ValueTime = reader.GetString();
          break;

        case "_valueTime":
          _ValueTime = new fhirCsR2.Models.Element();
          _ValueTime.DeserializeJson(ref reader, options);
          break;

        case "valueString":
          ValueString = reader.GetString();
          break;

        case "_valueString":
          _ValueString = new fhirCsR2.Models.Element();
          _ValueString.DeserializeJson(ref reader, options);
          break;

        case "valueUri":
          ValueUri = reader.GetString();
          break;

        case "_valueUri":
          _ValueUri = new fhirCsR2.Models.Element();
          _ValueUri.DeserializeJson(ref reader, options);
          break;

        case "valueAttachment":
          ValueAttachment = new fhirCsR2.Models.Attachment();
          ValueAttachment.DeserializeJson(ref reader, options);
          break;

        case "valueCoding":
          ValueCoding = new fhirCsR2.Models.Coding();
          ValueCoding.DeserializeJson(ref reader, options);
          break;

        case "valueQuantity":
          ValueQuantity = new fhirCsR2.Models.Quantity();
          ValueQuantity.DeserializeJson(ref reader, options);
          break;

        case "valueReference":
          ValueReference = new fhirCsR2.Models.Reference();
          ValueReference.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR2.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Must register answers to questions.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<QuestionnaireResponseGroupQuestion>))]
  public class QuestionnaireResponseGroupQuestion : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The respondent's answer(s) to the question.
    /// </summary>
    public List<QuestionnaireResponseGroupQuestionAnswer> Answer { get; set; }
    /// <summary>
    /// Groups can repeat in the answers, so a direct 1..1 correspondence may not exist - requiring correspondence by id.
    /// </summary>
    public string LinkId { get; set; }
    /// <summary>
    /// Extension container element for LinkId
    /// </summary>
    public Element _LinkId { get; set; }
    /// <summary>
    /// When including text for the questionnaire, each question may contain its actual question display text.
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Extension container element for Text
    /// </summary>
    public Element _Text { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR2.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(LinkId))
      {
        writer.WriteString("linkId", (string)LinkId!);
      }

      if (_LinkId != null)
      {
        writer.WritePropertyName("_linkId");
        _LinkId.SerializeJson(writer, options);
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

      if ((Answer != null) && (Answer.Count != 0))
      {
        writer.WritePropertyName("answer");
        writer.WriteStartArray();

        foreach (QuestionnaireResponseGroupQuestionAnswer valAnswer in Answer)
        {
          valAnswer.SerializeJson(writer, options, true);
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
        case "answer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Answer = new List<QuestionnaireResponseGroupQuestionAnswer>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.QuestionnaireResponseGroupQuestionAnswer objAnswer = new fhirCsR2.Models.QuestionnaireResponseGroupQuestionAnswer();
            objAnswer.DeserializeJson(ref reader, options);
            Answer.Add(objAnswer);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Answer.Count == 0)
          {
            Answer = null;
          }

          break;

        case "linkId":
          LinkId = reader.GetString();
          break;

        case "_linkId":
          _LinkId = new fhirCsR2.Models.Element();
          _LinkId.DeserializeJson(ref reader, options);
          break;

        case "text":
          Text = reader.GetString();
          break;

        case "_text":
          _Text = new fhirCsR2.Models.Element();
          _Text.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR2.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Need to be able to logically group answers to grouped questions.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<QuestionnaireResponseGroup>))]
  public class QuestionnaireResponseGroup : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Reports can consist of complex nested groups.
    /// </summary>
    public List<QuestionnaireResponseGroup> Group { get; set; }
    /// <summary>
    /// Groups can repeat in the answers, so a direct 1..1 correspondence may not exist - requiring correspondence by identifier.
    /// </summary>
    public string LinkId { get; set; }
    /// <summary>
    /// Extension container element for LinkId
    /// </summary>
    public Element _LinkId { get; set; }
    /// <summary>
    /// Must register answers to questions.
    /// </summary>
    public List<QuestionnaireResponseGroupQuestion> Question { get; set; }
    /// <summary>
    /// Sometimes a group of answers is about a specific participant, artifact or piece of information in the patient's care or record, e.g. a specific Problem, RelatedPerson, Allergy etc.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// When including text for the questionnaire, each section may contain additional explanations are background text.
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Extension container element for Text
    /// </summary>
    public Element _Text { get; set; }
    /// <summary>
    /// When including text for the questionnaire with the answers, sections may have a section header.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Extension container element for Title
    /// </summary>
    public Element _Title { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR2.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(LinkId))
      {
        writer.WriteString("linkId", (string)LinkId!);
      }

      if (_LinkId != null)
      {
        writer.WritePropertyName("_linkId");
        _LinkId.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Title))
      {
        writer.WriteString("title", (string)Title!);
      }

      if (_Title != null)
      {
        writer.WritePropertyName("_title");
        _Title.SerializeJson(writer, options);
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

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if ((Group != null) && (Group.Count != 0))
      {
        writer.WritePropertyName("group");
        writer.WriteStartArray();

        foreach (QuestionnaireResponseGroup valGroup in Group)
        {
          valGroup.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Question != null) && (Question.Count != 0))
      {
        writer.WritePropertyName("question");
        writer.WriteStartArray();

        foreach (QuestionnaireResponseGroupQuestion valQuestion in Question)
        {
          valQuestion.SerializeJson(writer, options, true);
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
        case "group":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Group = new List<QuestionnaireResponseGroup>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.QuestionnaireResponseGroup objGroup = new fhirCsR2.Models.QuestionnaireResponseGroup();
            objGroup.DeserializeJson(ref reader, options);
            Group.Add(objGroup);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Group.Count == 0)
          {
            Group = null;
          }

          break;

        case "linkId":
          LinkId = reader.GetString();
          break;

        case "_linkId":
          _LinkId = new fhirCsR2.Models.Element();
          _LinkId.DeserializeJson(ref reader, options);
          break;

        case "question":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Question = new List<QuestionnaireResponseGroupQuestion>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.QuestionnaireResponseGroupQuestion objQuestion = new fhirCsR2.Models.QuestionnaireResponseGroupQuestion();
            objQuestion.DeserializeJson(ref reader, options);
            Question.Add(objQuestion);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Question.Count == 0)
          {
            Question = null;
          }

          break;

        case "subject":
          Subject = new fhirCsR2.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "text":
          Text = reader.GetString();
          break;

        case "_text":
          _Text = new fhirCsR2.Models.Element();
          _Text.DeserializeJson(ref reader, options);
          break;

        case "title":
          Title = reader.GetString();
          break;

        case "_title":
          _Title = new fhirCsR2.Models.Element();
          _Title.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR2.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// A structured set of questions and their answers. The questions are ordered and grouped into coherent subsets, corresponding to the structure of the grouping of the underlying questions.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<QuestionnaireResponse>))]
  public class QuestionnaireResponse : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "QuestionnaireResponse";
    /// <summary>
    /// Need to know who interpreted the subject's answers to the questions in the questionnaire, and selected the appropriate options for answers.
    /// </summary>
    public Reference Author { get; set; }
    /// <summary>
    /// Clinicians need to be able to check the date that the information in the questionnaire was collected, to derive the context of the answers.
    /// </summary>
    public string Authored { get; set; }
    /// <summary>
    /// Extension container element for Authored
    /// </summary>
    public Element _Authored { get; set; }
    /// <summary>
    /// Some institutions track questionnaires under a specific encounter.
    /// </summary>
    public Reference Encounter { get; set; }
    /// <summary>
    /// Need to be able to logically group answers to grouped questions.
    /// </summary>
    public QuestionnaireResponseGroup Group { get; set; }
    /// <summary>
    /// Used for tracking, registration and other business purposes.
    /// </summary>
    public Identifier Identifier { get; set; }
    /// <summary>
    /// Needed to allow editing of the questionnaire in a manner that enforces the constraints of the original form.
    /// </summary>
    public Reference Questionnaire { get; set; }
    /// <summary>
    /// When answering questions about a subject that is minor, incapable of answering or an animal, another human source is used to answer the questions.
    /// </summary>
    public Reference Source { get; set; }
    /// <summary>
    /// The information on Questionnaire resources  may possibly be gathered during multiple sessions and altered after considered being finished. Questionnaire resources with just questions may serve as template forms, with the applicable publication statuses.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The subject context must be known.
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


      ((fhirCsR2.Models.DomainResource)this).SerializeJson(writer, options, false);

      if (Identifier != null)
      {
        writer.WritePropertyName("identifier");
        Identifier.SerializeJson(writer, options);
      }

      if (Questionnaire != null)
      {
        writer.WritePropertyName("questionnaire");
        Questionnaire.SerializeJson(writer, options);
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

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (Author != null)
      {
        writer.WritePropertyName("author");
        Author.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Authored))
      {
        writer.WriteString("authored", (string)Authored!);
      }

      if (_Authored != null)
      {
        writer.WritePropertyName("_authored");
        _Authored.SerializeJson(writer, options);
      }

      if (Source != null)
      {
        writer.WritePropertyName("source");
        Source.SerializeJson(writer, options);
      }

      if (Encounter != null)
      {
        writer.WritePropertyName("encounter");
        Encounter.SerializeJson(writer, options);
      }

      if (Group != null)
      {
        writer.WritePropertyName("group");
        Group.SerializeJson(writer, options);
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
        case "author":
          Author = new fhirCsR2.Models.Reference();
          Author.DeserializeJson(ref reader, options);
          break;

        case "authored":
          Authored = reader.GetString();
          break;

        case "_authored":
          _Authored = new fhirCsR2.Models.Element();
          _Authored.DeserializeJson(ref reader, options);
          break;

        case "encounter":
          Encounter = new fhirCsR2.Models.Reference();
          Encounter.DeserializeJson(ref reader, options);
          break;

        case "group":
          Group = new fhirCsR2.Models.QuestionnaireResponseGroup();
          Group.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          Identifier = new fhirCsR2.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
          break;

        case "questionnaire":
          Questionnaire = new fhirCsR2.Models.Reference();
          Questionnaire.DeserializeJson(ref reader, options);
          break;

        case "source":
          Source = new fhirCsR2.Models.Reference();
          Source.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR2.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new fhirCsR2.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR2.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Code Values for the QuestionnaireResponse.status field
  /// </summary>
  public static class QuestionnaireResponseStatusCodes {
    public const string IN_PROGRESS = "in-progress";
    public const string COMPLETED = "completed";
    public const string AMENDED = "amended";
    public static HashSet<string> Values = new HashSet<string>() {
      "in-progress",
      "completed",
      "amended",
    };
  }
}
