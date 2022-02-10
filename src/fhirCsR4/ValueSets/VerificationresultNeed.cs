// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The frequency with which the target must be validated
  /// </summary>
  public static class VerificationresultNeedCodes
  {
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding Initial = new Coding
    {
      Code = "initial",
      Display = "Initial",
      System = "http://terminology.hl7.org/CodeSystem/need"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding None = new Coding
    {
      Code = "none",
      Display = "None",
      System = "http://terminology.hl7.org/CodeSystem/need"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding Periodic = new Coding
    {
      Code = "periodic",
      Display = "Periodic",
      System = "http://terminology.hl7.org/CodeSystem/need"
    };

    /// <summary>
    /// Literal for code: Initial
    /// </summary>
    public const string LiteralInitial = "initial";

    /// <summary>
    /// Literal for code: VerificationresultNeedInitial
    /// </summary>
    public const string LiteralVerificationresultNeedInitial = "http://terminology.hl7.org/CodeSystem/need#initial";

    /// <summary>
    /// Literal for code: None
    /// </summary>
    public const string LiteralNone = "none";

    /// <summary>
    /// Literal for code: VerificationresultNeedNone
    /// </summary>
    public const string LiteralVerificationresultNeedNone = "http://terminology.hl7.org/CodeSystem/need#none";

    /// <summary>
    /// Literal for code: Periodic
    /// </summary>
    public const string LiteralPeriodic = "periodic";

    /// <summary>
    /// Literal for code: VerificationresultNeedPeriodic
    /// </summary>
    public const string LiteralVerificationresultNeedPeriodic = "http://terminology.hl7.org/CodeSystem/need#periodic";

    /// <summary>
    /// Dictionary for looking up VerificationresultNeed Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "initial", Initial }, 
      { "http://terminology.hl7.org/CodeSystem/need#initial", Initial }, 
      { "none", None }, 
      { "http://terminology.hl7.org/CodeSystem/need#none", None }, 
      { "periodic", Periodic }, 
      { "http://terminology.hl7.org/CodeSystem/need#periodic", Periodic }, 
    };
  };
}
