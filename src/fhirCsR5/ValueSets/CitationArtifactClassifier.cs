// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Citation artifact classifier
  /// </summary>
  public static class CitationArtifactClassifierCodes
  {
    /// <summary>
    /// Used with articles which include video files or clips, or for articles which are entirely video.
    /// </summary>
    public static readonly Coding VideoAudioMedia = new Coding
    {
      Code = "68059040",
      Display = "Video-Audio Media",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// The article cited is an audio file.
    /// </summary>
    public static readonly Coding AudioFile = new Coding
    {
      Code = "audio",
      Display = "Audio file",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// The artifact is used for decision support for healthcare decisions.
    /// </summary>
    public static readonly Coding ClinicalDecisionSupportArtifact = new Coding
    {
      Code = "cds-artifact",
      Display = "Clinical Decision Support Artifact",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Citation Resource containing value added data that is openly shared
    /// </summary>
    public static readonly Coding CommonShare = new Coding
    {
      Code = "common-share",
      Display = "Common Share",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Scientific manuscript made available prior to PEER REVIEW.
    /// </summary>
    public static readonly Coding Preprint = new Coding
    {
      Code = "D000076942",
      Display = "Preprint",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Non-periodical written or printed works consisting of sheets of pages fastened or bound together within covers.
    /// </summary>
    public static readonly Coding Book = new Coding
    {
      Code = "D001877",
      Display = "Book",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Comment
    /// </summary>
    public static readonly Coding Comment = new Coding
    {
      Code = "D016420",
      Display = "Comment",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Letter
    /// </summary>
    public static readonly Coding Letter = new Coding
    {
      Code = "D016422",
      Display = "Letter",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Published Erratum
    /// </summary>
    public static readonly Coding PublishedErratum = new Coding
    {
      Code = "D016425",
      Display = "Published Erratum",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Journal Article
    /// </summary>
    public static readonly Coding JournalArticle = new Coding
    {
      Code = "D016428",
      Display = "Journal Article",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// A structured file of information or a set of logically related data stored and retrieved using computer-based means.
    /// </summary>
    public static readonly Coding Database = new Coding
    {
      Code = "D019991",
      Display = "Database",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Works consisting of organized collections of data, which have been stored permanently in a formalized manner suitable for communication, interpretation, or processing.
    /// </summary>
    public static readonly Coding Dataset = new Coding
    {
      Code = "D064886",
      Display = "Dataset",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// the journal is published in electronic format only
    /// </summary>
    public static readonly Coding Electronic = new Coding
    {
      Code = "Electronic",
      Display = "Electronic",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// used for electronic-only journals that publish individual articles first and then later collect them into an "issue" date that is typically called an eCollection.
    /// </summary>
    public static readonly Coding ElectronicECollection = new Coding
    {
      Code = "Electronic-eCollection",
      Display = "Electronic-eCollection",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// the journal is published first in electronic format followed by print (this value is currently used for just one journal, Nucleic Acids Research)
    /// </summary>
    public static readonly Coding ElectronicPrint = new Coding
    {
      Code = "Electronic-Print",
      Display = "Electronic-Print",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Executable app
    /// </summary>
    public static readonly Coding ExecutableApp = new Coding
    {
      Code = "executable-app",
      Display = "Executable app",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// The article cited is a FHIR resource.
    /// </summary>
    public static readonly Coding FHIRResource = new Coding
    {
      Code = "fhir-resource",
      Display = "FHIR Resource",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// The article cited is an audio file.
    /// </summary>
    public static readonly Coding ImageFile = new Coding
    {
      Code = "image",
      Display = "Image file",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// A user interface that supports data entry and data display.
    /// </summary>
    public static readonly Coding InteractiveForm = new Coding
    {
      Code = "interactive-form",
      Display = "Interactive Form",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// The article cited is machine code.
    /// </summary>
    public static readonly Coding MachineCode = new Coding
    {
      Code = "machine-code",
      Display = "Machine code",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Citation Resource containing only data from Medline
    /// </summary>
    public static readonly Coding MedlineBase = new Coding
    {
      Code = "medline-base",
      Display = "Medline Base",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// A formula or expression used to calculate an outcome representing a predicted result.
    /// </summary>
    public static readonly Coding PredictionModel = new Coding
    {
      Code = "prediction-model",
      Display = "Prediction Model",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// the journal is published in print format only
    /// </summary>
    public static readonly Coding Print = new Coding
    {
      Code = "Print",
      Display = "Print",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// the journal is published in both print and electronic format
    /// </summary>
    public static readonly Coding PrintElectronic = new Coding
    {
      Code = "Print-Electronic",
      Display = "Print Electronic",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Citation Resource containing value added data specific to a project
    /// </summary>
    public static readonly Coding ProjectSpecific = new Coding
    {
      Code = "project-specific",
      Display = "Project Specific",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// The article cited is the protocol of an activity and not the results or findings.
    /// </summary>
    public static readonly Coding Protocol = new Coding
    {
      Code = "protocol",
      Display = "Protocol",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// A non-executable, human-readable representation of software code.
    /// </summary>
    public static readonly Coding PseudoCode = new Coding
    {
      Code = "pseudocode",
      Display = "PseudoCode",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// An explicit set of requirements for an item, material, component, system or service, often used to define a technical standard which is an established norm or requirement for a repeatable technical task.
    /// </summary>
    public static readonly Coding StandardSpecification = new Coding
    {
      Code = "standard-specification",
      Display = "Standard Specification",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// A structured set of codes and display values, which may be subtyped as a code system, value set, taxonomy, or ontology.
    /// </summary>
    public static readonly Coding Terminology = new Coding
    {
      Code = "terminology",
      Display = "Terminology",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Webpage
    /// </summary>
    public static readonly Coding Webpage = new Coding
    {
      Code = "webpage",
      Display = "Webpage",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };

    /// <summary>
    /// Literal for code: VideoAudioMedia
    /// </summary>
    public const string LiteralVideoAudioMedia = "68059040";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierVideoAudioMedia
    /// </summary>
    public const string LiteralCitationArtifactClassifierVideoAudioMedia = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#68059040";

    /// <summary>
    /// Literal for code: AudioFile
    /// </summary>
    public const string LiteralAudioFile = "audio";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierAudioFile
    /// </summary>
    public const string LiteralCitationArtifactClassifierAudioFile = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#audio";

    /// <summary>
    /// Literal for code: ClinicalDecisionSupportArtifact
    /// </summary>
    public const string LiteralClinicalDecisionSupportArtifact = "cds-artifact";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierClinicalDecisionSupportArtifact
    /// </summary>
    public const string LiteralCitationArtifactClassifierClinicalDecisionSupportArtifact = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#cds-artifact";

    /// <summary>
    /// Literal for code: CommonShare
    /// </summary>
    public const string LiteralCommonShare = "common-share";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierCommonShare
    /// </summary>
    public const string LiteralCitationArtifactClassifierCommonShare = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#common-share";

    /// <summary>
    /// Literal for code: Preprint
    /// </summary>
    public const string LiteralPreprint = "D000076942";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierPreprint
    /// </summary>
    public const string LiteralCitationArtifactClassifierPreprint = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#D000076942";

    /// <summary>
    /// Literal for code: Book
    /// </summary>
    public const string LiteralBook = "D001877";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierBook
    /// </summary>
    public const string LiteralCitationArtifactClassifierBook = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#D001877";

    /// <summary>
    /// Literal for code: Comment
    /// </summary>
    public const string LiteralComment = "D016420";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierComment
    /// </summary>
    public const string LiteralCitationArtifactClassifierComment = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#D016420";

    /// <summary>
    /// Literal for code: Letter
    /// </summary>
    public const string LiteralLetter = "D016422";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierLetter
    /// </summary>
    public const string LiteralCitationArtifactClassifierLetter = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#D016422";

    /// <summary>
    /// Literal for code: PublishedErratum
    /// </summary>
    public const string LiteralPublishedErratum = "D016425";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierPublishedErratum
    /// </summary>
    public const string LiteralCitationArtifactClassifierPublishedErratum = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#D016425";

    /// <summary>
    /// Literal for code: JournalArticle
    /// </summary>
    public const string LiteralJournalArticle = "D016428";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierJournalArticle
    /// </summary>
    public const string LiteralCitationArtifactClassifierJournalArticle = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#D016428";

    /// <summary>
    /// Literal for code: Database
    /// </summary>
    public const string LiteralDatabase = "D019991";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierDatabase
    /// </summary>
    public const string LiteralCitationArtifactClassifierDatabase = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#D019991";

    /// <summary>
    /// Literal for code: Dataset
    /// </summary>
    public const string LiteralDataset = "D064886";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierDataset
    /// </summary>
    public const string LiteralCitationArtifactClassifierDataset = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#D064886";

    /// <summary>
    /// Literal for code: Electronic
    /// </summary>
    public const string LiteralElectronic = "Electronic";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierElectronic
    /// </summary>
    public const string LiteralCitationArtifactClassifierElectronic = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#Electronic";

    /// <summary>
    /// Literal for code: ElectronicECollection
    /// </summary>
    public const string LiteralElectronicECollection = "Electronic-eCollection";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierElectronicECollection
    /// </summary>
    public const string LiteralCitationArtifactClassifierElectronicECollection = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#Electronic-eCollection";

    /// <summary>
    /// Literal for code: ElectronicPrint
    /// </summary>
    public const string LiteralElectronicPrint = "Electronic-Print";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierElectronicPrint
    /// </summary>
    public const string LiteralCitationArtifactClassifierElectronicPrint = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#Electronic-Print";

    /// <summary>
    /// Literal for code: ExecutableApp
    /// </summary>
    public const string LiteralExecutableApp = "executable-app";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierExecutableApp
    /// </summary>
    public const string LiteralCitationArtifactClassifierExecutableApp = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#executable-app";

    /// <summary>
    /// Literal for code: FHIRResource
    /// </summary>
    public const string LiteralFHIRResource = "fhir-resource";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierFHIRResource
    /// </summary>
    public const string LiteralCitationArtifactClassifierFHIRResource = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#fhir-resource";

    /// <summary>
    /// Literal for code: ImageFile
    /// </summary>
    public const string LiteralImageFile = "image";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierImageFile
    /// </summary>
    public const string LiteralCitationArtifactClassifierImageFile = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#image";

    /// <summary>
    /// Literal for code: InteractiveForm
    /// </summary>
    public const string LiteralInteractiveForm = "interactive-form";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierInteractiveForm
    /// </summary>
    public const string LiteralCitationArtifactClassifierInteractiveForm = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#interactive-form";

    /// <summary>
    /// Literal for code: MachineCode
    /// </summary>
    public const string LiteralMachineCode = "machine-code";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierMachineCode
    /// </summary>
    public const string LiteralCitationArtifactClassifierMachineCode = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#machine-code";

    /// <summary>
    /// Literal for code: MedlineBase
    /// </summary>
    public const string LiteralMedlineBase = "medline-base";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierMedlineBase
    /// </summary>
    public const string LiteralCitationArtifactClassifierMedlineBase = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#medline-base";

    /// <summary>
    /// Literal for code: PredictionModel
    /// </summary>
    public const string LiteralPredictionModel = "prediction-model";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierPredictionModel
    /// </summary>
    public const string LiteralCitationArtifactClassifierPredictionModel = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#prediction-model";

    /// <summary>
    /// Literal for code: Print
    /// </summary>
    public const string LiteralPrint = "Print";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierPrint
    /// </summary>
    public const string LiteralCitationArtifactClassifierPrint = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#Print";

    /// <summary>
    /// Literal for code: PrintElectronic
    /// </summary>
    public const string LiteralPrintElectronic = "Print-Electronic";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierPrintElectronic
    /// </summary>
    public const string LiteralCitationArtifactClassifierPrintElectronic = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#Print-Electronic";

    /// <summary>
    /// Literal for code: ProjectSpecific
    /// </summary>
    public const string LiteralProjectSpecific = "project-specific";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierProjectSpecific
    /// </summary>
    public const string LiteralCitationArtifactClassifierProjectSpecific = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#project-specific";

    /// <summary>
    /// Literal for code: Protocol
    /// </summary>
    public const string LiteralProtocol = "protocol";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierProtocol
    /// </summary>
    public const string LiteralCitationArtifactClassifierProtocol = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#protocol";

    /// <summary>
    /// Literal for code: PseudoCode
    /// </summary>
    public const string LiteralPseudoCode = "pseudocode";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierPseudoCode
    /// </summary>
    public const string LiteralCitationArtifactClassifierPseudoCode = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#pseudocode";

    /// <summary>
    /// Literal for code: StandardSpecification
    /// </summary>
    public const string LiteralStandardSpecification = "standard-specification";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierStandardSpecification
    /// </summary>
    public const string LiteralCitationArtifactClassifierStandardSpecification = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#standard-specification";

    /// <summary>
    /// Literal for code: Terminology
    /// </summary>
    public const string LiteralTerminology = "terminology";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierTerminology
    /// </summary>
    public const string LiteralCitationArtifactClassifierTerminology = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#terminology";

    /// <summary>
    /// Literal for code: Webpage
    /// </summary>
    public const string LiteralWebpage = "webpage";

    /// <summary>
    /// Literal for code: CitationArtifactClassifierWebpage
    /// </summary>
    public const string LiteralCitationArtifactClassifierWebpage = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#webpage";

    /// <summary>
    /// Dictionary for looking up CitationArtifactClassifier Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "68059040", VideoAudioMedia }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#68059040", VideoAudioMedia }, 
      { "audio", AudioFile }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#audio", AudioFile }, 
      { "cds-artifact", ClinicalDecisionSupportArtifact }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#cds-artifact", ClinicalDecisionSupportArtifact }, 
      { "common-share", CommonShare }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#common-share", CommonShare }, 
      { "D000076942", Preprint }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#D000076942", Preprint }, 
      { "D001877", Book }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#D001877", Book }, 
      { "D016420", Comment }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#D016420", Comment }, 
      { "D016422", Letter }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#D016422", Letter }, 
      { "D016425", PublishedErratum }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#D016425", PublishedErratum }, 
      { "D016428", JournalArticle }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#D016428", JournalArticle }, 
      { "D019991", Database }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#D019991", Database }, 
      { "D064886", Dataset }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#D064886", Dataset }, 
      { "Electronic", Electronic }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#Electronic", Electronic }, 
      { "Electronic-eCollection", ElectronicECollection }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#Electronic-eCollection", ElectronicECollection }, 
      { "Electronic-Print", ElectronicPrint }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#Electronic-Print", ElectronicPrint }, 
      { "executable-app", ExecutableApp }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#executable-app", ExecutableApp }, 
      { "fhir-resource", FHIRResource }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#fhir-resource", FHIRResource }, 
      { "image", ImageFile }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#image", ImageFile }, 
      { "interactive-form", InteractiveForm }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#interactive-form", InteractiveForm }, 
      { "machine-code", MachineCode }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#machine-code", MachineCode }, 
      { "medline-base", MedlineBase }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#medline-base", MedlineBase }, 
      { "prediction-model", PredictionModel }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#prediction-model", PredictionModel }, 
      { "Print", Print }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#Print", Print }, 
      { "Print-Electronic", PrintElectronic }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#Print-Electronic", PrintElectronic }, 
      { "project-specific", ProjectSpecific }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#project-specific", ProjectSpecific }, 
      { "protocol", Protocol }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#protocol", Protocol }, 
      { "pseudocode", PseudoCode }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#pseudocode", PseudoCode }, 
      { "standard-specification", StandardSpecification }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#standard-specification", StandardSpecification }, 
      { "terminology", Terminology }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#terminology", Terminology }, 
      { "webpage", Webpage }, 
      { "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier#webpage", Webpage }, 
    };
  };
}
