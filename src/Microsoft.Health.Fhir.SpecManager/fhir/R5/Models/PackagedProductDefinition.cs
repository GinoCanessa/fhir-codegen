// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR5.Serialization;

namespace fhirCsR5.Models
{
  /// <summary>
  /// General characteristics of this item.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<PackagedProductDefinitionPackageProperty>))]
  public class PackagedProductDefinitionPackageProperty : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A code expressing the type of characteristic.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// A value for the characteristic.
    /// </summary>
    public CodeableConcept ValueCodeableConcept { get; set; }
    /// <summary>
    /// A value for the characteristic.
    /// </summary>
    public Quantity ValueQuantity { get; set; }
    /// <summary>
    /// A value for the characteristic.
    /// </summary>
    public string ValueDate { get; set; }
    /// <summary>
    /// Extension container element for ValueDate
    /// </summary>
    public Element _ValueDate { get; set; }
    /// <summary>
    /// A value for the characteristic.
    /// </summary>
    public bool? ValueBoolean { get; set; }
    /// <summary>
    /// A value for the characteristic.
    /// </summary>
    public Attachment ValueAttachment { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (ValueCodeableConcept != null)
      {
        writer.WritePropertyName("valueCodeableConcept");
        ValueCodeableConcept.SerializeJson(writer, options);
      }

      if (ValueQuantity != null)
      {
        writer.WritePropertyName("valueQuantity");
        ValueQuantity.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ValueDate))
      {
        writer.WriteString("valueDate", (string)ValueDate!);
      }

      if (_ValueDate != null)
      {
        writer.WritePropertyName("_valueDate");
        _ValueDate.SerializeJson(writer, options);
      }

      if (ValueBoolean != null)
      {
        writer.WriteBoolean("valueBoolean", (bool)ValueBoolean!);
      }

