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
  /// JSON Serialization Extensions for EpisodeOfCare
  /// </summary>
  public static class EpisodeOfCareJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR EpisodeOfCare into JSON
    /// </summary>
    public static void SerializeJson(this EpisodeOfCare current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","EpisodeOfCare");
      // Complex: EpisodeOfCare, Export: EpisodeOfCare, Base: DomainResource (DomainResource)
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

      if ((current.StatusHistory != null) && (current.StatusHistory.Count != 0))
      {
        writer.WritePropertyName("statusHistory");
        writer.WriteStartArray();
        foreach (EpisodeOfCare.StatusHistoryComponent val in current.StatusHistory)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Type != null) && (current.Type.Count != 0))
      {
        writer.WritePropertyName("type");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Type)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Diagnosis != null) && (current.Diagnosis.Count != 0))
      {
        writer.WritePropertyName("diagnosis");
        writer.WriteStartArray();
        foreach (EpisodeOfCare.DiagnosisComponent val in current.Diagnosis)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      writer.WritePropertyName("patient");
      current.Patient.SerializeJson(writer, options);

      if (current.ManagingOrganization != null)
      {
        writer.WritePropertyName("managingOrganization");
        current.ManagingOrganization.SerializeJson(writer, options);
      }

      if (current.Period != null)
      {
        writer.WritePropertyName("period");
        current.Period.SerializeJson(writer, options);
      }

      if ((current.ReferralRequest != null) && (current.ReferralRequest.Count != 0))
      {
        writer.WritePropertyName("referralRequest");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.ReferralRequest)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.CareManager != null)
      {
        writer.WritePropertyName("careManager");
        current.CareManager.SerializeJson(writer, options);
      }

      if ((current.Team != null) && (current.Team.Count != 0))
      {
        writer.WritePropertyName("team");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Team)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Account != null) && (current.Account.Count != 0))
      {
        writer.WritePropertyName("account");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Account)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR EpisodeOfCare
    /// </summary>
    public static void DeserializeJson(this EpisodeOfCare current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"EpisodeOfCare >>> EpisodeOfCare.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"EpisodeOfCare: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR EpisodeOfCare
    /// </summary>
    public static void DeserializeJsonProperty(this EpisodeOfCare current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"EpisodeOfCare error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
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
            current.StatusElement = new Code<Hl7.Fhir.Model.EpisodeOfCare.EpisodeOfCareStatus>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.EpisodeOfCare.EpisodeOfCareStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.EpisodeOfCare.EpisodeOfCareStatus>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.EpisodeOfCare.EpisodeOfCareStatus>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "statusHistory":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"EpisodeOfCare error reading 'statusHistory' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.StatusHistory = new List<EpisodeOfCare.StatusHistoryComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.EpisodeOfCare.StatusHistoryComponent v_StatusHistory = new Hl7.Fhir.Model.EpisodeOfCare.StatusHistoryComponent();
            v_StatusHistory.DeserializeJson(ref reader, options);
            current.StatusHistory.Add(v_StatusHistory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.StatusHistory.Count == 0)
          {
            current.StatusHistory = null;
          }
          break;

        case "type":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"EpisodeOfCare error reading 'type' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Type = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Type = new Hl7.Fhir.Model.CodeableConcept();
            v_Type.DeserializeJson(ref reader, options);
            current.Type.Add(v_Type);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Type.Count == 0)
          {
            current.Type = null;
          }
          break;

        case "diagnosis":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"EpisodeOfCare error reading 'diagnosis' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Diagnosis = new List<EpisodeOfCare.DiagnosisComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.EpisodeOfCare.DiagnosisComponent v_Diagnosis = new Hl7.Fhir.Model.EpisodeOfCare.DiagnosisComponent();
            v_Diagnosis.DeserializeJson(ref reader, options);
            current.Diagnosis.Add(v_Diagnosis);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Diagnosis.Count == 0)
          {
            current.Diagnosis = null;
          }
          break;

        case "patient":
          current.Patient = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Patient).DeserializeJson(ref reader, options);
          break;

        case "managingOrganization":
          current.ManagingOrganization = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.ManagingOrganization).DeserializeJson(ref reader, options);
          break;

        case "period":
          current.Period = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Period).DeserializeJson(ref reader, options);
          break;

        case "referralRequest":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"EpisodeOfCare error reading 'referralRequest' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ReferralRequest = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_ReferralRequest = new Hl7.Fhir.Model.ResourceReference();
            v_ReferralRequest.DeserializeJson(ref reader, options);
            current.ReferralRequest.Add(v_ReferralRequest);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ReferralRequest.Count == 0)
          {
            current.ReferralRequest = null;
          }
          break;

        case "careManager":
          current.CareManager = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.CareManager).DeserializeJson(ref reader, options);
          break;

        case "team":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"EpisodeOfCare error reading 'team' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Team = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Team = new Hl7.Fhir.Model.ResourceReference();
            v_Team.DeserializeJson(ref reader, options);
            current.Team.Add(v_Team);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Team.Count == 0)
          {
            current.Team = null;
          }
          break;

        case "account":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"EpisodeOfCare error reading 'account' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Account = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Account = new Hl7.Fhir.Model.ResourceReference();
            v_Account.DeserializeJson(ref reader, options);
            current.Account.Add(v_Account);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Account.Count == 0)
          {
            current.Account = null;
          }
          break;

        // Complex: EpisodeOfCare, Export: EpisodeOfCare, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR EpisodeOfCare#StatusHistory into JSON
    /// </summary>
    public static void SerializeJson(this EpisodeOfCare.StatusHistoryComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: EpisodeOfCare#StatusHistory, Export: StatusHistoryComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));

      writer.WritePropertyName("period");
      current.Period.SerializeJson(writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR EpisodeOfCare#StatusHistory
    /// </summary>
    public static void DeserializeJson(this EpisodeOfCare.StatusHistoryComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"EpisodeOfCare.StatusHistoryComponent >>> EpisodeOfCare#StatusHistory.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"EpisodeOfCare.StatusHistoryComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR EpisodeOfCare#StatusHistory
    /// </summary>
    public static void DeserializeJsonProperty(this EpisodeOfCare.StatusHistoryComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.EpisodeOfCare.EpisodeOfCareStatus>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.EpisodeOfCare.EpisodeOfCareStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.EpisodeOfCare.EpisodeOfCareStatus>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.EpisodeOfCare.EpisodeOfCareStatus>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "period":
          current.Period = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Period).DeserializeJson(ref reader, options);
          break;

        // Complex: statusHistory, Export: StatusHistoryComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR EpisodeOfCare#Diagnosis into JSON
    /// </summary>
    public static void SerializeJson(this EpisodeOfCare.DiagnosisComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: EpisodeOfCare#Diagnosis, Export: DiagnosisComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WritePropertyName("condition");
      current.Condition.SerializeJson(writer, options);

      if (current.Role != null)
      {
        writer.WritePropertyName("role");
        current.Role.SerializeJson(writer, options);
      }

      if (current.RankElement != null)
      {
        if (current.RankElement.Value != null)
        {
          writer.WriteNumber("rank",(int)current.RankElement.Value);
        }
        if (current.RankElement.HasExtensions() || (!string.IsNullOrEmpty(current.RankElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_rank",false,current.RankElement.Extension,current.RankElement.ElementId);
        }
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR EpisodeOfCare#Diagnosis
    /// </summary>
    public static void DeserializeJson(this EpisodeOfCare.DiagnosisComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"EpisodeOfCare.DiagnosisComponent >>> EpisodeOfCare#Diagnosis.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"EpisodeOfCare.DiagnosisComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR EpisodeOfCare#Diagnosis
    /// </summary>
    public static void DeserializeJsonProperty(this EpisodeOfCare.DiagnosisComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "condition":
          current.Condition = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Condition).DeserializeJson(ref reader, options);
          break;

        case "role":
          current.Role = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Role).DeserializeJson(ref reader, options);
          break;

        case "rank":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.RankElement = new PositiveInt();
            reader.Skip();
          }
          else
          {
            current.RankElement = new PositiveInt(reader.GetInt32());
          }
          break;

        case "_rank":
          if (current.RankElement == null) { current.RankElement = new PositiveInt(); }
          ((Hl7.Fhir.Model.Element)current.RankElement).DeserializeJson(ref reader, options);
          break;

        // Complex: diagnosis, Export: DiagnosisComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class EpisodeOfCareJsonConverter : JsonConverter<EpisodeOfCare>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, EpisodeOfCare value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override EpisodeOfCare Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        EpisodeOfCare target = new EpisodeOfCare();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
