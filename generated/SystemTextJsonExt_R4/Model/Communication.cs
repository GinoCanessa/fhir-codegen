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
  /// JSON Serialization Extensions for Communication
  /// </summary>
  public static class CommunicationJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR Communication into JSON
    /// </summary>
    public static void SerializeJson(this Communication current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Communication");
      // Complex: Communication, Export: Communication, Base: DomainResource (DomainResource)
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

      if ((current.InstantiatesCanonicalElement != null) && (current.InstantiatesCanonicalElement.Count != 0))
      {
        int valueCount = 0;
        int extensionCount = 0;
        foreach (Canonical val in current.InstantiatesCanonicalElement)
        {
          if (!string.IsNullOrEmpty(val.Value)) { valueCount++; }
          if (val.HasExtensions()) { extensionCount++; }
        }

        if (valueCount > 0)
        {
          writer.WritePropertyName("instantiatesCanonical");
          writer.WriteStartArray();
          foreach (Canonical val in current.InstantiatesCanonicalElement)
          {
            if (string.IsNullOrEmpty(val.Value))
            {
              writer.WriteNullValue();
            }
            else
            {
              writer.WriteStringValue(val.Value);
            }
          }

          writer.WriteEndArray();
        }

        if (extensionCount > 0)
        {
          writer.WritePropertyName("_instantiatesCanonical");
          writer.WriteStartArray();
          foreach (Canonical val in current.InstantiatesCanonicalElement)
          {
            if (val.HasExtensions() || (!string.IsNullOrEmpty(val.ElementId)))
            {
              JsonStreamUtilities.SerializeExtensionList(writer,options,string.Empty,true,val.Extension,val.ElementId);
            }
            else
            {
              writer.WriteNullValue();
            }

          }

          writer.WriteEndArray();
        }
      }

      if ((current.InstantiatesUriElement != null) && (current.InstantiatesUriElement.Count != 0))
      {
        int valueCount = 0;
        int extensionCount = 0;
        foreach (FhirUri val in current.InstantiatesUriElement)
        {
          if (!string.IsNullOrEmpty(val.Value)) { valueCount++; }
          if (val.HasExtensions()) { extensionCount++; }
        }

        if (valueCount > 0)
        {
          writer.WritePropertyName("instantiatesUri");
          writer.WriteStartArray();
          foreach (FhirUri val in current.InstantiatesUriElement)
          {
            if (string.IsNullOrEmpty(val.Value))
            {
              writer.WriteNullValue();
            }
            else
            {
              writer.WriteStringValue(val.Value);
            }
          }

          writer.WriteEndArray();
        }

        if (extensionCount > 0)
        {
          writer.WritePropertyName("_instantiatesUri");
          writer.WriteStartArray();
          foreach (FhirUri val in current.InstantiatesUriElement)
          {
            if (val.HasExtensions() || (!string.IsNullOrEmpty(val.ElementId)))
            {
              JsonStreamUtilities.SerializeExtensionList(writer,options,string.Empty,true,val.Extension,val.ElementId);
            }
            else
            {
              writer.WriteNullValue();
            }

          }

          writer.WriteEndArray();
        }
      }

      if ((current.BasedOn != null) && (current.BasedOn.Count != 0))
      {
        writer.WritePropertyName("basedOn");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.BasedOn)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.PartOf != null) && (current.PartOf.Count != 0))
      {
        writer.WritePropertyName("partOf");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.PartOf)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.InResponseTo != null) && (current.InResponseTo.Count != 0))
      {
        writer.WritePropertyName("inResponseTo");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.InResponseTo)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));

      if (current.StatusReason != null)
      {
        writer.WritePropertyName("statusReason");
        current.StatusReason.SerializeJson(writer, options);
      }

      if ((current.Category != null) && (current.Category.Count != 0))
      {
        writer.WritePropertyName("category");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Category)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.PriorityElement != null)
      {
        if (current.PriorityElement.Value != null)
        {
          writer.WriteString("priority",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.PriorityElement.Value));
        }
        if (current.PriorityElement.HasExtensions() || (!string.IsNullOrEmpty(current.PriorityElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_priority",false,current.PriorityElement.Extension,current.PriorityElement.ElementId);
        }
      }

      if ((current.Medium != null) && (current.Medium.Count != 0))
      {
        writer.WritePropertyName("medium");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Medium)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Subject != null)
      {
        writer.WritePropertyName("subject");
        current.Subject.SerializeJson(writer, options);
      }

      if (current.Topic != null)
      {
        writer.WritePropertyName("topic");
        current.Topic.SerializeJson(writer, options);
      }

      if ((current.About != null) && (current.About.Count != 0))
      {
        writer.WritePropertyName("about");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.About)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Encounter != null)
      {
        writer.WritePropertyName("encounter");
        current.Encounter.SerializeJson(writer, options);
      }

      if (current.SentElement != null)
      {
        if (!string.IsNullOrEmpty(current.SentElement.Value))
        {
          writer.WriteString("sent",current.SentElement.Value);
        }
        if (current.SentElement.HasExtensions() || (!string.IsNullOrEmpty(current.SentElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_sent",false,current.SentElement.Extension,current.SentElement.ElementId);
        }
      }

      if (current.ReceivedElement != null)
      {
        if (!string.IsNullOrEmpty(current.ReceivedElement.Value))
        {
          writer.WriteString("received",current.ReceivedElement.Value);
        }
        if (current.ReceivedElement.HasExtensions() || (!string.IsNullOrEmpty(current.ReceivedElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_received",false,current.ReceivedElement.Extension,current.ReceivedElement.ElementId);
        }
      }

      if ((current.Recipient != null) && (current.Recipient.Count != 0))
      {
        writer.WritePropertyName("recipient");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Recipient)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Sender != null)
      {
        writer.WritePropertyName("sender");
        current.Sender.SerializeJson(writer, options);
      }

      if ((current.ReasonCode != null) && (current.ReasonCode.Count != 0))
      {
        writer.WritePropertyName("reasonCode");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.ReasonCode)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.ReasonReference != null) && (current.ReasonReference.Count != 0))
      {
        writer.WritePropertyName("reasonReference");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.ReasonReference)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Payload != null) && (current.Payload.Count != 0))
      {
        writer.WritePropertyName("payload");
        writer.WriteStartArray();
        foreach (Communication.PayloadComponent val in current.Payload)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
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
    /// Deserialize JSON into a FHIR Communication
    /// </summary>
    public static void DeserializeJson(this Communication current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Communication >>> Communication.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Communication: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Communication
    /// </summary>
    public static void DeserializeJsonProperty(this Communication current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Communication error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
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

        case "instantiatesCanonical":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Communication error reading 'instantiatesCanonical' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.InstantiatesCanonicalElement = new List<Canonical>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.InstantiatesCanonicalElement.Add(new Canonical());
              reader.Skip();
            }
            else
            {
              current.InstantiatesCanonicalElement.Add(new Canonical(reader.GetString()));
            }

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.InstantiatesCanonicalElement.Count == 0)
          {
            current.InstantiatesCanonicalElement = null;
          }
          break;

        case "_instantiatesCanonical":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Communication error reading 'instantiatesCanonical' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_instantiatesCanonical = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_instantiatesCanonical >= current.InstantiatesCanonicalElement.Count)
            {
              current.InstantiatesCanonicalElement.Add(new Canonical());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.InstantiatesCanonicalElement[i_instantiatesCanonical++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "instantiatesUri":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Communication error reading 'instantiatesUri' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.InstantiatesUriElement = new List<FhirUri>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.InstantiatesUriElement.Add(new FhirUri());
              reader.Skip();
            }
            else
            {
              current.InstantiatesUriElement.Add(new FhirUri(reader.GetString()));
            }

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.InstantiatesUriElement.Count == 0)
          {
            current.InstantiatesUriElement = null;
          }
          break;

        case "_instantiatesUri":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Communication error reading 'instantiatesUri' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_instantiatesUri = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_instantiatesUri >= current.InstantiatesUriElement.Count)
            {
              current.InstantiatesUriElement.Add(new FhirUri());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.InstantiatesUriElement[i_instantiatesUri++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "basedOn":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Communication error reading 'basedOn' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.BasedOn = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_BasedOn = new Hl7.Fhir.Model.ResourceReference();
            v_BasedOn.DeserializeJson(ref reader, options);
            current.BasedOn.Add(v_BasedOn);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.BasedOn.Count == 0)
          {
            current.BasedOn = null;
          }
          break;

        case "partOf":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Communication error reading 'partOf' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.PartOf = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_PartOf = new Hl7.Fhir.Model.ResourceReference();
            v_PartOf.DeserializeJson(ref reader, options);
            current.PartOf.Add(v_PartOf);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.PartOf.Count == 0)
          {
            current.PartOf = null;
          }
          break;

        case "inResponseTo":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Communication error reading 'inResponseTo' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.InResponseTo = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_InResponseTo = new Hl7.Fhir.Model.ResourceReference();
            v_InResponseTo.DeserializeJson(ref reader, options);
            current.InResponseTo.Add(v_InResponseTo);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.InResponseTo.Count == 0)
          {
            current.InResponseTo = null;
          }
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.EventStatus>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.EventStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.EventStatus>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.EventStatus>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "statusReason":
          current.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.StatusReason).DeserializeJson(ref reader, options);
          break;

        case "category":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Communication error reading 'category' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Category = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Category = new Hl7.Fhir.Model.CodeableConcept();
            v_Category.DeserializeJson(ref reader, options);
            current.Category.Add(v_Category);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Category.Count == 0)
          {
            current.Category = null;
          }
          break;

        case "priority":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.PriorityElement = new Code<Hl7.Fhir.Model.RequestPriority>();
            reader.Skip();
          }
          else
          {
            current.PriorityElement = new Code<Hl7.Fhir.Model.RequestPriority>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.RequestPriority>(reader.GetString()));
          }
          break;

        case "_priority":
          if (current.PriorityElement == null) { current.PriorityElement = new Code<Hl7.Fhir.Model.RequestPriority>(); }
          ((Hl7.Fhir.Model.Element)current.PriorityElement).DeserializeJson(ref reader, options);
          break;

        case "medium":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Communication error reading 'medium' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Medium = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Medium = new Hl7.Fhir.Model.CodeableConcept();
            v_Medium.DeserializeJson(ref reader, options);
            current.Medium.Add(v_Medium);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Medium.Count == 0)
          {
            current.Medium = null;
          }
          break;

        case "subject":
          current.Subject = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Subject).DeserializeJson(ref reader, options);
          break;

        case "topic":
          current.Topic = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Topic).DeserializeJson(ref reader, options);
          break;

        case "about":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Communication error reading 'about' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.About = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_About = new Hl7.Fhir.Model.ResourceReference();
            v_About.DeserializeJson(ref reader, options);
            current.About.Add(v_About);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.About.Count == 0)
          {
            current.About = null;
          }
          break;

        case "encounter":
          current.Encounter = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Encounter).DeserializeJson(ref reader, options);
          break;

        case "sent":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.SentElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.SentElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_sent":
          if (current.SentElement == null) { current.SentElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.SentElement).DeserializeJson(ref reader, options);
          break;

        case "received":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ReceivedElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.ReceivedElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_received":
          if (current.ReceivedElement == null) { current.ReceivedElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.ReceivedElement).DeserializeJson(ref reader, options);
          break;

        case "recipient":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Communication error reading 'recipient' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Recipient = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Recipient = new Hl7.Fhir.Model.ResourceReference();
            v_Recipient.DeserializeJson(ref reader, options);
            current.Recipient.Add(v_Recipient);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Recipient.Count == 0)
          {
            current.Recipient = null;
          }
          break;

        case "sender":
          current.Sender = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Sender).DeserializeJson(ref reader, options);
          break;

        case "reasonCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Communication error reading 'reasonCode' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ReasonCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_ReasonCode = new Hl7.Fhir.Model.CodeableConcept();
            v_ReasonCode.DeserializeJson(ref reader, options);
            current.ReasonCode.Add(v_ReasonCode);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ReasonCode.Count == 0)
          {
            current.ReasonCode = null;
          }
          break;

        case "reasonReference":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Communication error reading 'reasonReference' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ReasonReference = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_ReasonReference = new Hl7.Fhir.Model.ResourceReference();
            v_ReasonReference.DeserializeJson(ref reader, options);
            current.ReasonReference.Add(v_ReasonReference);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ReasonReference.Count == 0)
          {
            current.ReasonReference = null;
          }
          break;

        case "payload":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Communication error reading 'payload' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Payload = new List<Communication.PayloadComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Communication.PayloadComponent v_Payload = new Hl7.Fhir.Model.Communication.PayloadComponent();
            v_Payload.DeserializeJson(ref reader, options);
            current.Payload.Add(v_Payload);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Payload.Count == 0)
          {
            current.Payload = null;
          }
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Communication error reading 'note' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
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

        // Complex: Communication, Export: Communication, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Communication#Payload into JSON
    /// </summary>
    public static void SerializeJson(this Communication.PayloadComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Communication#Payload, Export: PayloadComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Content != null)
      {
        switch (current.Content)
        {
          case FhirString v_FhirString:
            writer.WriteString("contentString",v_FhirString.Value);
            break;
          case Attachment v_Attachment:
            writer.WritePropertyName("contentAttachment");
            v_Attachment.SerializeJson(writer, options);
            break;
          case ResourceReference v_ResourceReference:
            writer.WritePropertyName("contentReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Communication#Payload
    /// </summary>
    public static void DeserializeJson(this Communication.PayloadComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Communication.PayloadComponent >>> Communication#Payload.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Communication.PayloadComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Communication#Payload
    /// </summary>
    public static void DeserializeJsonProperty(this Communication.PayloadComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "contentString":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Content = new FhirString();
            reader.Skip();
          }
          else
          {
            current.Content = new FhirString(reader.GetString());
          }
          break;

        case "_contentString":
          if (current.Content == null) { current.Content = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.Content).DeserializeJson(ref reader, options);
          break;

        case "contentAttachment":
          current.Content = new Hl7.Fhir.Model.Attachment();
          ((Hl7.Fhir.Model.Attachment)current.Content).DeserializeJson(ref reader, options);
          break;

        case "contentReference":
          current.Content = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Content).DeserializeJson(ref reader, options);
          break;

        // Complex: payload, Export: PayloadComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class CommunicationJsonConverter : JsonConverter<Communication>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Communication value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Communication Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        Communication target = new Communication();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
