// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set includes smattering of Payment Adjustment Reason codes.
  /// </summary>
  public static class PaymentAdjustmentReasonCodes
  {
    /// <summary>
    /// Prior Payment Reversal
    /// </summary>
    public static readonly Coding PriorPaymentReversal = new Coding
    {
      Code = "a001",
      Display = "Prior Payment Reversal",
      System = "http://terminology.hl7.org/CodeSystem/payment-adjustment-reason"
    };
    /// <summary>
    /// Prior Overpayment
    /// </summary>
    public static readonly Coding PriorOverpayment = new Coding
    {
      Code = "a002",
      Display = "Prior Overpayment",
      System = "http://terminology.hl7.org/CodeSystem/payment-adjustment-reason"
    };

    /// <summary>
    /// Literal for code: PriorPaymentReversal
    /// </summary>
    public const string LiteralPriorPaymentReversal = "a001";

    /// <summary>
    /// Literal for code: PaymentAdjustmentReasonPriorPaymentReversal
    /// </summary>
    public const string LiteralPaymentAdjustmentReasonPriorPaymentReversal = "http://terminology.hl7.org/CodeSystem/payment-adjustment-reason#a001";

    /// <summary>
    /// Literal for code: PriorOverpayment
    /// </summary>
    public const string LiteralPriorOverpayment = "a002";

    /// <summary>
    /// Literal for code: PaymentAdjustmentReasonPriorOverpayment
    /// </summary>
    public const string LiteralPaymentAdjustmentReasonPriorOverpayment = "http://terminology.hl7.org/CodeSystem/payment-adjustment-reason#a002";

    /// <summary>
    /// Dictionary for looking up PaymentAdjustmentReason Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "a001", PriorPaymentReversal }, 
      { "http://terminology.hl7.org/CodeSystem/payment-adjustment-reason#a001", PriorPaymentReversal }, 
      { "a002", PriorOverpayment }, 
      { "http://terminology.hl7.org/CodeSystem/payment-adjustment-reason#a002", PriorOverpayment }, 
    };
  };
}
