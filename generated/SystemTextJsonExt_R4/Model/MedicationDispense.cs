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
  /// JSON Serialization Extensions for MedicationDispense
  /// </summary>
  public static class MedicationDispenseJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR MedicationDispense into JSON
    /// </summary>
    public static void SerializeJson(this MedicationDispense current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","MedicationDispense");
      // Complex: MedicationDispense, Export: MedicationDispense, Base: DomainResource (DomainResource)
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

      writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));

      if (current.StatusReason != null)
      {
        switch (current.StatusReason)
        {
          case CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("statusReasonCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
          case ResourceReference v_ResourceReference:
            writer.WritePropertyName("statusReasonReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
        }
      }
      if (current.Category != null)
      {
        writer.WritePropertyName("category");
        current.Category.SerializeJson(writer, options);
      }

      if (current.Medication != null)
      {
        switch (current.Medication)
        {
          case CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("medicationCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
          case ResourceReference v_ResourceReference:
            writer.WritePropertyName("medicationReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
        }
      }
      if (current.Subject != null)
      {
        writer.WritePropertyName("subject");
        current.Subject.SerializeJson(writer, options);
      }

      if (current.Context != null)
      {
        writer.WritePropertyName("context");
        current.Context.SerializeJson(writer, options);
      }

      if ((current.SupportingInformation != null) && (current.SupportingInformation.Count != 0))
      {
        writer.WritePropertyName("supportingInformation");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.SupportingInformation)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Performer != null) && (current.Performer.Count != 0))
      {
        writer.WritePropertyName("performer");
        writer.WriteStartArray();
        foreach (MedicationDispense.PerformerComponent val in current.Performer)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Location != null)
      {
        writer.WritePropertyName("location");
        current.Location.SerializeJson(writer, options);
      }

      if ((current.AuthorizingPrescription != null) && (current.AuthorizingPrescription.Count != 0))
      {
        writer.WritePropertyName("authorizingPrescription");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.AuthorizingPrescription)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Type != null)
      {
        writer.WritePropertyName("type");
        current.Type.SerializeJson(writer, options);
      }

      if (current.Quantity != null)
      {
        writer.WritePropertyName("quantity");
        current.Quantity.SerializeJson(writer, options);
      }

      if (current.DaysSupply != null)
      {
        writer.WritePropertyName("daysSupply");
        current.DaysSupply.SerializeJson(writer, options);
      }

      if (current.WhenPreparedElement != null)
      {
        if (!string.IsNullOrEmpty(current.WhenPreparedElement.Value))
        {
          writer.WriteString("whenPrepared",current.WhenPreparedElement.Value);
        }
        if (current.WhenPreparedElement.HasExtensions() || (!string.IsNullOrEmpty(current.WhenPreparedElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_whenPrepared",false,current.WhenPreparedElement.Extension,current.WhenPreparedElement.ElementId);
        }
      }

      if (current.WhenHandedOverElement != null)
      {
        if (!string.IsNullOrEmpty(current.WhenHandedOverElement.Value))
        {
          writer.WriteString("whenHandedOver",current.WhenHandedOverElement.Value);
        }
        if (current.WhenHandedOverElement.HasExtensions() || (!string.IsNullOrEmpty(current.WhenHandedOverElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_whenHandedOver",false,current.WhenHandedOverElement.Extension,current.WhenHandedOverElement.ElementId);
        }
      }

      if (current.Destination != null)
      {
        writer.WritePropertyName("destination");
        current.Destination.SerializeJson(writer, options);
      }

      if ((current.Receiver != null) && (current.Receiver.Count != 0))
      {
        writer.WritePropertyName("receiver");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Receiver)
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

      if ((current.DosageInstruction != null) && (current.DosageInstruction.Count != 0))
      {
        writer.WritePropertyName("dosageInstruction");
        writer.WriteStartArray();
        foreach (Dosage val in current.DosageInstruction)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Substitution != null)
      {
        writer.WritePropertyName("substitution");
        current.Substitution.SerializeJson(writer, options);
      }

      if ((current.DetectedIssue != null) && (current.DetectedIssue.Count != 0))
      {
        writer.WritePropertyName("detectedIssue");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.DetectedIssue)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.EventHistory != null) && (current.EventHistory.Count != 0))
      {
        writer.WritePropertyName("eventHistory");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.EventHistory)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicationDispense
    /// </summary>
    public static void DeserializeJson(this MedicationDispense current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MedicationDispense >>> MedicationDispense.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MedicationDispense: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicationDispense
    /// </summary>
    public static void DeserializeJsonProperty(this MedicationDispense current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationDispense error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
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

        case "partOf":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationDispense error reading 'partOf' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
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

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatusCodes>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatusCodes>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatusCodes>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatusCodes>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "statusReasonCodeableConcept":
          current.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.StatusReason).DeserializeJson(ref reader, options);
          break;

        case "statusReasonReference":
          current.StatusReason = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.StatusReason).DeserializeJson(ref reader, options);
          break;

        case "category":
          current.Category = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Category).DeserializeJson(ref reader, options);
          break;

        case "medicationCodeableConcept":
          current.Medication = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Medication).DeserializeJson(ref reader, options);
          break;

        case "medicationReference":
          current.Medication = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Medication).DeserializeJson(ref reader, options);
          break;

        case "subject":
          current.Subject = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Subject).DeserializeJson(ref reader, options);
          break;

        case "context":
          current.Context = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Context).DeserializeJson(ref reader, options);
          break;

        case "supportingInformation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationDispense error reading 'supportingInformation' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.SupportingInformation = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_SupportingInformation = new Hl7.Fhir.Model.ResourceReference();
            v_SupportingInformation.DeserializeJson(ref reader, options);
            current.SupportingInformation.Add(v_SupportingInformation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.SupportingInformation.Count == 0)
          {
            current.SupportingInformation = null;
          }
          break;

        case "performer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationDispense error reading 'performer' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Performer = new List<MedicationDispense.PerformerComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.MedicationDispense.PerformerComponent v_Performer = new Hl7.Fhir.Model.MedicationDispense.PerformerComponent();
            v_Performer.DeserializeJson(ref reader, options);
            current.Performer.Add(v_Performer);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Performer.Count == 0)
          {
            current.Performer = null;
          }
          break;

        case "location":
          current.Location = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Location).DeserializeJson(ref reader, options);
          break;

        case "authorizingPrescription":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationDispense error reading 'authorizingPrescription' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.AuthorizingPrescription = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_AuthorizingPrescription = new Hl7.Fhir.Model.ResourceReference();
            v_AuthorizingPrescription.DeserializeJson(ref reader, options);
            current.AuthorizingPrescription.Add(v_AuthorizingPrescription);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.AuthorizingPrescription.Count == 0)
          {
            current.AuthorizingPrescription = null;
          }
          break;

        case "type":
          current.Type = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Type).DeserializeJson(ref reader, options);
          break;

        case "quantity":
          current.Quantity = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.Quantity).DeserializeJson(ref reader, options);
          break;

        case "daysSupply":
          current.DaysSupply = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.DaysSupply).DeserializeJson(ref reader, options);
          break;

        case "whenPrepared":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.WhenPreparedElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.WhenPreparedElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_whenPrepared":
          if (current.WhenPreparedElement == null) { current.WhenPreparedElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.WhenPreparedElement).DeserializeJson(ref reader, options);
          break;

        case "whenHandedOver":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.WhenHandedOverElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.WhenHandedOverElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_whenHandedOver":
          if (current.WhenHandedOverElement == null) { current.WhenHandedOverElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.WhenHandedOverElement).DeserializeJson(ref reader, options);
          break;

        case "destination":
          current.Destination = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Destination).DeserializeJson(ref reader, options);
          break;

        case "receiver":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationDispense error reading 'receiver' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Receiver = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Receiver = new Hl7.Fhir.Model.ResourceReference();
            v_Receiver.DeserializeJson(ref reader, options);
            current.Receiver.Add(v_Receiver);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Receiver.Count == 0)
          {
            current.Receiver = null;
          }
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationDispense error reading 'note' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
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

        case "dosageInstruction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationDispense error reading 'dosageInstruction' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.DosageInstruction = new List<Dosage>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Dosage v_DosageInstruction = new Hl7.Fhir.Model.Dosage();
            v_DosageInstruction.DeserializeJson(ref reader, options);
            current.DosageInstruction.Add(v_DosageInstruction);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.DosageInstruction.Count == 0)
          {
            current.DosageInstruction = null;
          }
          break;

        case "substitution":
          current.Substitution = new Hl7.Fhir.Model.MedicationDispense.SubstitutionComponent();
          ((Hl7.Fhir.Model.MedicationDispense.SubstitutionComponent)current.Substitution).DeserializeJson(ref reader, options);
          break;

        case "detectedIssue":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationDispense error reading 'detectedIssue' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.DetectedIssue = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_DetectedIssue = new Hl7.Fhir.Model.ResourceReference();
            v_DetectedIssue.DeserializeJson(ref reader, options);
            current.DetectedIssue.Add(v_DetectedIssue);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.DetectedIssue.Count == 0)
          {
            current.DetectedIssue = null;
          }
          break;

        case "eventHistory":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationDispense error reading 'eventHistory' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.EventHistory = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_EventHistory = new Hl7.Fhir.Model.ResourceReference();
            v_EventHistory.DeserializeJson(ref reader, options);
            current.EventHistory.Add(v_EventHistory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.EventHistory.Count == 0)
          {
            current.EventHistory = null;
          }
          break;

        // Complex: MedicationDispense, Export: MedicationDispense, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MedicationDispense#Performer into JSON
    /// </summary>
    public static void SerializeJson(this MedicationDispense.PerformerComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MedicationDispense#Performer, Export: PerformerComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Function != null)
      {
        writer.WritePropertyName("function");
        current.Function.SerializeJson(writer, options);
      }

      writer.WritePropertyName("actor");
      current.Actor.SerializeJson(writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicationDispense#Performer
    /// </summary>
    public static void DeserializeJson(this MedicationDispense.PerformerComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MedicationDispense.PerformerComponent >>> MedicationDispense#Performer.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MedicationDispense.PerformerComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicationDispense#Performer
    /// </summary>
    public static void DeserializeJsonProperty(this MedicationDispense.PerformerComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "function":
          current.Function = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Function).DeserializeJson(ref reader, options);
          break;

        case "actor":
          current.Actor = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Actor).DeserializeJson(ref reader, options);
          break;

        // Complex: performer, Export: PerformerComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MedicationDispense#Substitution into JSON
    /// </summary>
    public static void SerializeJson(this MedicationDispense.SubstitutionComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MedicationDispense#Substitution, Export: SubstitutionComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WriteBoolean("wasSubstituted",(bool)current.WasSubstitutedElement.Value);

      if (current.Type != null)
      {
        writer.WritePropertyName("type");
        current.Type.SerializeJson(writer, options);
      }

      if ((current.Reason != null) && (current.Reason.Count != 0))
      {
        writer.WritePropertyName("reason");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Reason)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.ResponsibleParty != null) && (current.ResponsibleParty.Count != 0))
      {
        writer.WritePropertyName("responsibleParty");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.ResponsibleParty)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicationDispense#Substitution
    /// </summary>
    public static void DeserializeJson(this MedicationDispense.SubstitutionComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MedicationDispense.SubstitutionComponent >>> MedicationDispense#Substitution.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MedicationDispense.SubstitutionComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicationDispense#Substitution
    /// </summary>
    public static void DeserializeJsonProperty(this MedicationDispense.SubstitutionComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "wasSubstituted":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.WasSubstitutedElement = new FhirBoolean();
            reader.Skip();
          }
          else
          {
            current.WasSubstitutedElement = new FhirBoolean(reader.GetBoolean());
          }
          break;

        case "_wasSubstituted":
          if (current.WasSubstitutedElement == null) { current.WasSubstitutedElement = new FhirBoolean(); }
          ((Hl7.Fhir.Model.Element)current.WasSubstitutedElement).DeserializeJson(ref reader, options);
          break;

        case "type":
          current.Type = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Type).DeserializeJson(ref reader, options);
          break;

        case "reason":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"SubstitutionComponent error reading 'reason' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Reason = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Reason = new Hl7.Fhir.Model.CodeableConcept();
            v_Reason.DeserializeJson(ref reader, options);
            current.Reason.Add(v_Reason);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Reason.Count == 0)
          {
            current.Reason = null;
          }
          break;

        case "responsibleParty":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"SubstitutionComponent error reading 'responsibleParty' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ResponsibleParty = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_ResponsibleParty = new Hl7.Fhir.Model.ResourceReference();
            v_ResponsibleParty.DeserializeJson(ref reader, options);
            current.ResponsibleParty.Add(v_ResponsibleParty);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ResponsibleParty.Count == 0)
          {
            current.ResponsibleParty = null;
          }
          break;

        // Complex: substitution, Export: SubstitutionComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class MedicationDispenseJsonConverter : JsonConverter<MedicationDispense>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, MedicationDispense value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override MedicationDispense Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        MedicationDispense target = new MedicationDispense();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
