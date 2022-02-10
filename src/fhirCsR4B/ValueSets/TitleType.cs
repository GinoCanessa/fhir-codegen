// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Used to express the reason and specific aspect for the variant title, such as language and specific language.
  /// </summary>
  public static class TitleTypeCodes
  {
    /// <summary>
    /// Abbreviation used as title
    /// </summary>
    public static readonly Coding Acronym = new Coding
    {
      Code = "acronym",
      Display = "Acronym",
      System = "http://terminology.hl7.org/CodeSystem/title-type"
    };
    /// <summary>
    /// Machine translated form of title in a different language, language element codes the language into which it was translated by machine.
    /// </summary>
    public static readonly Coding DifferentLanguageDerivedFromAutotranslation = new Coding
    {
      Code = "autotranslated",
      Display = "Different language derived from autotranslation",
      System = "http://terminology.hl7.org/CodeSystem/title-type"
    };
    /// <summary>
    /// An alternative form of the title in two or more entries, e.g. in multiple medline entries
    /// </summary>
    public static readonly Coding DifferentTextForTheSameObjectWithADifferentIdentifier = new Coding
    {
      Code = "duplicate-uid",
      Display = "Different text for the same object with a different identifier",
      System = "http://terminology.hl7.org/CodeSystem/title-type"
    };
    /// <summary>
    /// Alternative form of title in an earlier version such as epub ahead of print.
    /// </summary>
    public static readonly Coding DifferentTextInAnEarlierVersion = new Coding
    {
      Code = "earlier-title",
      Display = "Different text in an earlier version",
      System = "http://terminology.hl7.org/CodeSystem/title-type"
    };
    /// <summary>
    /// Human-friendly title
    /// </summary>
    public static readonly Coding HumanUse = new Coding
    {
      Code = "human-use",
      Display = "Human use",
      System = "http://terminology.hl7.org/CodeSystem/title-type"
    };
    /// <summary>
    /// Additional form of title in a different language.
    /// </summary>
    public static readonly Coding DifferentLanguage = new Coding
    {
      Code = "language",
      Display = "Different language",
      System = "http://terminology.hl7.org/CodeSystem/title-type"
    };
    /// <summary>
    /// Machine-friendly title
    /// </summary>
    public static readonly Coding MachineUse = new Coding
    {
      Code = "machine-use",
      Display = "Machine use",
      System = "http://terminology.hl7.org/CodeSystem/title-type"
    };
    /// <summary>
    /// The official or authoritative title.
    /// </summary>
    public static readonly Coding OfficialTitle = new Coding
    {
      Code = "official",
      Display = "Official title",
      System = "http://terminology.hl7.org/CodeSystem/title-type"
    };
    /// <summary>
    /// Title using language common to lay public discourse.
    /// </summary>
    public static readonly Coding PlainLanguageTitle = new Coding
    {
      Code = "plain-language",
      Display = "Plain language title",
      System = "http://terminology.hl7.org/CodeSystem/title-type"
    };
    /// <summary>
    /// Main title for common use. The primary title used for representation if multiple titles exist.
    /// </summary>
    public static readonly Coding PrimaryTitle = new Coding
    {
      Code = "primary",
      Display = "Primary title",
      System = "http://terminology.hl7.org/CodeSystem/title-type"
    };
    /// <summary>
    /// Title using scientific terminology.
    /// </summary>
    public static readonly Coding ScientificTitle = new Coding
    {
      Code = "scientific",
      Display = "Scientific title",
      System = "http://terminology.hl7.org/CodeSystem/title-type"
    };
    /// <summary>
    /// Brief title (e.g. 'running title' or title used in page headers)
    /// </summary>
    public static readonly Coding ShortTitle = new Coding
    {
      Code = "short-title",
      Display = "Short title",
      System = "http://terminology.hl7.org/CodeSystem/title-type"
    };
    /// <summary>
    /// Subtitle or secondary title.
    /// </summary>
    public static readonly Coding Subtitle = new Coding
    {
      Code = "subtitle",
      Display = "Subtitle",
      System = "http://terminology.hl7.org/CodeSystem/title-type"
    };

    /// <summary>
    /// Literal for code: Acronym
    /// </summary>
    public const string LiteralAcronym = "acronym";

    /// <summary>
    /// Literal for code: TitleTypeAcronym
    /// </summary>
    public const string LiteralTitleTypeAcronym = "http://terminology.hl7.org/CodeSystem/title-type#acronym";

    /// <summary>
    /// Literal for code: DifferentLanguageDerivedFromAutotranslation
    /// </summary>
    public const string LiteralDifferentLanguageDerivedFromAutotranslation = "autotranslated";

    /// <summary>
    /// Literal for code: TitleTypeDifferentLanguageDerivedFromAutotranslation
    /// </summary>
    public const string LiteralTitleTypeDifferentLanguageDerivedFromAutotranslation = "http://terminology.hl7.org/CodeSystem/title-type#autotranslated";

    /// <summary>
    /// Literal for code: DifferentTextForTheSameObjectWithADifferentIdentifier
    /// </summary>
    public const string LiteralDifferentTextForTheSameObjectWithADifferentIdentifier = "duplicate-uid";

    /// <summary>
    /// Literal for code: TitleTypeDifferentTextForTheSameObjectWithADifferentIdentifier
    /// </summary>
    public const string LiteralTitleTypeDifferentTextForTheSameObjectWithADifferentIdentifier = "http://terminology.hl7.org/CodeSystem/title-type#duplicate-uid";

    /// <summary>
    /// Literal for code: DifferentTextInAnEarlierVersion
    /// </summary>
    public const string LiteralDifferentTextInAnEarlierVersion = "earlier-title";

    /// <summary>
    /// Literal for code: TitleTypeDifferentTextInAnEarlierVersion
    /// </summary>
    public const string LiteralTitleTypeDifferentTextInAnEarlierVersion = "http://terminology.hl7.org/CodeSystem/title-type#earlier-title";

    /// <summary>
    /// Literal for code: HumanUse
    /// </summary>
    public const string LiteralHumanUse = "human-use";

    /// <summary>
    /// Literal for code: TitleTypeHumanUse
    /// </summary>
    public const string LiteralTitleTypeHumanUse = "http://terminology.hl7.org/CodeSystem/title-type#human-use";

    /// <summary>
    /// Literal for code: DifferentLanguage
    /// </summary>
    public const string LiteralDifferentLanguage = "language";

    /// <summary>
    /// Literal for code: TitleTypeDifferentLanguage
    /// </summary>
    public const string LiteralTitleTypeDifferentLanguage = "http://terminology.hl7.org/CodeSystem/title-type#language";

    /// <summary>
    /// Literal for code: MachineUse
    /// </summary>
    public const string LiteralMachineUse = "machine-use";

    /// <summary>
    /// Literal for code: TitleTypeMachineUse
    /// </summary>
    public const string LiteralTitleTypeMachineUse = "http://terminology.hl7.org/CodeSystem/title-type#machine-use";

    /// <summary>
    /// Literal for code: OfficialTitle
    /// </summary>
    public const string LiteralOfficialTitle = "official";

    /// <summary>
    /// Literal for code: TitleTypeOfficialTitle
    /// </summary>
    public const string LiteralTitleTypeOfficialTitle = "http://terminology.hl7.org/CodeSystem/title-type#official";

    /// <summary>
    /// Literal for code: PlainLanguageTitle
    /// </summary>
    public const string LiteralPlainLanguageTitle = "plain-language";

    /// <summary>
    /// Literal for code: TitleTypePlainLanguageTitle
    /// </summary>
    public const string LiteralTitleTypePlainLanguageTitle = "http://terminology.hl7.org/CodeSystem/title-type#plain-language";

    /// <summary>
    /// Literal for code: PrimaryTitle
    /// </summary>
    public const string LiteralPrimaryTitle = "primary";

    /// <summary>
    /// Literal for code: TitleTypePrimaryTitle
    /// </summary>
    public const string LiteralTitleTypePrimaryTitle = "http://terminology.hl7.org/CodeSystem/title-type#primary";

    /// <summary>
    /// Literal for code: ScientificTitle
    /// </summary>
    public const string LiteralScientificTitle = "scientific";

    /// <summary>
    /// Literal for code: TitleTypeScientificTitle
    /// </summary>
    public const string LiteralTitleTypeScientificTitle = "http://terminology.hl7.org/CodeSystem/title-type#scientific";

    /// <summary>
    /// Literal for code: ShortTitle
    /// </summary>
    public const string LiteralShortTitle = "short-title";

    /// <summary>
    /// Literal for code: TitleTypeShortTitle
    /// </summary>
    public const string LiteralTitleTypeShortTitle = "http://terminology.hl7.org/CodeSystem/title-type#short-title";

    /// <summary>
    /// Literal for code: Subtitle
    /// </summary>
    public const string LiteralSubtitle = "subtitle";

    /// <summary>
    /// Literal for code: TitleTypeSubtitle
    /// </summary>
    public const string LiteralTitleTypeSubtitle = "http://terminology.hl7.org/CodeSystem/title-type#subtitle";

    /// <summary>
    /// Dictionary for looking up TitleType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "acronym", Acronym }, 
      { "http://terminology.hl7.org/CodeSystem/title-type#acronym", Acronym }, 
      { "autotranslated", DifferentLanguageDerivedFromAutotranslation }, 
      { "http://terminology.hl7.org/CodeSystem/title-type#autotranslated", DifferentLanguageDerivedFromAutotranslation }, 
      { "duplicate-uid", DifferentTextForTheSameObjectWithADifferentIdentifier }, 
      { "http://terminology.hl7.org/CodeSystem/title-type#duplicate-uid", DifferentTextForTheSameObjectWithADifferentIdentifier }, 
      { "earlier-title", DifferentTextInAnEarlierVersion }, 
      { "http://terminology.hl7.org/CodeSystem/title-type#earlier-title", DifferentTextInAnEarlierVersion }, 
      { "human-use", HumanUse }, 
      { "http://terminology.hl7.org/CodeSystem/title-type#human-use", HumanUse }, 
      { "language", DifferentLanguage }, 
      { "http://terminology.hl7.org/CodeSystem/title-type#language", DifferentLanguage }, 
      { "machine-use", MachineUse }, 
      { "http://terminology.hl7.org/CodeSystem/title-type#machine-use", MachineUse }, 
      { "official", OfficialTitle }, 
      { "http://terminology.hl7.org/CodeSystem/title-type#official", OfficialTitle }, 
      { "plain-language", PlainLanguageTitle }, 
      { "http://terminology.hl7.org/CodeSystem/title-type#plain-language", PlainLanguageTitle }, 
      { "primary", PrimaryTitle }, 
      { "http://terminology.hl7.org/CodeSystem/title-type#primary", PrimaryTitle }, 
      { "scientific", ScientificTitle }, 
      { "http://terminology.hl7.org/CodeSystem/title-type#scientific", ScientificTitle }, 
      { "short-title", ShortTitle }, 
      { "http://terminology.hl7.org/CodeSystem/title-type#short-title", ShortTitle }, 
      { "subtitle", Subtitle }, 
      { "http://terminology.hl7.org/CodeSystem/title-type#subtitle", Subtitle }, 
    };
  };
}
