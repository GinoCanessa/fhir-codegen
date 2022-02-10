// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Operations supported by REST at the system level.
  /// </summary>
  public static class SystemRestfulInteractionCodes
  {
    /// <summary>
    /// perform a set of a separate interactions in a single http operation
    /// </summary>
    public static readonly Coding Batch = new Coding
    {
      Code = "batch",
      Display = "batch",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Retrieve the change history for all resources on a system.
    /// </summary>
    public static readonly Coding HistorySystem = new Coding
    {
      Code = "history-system",
      Display = "history-system",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Search all resources based on some filter criteria.
    /// </summary>
    public static readonly Coding SearchSystem = new Coding
    {
      Code = "search-system",
      Display = "search-system",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Update, create or delete a set of resources as a single transaction.
    /// </summary>
    public static readonly Coding Transaction = new Coding
    {
      Code = "transaction",
      Display = "transaction",
      System = "http://hl7.org/fhir/restful-interaction"
    };

    /// <summary>
    /// Literal for code: Batch
    /// </summary>
    public const string LiteralBatch = "batch";

    /// <summary>
    /// Literal for code: RestfulInteractionBatch
    /// </summary>
    public const string LiteralRestfulInteractionBatch = "http://hl7.org/fhir/restful-interaction#batch";

    /// <summary>
    /// Literal for code: HistorySystem
    /// </summary>
    public const string LiteralHistorySystem = "history-system";

    /// <summary>
    /// Literal for code: RestfulInteractionHistorySystem
    /// </summary>
    public const string LiteralRestfulInteractionHistorySystem = "http://hl7.org/fhir/restful-interaction#history-system";

    /// <summary>
    /// Literal for code: SearchSystem
    /// </summary>
    public const string LiteralSearchSystem = "search-system";

    /// <summary>
    /// Literal for code: RestfulInteractionSearchSystem
    /// </summary>
    public const string LiteralRestfulInteractionSearchSystem = "http://hl7.org/fhir/restful-interaction#search-system";

    /// <summary>
    /// Literal for code: Transaction
    /// </summary>
    public const string LiteralTransaction = "transaction";

    /// <summary>
    /// Literal for code: RestfulInteractionTransaction
    /// </summary>
    public const string LiteralRestfulInteractionTransaction = "http://hl7.org/fhir/restful-interaction#transaction";

    /// <summary>
    /// Dictionary for looking up SystemRestfulInteraction Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "batch", Batch }, 
      { "http://hl7.org/fhir/restful-interaction#batch", Batch }, 
      { "history-system", HistorySystem }, 
      { "http://hl7.org/fhir/restful-interaction#history-system", HistorySystem }, 
      { "search-system", SearchSystem }, 
      { "http://hl7.org/fhir/restful-interaction#search-system", SearchSystem }, 
      { "transaction", Transaction }, 
      { "http://hl7.org/fhir/restful-interaction#transaction", Transaction }, 
    };
  };
}
