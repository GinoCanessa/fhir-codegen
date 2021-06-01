// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.JsonExtensions;
using Hl7.Fhir.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model.JsonExtensions
{
  /// <summary>
  /// JSON Serialization Extensions for VisionPrescription
  /// </summary>
  public static class VisionPrescriptionJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR VisionPrescription into JSON
    /// </summary>
    public static void SerializeJson(this VisionPrescription current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","VisionPrescription");
      // Complex: VisionPrescription, Export: VisionPrescription, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if ((current.Identifier != null) && (current.Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();
        foreach (Identifier val in current.Identifier)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));

      writer.WriteString("created",current.CreatedElement.Value);

      writer.WritePropertyName("patient");
      current.Patient.SerializeJson(writer, options);

      if (current.Encounter != null)
      {
        writer.WritePropertyName("encounter");
        current.Encounter.SerializeJson(writer, options);
      }

      writer.WriteString("dateWritten",current.DateWrittenElement.Value);

      writer.WritePropertyName("prescriber");
      current.Prescriber.SerializeJson(writer, options);

      if ((current.LensSpecification != null) && (current.LensSpecification.Count != 0))
      {
        writer.WritePropertyName("lensSpecification");
        writer.WriteStartArray();
        foreach (VisionPrescription.LensSpecificationComponent val in current.LensSpecification)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR VisionPrescription
    /// </summary>
    public static void DeserializeJson(this VisionPrescription current, ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"VisionPrescription >>> VisionPrescription.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"VisionPrescription: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR VisionPrescription
    /// </summary>
    public static void DeserializeJsonProperty(this VisionPrescription current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"VisionPrescription error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.FinancialResourceStatusCodes>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "created":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.CreatedElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.CreatedElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_created":
          if (current.CreatedElement == null) { current.CreatedElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.CreatedElement).DeserializeJson(ref reader, options);
          break;

        case "patient":
          current.Patient = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Patient).DeserializeJson(ref reader, options);
          break;

        case "encounter":
          current.Encounter = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Encounter).DeserializeJson(ref reader, options);
          break;

        case "dateWritten":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DateWrittenElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.DateWrittenElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_dateWritten":
          if (current.DateWrittenElement == null) { current.DateWrittenElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.DateWrittenElement).DeserializeJson(ref reader, options);
          break;

        case "prescriber":
          current.Prescriber = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Prescriber).DeserializeJson(ref reader, options);
          break;

        case "lensSpecification":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"VisionPrescription error reading 'lensSpecification' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.LensSpecification = new List<VisionPrescription.LensSpecificationComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.VisionPrescription.LensSpecificationComponent v_LensSpecification = new Hl7.Fhir.Model.VisionPrescription.LensSpecificationComponent();
            v_LensSpecification.DeserializeJson(ref reader, options);
            current.LensSpecification.Add(v_LensSpecification);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.LensSpecification.Count == 0)
          {
            current.LensSpecification = null;
          }
          break;

        // Complex: VisionPrescription, Export: VisionPrescription, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR VisionPrescription#LensSpecification into JSON
    /// </summary>
    public static void SerializeJson(this VisionPrescription.LensSpecificationComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: VisionPrescription#LensSpecification, Export: LensSpecificationComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WritePropertyName("product");
      current.Product.SerializeJson(writer, options);

      writer.WriteString("eye",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.EyeElement.Value));

      if (current.SphereElement != null)
      {
        if (current.SphereElement.Value != null)
        {
          writer.WriteNumber("sphere",(decimal)current.SphereElement.Value);
        }
        if (current.SphereElement.HasExtensions() || (!string.IsNullOrEmpty(current.SphereElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_sphere",false,current.SphereElement.Extension,current.SphereElement.ElementId);
        }
      }

      if (current.CylinderElement != null)
      {
        if (current.CylinderElement.Value != null)
        {
          writer.WriteNumber("cylinder",(decimal)current.CylinderElement.Value);
        }
        if (current.CylinderElement.HasExtensions() || (!string.IsNullOrEmpty(current.CylinderElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_cylinder",false,current.CylinderElement.Extension,current.CylinderElement.ElementId);
        }
      }

      if (current.AxisElement != null)
      {
        if (current.AxisElement.Value != null)
        {
          writer.WriteNumber("axis",(int)current.AxisElement.Value);
        }
        if (current.AxisElement.HasExtensions() || (!string.IsNullOrEmpty(current.AxisElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_axis",false,current.AxisElement.Extension,current.AxisElement.ElementId);
        }
      }

      if ((current.Prism != null) && (current.Prism.Count != 0))
      {
        writer.WritePropertyName("prism");
        writer.WriteStartArray();
        foreach (VisionPrescription.PrismComponent val in current.Prism)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.AddElement != null)
      {
        if (current.AddElement.Value != null)
        {
          writer.WriteNumber("add",(decimal)current.AddElement.Value);
        }
        if (current.AddElement.HasExtensions() || (!string.IsNullOrEmpty(current.AddElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_add",false,current.AddElement.Extension,current.AddElement.ElementId);
        }
      }

      if (current.PowerElement != null)
      {
        if (current.PowerElement.Value != null)
        {
          writer.WriteNumber("power",(decimal)current.PowerElement.Value);
        }
        if (current.PowerElement.HasExtensions() || (!string.IsNullOrEmpty(current.PowerElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_power",false,current.PowerElement.Extension,current.PowerElement.ElementId);
        }
      }

      if (current.BackCurveElement != null)
      {
        if (current.BackCurveElement.Value != null)
        {
          writer.WriteNumber("backCurve",(decimal)current.BackCurveElement.Value);
        }
        if (current.BackCurveElement.HasExtensions() || (!string.IsNullOrEmpty(current.BackCurveElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_backCurve",false,current.BackCurveElement.Extension,current.BackCurveElement.ElementId);
        }
      }

      if (current.DiameterElement != null)
      {
        if (current.DiameterElement.Value != null)
        {
          writer.WriteNumber("diameter",(decimal)current.DiameterElement.Value);
        }
        if (current.DiameterElement.HasExtensions() || (!string.IsNullOrEmpty(current.DiameterElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_diameter",false,current.DiameterElement.Extension,current.DiameterElement.ElementId);
        }
      }

      if (current.Duration != null)
      {
        writer.WritePropertyName("duration");
        current.Duration.SerializeJson(writer, options);
      }

      if (current.ColorElement != null)
      {
        if (!string.IsNullOrEmpty(current.ColorElement.Value))
        {
          writer.WriteString("color",current.ColorElement.Value);
        }
        if (current.ColorElement.HasExtensions() || (!string.IsNullOrEmpty(current.ColorElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_color",false,current.ColorElement.Extension,current.ColorElement.ElementId);
        }
      }

      if (current.BrandElement != null)
      {
        if (!string.IsNullOrEmpty(current.BrandElement.Value))
        {
          writer.WriteString("brand",current.BrandElement.Value);
        }
        if (current.BrandElement.HasExtensions() || (!string.IsNullOrEmpty(current.BrandElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_brand",false,current.BrandElement.Extension,current.BrandElement.ElementId);
        }
      }

      if ((current.Note != null) && (current.Note.Count != 0))
      {
        writer.WritePropertyName("note");
        writer.WriteStartArray();
        foreach (Annotation val in current.Note)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR VisionPrescription#LensSpecification
    /// </summary>
    public static void DeserializeJson(this VisionPrescription.LensSpecificationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"VisionPrescription.LensSpecificationComponent >>> VisionPrescription#LensSpecification.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"VisionPrescription.LensSpecificationComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR VisionPrescription#LensSpecification
    /// </summary>
    public static void DeserializeJsonProperty(this VisionPrescription.LensSpecificationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "product":
          current.Product = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Product).DeserializeJson(ref reader, options);
          break;

        case "eye":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.EyeElement = new Code<Hl7.Fhir.Model.VisionPrescription.VisionEyes>();
            reader.Skip();
          }
          else
          {
            current.EyeElement = new Code<Hl7.Fhir.Model.VisionPrescription.VisionEyes>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.VisionPrescription.VisionEyes>(reader.GetString()));
          }
          break;

        case "_eye":
          if (current.EyeElement == null) { current.EyeElement = new Code<Hl7.Fhir.Model.VisionPrescription.VisionEyes>(); }
          ((Hl7.Fhir.Model.Element)current.EyeElement).DeserializeJson(ref reader, options);
          break;

        case "sphere":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.SphereElement = new FhirDecimal();
            reader.Skip();
          }
          else
          {
            current.SphereElement = new FhirDecimal(reader.GetDecimal());
          }
          break;

        case "_sphere":
          if (current.SphereElement == null) { current.SphereElement = new FhirDecimal(); }
          ((Hl7.Fhir.Model.Element)current.SphereElement).DeserializeJson(ref reader, options);
          break;

        case "cylinder":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.CylinderElement = new FhirDecimal();
            reader.Skip();
          }
          else
          {
            current.CylinderElement = new FhirDecimal(reader.GetDecimal());
          }
          break;

        case "_cylinder":
          if (current.CylinderElement == null) { current.CylinderElement = new FhirDecimal(); }
          ((Hl7.Fhir.Model.Element)current.CylinderElement).DeserializeJson(ref reader, options);
          break;

        case "axis":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.AxisElement = new Integer();
            reader.Skip();
          }
          else
          {
            current.AxisElement = new Integer(reader.GetInt32());
          }
          break;

        case "_axis":
          if (current.AxisElement == null) { current.AxisElement = new Integer(); }
          ((Hl7.Fhir.Model.Element)current.AxisElement).DeserializeJson(ref reader, options);
          break;

        case "prism":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"LensSpecificationComponent error reading 'prism' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Prism = new List<VisionPrescription.PrismComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.VisionPrescription.PrismComponent v_Prism = new Hl7.Fhir.Model.VisionPrescription.PrismComponent();
            v_Prism.DeserializeJson(ref reader, options);
            current.Prism.Add(v_Prism);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Prism.Count == 0)
          {
            current.Prism = null;
          }
          break;

        case "add":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.AddElement = new FhirDecimal();
            reader.Skip();
          }
          else
          {
            current.AddElement = new FhirDecimal(reader.GetDecimal());
          }
          break;

        case "_add":
          if (current.AddElement == null) { current.AddElement = new FhirDecimal(); }
          ((Hl7.Fhir.Model.Element)current.AddElement).DeserializeJson(ref reader, options);
          break;

        case "power":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.PowerElement = new FhirDecimal();
            reader.Skip();
          }
          else
          {
            current.PowerElement = new FhirDecimal(reader.GetDecimal());
          }
          break;

        case "_power":
          if (current.PowerElement == null) { current.PowerElement = new FhirDecimal(); }
          ((Hl7.Fhir.Model.Element)current.PowerElement).DeserializeJson(ref reader, options);
          break;

        case "backCurve":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.BackCurveElement = new FhirDecimal();
            reader.Skip();
          }
          else
          {
            current.BackCurveElement = new FhirDecimal(reader.GetDecimal());
          }
          break;

        case "_backCurve":
          if (current.BackCurveElement == null) { current.BackCurveElement = new FhirDecimal(); }
          ((Hl7.Fhir.Model.Element)current.BackCurveElement).DeserializeJson(ref reader, options);
          break;

        case "diameter":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DiameterElement = new FhirDecimal();
            reader.Skip();
          }
          else
          {
            current.DiameterElement = new FhirDecimal(reader.GetDecimal());
          }
          break;

        case "_diameter":
          if (current.DiameterElement == null) { current.DiameterElement = new FhirDecimal(); }
          ((Hl7.Fhir.Model.Element)current.DiameterElement).DeserializeJson(ref reader, options);
          break;

        case "duration":
          current.Duration = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.Duration).DeserializeJson(ref reader, options);
          break;

        case "color":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ColorElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.ColorElement = new FhirString(reader.GetString());
          }
          break;

        case "_color":
          if (current.ColorElement == null) { current.ColorElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.ColorElement).DeserializeJson(ref reader, options);
          break;

        case "brand":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.BrandElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.BrandElement = new FhirString(reader.GetString());
          }
          break;

        case "_brand":
          if (current.BrandElement == null) { current.BrandElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.BrandElement).DeserializeJson(ref reader, options);
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"LensSpecificationComponent error reading 'note' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Annotation v_Note = new Hl7.Fhir.Model.Annotation();
            v_Note.DeserializeJson(ref reader, options);
            current.Note.Add(v_Note);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Note.Count == 0)
          {
            current.Note = null;
          }
          break;

        // Complex: lensSpecification, Export: LensSpecificationComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR VisionPrescription#Prism into JSON
    /// </summary>
    public static void SerializeJson(this VisionPrescription.PrismComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: VisionPrescription#Prism, Export: PrismComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WriteNumber("amount",(decimal)current.AmountElement.Value);

      writer.WriteString("base",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.BaseElement.Value));

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR VisionPrescription#Prism
    /// </summary>
    public static void DeserializeJson(this VisionPrescription.PrismComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"VisionPrescription.PrismComponent >>> VisionPrescription#Prism.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"VisionPrescription.PrismComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR VisionPrescription#Prism
    /// </summary>
    public static void DeserializeJsonProperty(this VisionPrescription.PrismComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "amount":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.AmountElement = new FhirDecimal();
            reader.Skip();
          }
          else
          {
            current.AmountElement = new FhirDecimal(reader.GetDecimal());
          }
          break;

        case "_amount":
          if (current.AmountElement == null) { current.AmountElement = new FhirDecimal(); }
          ((Hl7.Fhir.Model.Element)current.AmountElement).DeserializeJson(ref reader, options);
          break;

        case "base":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.BaseElement = new Code<Hl7.Fhir.Model.VisionPrescription.VisionBase>();
            reader.Skip();
          }
          else
          {
            current.BaseElement = new Code<Hl7.Fhir.Model.VisionPrescription.VisionBase>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.VisionPrescription.VisionBase>(reader.GetString()));
          }
          break;

        case "_base":
          if (current.BaseElement == null) { current.BaseElement = new Code<Hl7.Fhir.Model.VisionPrescription.VisionBase>(); }
          ((Hl7.Fhir.Model.Element)current.BaseElement).DeserializeJson(ref reader, options);
          break;

        // Complex: prism, Export: PrismComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class VisionPrescriptionJsonConverter : JsonConverter<VisionPrescription>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, VisionPrescription value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override VisionPrescription Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        VisionPrescription target = new VisionPrescription();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
