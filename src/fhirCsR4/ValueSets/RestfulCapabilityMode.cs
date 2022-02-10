// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The mode of a RESTful capability statement.
  /// </summary>
  public static class RestfulCapabilityModeCodes
  {
    /// <summary>
    /// The application acts as a client for this resource.
    /// </summary>
    public static readonly Coding Client = new Coding
    {
      Code = "client",
      Display = "Client",
      System = "http://hl7.org/fhir/restful-capability-mode"
    };
    /// <summary>
    /// The application acts as a server for this resource.
    /// </summary>
    public static readonly Coding Server = new Coding
    {
      Code = "server",
      Display = "Server",
      System = "http://hl7.org/fhir/restful-capability-mode"
    };

    /// <summary>
    /// Literal for code: Client
    /// </summary>
    public const string LiteralClient = "client";

    /// <summary>
    /// Literal for code: RestfulCapabilityModeClient
    /// </summary>
    public const string LiteralRestfulCapabilityModeClient = "http://hl7.org/fhir/restful-capability-mode#client";

    /// <summary>
    /// Literal for code: Server
    /// </summary>
    public const string LiteralServer = "server";

    /// <summary>
    /// Literal for code: RestfulCapabilityModeServer
    /// </summary>
    public const string LiteralRestfulCapabilityModeServer = "http://hl7.org/fhir/restful-capability-mode#server";

    /// <summary>
    /// Dictionary for looking up RestfulCapabilityMode Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "client", Client }, 
      { "http://hl7.org/fhir/restful-capability-mode#client", Client }, 
      { "server", Server }, 
      { "http://hl7.org/fhir/restful-capability-mode#server", Server }, 
    };
  };
}
