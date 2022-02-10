// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This value set includes sample Related Claim Relationship codes.
  /// </summary>
  public static class RelatedClaimRelationshipCodes
  {
    /// <summary>
    /// A claim for a different suite of services which is related the suite claimed here.
    /// </summary>
    public static readonly Coding AssociatedClaim = new Coding
    {
      Code = "associated",
      Display = "Associated Claim",
      System = "http://hl7.org/fhir/ex-relatedclaimrelationship"
    };
    /// <summary>
    /// A prior claim instance for the same intended suite of services.
    /// </summary>
    public static readonly Coding PriorClaim = new Coding
    {
      Code = "prior",
      Display = "Prior Claim",
      System = "http://hl7.org/fhir/ex-relatedclaimrelationship"
    };

    /// <summary>
    /// Literal for code: AssociatedClaim
    /// </summary>
    public const string LiteralAssociatedClaim = "associated";

    /// <summary>
    /// Literal for code: RelatedClaimRelationshipAssociatedClaim
    /// </summary>
    public const string LiteralRelatedClaimRelationshipAssociatedClaim = "http://hl7.org/fhir/ex-relatedclaimrelationship#associated";

    /// <summary>
    /// Literal for code: PriorClaim
    /// </summary>
    public const string LiteralPriorClaim = "prior";

    /// <summary>
    /// Literal for code: RelatedClaimRelationshipPriorClaim
    /// </summary>
    public const string LiteralRelatedClaimRelationshipPriorClaim = "http://hl7.org/fhir/ex-relatedclaimrelationship#prior";

    /// <summary>
    /// Dictionary for looking up RelatedClaimRelationship Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "associated", AssociatedClaim }, 
      { "http://hl7.org/fhir/ex-relatedclaimrelationship#associated", AssociatedClaim }, 
      { "prior", PriorClaim }, 
      { "http://hl7.org/fhir/ex-relatedclaimrelationship#prior", PriorClaim }, 
    };
  };
}
