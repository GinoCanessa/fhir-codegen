// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Distinguishes groups from questions and display text and indicates data type for questions.
  /// </summary>
  public static class ItemTypeCodes
  {
    /// <summary>
    /// Question with binary content such as an image, PDF, etc. as an answer (valueAttachment).
    /// </summary>
    public static readonly Coding Attachment = new Coding
    {
      Code = "attachment",
      Display = "Attachment",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a yes/no answer (valueBoolean).
    /// </summary>
    public static readonly Coding Boolean = new Coding
    {
      Code = "boolean",
      Display = "Boolean",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a Coding drawn from a list of possible answers (specified in either the answerOption property, or via the valueset referenced in the answerValueSet property) as an answer (valueCoding).
    /// </summary>
    public static readonly Coding Choice = new Coding
    {
      Code = "choice",
      Display = "Choice",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a date answer (valueDate).
    /// </summary>
    public static readonly Coding Date = new Coding
    {
      Code = "date",
      Display = "Date",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a date and time answer (valueDateTime).
    /// </summary>
    public static readonly Coding DateTime = new Coding
    {
      Code = "dateTime",
      Display = "Date Time",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with is a real number answer (valueDecimal).
    /// </summary>
    public static readonly Coding Decimal = new Coding
    {
      Code = "decimal",
      Display = "Decimal",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Text for display that will not capture an answer or have child items.
    /// </summary>
    public static readonly Coding Display = new Coding
    {
      Code = "display",
      Display = "Display",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// An item with no direct answer but should have at least one child item.
    /// </summary>
    public static readonly Coding Group = new Coding
    {
      Code = "group",
      Display = "Group",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with an integer answer (valueInteger).
    /// </summary>
    public static readonly Coding Integer = new Coding
    {
      Code = "integer",
      Display = "Integer",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Answer is a Coding drawn from a list of possible answers (as with the choice type) or a free-text entry in a string (valueCoding or valueString).
    /// </summary>
    public static readonly Coding OpenChoice = new Coding
    {
      Code = "open-choice",
      Display = "Open Choice",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a combination of a numeric value and unit, potentially with a comparator (&lt;, &gt;, etc.) as an answer. (valueQuantity) There is an extension 'http://hl7.org/fhir/StructureDefinition/questionnaire-unit' that can be used to define what unit should be captured (or the unit that has a ucum conversion from the provided unit).
    /// </summary>
    public static readonly Coding Quantity = new Coding
    {
      Code = "quantity",
      Display = "Quantity",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// An item that defines a specific answer to be captured, and which may have child items. (the answer provided in the QuestionnaireResponse should be of the defined datatype).
    /// </summary>
    public static readonly Coding Question = new Coding
    {
      Code = "question",
      Display = "Question",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a reference to another resource (practitioner, organization, etc.) as an answer (valueReference).
    /// </summary>
    public static readonly Coding Reference = new Coding
    {
      Code = "reference",
      Display = "Reference",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a short (few words to short sentence) free-text entry answer (valueString).
    /// </summary>
    public static readonly Coding String = new Coding
    {
      Code = "string",
      Display = "String",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a long (potentially multi-paragraph) free-text entry answer (valueString).
    /// </summary>
    public static readonly Coding Text = new Coding
    {
      Code = "text",
      Display = "Text",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a time (hour:minute:second) answer independent of date. (valueTime).
    /// </summary>
    public static readonly Coding Time = new Coding
    {
      Code = "time",
      Display = "Time",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a URL (website, FTP site, etc.) answer (valueUri).
    /// </summary>
    public static readonly Coding Url = new Coding
    {
      Code = "url",
      Display = "Url",
      System = "http://hl7.org/fhir/item-type"
    };

    /// <summary>
    /// Literal for code: Attachment
    /// </summary>
    public const string LiteralAttachment = "attachment";

    /// <summary>
    /// Literal for code: ItemTypeAttachment
    /// </summary>
    public const string LiteralItemTypeAttachment = "http://hl7.org/fhir/item-type#attachment";

    /// <summary>
    /// Literal for code: Boolean
    /// </summary>
    public const string LiteralBoolean = "boolean";

    /// <summary>
    /// Literal for code: ItemTypeBoolean
    /// </summary>
    public const string LiteralItemTypeBoolean = "http://hl7.org/fhir/item-type#boolean";

    /// <summary>
    /// Literal for code: Choice
    /// </summary>
    public const string LiteralChoice = "choice";

    /// <summary>
    /// Literal for code: ItemTypeChoice
    /// </summary>
    public const string LiteralItemTypeChoice = "http://hl7.org/fhir/item-type#choice";

    /// <summary>
    /// Literal for code: Date
    /// </summary>
    public const string LiteralDate = "date";

    /// <summary>
    /// Literal for code: ItemTypeDate
    /// </summary>
    public const string LiteralItemTypeDate = "http://hl7.org/fhir/item-type#date";

    /// <summary>
    /// Literal for code: DateTime
    /// </summary>
    public const string LiteralDateTime = "dateTime";

    /// <summary>
    /// Literal for code: ItemTypeDateTime
    /// </summary>
    public const string LiteralItemTypeDateTime = "http://hl7.org/fhir/item-type#dateTime";

    /// <summary>
    /// Literal for code: Decimal
    /// </summary>
    public const string LiteralDecimal = "decimal";

    /// <summary>
    /// Literal for code: ItemTypeDecimal
    /// </summary>
    public const string LiteralItemTypeDecimal = "http://hl7.org/fhir/item-type#decimal";

    /// <summary>
    /// Literal for code: Display
    /// </summary>
    public const string LiteralDisplay = "display";

    /// <summary>
    /// Literal for code: ItemTypeDisplay
    /// </summary>
    public const string LiteralItemTypeDisplay = "http://hl7.org/fhir/item-type#display";

    /// <summary>
    /// Literal for code: Group
    /// </summary>
    public const string LiteralGroup = "group";

    /// <summary>
    /// Literal for code: ItemTypeGroup
    /// </summary>
    public const string LiteralItemTypeGroup = "http://hl7.org/fhir/item-type#group";

    /// <summary>
    /// Literal for code: Integer
    /// </summary>
    public const string LiteralInteger = "integer";

    /// <summary>
    /// Literal for code: ItemTypeInteger
    /// </summary>
    public const string LiteralItemTypeInteger = "http://hl7.org/fhir/item-type#integer";

    /// <summary>
    /// Literal for code: OpenChoice
    /// </summary>
    public const string LiteralOpenChoice = "open-choice";

    /// <summary>
    /// Literal for code: ItemTypeOpenChoice
    /// </summary>
    public const string LiteralItemTypeOpenChoice = "http://hl7.org/fhir/item-type#open-choice";

    /// <summary>
    /// Literal for code: Quantity
    /// </summary>
    public const string LiteralQuantity = "quantity";

    /// <summary>
    /// Literal for code: ItemTypeQuantity
    /// </summary>
    public const string LiteralItemTypeQuantity = "http://hl7.org/fhir/item-type#quantity";

    /// <summary>
    /// Literal for code: Question
    /// </summary>
    public const string LiteralQuestion = "question";

    /// <summary>
    /// Literal for code: ItemTypeQuestion
    /// </summary>
    public const string LiteralItemTypeQuestion = "http://hl7.org/fhir/item-type#question";

    /// <summary>
    /// Literal for code: Reference
    /// </summary>
    public const string LiteralReference = "reference";

    /// <summary>
    /// Literal for code: ItemTypeReference
    /// </summary>
    public const string LiteralItemTypeReference = "http://hl7.org/fhir/item-type#reference";

    /// <summary>
    /// Literal for code: String
    /// </summary>
    public const string LiteralString = "string";

    /// <summary>
    /// Literal for code: ItemTypeString
    /// </summary>
    public const string LiteralItemTypeString = "http://hl7.org/fhir/item-type#string";

    /// <summary>
    /// Literal for code: Text
    /// </summary>
    public const string LiteralText = "text";

    /// <summary>
    /// Literal for code: ItemTypeText
    /// </summary>
    public const string LiteralItemTypeText = "http://hl7.org/fhir/item-type#text";

    /// <summary>
    /// Literal for code: Time
    /// </summary>
    public const string LiteralTime = "time";

    /// <summary>
    /// Literal for code: ItemTypeTime
    /// </summary>
    public const string LiteralItemTypeTime = "http://hl7.org/fhir/item-type#time";

    /// <summary>
    /// Literal for code: Url
    /// </summary>
    public const string LiteralUrl = "url";

    /// <summary>
    /// Literal for code: ItemTypeUrl
    /// </summary>
    public const string LiteralItemTypeUrl = "http://hl7.org/fhir/item-type#url";

    /// <summary>
    /// Dictionary for looking up ItemType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "attachment", Attachment }, 
      { "http://hl7.org/fhir/item-type#attachment", Attachment }, 
      { "boolean", Boolean }, 
      { "http://hl7.org/fhir/item-type#boolean", Boolean }, 
      { "choice", Choice }, 
      { "http://hl7.org/fhir/item-type#choice", Choice }, 
      { "date", Date }, 
      { "http://hl7.org/fhir/item-type#date", Date }, 
      { "dateTime", DateTime }, 
      { "http://hl7.org/fhir/item-type#dateTime", DateTime }, 
      { "decimal", Decimal }, 
      { "http://hl7.org/fhir/item-type#decimal", Decimal }, 
      { "display", Display }, 
      { "http://hl7.org/fhir/item-type#display", Display }, 
      { "group", Group }, 
      { "http://hl7.org/fhir/item-type#group", Group }, 
      { "integer", Integer }, 
      { "http://hl7.org/fhir/item-type#integer", Integer }, 
      { "open-choice", OpenChoice }, 
      { "http://hl7.org/fhir/item-type#open-choice", OpenChoice }, 
      { "quantity", Quantity }, 
      { "http://hl7.org/fhir/item-type#quantity", Quantity }, 
      { "question", Question }, 
      { "http://hl7.org/fhir/item-type#question", Question }, 
      { "reference", Reference }, 
      { "http://hl7.org/fhir/item-type#reference", Reference }, 
      { "string", String }, 
      { "http://hl7.org/fhir/item-type#string", String }, 
      { "text", Text }, 
      { "http://hl7.org/fhir/item-type#text", Text }, 
      { "time", Time }, 
      { "http://hl7.org/fhir/item-type#time", Time }, 
      { "url", Url }, 
      { "http://hl7.org/fhir/item-type#url", Url }, 
    };
  };
}
