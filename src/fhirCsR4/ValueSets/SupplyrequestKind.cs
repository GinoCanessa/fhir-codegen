// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value sets refers to a Category of supply.
  /// </summary>
  public static class SupplyrequestKindCodes
  {
    /// <summary>
    /// Supply is stored and requested from central supply.
    /// </summary>
    public static readonly Coding CentralSupply = new Coding
    {
      Code = "central",
      Display = "Central Supply",
      System = "http://terminology.hl7.org/CodeSystem/supply-kind"
    };
    /// <summary>
    /// Supply is not onsite and must be requested from an outside vendor using a non-stock requisition.
    /// </summary>
    public static readonly Coding NonStock = new Coding
    {
      Code = "nonstock",
      Display = "Non-Stock",
      System = "http://terminology.hl7.org/CodeSystem/supply-kind"
    };

    /// <summary>
    /// Literal for code: CentralSupply
    /// </summary>
    public const string LiteralCentralSupply = "central";

    /// <summary>
    /// Literal for code: SupplyrequestKindCentralSupply
    /// </summary>
    public const string LiteralSupplyrequestKindCentralSupply = "http://terminology.hl7.org/CodeSystem/supply-kind#central";

    /// <summary>
    /// Literal for code: NonStock
    /// </summary>
    public const string LiteralNonStock = "nonstock";

    /// <summary>
    /// Literal for code: SupplyrequestKindNonStock
    /// </summary>
    public const string LiteralSupplyrequestKindNonStock = "http://terminology.hl7.org/CodeSystem/supply-kind#nonstock";

    /// <summary>
    /// Dictionary for looking up SupplyrequestKind Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "central", CentralSupply }, 
      { "http://terminology.hl7.org/CodeSystem/supply-kind#central", CentralSupply }, 
      { "nonstock", NonStock }, 
      { "http://terminology.hl7.org/CodeSystem/supply-kind#nonstock", NonStock }, 
    };
  };
}