      if (ValueAttachment != null)
      {
        writer.WritePropertyName("valueAttachment");
        ValueAttachment.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "type":
          Type = new fhirCsR5.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        case "valueCodeableConcept":
          ValueCodeableConcept = new fhirCsR5.Models.CodeableConcept();
          ValueCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "valueQuantity":
          ValueQuantity = new fhirCsR5.Models.Quantity();
          ValueQuantity.DeserializeJson(ref reader, options);
          break;

        case "valueDate":
          ValueDate = reader.GetString();
          break;

        case "_valueDate":
          _ValueDate = new fhirCsR5.Models.Element();
          _ValueDate.DeserializeJson(ref reader, options);
          break;

        case "valueBoolean":
          ValueBoolean = reader.GetBoolean();
          break;

        case "valueAttachment":
          ValueAttachment = new fhirCsR5.Models.Attachment();
          ValueAttachment.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// The item(s) within the packaging.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<PackagedProductDefinitionPackageContainedItem>))]
  public class PackagedProductDefinitionPackageContainedItem : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The number of this type of item within this packaging.
    /// </summary>
    public Quantity AmountQuantity { get; set; }
    /// <summary>
    /// The number of this type of item within this packaging.
    /// </summary>
    public int? AmountInteger { get; set; }
    /// <summary>
    /// The actual item(s) of medication, as manufactured, or a device (typically, but not necessarily, a co-packaged one), or other medically related item (such as food, biologicals, raw materials, medical fluids, gases etc.), as contained in the package. This also allows another packaged product to be included, which is solely for the case where a package of other entire packages is wanted - such as a wholesale or distribution pack.
    /// </summary>
    public List<CodeableReference> Item { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if ((Item != null) && (Item.Count != 0))
      {
        writer.WritePropertyName("item");
        writer.WriteStartArray();

        foreach (CodeableReference valItem in Item)
        {
          valItem.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (AmountQuantity != null)
      {
        writer.WritePropertyName("amountQuantity");
        AmountQuantity.SerializeJson(writer, options);
      }

      if (AmountInteger != null)
      {
        writer.WriteNumber("amountInteger", (int)AmountInteger!);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "amountQuantity":
          AmountQuantity = new fhirCsR5.Models.Quantity();
          AmountQuantity.DeserializeJson(ref reader, options);
          break;

        case "amountInteger":
          AmountInteger = reader.GetInt32();
          break;

        case "item":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Item = new List<CodeableReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableReference objItem = new fhirCsR5.Models.CodeableReference();
            objItem.DeserializeJson(ref reader, options);
            Item.Add(objItem);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Item.Count == 0)
          {
            Item = null;
          }

          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// A packaging item, as a container for medically related items, possibly with other packaging items within, or a packaging component, such as bottle cap (which is not a device or a medication manufactured item).
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<PackagedProductDefinitionPackage>))]
  public class PackagedProductDefinitionPackage : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A possible alternate material for the packaging.
    /// </summary>
    public List<CodeableConcept> AlternateMaterial { get; set; }
    /// <summary>
    /// The item(s) within the packaging.
    /// </summary>
    public List<PackagedProductDefinitionPackageContainedItem> ContainedItem { get; set; }
    /// <summary>
    /// Including possibly Data Carrier Identifier.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Manufacturer of this package Item. When there are multiple it means these are all possible manufacturers.
    /// </summary>
    public List<Reference> Manufacturer { get; set; }
    /// <summary>
    /// Material type of the package item.
    /// </summary>
    public List<CodeableConcept> Material { get; set; }
    /// <summary>
    /// Allows containers within containers.
    /// </summary>
    public List<PackagedProductDefinitionPackage> Package { get; set; }
    /// <summary>
    /// General characteristics of this item.
    /// </summary>
    public List<PackagedProductDefinitionPackageProperty> Property { get; set; }
    /// <summary>
    /// The quantity of this level of packaging in the package that contains it. If specified, the outermost level is always 1.
    /// </summary>
    public int? Quantity { get; set; }
    /// <summary>
    /// Shelf Life and storage information.
    /// </summary>
    public List<ProductShelfLife> ShelfLifeStorage { get; set; }
    /// <summary>
    /// The physical type of the container of the items.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (Quantity != null)
      {
        writer.WriteNumber("quantity", (int)Quantity!);
      }

      if ((Material != null) && (Material.Count != 0))
      {
        writer.WritePropertyName("material");
        writer.WriteStartArray();

        foreach (CodeableConcept valMaterial in Material)
        {
          valMaterial.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((AlternateMaterial != null) && (AlternateMaterial.Count != 0))
      {
        writer.WritePropertyName("alternateMaterial");
        writer.WriteStartArray();

        foreach (CodeableConcept valAlternateMaterial in AlternateMaterial)
        {
          valAlternateMaterial.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ShelfLifeStorage != null) && (ShelfLifeStorage.Count != 0))
      {
        writer.WritePropertyName("shelfLifeStorage");
        writer.WriteStartArray();

        foreach (ProductShelfLife valShelfLifeStorage in ShelfLifeStorage)
        {
          valShelfLifeStorage.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Manufacturer != null) && (Manufacturer.Count != 0))
      {
        writer.WritePropertyName("manufacturer");
        writer.WriteStartArray();

        foreach (Reference valManufacturer in Manufacturer)
        {
          valManufacturer.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Property != null) && (Property.Count != 0))
      {
        writer.WritePropertyName("property");
        writer.WriteStartArray();

        foreach (PackagedProductDefinitionPackageProperty valProperty in Property)
        {
          valProperty.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ContainedItem != null) && (ContainedItem.Count != 0))
      {
        writer.WritePropertyName("containedItem");
        writer.WriteStartArray();

        foreach (PackagedProductDefinitionPackageContainedItem valContainedItem in ContainedItem)
        {
          valContainedItem.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Package != null) && (Package.Count != 0))
      {
        writer.WritePropertyName("package");
        writer.WriteStartArray();

        foreach (PackagedProductDefinitionPackage valPackage in Package)
        {
          valPackage.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "alternateMaterial":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          AlternateMaterial = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objAlternateMaterial = new fhirCsR5.Models.CodeableConcept();
            objAlternateMaterial.DeserializeJson(ref reader, options);
            AlternateMaterial.Add(objAlternateMaterial);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (AlternateMaterial.Count == 0)
          {
            AlternateMaterial = null;
          }

          break;

        case "containedItem":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ContainedItem = new List<PackagedProductDefinitionPackageContainedItem>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.PackagedProductDefinitionPackageContainedItem objContainedItem = new fhirCsR5.Models.PackagedProductDefinitionPackageContainedItem();
            objContainedItem.DeserializeJson(ref reader, options);
            ContainedItem.Add(objContainedItem);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ContainedItem.Count == 0)
          {
            ContainedItem = null;
          }

          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Identifier objIdentifier = new fhirCsR5.Models.Identifier();
            objIdentifier.DeserializeJson(ref reader, options);
            Identifier.Add(objIdentifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Identifier.Count == 0)
          {
            Identifier = null;
          }

          break;

        case "manufacturer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Manufacturer = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objManufacturer = new fhirCsR5.Models.Reference();
            objManufacturer.DeserializeJson(ref reader, options);
            Manufacturer.Add(objManufacturer);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Manufacturer.Count == 0)
          {
            Manufacturer = null;
          }

          break;

        case "material":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Material = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objMaterial = new fhirCsR5.Models.CodeableConcept();
            objMaterial.DeserializeJson(ref reader, options);
            Material.Add(objMaterial);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Material.Count == 0)
          {
            Material = null;
          }

          break;

        case "package":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Package = new List<PackagedProductDefinitionPackage>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.PackagedProductDefinitionPackage objPackage = new fhirCsR5.Models.PackagedProductDefinitionPackage();
            objPackage.DeserializeJson(ref reader, options);
            Package.Add(objPackage);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Package.Count == 0)
          {
            Package = null;
          }

          break;

        case "property":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Property = new List<PackagedProductDefinitionPackageProperty>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.PackagedProductDefinitionPackageProperty objProperty = new fhirCsR5.Models.PackagedProductDefinitionPackageProperty();
            objProperty.DeserializeJson(ref reader, options);
            Property.Add(objProperty);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Property.Count == 0)
          {
            Property = null;
          }

