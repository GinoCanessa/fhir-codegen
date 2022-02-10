// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Types of combining results from a body of evidence (eg. summary data meta-analysis).
  /// </summary>
  public static class SynthesisTypeCodes
  {
    /// <summary>
    /// An approach describing a body of evidence by categorically classifying individual studies (eg 3 studies showed beneft and 2 studied found no effect).
    /// </summary>
    public static readonly Coding ClassifcationOfResults = new Coding
    {
      Code = "classification",
      Display = "classifcation of results",
      System = "http://terminology.hl7.org/CodeSystem/synthesis-type"
    };
    /// <summary>
    /// An composite meta-analysis derived from direct comparisons and indirect comparisons in a network meta-analysis.
    /// </summary>
    public static readonly Coding CombinedDirectPlusIndirectNetworkMetaAnalysis = new Coding
    {
      Code = "combined-NMA",
      Display = "combined direct plus indirect network meta-analysis",
      System = "http://terminology.hl7.org/CodeSystem/synthesis-type"
    };
    /// <summary>
    /// An indirect meta-analysis derived from 2 or more direct comparisons in a network meta-analysis.
    /// </summary>
    public static readonly Coding IndirectNetworkMetaAnalysis = new Coding
    {
      Code = "indirect-NMA",
      Display = "indirect network meta-analysis",
      System = "http://terminology.hl7.org/CodeSystem/synthesis-type"
    };
    /// <summary>
    /// A meta-analysis of the individual participant data from individual studies or data sets.
    /// </summary>
    public static readonly Coding IndividualPatientDataMetaAnalysis = new Coding
    {
      Code = "IPD-MA",
      Display = "individual patient data meta-analysis",
      System = "http://terminology.hl7.org/CodeSystem/synthesis-type"
    };
    /// <summary>
    /// Not applicable because the evidence is not from a synthesis but from a single study. Used fo explicitly state that it's not a synthesis.
    /// </summary>
    public static readonly Coding NotApplicable = new Coding
    {
      Code = "NotApplicable",
      Display = "not applicable",
      System = "http://terminology.hl7.org/CodeSystem/synthesis-type"
    };
    /// <summary>
    /// A range of results across a body of evidence.
    /// </summary>
    public static readonly Coding RangeOfResults = new Coding
    {
      Code = "range",
      Display = "range of results",
      System = "http://terminology.hl7.org/CodeSystem/synthesis-type"
    };
    /// <summary>
    /// A meta-analysis of the summary data of estimates from individual studies or data sets.
    /// </summary>
    public static readonly Coding SummaryDataMetaAnalysis = new Coding
    {
      Code = "std-MA",
      Display = "summary data meta-analysis",
      System = "http://terminology.hl7.org/CodeSystem/synthesis-type"
    };

    /// <summary>
    /// Literal for code: ClassifcationOfResults
    /// </summary>
    public const string LiteralClassifcationOfResults = "classification";

    /// <summary>
    /// Literal for code: SynthesisTypeClassifcationOfResults
    /// </summary>
    public const string LiteralSynthesisTypeClassifcationOfResults = "http://terminology.hl7.org/CodeSystem/synthesis-type#classification";

    /// <summary>
    /// Literal for code: CombinedDirectPlusIndirectNetworkMetaAnalysis
    /// </summary>
    public const string LiteralCombinedDirectPlusIndirectNetworkMetaAnalysis = "combined-NMA";

    /// <summary>
    /// Literal for code: SynthesisTypeCombinedDirectPlusIndirectNetworkMetaAnalysis
    /// </summary>
    public const string LiteralSynthesisTypeCombinedDirectPlusIndirectNetworkMetaAnalysis = "http://terminology.hl7.org/CodeSystem/synthesis-type#combined-NMA";

    /// <summary>
    /// Literal for code: IndirectNetworkMetaAnalysis
    /// </summary>
    public const string LiteralIndirectNetworkMetaAnalysis = "indirect-NMA";

    /// <summary>
    /// Literal for code: SynthesisTypeIndirectNetworkMetaAnalysis
    /// </summary>
    public const string LiteralSynthesisTypeIndirectNetworkMetaAnalysis = "http://terminology.hl7.org/CodeSystem/synthesis-type#indirect-NMA";

    /// <summary>
    /// Literal for code: IndividualPatientDataMetaAnalysis
    /// </summary>
    public const string LiteralIndividualPatientDataMetaAnalysis = "IPD-MA";

    /// <summary>
    /// Literal for code: SynthesisTypeIndividualPatientDataMetaAnalysis
    /// </summary>
    public const string LiteralSynthesisTypeIndividualPatientDataMetaAnalysis = "http://terminology.hl7.org/CodeSystem/synthesis-type#IPD-MA";

    /// <summary>
    /// Literal for code: NotApplicable
    /// </summary>
    public const string LiteralNotApplicable = "NotApplicable";

    /// <summary>
    /// Literal for code: SynthesisTypeNotApplicable
    /// </summary>
    public const string LiteralSynthesisTypeNotApplicable = "http://terminology.hl7.org/CodeSystem/synthesis-type#NotApplicable";

    /// <summary>
    /// Literal for code: RangeOfResults
    /// </summary>
    public const string LiteralRangeOfResults = "range";

    /// <summary>
    /// Literal for code: SynthesisTypeRangeOfResults
    /// </summary>
    public const string LiteralSynthesisTypeRangeOfResults = "http://terminology.hl7.org/CodeSystem/synthesis-type#range";

    /// <summary>
    /// Literal for code: SummaryDataMetaAnalysis
    /// </summary>
    public const string LiteralSummaryDataMetaAnalysis = "std-MA";

    /// <summary>
    /// Literal for code: SynthesisTypeSummaryDataMetaAnalysis
    /// </summary>
    public const string LiteralSynthesisTypeSummaryDataMetaAnalysis = "http://terminology.hl7.org/CodeSystem/synthesis-type#std-MA";

    /// <summary>
    /// Dictionary for looking up SynthesisType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "classification", ClassifcationOfResults }, 
      { "http://terminology.hl7.org/CodeSystem/synthesis-type#classification", ClassifcationOfResults }, 
      { "combined-NMA", CombinedDirectPlusIndirectNetworkMetaAnalysis }, 
      { "http://terminology.hl7.org/CodeSystem/synthesis-type#combined-NMA", CombinedDirectPlusIndirectNetworkMetaAnalysis }, 
      { "indirect-NMA", IndirectNetworkMetaAnalysis }, 
      { "http://terminology.hl7.org/CodeSystem/synthesis-type#indirect-NMA", IndirectNetworkMetaAnalysis }, 
      { "IPD-MA", IndividualPatientDataMetaAnalysis }, 
      { "http://terminology.hl7.org/CodeSystem/synthesis-type#IPD-MA", IndividualPatientDataMetaAnalysis }, 
      { "NotApplicable", NotApplicable }, 
      { "http://terminology.hl7.org/CodeSystem/synthesis-type#NotApplicable", NotApplicable }, 
      { "range", RangeOfResults }, 
      { "http://terminology.hl7.org/CodeSystem/synthesis-type#range", RangeOfResults }, 
      { "std-MA", SummaryDataMetaAnalysis }, 
      { "http://terminology.hl7.org/CodeSystem/synthesis-type#std-MA", SummaryDataMetaAnalysis }, 
    };
  };
}
