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
  /// JSON Serialization Extensions for RiskAssessment
  /// </summary>
  public static class RiskAssessmentJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR RiskAssessment into JSON
    /// </summary>
    public static void SerializeJson(this RiskAssessment current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","RiskAssessment");
      // Complex: RiskAssessment, Export: RiskAssessment, Base: DomainResource (DomainResource)
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

      if (current.BasedOn != null)
      {
        writer.WritePropertyName("basedOn");
        current.BasedOn.SerializeJson(writer, options);
      }

      if (current.Parent != null)
      {
        writer.WritePropertyName("parent");
        current.Parent.SerializeJson(writer, options);
      }

      writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));

      if (current.Method != null)
      {
        writer.WritePropertyName("method");
        current.Method.SerializeJson(writer, options);
      }

      if (current.Code != null)
      {
        writer.WritePropertyName("code");
        current.Code.SerializeJson(writer, options);
      }

      writer.WritePropertyName("subject");
      current.Subject.SerializeJson(writer, options);

      if (current.Encounter != null)
      {
        writer.WritePropertyName("encounter");
        current.Encounter.SerializeJson(writer, options);
      }

      if (current.Occurrence != null)
      {
        switch (current.Occurrence)
        {
          case FhirDateTime v_FhirDateTime:
            if (v_FhirDateTime != null)
            {
              if (!string.IsNullOrEmpty(v_FhirDateTime.Value))
              {
                writer.WriteString("occurrenceDateTime",v_FhirDateTime.Value);
              }
              if (v_FhirDateTime.HasExtensions() || (!string.IsNullOrEmpty(v_FhirDateTime.ElementId)))
              {
                JsonStreamUtilities.SerializeExtensionList(writer,options,"_occurrenceDateTime",false,v_FhirDateTime.Extension,v_FhirDateTime.ElementId);
              }
            }
            break;
          case Period v_Period:
            writer.WritePropertyName("occurrencePeriod");
            v_Period.SerializeJson(writer, options);
            break;
        }
      }
      if (current.Condition != null)
      {
        writer.WritePropertyName("condition");
        current.Condition.SerializeJson(writer, options);
      }

      if (current.Performer != null)
      {
        writer.WritePropertyName("performer");
        current.Performer.SerializeJson(writer, options);
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

      if ((current.Basis != null) && (current.Basis.Count != 0))
      {
        writer.WritePropertyName("basis");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Basis)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Prediction != null) && (current.Prediction.Count != 0))
      {
        writer.WritePropertyName("prediction");
        writer.WriteStartArray();
        foreach (RiskAssessment.PredictionComponent val in current.Prediction)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.MitigationElement != null)
      {
        if (!string.IsNullOrEmpty(current.MitigationElement.Value))
        {
          writer.WriteString("mitigation",current.MitigationElement.Value);
        }
        if (current.MitigationElement.HasExtensions() || (!string.IsNullOrEmpty(current.MitigationElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_mitigation",false,current.MitigationElement.Extension,current.MitigationElement.ElementId);
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
    /// Deserialize JSON into a FHIR RiskAssessment
    /// </summary>
    public static void DeserializeJson(this RiskAssessment current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"RiskAssessment >>> RiskAssessment.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"RiskAssessment: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR RiskAssessment
    /// </summary>
    public static void DeserializeJsonProperty(this RiskAssessment current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"RiskAssessment error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
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

        case "basedOn":
          current.BasedOn = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.BasedOn).DeserializeJson(ref reader, options);
          break;

        case "parent":
          current.Parent = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Parent).DeserializeJson(ref reader, options);
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.ObservationStatus>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.ObservationStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.ObservationStatus>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.ObservationStatus>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "method":
          current.Method = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Method).DeserializeJson(ref reader, options);
          break;

        case "code":
          current.Code = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Code).DeserializeJson(ref reader, options);
          break;

        case "subject":
          current.Subject = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Subject).DeserializeJson(ref reader, options);
          break;

        case "encounter":
          current.Encounter = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Encounter).DeserializeJson(ref reader, options);
          break;

        case "occurrenceDateTime":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Occurrence = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.Occurrence = new FhirDateTime(reader.GetString());
          }
          break;

        case "_occurrenceDateTime":
          if (current.Occurrence == null) { current.Occurrence = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.Occurrence).DeserializeJson(ref reader, options);
          break;

        case "occurrencePeriod":
          current.Occurrence = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Occurrence).DeserializeJson(ref reader, options);
          break;

        case "condition":
          current.Condition = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Condition).DeserializeJson(ref reader, options);
          break;

        case "performer":
          current.Performer = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Performer).DeserializeJson(ref reader, options);
          break;

        case "reasonCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"RiskAssessment error reading 'reasonCode' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
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
            throw new JsonException($"RiskAssessment error reading 'reasonReference' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
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

        case "basis":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"RiskAssessment error reading 'basis' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Basis = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Basis = new Hl7.Fhir.Model.ResourceReference();
            v_Basis.DeserializeJson(ref reader, options);
            current.Basis.Add(v_Basis);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Basis.Count == 0)
          {
            current.Basis = null;
          }
          break;

        case "prediction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"RiskAssessment error reading 'prediction' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Prediction = new List<RiskAssessment.PredictionComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.RiskAssessment.PredictionComponent v_Prediction = new Hl7.Fhir.Model.RiskAssessment.PredictionComponent();
            v_Prediction.DeserializeJson(ref reader, options);
            current.Prediction.Add(v_Prediction);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Prediction.Count == 0)
          {
            current.Prediction = null;
          }
          break;

        case "mitigation":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.MitigationElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.MitigationElement = new FhirString(reader.GetString());
          }
          break;

        case "_mitigation":
          if (current.MitigationElement == null) { current.MitigationElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.MitigationElement).DeserializeJson(ref reader, options);
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"RiskAssessment error reading 'note' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
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

        // Complex: RiskAssessment, Export: RiskAssessment, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR RiskAssessment#Prediction into JSON
    /// </summary>
    public static void SerializeJson(this RiskAssessment.PredictionComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: RiskAssessment#Prediction, Export: PredictionComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Outcome != null)
      {
        writer.WritePropertyName("outcome");
        current.Outcome.SerializeJson(writer, options);
      }

      if (current.Probability != null)
      {
        switch (current.Probability)
        {
          case FhirDecimal v_FhirDecimal:
            if (v_FhirDecimal != null)
            {
              if (v_FhirDecimal.Value != null)
              {
                writer.WriteNumber("probabilityDecimal",(decimal)v_FhirDecimal.Value);
              }
              if (v_FhirDecimal.HasExtensions() || (!string.IsNullOrEmpty(v_FhirDecimal.ElementId)))
              {
                JsonStreamUtilities.SerializeExtensionList(writer,options,"_probabilityDecimal",false,v_FhirDecimal.Extension,v_FhirDecimal.ElementId);
              }
            }
            break;
          case Range v_Range:
            writer.WritePropertyName("probabilityRange");
            v_Range.SerializeJson(writer, options);
            break;
        }
      }
      if (current.QualitativeRisk != null)
      {
        writer.WritePropertyName("qualitativeRisk");
        current.QualitativeRisk.SerializeJson(writer, options);
      }

      if (current.RelativeRiskElement != null)
      {
        if (current.RelativeRiskElement.Value != null)
        {
          writer.WriteNumber("relativeRisk",(decimal)current.RelativeRiskElement.Value);
        }
        if (current.RelativeRiskElement.HasExtensions() || (!string.IsNullOrEmpty(current.RelativeRiskElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_relativeRisk",false,current.RelativeRiskElement.Extension,current.RelativeRiskElement.ElementId);
        }
      }

      if (current.When != null)
      {
        switch (current.When)
        {
          case Period v_Period:
            writer.WritePropertyName("whenPeriod");
            v_Period.SerializeJson(writer, options);
            break;
          case Range v_Range:
            writer.WritePropertyName("whenRange");
            v_Range.SerializeJson(writer, options);
            break;
        }
      }
      if (current.RationaleElement != null)
      {
        if (!string.IsNullOrEmpty(current.RationaleElement.Value))
        {
          writer.WriteString("rationale",current.RationaleElement.Value);
        }
        if (current.RationaleElement.HasExtensions() || (!string.IsNullOrEmpty(current.RationaleElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_rationale",false,current.RationaleElement.Extension,current.RationaleElement.ElementId);
        }
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR RiskAssessment#Prediction
    /// </summary>
    public static void DeserializeJson(this RiskAssessment.PredictionComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"RiskAssessment.PredictionComponent >>> RiskAssessment#Prediction.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"RiskAssessment.PredictionComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR RiskAssessment#Prediction
    /// </summary>
    public static void DeserializeJsonProperty(this RiskAssessment.PredictionComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "outcome":
          current.Outcome = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Outcome).DeserializeJson(ref reader, options);
          break;

        case "probabilityDecimal":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Probability = new FhirDecimal();
            reader.Skip();
          }
          else
          {
            current.Probability = new FhirDecimal(reader.GetDecimal());
          }
          break;

        case "_probabilityDecimal":
          if (current.Probability == null) { current.Probability = new FhirDecimal(); }
          ((Hl7.Fhir.Model.Element)current.Probability).DeserializeJson(ref reader, options);
          break;

        case "probabilityRange":
          current.Probability = new Hl7.Fhir.Model.Range();
          ((Hl7.Fhir.Model.Range)current.Probability).DeserializeJson(ref reader, options);
          break;

        case "qualitativeRisk":
          current.QualitativeRisk = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.QualitativeRisk).DeserializeJson(ref reader, options);
          break;

        case "relativeRisk":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.RelativeRiskElement = new FhirDecimal();
            reader.Skip();
          }
          else
          {
            current.RelativeRiskElement = new FhirDecimal(reader.GetDecimal());
          }
          break;

        case "_relativeRisk":
          if (current.RelativeRiskElement == null) { current.RelativeRiskElement = new FhirDecimal(); }
          ((Hl7.Fhir.Model.Element)current.RelativeRiskElement).DeserializeJson(ref reader, options);
          break;

        case "whenPeriod":
          current.When = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.When).DeserializeJson(ref reader, options);
          break;

        case "whenRange":
          current.When = new Hl7.Fhir.Model.Range();
          ((Hl7.Fhir.Model.Range)current.When).DeserializeJson(ref reader, options);
          break;

        case "rationale":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.RationaleElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.RationaleElement = new FhirString(reader.GetString());
          }
          break;

        case "_rationale":
          if (current.RationaleElement == null) { current.RationaleElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.RationaleElement).DeserializeJson(ref reader, options);
          break;

        // Complex: prediction, Export: PredictionComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class RiskAssessmentJsonConverter : JsonConverter<RiskAssessment>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, RiskAssessment value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override RiskAssessment Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        RiskAssessment target = new RiskAssessment();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
