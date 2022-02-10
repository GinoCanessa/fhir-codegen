// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// The type of method used to execute a subscription.
  /// </summary>
  public static class SubscriptionChannelTypeCodes
  {
    /// <summary>
    /// The channel is executed by sending an email to the email addressed in the URI (which must be a mailto:).
    /// </summary>
    public static readonly Coding Email = new Coding
    {
      Code = "email",
      Display = "Email",
      System = "http://hl7.org/fhir/subscription-channel-type"
    };
    /// <summary>
    /// The channel is executed by sending a message (e.g. a Bundle with a MessageHeader resource etc.) to the application identified in the URI.
    /// </summary>
    public static readonly Coding Message = new Coding
    {
      Code = "message",
      Display = "Message",
      System = "http://hl7.org/fhir/subscription-channel-type"
    };
    /// <summary>
    /// The channel is executed by making a post to the URI. If a payload is included, the URL is interpreted as the service base, and an update (PUT) is made.
    /// </summary>
    public static readonly Coding RestHook = new Coding
    {
      Code = "rest-hook",
      Display = "Rest Hook",
      System = "http://hl7.org/fhir/subscription-channel-type"
    };
    /// <summary>
    /// The channel is executed by sending an SMS message to the phone number identified in the URL (tel:).
    /// </summary>
    public static readonly Coding SMS = new Coding
    {
      Code = "sms",
      Display = "SMS",
      System = "http://hl7.org/fhir/subscription-channel-type"
    };
    /// <summary>
    /// The channel is executed by sending a packet across a web socket connection maintained by the client. The URL identifies the websocket, and the client binds to this URL.
    /// </summary>
    public static readonly Coding Websocket = new Coding
    {
      Code = "websocket",
      Display = "Websocket",
      System = "http://hl7.org/fhir/subscription-channel-type"
    };

    /// <summary>
    /// Literal for code: Email
    /// </summary>
    public const string LiteralEmail = "email";

    /// <summary>
    /// Literal for code: SubscriptionChannelTypeEmail
    /// </summary>
    public const string LiteralSubscriptionChannelTypeEmail = "http://hl7.org/fhir/subscription-channel-type#email";

    /// <summary>
    /// Literal for code: Message
    /// </summary>
    public const string LiteralMessage = "message";

    /// <summary>
    /// Literal for code: SubscriptionChannelTypeMessage
    /// </summary>
    public const string LiteralSubscriptionChannelTypeMessage = "http://hl7.org/fhir/subscription-channel-type#message";

    /// <summary>
    /// Literal for code: RestHook
    /// </summary>
    public const string LiteralRestHook = "rest-hook";

    /// <summary>
    /// Literal for code: SubscriptionChannelTypeRestHook
    /// </summary>
    public const string LiteralSubscriptionChannelTypeRestHook = "http://hl7.org/fhir/subscription-channel-type#rest-hook";

    /// <summary>
    /// Literal for code: SMS
    /// </summary>
    public const string LiteralSMS = "sms";

    /// <summary>
    /// Literal for code: SubscriptionChannelTypeSMS
    /// </summary>
    public const string LiteralSubscriptionChannelTypeSMS = "http://hl7.org/fhir/subscription-channel-type#sms";

    /// <summary>
    /// Literal for code: Websocket
    /// </summary>
    public const string LiteralWebsocket = "websocket";

    /// <summary>
    /// Literal for code: SubscriptionChannelTypeWebsocket
    /// </summary>
    public const string LiteralSubscriptionChannelTypeWebsocket = "http://hl7.org/fhir/subscription-channel-type#websocket";

    /// <summary>
    /// Dictionary for looking up SubscriptionChannelType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "email", Email }, 
      { "http://hl7.org/fhir/subscription-channel-type#email", Email }, 
      { "message", Message }, 
      { "http://hl7.org/fhir/subscription-channel-type#message", Message }, 
      { "rest-hook", RestHook }, 
      { "http://hl7.org/fhir/subscription-channel-type#rest-hook", RestHook }, 
      { "sms", SMS }, 
      { "http://hl7.org/fhir/subscription-channel-type#sms", SMS }, 
      { "websocket", Websocket }, 
      { "http://hl7.org/fhir/subscription-channel-type#websocket", Websocket }, 
    };
  };
}
