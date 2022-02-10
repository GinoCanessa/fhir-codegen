// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// BiologicallyDerived Product Storage Scale.
  /// </summary>
  public static class ProductStorageScaleCodes
  {
    /// <summary>
    /// Celsius or centigrade temperature scale.
    /// </summary>
    public static readonly Coding Celsius = new Coding
    {
      Code = "celsius",
      Display = "Celsius",
      System = "http://hl7.org/fhir/product-storage-scale"
    };
    /// <summary>
    /// Fahrenheit temperature scale.
    /// </summary>
    public static readonly Coding Fahrenheit = new Coding
    {
      Code = "farenheit",
      Display = "Fahrenheit",
      System = "http://hl7.org/fhir/product-storage-scale"
    };
    /// <summary>
    /// Kelvin absolute thermodynamic temperature scale.
    /// </summary>
    public static readonly Coding Kelvin = new Coding
    {
      Code = "kelvin",
      Display = "Kelvin",
      System = "http://hl7.org/fhir/product-storage-scale"
    };

    /// <summary>
    /// Literal for code: Celsius
    /// </summary>
    public const string LiteralCelsius = "celsius";

    /// <summary>
    /// Literal for code: ProductStorageScaleCelsius
    /// </summary>
    public const string LiteralProductStorageScaleCelsius = "http://hl7.org/fhir/product-storage-scale#celsius";

    /// <summary>
    /// Literal for code: Fahrenheit
    /// </summary>
    public const string LiteralFahrenheit = "farenheit";

    /// <summary>
    /// Literal for code: ProductStorageScaleFahrenheit
    /// </summary>
    public const string LiteralProductStorageScaleFahrenheit = "http://hl7.org/fhir/product-storage-scale#farenheit";

    /// <summary>
    /// Literal for code: Kelvin
    /// </summary>
    public const string LiteralKelvin = "kelvin";

    /// <summary>
    /// Literal for code: ProductStorageScaleKelvin
    /// </summary>
    public const string LiteralProductStorageScaleKelvin = "http://hl7.org/fhir/product-storage-scale#kelvin";

    /// <summary>
    /// Dictionary for looking up ProductStorageScale Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "celsius", Celsius }, 
      { "http://hl7.org/fhir/product-storage-scale#celsius", Celsius }, 
      { "farenheit", Fahrenheit }, 
      { "http://hl7.org/fhir/product-storage-scale#farenheit", Fahrenheit }, 
      { "kelvin", Kelvin }, 
      { "http://hl7.org/fhir/product-storage-scale#kelvin", Kelvin }, 
    };
  };
}
