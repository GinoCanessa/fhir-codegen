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
  /// JSON Serialization Extensions for ContactPoint
  /// </summary>
  public static class ContactPointJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR ContactPoint into JSON
    /// </summary>
    public static void SerializeJson(this ContactPoint current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Complex: ContactPoint, Export: ContactPoint, Base: Element (Element)
      ((Hl7.Fhir.Model.Element)current).SerializeJson(writer, options, false);

      if (current.SystemElement != null)
      {
        if (current.SystemElement.Value != null)
        {
          writer.WriteString("system",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.SystemElement.Value));
        }
        if (current.SystemElement.HasExtensions() || (!string.IsNullOrEmpty(current.SystemElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_system",false,current.SystemElement.Extension,current.SystemElement.ElementId);
        }
      }

      if (current.ValueElement != null)
      {
        if (!string.IsNullOrEmpty(current.ValueElement.Value))
        {
          writer.WriteString("value",current.ValueElement.Value);
        }
        if (current.ValueElement.HasExtensions() || (!string.IsNullOrEmpty(current.ValueElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_value",false,current.ValueElement.Extension,current.ValueElement.ElementId);
        }
      }

      if (current.UseElement != null)
      {
        if (current.UseElement.Value != null)
        {
          writer.WriteString("use",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.UseElement.Value));
        }
        if (current.UseElement.HasExtensions() || (!string.IsNullOrEmpty(current.UseElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_use",false,current.UseElement.Extension,current.UseElement.ElementId);
        }
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

      if (current.Period != null)
      {
        writer.WritePropertyName("period");
        current.Period.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ContactPoint
    /// </summary>
    public static void DeserializeJson(this ContactPoint current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"ContactPoint >>> ContactPoint.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"ContactPoint: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ContactPoint
    /// </summary>
    public static void DeserializeJsonProperty(this ContactPoint current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "system":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.SystemElement = new Code<Hl7.Fhir.Model.ContactPoint.ContactPointSystem>();
            reader.Skip();
          }
          else
          {
            current.SystemElement = new Code<Hl7.Fhir.Model.ContactPoint.ContactPointSystem>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.ContactPoint.ContactPointSystem>(reader.GetString()));
          }
          break;

        case "_system":
          if (current.SystemElement == null) { current.SystemElement = new Code<Hl7.Fhir.Model.ContactPoint.ContactPointSystem>(); }
          ((Hl7.Fhir.Model.Element)current.SystemElement).DeserializeJson(ref reader, options);
          break;

        case "value":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ValueElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.ValueElement = new FhirString(reader.GetString());
          }
          break;

        case "_value":
          if (current.ValueElement == null) { current.ValueElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.ValueElement).DeserializeJson(ref reader, options);
          break;

        case "use":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.UseElement = new Code<Hl7.Fhir.Model.ContactPoint.ContactPointUse>();
            reader.Skip();
          }
          else
          {
            current.UseElement = new Code<Hl7.Fhir.Model.ContactPoint.ContactPointUse>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.ContactPoint.ContactPointUse>(reader.GetString()));
          }
          break;

        case "_use":
          if (current.UseElement == null) { current.UseElement = new Code<Hl7.Fhir.Model.ContactPoint.ContactPointUse>(); }
          ((Hl7.Fhir.Model.Element)current.UseElement).DeserializeJson(ref reader, options);
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

        case "period":
          current.Period = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Period).DeserializeJson(ref reader, options);
          break;

        // Complex: ContactPoint, Export: ContactPoint, Base: Element
        default:
          ((Hl7.Fhir.Model.Element)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class ContactPointJsonConverter : JsonConverter<ContactPoint>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, ContactPoint value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override ContactPoint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        ContactPoint target = new ContactPoint();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
