// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Type if a sequence -- DNA, RNA, or amino acid sequence.
  /// </summary>
  public static class SequenceTypeCodes
  {
    /// <summary>
    /// Amino acid sequence.
    /// </summary>
    public static readonly Coding AASequence = new Coding
    {
      Code = "aa",
      Display = "AA Sequence",
      System = "http://hl7.org/fhir/sequence-type"
    };
    /// <summary>
    /// DNA Sequence.
    /// </summary>
    public static readonly Coding DNASequence = new Coding
    {
      Code = "dna",
      Display = "DNA Sequence",
      System = "http://hl7.org/fhir/sequence-type"
    };
    /// <summary>
    /// RNA Sequence.
    /// </summary>
    public static readonly Coding RNASequence = new Coding
    {
      Code = "rna",
      Display = "RNA Sequence",
      System = "http://hl7.org/fhir/sequence-type"
    };
  };
}