          break;

        case "quantity":
          Quantity = reader.GetInt32();
          break;

        case "shelfLifeStorage":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ShelfLifeStorage = new List<ProductShelfLife>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.ProductShelfLife objShelfLifeStorage = new fhirCsR5.Models.ProductShelfLife();
            objShelfLifeStorage.DeserializeJson(ref reader, options);
            ShelfLifeStorage.Add(objShelfLifeStorage);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ShelfLifeStorage.Count == 0)
          {
            ShelfLifeStorage = null;
          }

          break;

        case "type":
          Type = new fhirCsR5.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// A medically related item or items, in a container or package.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<PackagedProductDefinition>))]
  public class PackagedProductDefinition : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "PackagedProductDefinition";
    /// <summary>
    /// Additional information or supporting documentation about the packaged product.
    /// </summary>
    public List<Reference> AttachedDocument { get; set; }
    /// <summary>
    /// Allows the key features to be recorded, such as "hospital pack", "nurse prescribable", "calendar pack".
    /// </summary>
    public List<CodeableConcept> Characteristic { get; set; }
    /// <summary>
    /// A total of the amount of items in the package, per item type. This can be considered as the pack size. This attribite is repeatable so that the different item types in one pack type can be counted (e.g. a count of vials and count of syringes). Repeats are not to be used to represent differerent pack sizes (e.g. 20 pack vs 50 pack) - which would be different resource instances. This attribute differs from  containedItem.amount in that it can give a single count of all tablet types in a pack, even when these are different manufactured items.
    /// </summary>
    public List<Quantity> ContainedItemQuantity { get; set; }
    /// <summary>
    /// States whether a drug product is supplied with another item such as a diluent or adjuvant.
    /// </summary>
    public bool? CopackagedIndicator { get; set; }
    /// <summary>
    /// Textual description. Note that this is not the name of the package or product.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// Unique identifier.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The legal status of supply of the packaged item as classified by the regulator.
    /// </summary>
    public CodeableConcept LegalStatusOfSupply { get; set; }
    /// <summary>
    /// Manufacturer of this package type. When there are multiple it means these are all possible manufacturers.
    /// </summary>
    public List<Reference> Manufacturer { get; set; }
    /// <summary>
    /// An authorization for this package type.
    /// </summary>
    public Reference MarketingAuthorization { get; set; }
    /// <summary>
    /// Marketing information.
    /// </summary>
    public List<MarketingStatus> MarketingStatus { get; set; }
    /// <summary>
    /// A name for this package. Typically what it would be listed as in a drug formulary or catalogue, inventory etc.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Extension container element for Name
    /// </summary>
    public Element _Name { get; set; }
    /// <summary>
    /// A packaging item, as a container for medically related items, possibly with other packaging items within, or a packaging component, such as bottle cap (which is not a device or a medication manufactured item).
    /// </summary>
    public PackagedProductDefinitionPackage Package { get; set; }
    /// <summary>
    /// The status within the lifecycle of this item. A high level status, this is not intended to duplicate details carried elsewhere such as legal status, or authorization or marketing status.
    /// </summary>
    public CodeableConcept Status { get; set; }
    /// <summary>
    /// The date at which the given status became applicable.
    /// </summary>
    public string StatusDate { get; set; }
    /// <summary>
    /// Extension container element for StatusDate
    /// </summary>
    public Element _StatusDate { get; set; }
    /// <summary>
    /// The product that this is a pack for.
    /// </summary>
    public List<Reference> Subject { get; set; }
    /// <summary>
    /// A high level category e.g. medicinal product, raw material, shipping/transport container, etc.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((fhirCsR5.Models.DomainResource)this).SerializeJson(writer, options, false);

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Name))
      {
        writer.WriteString("name", (string)Name!);
      }

      if (_Name != null)
      {
        writer.WritePropertyName("_name");
        _Name.SerializeJson(writer, options);
      }

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if ((Subject != null) && (Subject.Count != 0))
      {
        writer.WritePropertyName("subject");
        writer.WriteStartArray();

        foreach (Reference valSubject in Subject)
        {
          valSubject.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Status != null)
      {
        writer.WritePropertyName("status");
        Status.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(StatusDate))
      {
        writer.WriteString("statusDate", (string)StatusDate!);
      }

      if (_StatusDate != null)
      {
        writer.WritePropertyName("_statusDate");
        _StatusDate.SerializeJson(writer, options);
      }

      if ((ContainedItemQuantity != null) && (ContainedItemQuantity.Count != 0))
      {
        writer.WritePropertyName("containedItemQuantity");
        writer.WriteStartArray();

        foreach (Quantity valContainedItemQuantity in ContainedItemQuantity)
        {
          valContainedItemQuantity.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Description))
      {
        writer.WriteString("description", (string)Description!);
      }

      if (_Description != null)
      {
        writer.WritePropertyName("_description");
        _Description.SerializeJson(writer, options);
      }

      if (LegalStatusOfSupply != null)
      {
        writer.WritePropertyName("legalStatusOfSupply");
        LegalStatusOfSupply.SerializeJson(writer, options);
      }

      if ((MarketingStatus != null) && (MarketingStatus.Count != 0))
      {
        writer.WritePropertyName("marketingStatus");
        writer.WriteStartArray();

        foreach (MarketingStatus valMarketingStatus in MarketingStatus)
        {
          valMarketingStatus.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Characteristic != null) && (Characteristic.Count != 0))
      {
        writer.WritePropertyName("characteristic");
        writer.WriteStartArray();

        foreach (CodeableConcept valCharacteristic in Characteristic)
        {
          valCharacteristic.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (CopackagedIndicator != null)
      {
        writer.WriteBoolean("copackagedIndicator", (bool)CopackagedIndicator!);
      }

      if (MarketingAuthorization != null)
      {
        writer.WritePropertyName("marketingAuthorization");
        MarketingAuthorization.SerializeJson(writer, options);
      }

      if ((Manufacturer != null) && (Manufacturer.Count != 0))
      {
        writer.WritePropertyName("manufacturer");
        writer.WriteStartArray();

        foreach (Reference valManufacturer in Manufacturer)
        {
          valManufacturer.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((AttachedDocument != null) && (AttachedDocument.Count != 0))
      {
        writer.WritePropertyName("attachedDocument");
        writer.WriteStartArray();

        foreach (Reference valAttachedDocument in AttachedDocument)
        {
          valAttachedDocument.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Package != null)
      {
        writer.WritePropertyName("package");
        Package.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "attachedDocument":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          AttachedDocument = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objAttachedDocument = new fhirCsR5.Models.Reference();
            objAttachedDocument.DeserializeJson(ref reader, options);
            AttachedDocument.Add(objAttachedDocument);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (AttachedDocument.Count == 0)
          {
            AttachedDocument = null;
          }

          break;

        case "characteristic":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Characteristic = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objCharacteristic = new fhirCsR5.Models.CodeableConcept();
            objCharacteristic.DeserializeJson(ref reader, options);
            Characteristic.Add(objCharacteristic);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Characteristic.Count == 0)
          {
            Characteristic = null;
          }

          break;

        case "containedItemQuantity":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ContainedItemQuantity = new List<Quantity>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Quantity objContainedItemQuantity = new fhirCsR5.Models.Quantity();
            objContainedItemQuantity.DeserializeJson(ref reader, options);
            ContainedItemQuantity.Add(objContainedItemQuantity);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ContainedItemQuantity.Count == 0)
          {
            ContainedItemQuantity = null;
          }

          break;

        case "copackagedIndicator":
          CopackagedIndicator = reader.GetBoolean();
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new fhirCsR5.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Identifier objIdentifier = new fhirCsR5.Models.Identifier();
            objIdentifier.DeserializeJson(ref reader, options);
            Identifier.Add(objIdentifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Identifier.Count == 0)
          {
            Identifier = null;
          }

          break;

        case "legalStatusOfSupply":
          LegalStatusOfSupply = new fhirCsR5.Models.CodeableConcept();
          LegalStatusOfSupply.DeserializeJson(ref reader, options);
          break;

        case "manufacturer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Manufacturer = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objManufacturer = new fhirCsR5.Models.Reference();
            objManufacturer.DeserializeJson(ref reader, options);
            Manufacturer.Add(objManufacturer);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Manufacturer.Count == 0)
          {
            Manufacturer = null;
          }

          break;

        case "marketingAuthorization":
          MarketingAuthorization = new fhirCsR5.Models.Reference();
          MarketingAuthorization.DeserializeJson(ref reader, options);
          break;

        case "marketingStatus":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          MarketingStatus = new List<MarketingStatus>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.MarketingStatus objMarketingStatus = new fhirCsR5.Models.MarketingStatus();
            objMarketingStatus.DeserializeJson(ref reader, options);
            MarketingStatus.Add(objMarketingStatus);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (MarketingStatus.Count == 0)
          {
            MarketingStatus = null;
          }

          break;

        case "name":
          Name = reader.GetString();
          break;

        case "_name":
          _Name = new fhirCsR5.Models.Element();
          _Name.DeserializeJson(ref reader, options);
          break;

        case "package":
          Package = new fhirCsR5.Models.PackagedProductDefinitionPackage();
          Package.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = new fhirCsR5.Models.CodeableConcept();
          Status.DeserializeJson(ref reader, options);
          break;

        case "statusDate":
          StatusDate = reader.GetString();
          break;

        case "_statusDate":
          _StatusDate = new fhirCsR5.Models.Element();
          _StatusDate.DeserializeJson(ref reader, options);
          break;

        case "subject":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Subject = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objSubject = new fhirCsR5.Models.Reference();
            objSubject.DeserializeJson(ref reader, options);
            Subject.Add(objSubject);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Subject.Count == 0)
          {
            Subject = null;
          }

          break;

        case "type":
          Type = new fhirCsR5.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
}
