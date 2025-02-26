// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class InlineEventProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(DocumentationUri))
            {
                writer.WritePropertyName("documentationUrl"u8);
                writer.WriteStringValue(DocumentationUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DataSchemaUri))
            {
                writer.WritePropertyName("dataSchemaUrl"u8);
                writer.WriteStringValue(DataSchemaUri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static InlineEventProperties DeserializeInlineEventProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> description = default;
            Optional<string> displayName = default;
            Optional<Uri> documentationUri = default;
            Optional<Uri> dataSchemaUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("documentationUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        documentationUri = null;
                        continue;
                    }
                    documentationUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSchemaUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataSchemaUri = null;
                        continue;
                    }
                    dataSchemaUri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new InlineEventProperties(description.Value, displayName.Value, documentationUri.Value, dataSchemaUri.Value);
        }
    }
}
