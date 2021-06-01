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
  /// JSON Serialization Extensions for MessageHeader
  /// </summary>
  public static class MessageHeaderJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR MessageHeader into JSON
    /// </summary>
    public static void SerializeJson(this MessageHeader current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","MessageHeader");
      // Complex: MessageHeader, Export: MessageHeader, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if (current.Event != null)
      {
        switch (current.Event)
        {
          case Coding v_Coding:
            writer.WritePropertyName("eventCoding");
            v_Coding.SerializeJson(writer, options);
            break;
          case FhirUri v_FhirUri:
            writer.WriteString("eventUri",v_FhirUri.Value);
            break;
        }
      }
      if ((current.Destination != null) && (current.Destination.Count != 0))
      {
        writer.WritePropertyName("destination");
        writer.WriteStartArray();
        foreach (MessageHeader.MessageDestinationComponent val in current.Destination)
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

      if (current.Enterer != null)
      {
        writer.WritePropertyName("enterer");
        current.Enterer.SerializeJson(writer, options);
      }

      if (current.Author != null)
      {
        writer.WritePropertyName("author");
        current.Author.SerializeJson(writer, options);
      }

      writer.WritePropertyName("source");
      current.Source.SerializeJson(writer, options);

      if (current.Responsible != null)
      {
        writer.WritePropertyName("responsible");
        current.Responsible.SerializeJson(writer, options);
      }

      if (current.Reason != null)
      {
        writer.WritePropertyName("reason");
        current.Reason.SerializeJson(writer, options);
      }

      if (current.Response != null)
      {
        writer.WritePropertyName("response");
        current.Response.SerializeJson(writer, options);
      }

      if ((current.Focus != null) && (current.Focus.Count != 0))
      {
        writer.WritePropertyName("focus");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Focus)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.DefinitionElement != null)
      {
        if (!string.IsNullOrEmpty(current.DefinitionElement.Value))
        {
          writer.WriteString("definition",current.DefinitionElement.Value);
        }
        if (current.DefinitionElement.HasExtensions() || (!string.IsNullOrEmpty(current.DefinitionElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_definition",false,current.DefinitionElement.Extension,current.DefinitionElement.ElementId);
        }
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MessageHeader
    /// </summary>
    public static void DeserializeJson(this MessageHeader current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MessageHeader >>> MessageHeader.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MessageHeader: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MessageHeader
    /// </summary>
    public static void DeserializeJsonProperty(this MessageHeader current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "eventCoding":
          current.Event = new Hl7.Fhir.Model.Coding();
          ((Hl7.Fhir.Model.Coding)current.Event).DeserializeJson(ref reader, options);
          break;

        case "eventUri":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Event = new FhirUri();
            reader.Skip();
          }
          else
          {
            current.Event = new FhirUri(reader.GetString());
          }
          break;

        case "_eventUri":
          if (current.Event == null) { current.Event = new FhirUri(); }
          ((Hl7.Fhir.Model.Element)current.Event).DeserializeJson(ref reader, options);
          break;

        case "destination":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MessageHeader error reading 'destination' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Destination = new List<MessageHeader.MessageDestinationComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.MessageHeader.MessageDestinationComponent v_Destination = new Hl7.Fhir.Model.MessageHeader.MessageDestinationComponent();
            v_Destination.DeserializeJson(ref reader, options);
            current.Destination.Add(v_Destination);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Destination.Count == 0)
          {
            current.Destination = null;
          }
          break;

        case "sender":
          current.Sender = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Sender).DeserializeJson(ref reader, options);
          break;

        case "enterer":
          current.Enterer = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Enterer).DeserializeJson(ref reader, options);
          break;

        case "author":
          current.Author = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Author).DeserializeJson(ref reader, options);
          break;

        case "source":
          current.Source = new Hl7.Fhir.Model.MessageHeader.MessageSourceComponent();
          ((Hl7.Fhir.Model.MessageHeader.MessageSourceComponent)current.Source).DeserializeJson(ref reader, options);
          break;

        case "responsible":
          current.Responsible = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Responsible).DeserializeJson(ref reader, options);
          break;

        case "reason":
          current.Reason = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Reason).DeserializeJson(ref reader, options);
          break;

        case "response":
          current.Response = new Hl7.Fhir.Model.MessageHeader.ResponseComponent();
          ((Hl7.Fhir.Model.MessageHeader.ResponseComponent)current.Response).DeserializeJson(ref reader, options);
          break;

        case "focus":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MessageHeader error reading 'focus' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Focus = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Focus = new Hl7.Fhir.Model.ResourceReference();
            v_Focus.DeserializeJson(ref reader, options);
            current.Focus.Add(v_Focus);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Focus.Count == 0)
          {
            current.Focus = null;
          }
          break;

        case "definition":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DefinitionElement = new Canonical();
            reader.Skip();
          }
          else
          {
            current.DefinitionElement = new Canonical(reader.GetString());
          }
          break;

        case "_definition":
          if (current.DefinitionElement == null) { current.DefinitionElement = new Canonical(); }
          ((Hl7.Fhir.Model.Element)current.DefinitionElement).DeserializeJson(ref reader, options);
          break;

        // Complex: MessageHeader, Export: MessageHeader, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MessageHeader#MessageDestination into JSON
    /// </summary>
    public static void SerializeJson(this MessageHeader.MessageDestinationComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MessageHeader#MessageDestination, Export: MessageDestinationComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.NameElement != null)
      {
        if (!string.IsNullOrEmpty(current.NameElement.Value))
        {
          writer.WriteString("name",current.NameElement.Value);
        }
        if (current.NameElement.HasExtensions() || (!string.IsNullOrEmpty(current.NameElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_name",false,current.NameElement.Extension,current.NameElement.ElementId);
        }
      }

      if (current.Target != null)
      {
        writer.WritePropertyName("target");
        current.Target.SerializeJson(writer, options);
      }

      writer.WriteString("endpoint",current.EndpointElement.Value);

      if (current.Receiver != null)
      {
        writer.WritePropertyName("receiver");
        current.Receiver.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MessageHeader#MessageDestination
    /// </summary>
    public static void DeserializeJson(this MessageHeader.MessageDestinationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MessageHeader.MessageDestinationComponent >>> MessageHeader#MessageDestination.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MessageHeader.MessageDestinationComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MessageHeader#MessageDestination
    /// </summary>
    public static void DeserializeJsonProperty(this MessageHeader.MessageDestinationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "name":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.NameElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.NameElement = new FhirString(reader.GetString());
          }
          break;

        case "_name":
          if (current.NameElement == null) { current.NameElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.NameElement).DeserializeJson(ref reader, options);
          break;

        case "target":
          current.Target = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Target).DeserializeJson(ref reader, options);
          break;

        case "endpoint":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.EndpointElement = new FhirUrl();
            reader.Skip();
          }
          else
          {
            current.EndpointElement = new FhirUrl(reader.GetString());
          }
          break;

        case "_endpoint":
          if (current.EndpointElement == null) { current.EndpointElement = new FhirUrl(); }
          ((Hl7.Fhir.Model.Element)current.EndpointElement).DeserializeJson(ref reader, options);
          break;

        case "receiver":
          current.Receiver = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Receiver).DeserializeJson(ref reader, options);
          break;

        // Complex: destination, Export: MessageDestinationComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MessageHeader#MessageSource into JSON
    /// </summary>
    public static void SerializeJson(this MessageHeader.MessageSourceComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MessageHeader#MessageSource, Export: MessageSourceComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.NameElement != null)
      {
        if (!string.IsNullOrEmpty(current.NameElement.Value))
        {
          writer.WriteString("name",current.NameElement.Value);
        }
        if (current.NameElement.HasExtensions() || (!string.IsNullOrEmpty(current.NameElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_name",false,current.NameElement.Extension,current.NameElement.ElementId);
        }
      }

      if (current.SoftwareElement != null)
      {
        if (!string.IsNullOrEmpty(current.SoftwareElement.Value))
        {
          writer.WriteString("software",current.SoftwareElement.Value);
        }
        if (current.SoftwareElement.HasExtensions() || (!string.IsNullOrEmpty(current.SoftwareElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_software",false,current.SoftwareElement.Extension,current.SoftwareElement.ElementId);
        }
      }

      if (current.VersionElement != null)
      {
        if (!string.IsNullOrEmpty(current.VersionElement.Value))
        {
          writer.WriteString("version",current.VersionElement.Value);
        }
        if (current.VersionElement.HasExtensions() || (!string.IsNullOrEmpty(current.VersionElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_version",false,current.VersionElement.Extension,current.VersionElement.ElementId);
        }
      }

      if (current.Contact != null)
      {
        writer.WritePropertyName("contact");
        current.Contact.SerializeJson(writer, options);
      }

      writer.WriteString("endpoint",current.EndpointElement.Value);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MessageHeader#MessageSource
    /// </summary>
    public static void DeserializeJson(this MessageHeader.MessageSourceComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MessageHeader.MessageSourceComponent >>> MessageHeader#MessageSource.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MessageHeader.MessageSourceComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MessageHeader#MessageSource
    /// </summary>
    public static void DeserializeJsonProperty(this MessageHeader.MessageSourceComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "name":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.NameElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.NameElement = new FhirString(reader.GetString());
          }
          break;

        case "_name":
          if (current.NameElement == null) { current.NameElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.NameElement).DeserializeJson(ref reader, options);
          break;

        case "software":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.SoftwareElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.SoftwareElement = new FhirString(reader.GetString());
          }
          break;

        case "_software":
          if (current.SoftwareElement == null) { current.SoftwareElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.SoftwareElement).DeserializeJson(ref reader, options);
          break;

        case "version":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.VersionElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.VersionElement = new FhirString(reader.GetString());
          }
          break;

        case "_version":
          if (current.VersionElement == null) { current.VersionElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.VersionElement).DeserializeJson(ref reader, options);
          break;

        case "contact":
          current.Contact = new Hl7.Fhir.Model.ContactPoint();
          ((Hl7.Fhir.Model.ContactPoint)current.Contact).DeserializeJson(ref reader, options);
          break;

        case "endpoint":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.EndpointElement = new FhirUrl();
            reader.Skip();
          }
          else
          {
            current.EndpointElement = new FhirUrl(reader.GetString());
          }
          break;

        case "_endpoint":
          if (current.EndpointElement == null) { current.EndpointElement = new FhirUrl(); }
          ((Hl7.Fhir.Model.Element)current.EndpointElement).DeserializeJson(ref reader, options);
          break;

        // Complex: source, Export: MessageSourceComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MessageHeader#Response into JSON
    /// </summary>
    public static void SerializeJson(this MessageHeader.ResponseComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MessageHeader#Response, Export: ResponseComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WriteString("identifier",current.IdentifierElement.Value);

      writer.WriteString("code",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.CodeElement.Value));

      if (current.Details != null)
      {
        writer.WritePropertyName("details");
        current.Details.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MessageHeader#Response
    /// </summary>
    public static void DeserializeJson(this MessageHeader.ResponseComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MessageHeader.ResponseComponent >>> MessageHeader#Response.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MessageHeader.ResponseComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MessageHeader#Response
    /// </summary>
    public static void DeserializeJsonProperty(this MessageHeader.ResponseComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.IdentifierElement = new Id();
            reader.Skip();
          }
          else
          {
            current.IdentifierElement = new Id(reader.GetString());
          }
          break;

        case "_identifier":
          if (current.IdentifierElement == null) { current.IdentifierElement = new Id(); }
          ((Hl7.Fhir.Model.Element)current.IdentifierElement).DeserializeJson(ref reader, options);
          break;

        case "code":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.CodeElement = new Code<Hl7.Fhir.Model.MessageHeader.ResponseType>();
            reader.Skip();
          }
          else
          {
            current.CodeElement = new Code<Hl7.Fhir.Model.MessageHeader.ResponseType>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.MessageHeader.ResponseType>(reader.GetString()));
          }
          break;

        case "_code":
          if (current.CodeElement == null) { current.CodeElement = new Code<Hl7.Fhir.Model.MessageHeader.ResponseType>(); }
          ((Hl7.Fhir.Model.Element)current.CodeElement).DeserializeJson(ref reader, options);
          break;

        case "details":
          current.Details = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Details).DeserializeJson(ref reader, options);
          break;

        // Complex: response, Export: ResponseComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class MessageHeaderJsonConverter : JsonConverter<MessageHeader>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, MessageHeader value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override MessageHeader Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        MessageHeader target = new MessageHeader();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
