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
  /// JSON Serialization Extensions for BiologicallyDerivedProduct
  /// </summary>
  public static class BiologicallyDerivedProductJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR BiologicallyDerivedProduct into JSON
    /// </summary>
    public static void SerializeJson(this BiologicallyDerivedProduct current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","BiologicallyDerivedProduct");
      // Complex: BiologicallyDerivedProduct, Export: BiologicallyDerivedProduct, Base: DomainResource (DomainResource)
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

      if (current.ProductCategoryElement != null)
      {
        if (current.ProductCategoryElement.Value != null)
        {
          writer.WriteString("productCategory",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.ProductCategoryElement.Value));
        }
        if (current.ProductCategoryElement.HasExtensions() || (!string.IsNullOrEmpty(current.ProductCategoryElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_productCategory",false,current.ProductCategoryElement.Extension,current.ProductCategoryElement.ElementId);
        }
      }

      if (current.ProductCode != null)
      {
        writer.WritePropertyName("productCode");
        current.ProductCode.SerializeJson(writer, options);
      }

      if (current.StatusElement != null)
      {
        if (current.StatusElement.Value != null)
        {
          writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));
        }
        if (current.StatusElement.HasExtensions() || (!string.IsNullOrEmpty(current.StatusElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_status",false,current.StatusElement.Extension,current.StatusElement.ElementId);
        }
      }

      if ((current.Request != null) && (current.Request.Count != 0))
      {
        writer.WritePropertyName("request");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Request)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.QuantityElement != null)
      {
        if (current.QuantityElement.Value != null)
        {
          writer.WriteNumber("quantity",(int)current.QuantityElement.Value);
        }
        if (current.QuantityElement.HasExtensions() || (!string.IsNullOrEmpty(current.QuantityElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_quantity",false,current.QuantityElement.Extension,current.QuantityElement.ElementId);
        }
      }

      if ((current.Parent != null) && (current.Parent.Count != 0))
      {
        writer.WritePropertyName("parent");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Parent)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Collection != null)
      {
        writer.WritePropertyName("collection");
        current.Collection.SerializeJson(writer, options);
      }

      if ((current.Processing != null) && (current.Processing.Count != 0))
      {
        writer.WritePropertyName("processing");
        writer.WriteStartArray();
        foreach (BiologicallyDerivedProduct.ProcessingComponent val in current.Processing)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Manipulation != null)
      {
        writer.WritePropertyName("manipulation");
        current.Manipulation.SerializeJson(writer, options);
      }

      if ((current.Storage != null) && (current.Storage.Count != 0))
      {
        writer.WritePropertyName("storage");
        writer.WriteStartArray();
        foreach (BiologicallyDerivedProduct.StorageComponent val in current.Storage)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR BiologicallyDerivedProduct
    /// </summary>
    public static void DeserializeJson(this BiologicallyDerivedProduct current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"BiologicallyDerivedProduct >>> BiologicallyDerivedProduct.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"BiologicallyDerivedProduct: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR BiologicallyDerivedProduct
    /// </summary>
    public static void DeserializeJsonProperty(this BiologicallyDerivedProduct current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"BiologicallyDerivedProduct error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
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

        case "productCategory":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ProductCategoryElement = new Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductCategory>();
            reader.Skip();
          }
          else
          {
            current.ProductCategoryElement = new Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductCategory>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductCategory>(reader.GetString()));
          }
          break;

        case "_productCategory":
          if (current.ProductCategoryElement == null) { current.ProductCategoryElement = new Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductCategory>(); }
          ((Hl7.Fhir.Model.Element)current.ProductCategoryElement).DeserializeJson(ref reader, options);
          break;

        case "productCode":
          current.ProductCode = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.ProductCode).DeserializeJson(ref reader, options);
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStatus>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStatus>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStatus>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "request":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"BiologicallyDerivedProduct error reading 'request' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Request = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Request = new Hl7.Fhir.Model.ResourceReference();
            v_Request.DeserializeJson(ref reader, options);
            current.Request.Add(v_Request);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Request.Count == 0)
          {
            current.Request = null;
          }
          break;

        case "quantity":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.QuantityElement = new Integer();
            reader.Skip();
          }
          else
          {
            current.QuantityElement = new Integer(reader.GetInt32());
          }
          break;

        case "_quantity":
          if (current.QuantityElement == null) { current.QuantityElement = new Integer(); }
          ((Hl7.Fhir.Model.Element)current.QuantityElement).DeserializeJson(ref reader, options);
          break;

        case "parent":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"BiologicallyDerivedProduct error reading 'parent' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Parent = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Parent = new Hl7.Fhir.Model.ResourceReference();
            v_Parent.DeserializeJson(ref reader, options);
            current.Parent.Add(v_Parent);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Parent.Count == 0)
          {
            current.Parent = null;
          }
          break;

        case "collection":
          current.Collection = new Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent();
          ((Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent)current.Collection).DeserializeJson(ref reader, options);
          break;

        case "processing":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"BiologicallyDerivedProduct error reading 'processing' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Processing = new List<BiologicallyDerivedProduct.ProcessingComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.BiologicallyDerivedProduct.ProcessingComponent v_Processing = new Hl7.Fhir.Model.BiologicallyDerivedProduct.ProcessingComponent();
            v_Processing.DeserializeJson(ref reader, options);
            current.Processing.Add(v_Processing);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Processing.Count == 0)
          {
            current.Processing = null;
          }
          break;

        case "manipulation":
          current.Manipulation = new Hl7.Fhir.Model.BiologicallyDerivedProduct.ManipulationComponent();
          ((Hl7.Fhir.Model.BiologicallyDerivedProduct.ManipulationComponent)current.Manipulation).DeserializeJson(ref reader, options);
          break;

        case "storage":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"BiologicallyDerivedProduct error reading 'storage' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Storage = new List<BiologicallyDerivedProduct.StorageComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.BiologicallyDerivedProduct.StorageComponent v_Storage = new Hl7.Fhir.Model.BiologicallyDerivedProduct.StorageComponent();
            v_Storage.DeserializeJson(ref reader, options);
            current.Storage.Add(v_Storage);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Storage.Count == 0)
          {
            current.Storage = null;
          }
          break;

        // Complex: BiologicallyDerivedProduct, Export: BiologicallyDerivedProduct, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR BiologicallyDerivedProduct#Collection into JSON
    /// </summary>
    public static void SerializeJson(this BiologicallyDerivedProduct.CollectionComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: BiologicallyDerivedProduct#Collection, Export: CollectionComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Collector != null)
      {
        writer.WritePropertyName("collector");
        current.Collector.SerializeJson(writer, options);
      }

      if (current.Source != null)
      {
        writer.WritePropertyName("source");
        current.Source.SerializeJson(writer, options);
      }

      if (current.Collected != null)
      {
        switch (current.Collected)
        {
          case FhirDateTime v_FhirDateTime:
            if (v_FhirDateTime != null)
            {
              if (!string.IsNullOrEmpty(v_FhirDateTime.Value))
              {
                writer.WriteString("collectedDateTime",v_FhirDateTime.Value);
              }
              if (v_FhirDateTime.HasExtensions() || (!string.IsNullOrEmpty(v_FhirDateTime.ElementId)))
              {
                JsonStreamUtilities.SerializeExtensionList(writer,options,"_collectedDateTime",false,v_FhirDateTime.Extension,v_FhirDateTime.ElementId);
              }
            }
            break;
          case Period v_Period:
            writer.WritePropertyName("collectedPeriod");
            v_Period.SerializeJson(writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR BiologicallyDerivedProduct#Collection
    /// </summary>
    public static void DeserializeJson(this BiologicallyDerivedProduct.CollectionComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"BiologicallyDerivedProduct.CollectionComponent >>> BiologicallyDerivedProduct#Collection.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"BiologicallyDerivedProduct.CollectionComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR BiologicallyDerivedProduct#Collection
    /// </summary>
    public static void DeserializeJsonProperty(this BiologicallyDerivedProduct.CollectionComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "collector":
          current.Collector = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Collector).DeserializeJson(ref reader, options);
          break;

        case "source":
          current.Source = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Source).DeserializeJson(ref reader, options);
          break;

        case "collectedDateTime":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Collected = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.Collected = new FhirDateTime(reader.GetString());
          }
          break;

        case "_collectedDateTime":
          if (current.Collected == null) { current.Collected = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.Collected).DeserializeJson(ref reader, options);
          break;

        case "collectedPeriod":
          current.Collected = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Collected).DeserializeJson(ref reader, options);
          break;

        // Complex: collection, Export: CollectionComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR BiologicallyDerivedProduct#Processing into JSON
    /// </summary>
    public static void SerializeJson(this BiologicallyDerivedProduct.ProcessingComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: BiologicallyDerivedProduct#Processing, Export: ProcessingComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.DescriptionElement != null)
      {
        if (!string.IsNullOrEmpty(current.DescriptionElement.Value))
        {
          writer.WriteString("description",current.DescriptionElement.Value);
        }
        if (current.DescriptionElement.HasExtensions() || (!string.IsNullOrEmpty(current.DescriptionElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_description",false,current.DescriptionElement.Extension,current.DescriptionElement.ElementId);
        }
      }

      if (current.Procedure != null)
      {
        writer.WritePropertyName("procedure");
        current.Procedure.SerializeJson(writer, options);
      }

      if (current.Additive != null)
      {
        writer.WritePropertyName("additive");
        current.Additive.SerializeJson(writer, options);
      }

      if (current.Time != null)
      {
        switch (current.Time)
        {
          case FhirDateTime v_FhirDateTime:
            if (v_FhirDateTime != null)
            {
              if (!string.IsNullOrEmpty(v_FhirDateTime.Value))
              {
                writer.WriteString("timeDateTime",v_FhirDateTime.Value);
              }
              if (v_FhirDateTime.HasExtensions() || (!string.IsNullOrEmpty(v_FhirDateTime.ElementId)))
              {
                JsonStreamUtilities.SerializeExtensionList(writer,options,"_timeDateTime",false,v_FhirDateTime.Extension,v_FhirDateTime.ElementId);
              }
            }
            break;
          case Period v_Period:
            writer.WritePropertyName("timePeriod");
            v_Period.SerializeJson(writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR BiologicallyDerivedProduct#Processing
    /// </summary>
    public static void DeserializeJson(this BiologicallyDerivedProduct.ProcessingComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"BiologicallyDerivedProduct.ProcessingComponent >>> BiologicallyDerivedProduct#Processing.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"BiologicallyDerivedProduct.ProcessingComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR BiologicallyDerivedProduct#Processing
    /// </summary>
    public static void DeserializeJsonProperty(this BiologicallyDerivedProduct.ProcessingComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "description":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DescriptionElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.DescriptionElement = new FhirString(reader.GetString());
          }
          break;

        case "_description":
          if (current.DescriptionElement == null) { current.DescriptionElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.DescriptionElement).DeserializeJson(ref reader, options);
          break;

        case "procedure":
          current.Procedure = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Procedure).DeserializeJson(ref reader, options);
          break;

        case "additive":
          current.Additive = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Additive).DeserializeJson(ref reader, options);
          break;

        case "timeDateTime":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Time = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.Time = new FhirDateTime(reader.GetString());
          }
          break;

        case "_timeDateTime":
          if (current.Time == null) { current.Time = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.Time).DeserializeJson(ref reader, options);
          break;

        case "timePeriod":
          current.Time = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Time).DeserializeJson(ref reader, options);
          break;

        // Complex: processing, Export: ProcessingComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR BiologicallyDerivedProduct#Manipulation into JSON
    /// </summary>
    public static void SerializeJson(this BiologicallyDerivedProduct.ManipulationComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: BiologicallyDerivedProduct#Manipulation, Export: ManipulationComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.DescriptionElement != null)
      {
        if (!string.IsNullOrEmpty(current.DescriptionElement.Value))
        {
          writer.WriteString("description",current.DescriptionElement.Value);
        }
        if (current.DescriptionElement.HasExtensions() || (!string.IsNullOrEmpty(current.DescriptionElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_description",false,current.DescriptionElement.Extension,current.DescriptionElement.ElementId);
        }
      }

      if (current.Time != null)
      {
        switch (current.Time)
        {
          case FhirDateTime v_FhirDateTime:
            if (v_FhirDateTime != null)
            {
              if (!string.IsNullOrEmpty(v_FhirDateTime.Value))
              {
                writer.WriteString("timeDateTime",v_FhirDateTime.Value);
              }
              if (v_FhirDateTime.HasExtensions() || (!string.IsNullOrEmpty(v_FhirDateTime.ElementId)))
              {
                JsonStreamUtilities.SerializeExtensionList(writer,options,"_timeDateTime",false,v_FhirDateTime.Extension,v_FhirDateTime.ElementId);
              }
            }
            break;
          case Period v_Period:
            writer.WritePropertyName("timePeriod");
            v_Period.SerializeJson(writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR BiologicallyDerivedProduct#Manipulation
    /// </summary>
    public static void DeserializeJson(this BiologicallyDerivedProduct.ManipulationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"BiologicallyDerivedProduct.ManipulationComponent >>> BiologicallyDerivedProduct#Manipulation.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"BiologicallyDerivedProduct.ManipulationComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR BiologicallyDerivedProduct#Manipulation
    /// </summary>
    public static void DeserializeJsonProperty(this BiologicallyDerivedProduct.ManipulationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "description":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DescriptionElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.DescriptionElement = new FhirString(reader.GetString());
          }
          break;

        case "_description":
          if (current.DescriptionElement == null) { current.DescriptionElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.DescriptionElement).DeserializeJson(ref reader, options);
          break;

        case "timeDateTime":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Time = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.Time = new FhirDateTime(reader.GetString());
          }
          break;

        case "_timeDateTime":
          if (current.Time == null) { current.Time = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.Time).DeserializeJson(ref reader, options);
          break;

        case "timePeriod":
          current.Time = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Time).DeserializeJson(ref reader, options);
          break;

        // Complex: manipulation, Export: ManipulationComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR BiologicallyDerivedProduct#Storage into JSON
    /// </summary>
    public static void SerializeJson(this BiologicallyDerivedProduct.StorageComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: BiologicallyDerivedProduct#Storage, Export: StorageComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.DescriptionElement != null)
      {
        if (!string.IsNullOrEmpty(current.DescriptionElement.Value))
        {
          writer.WriteString("description",current.DescriptionElement.Value);
        }
        if (current.DescriptionElement.HasExtensions() || (!string.IsNullOrEmpty(current.DescriptionElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_description",false,current.DescriptionElement.Extension,current.DescriptionElement.ElementId);
        }
      }

      if (current.TemperatureElement != null)
      {
        if (current.TemperatureElement.Value != null)
        {
          writer.WriteNumber("temperature",(decimal)current.TemperatureElement.Value);
        }
        if (current.TemperatureElement.HasExtensions() || (!string.IsNullOrEmpty(current.TemperatureElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_temperature",false,current.TemperatureElement.Extension,current.TemperatureElement.ElementId);
        }
      }

      if (current.ScaleElement != null)
      {
        if (current.ScaleElement.Value != null)
        {
          writer.WriteString("scale",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.ScaleElement.Value));
        }
        if (current.ScaleElement.HasExtensions() || (!string.IsNullOrEmpty(current.ScaleElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_scale",false,current.ScaleElement.Extension,current.ScaleElement.ElementId);
        }
      }

      if (current.Duration != null)
      {
        writer.WritePropertyName("duration");
        current.Duration.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR BiologicallyDerivedProduct#Storage
    /// </summary>
    public static void DeserializeJson(this BiologicallyDerivedProduct.StorageComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"BiologicallyDerivedProduct.StorageComponent >>> BiologicallyDerivedProduct#Storage.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"BiologicallyDerivedProduct.StorageComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR BiologicallyDerivedProduct#Storage
    /// </summary>
    public static void DeserializeJsonProperty(this BiologicallyDerivedProduct.StorageComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "description":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DescriptionElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.DescriptionElement = new FhirString(reader.GetString());
          }
          break;

        case "_description":
          if (current.DescriptionElement == null) { current.DescriptionElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.DescriptionElement).DeserializeJson(ref reader, options);
          break;

        case "temperature":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.TemperatureElement = new FhirDecimal();
            reader.Skip();
          }
          else
          {
            current.TemperatureElement = new FhirDecimal(reader.GetDecimal());
          }
          break;

        case "_temperature":
          if (current.TemperatureElement == null) { current.TemperatureElement = new FhirDecimal(); }
          ((Hl7.Fhir.Model.Element)current.TemperatureElement).DeserializeJson(ref reader, options);
          break;

        case "scale":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ScaleElement = new Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale>();
            reader.Skip();
          }
          else
          {
            current.ScaleElement = new Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale>(reader.GetString()));
          }
          break;

        case "_scale":
          if (current.ScaleElement == null) { current.ScaleElement = new Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale>(); }
          ((Hl7.Fhir.Model.Element)current.ScaleElement).DeserializeJson(ref reader, options);
          break;

        case "duration":
          current.Duration = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Duration).DeserializeJson(ref reader, options);
          break;

        // Complex: storage, Export: StorageComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class BiologicallyDerivedProductJsonConverter : JsonConverter<BiologicallyDerivedProduct>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, BiologicallyDerivedProduct value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override BiologicallyDerivedProduct Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        BiologicallyDerivedProduct target = new BiologicallyDerivedProduct();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
