// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// Whether the application produces or consumes documents.
  /// </summary>
  public static class DocumentModeCodes
  {
    /// <summary>
    /// The application consumes documents of the specified type.
    /// </summary>
    public static readonly Coding Consumer = new Coding
    {
      Code = "consumer",
      Display = "Consumer",
      System = "http://hl7.org/fhir/document-mode"
    };
    /// <summary>
    /// The application produces documents of the specified type.
    /// </summary>
    public static readonly Coding Producer = new Coding
    {
      Code = "producer",
      Display = "Producer",
      System = "http://hl7.org/fhir/document-mode"
    };

    /// <summary>
    /// Literal for code: Consumer
    /// </summary>
    public const string LiteralConsumer = "consumer";

    /// <summary>
    /// Literal for code: DocumentModeConsumer
    /// </summary>
    public const string LiteralDocumentModeConsumer = "http://hl7.org/fhir/document-mode#consumer";

    /// <summary>
    /// Literal for code: Producer
    /// </summary>
    public const string LiteralProducer = "producer";

    /// <summary>
    /// Literal for code: DocumentModeProducer
    /// </summary>
    public const string LiteralDocumentModeProducer = "http://hl7.org/fhir/document-mode#producer";

    /// <summary>
    /// Dictionary for looking up DocumentMode Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "consumer", Consumer }, 
      { "http://hl7.org/fhir/document-mode#consumer", Consumer }, 
      { "producer", Producer }, 
      { "http://hl7.org/fhir/document-mode#producer", Producer }, 
    };
  };
}
