// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventHubs
{
    public partial class EventHubsApplicationGroupData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("isEnabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(ClientAppGroupIdentifier))
            {
                writer.WritePropertyName("clientAppGroupIdentifier"u8);
                writer.WriteStringValue(ClientAppGroupIdentifier);
            }
            if (Optional.IsCollectionDefined(Policies))
            {
                writer.WritePropertyName("policies"u8);
                writer.WriteStartArray();
                foreach (var item in Policies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static EventHubsApplicationGroupData DeserializeEventHubsApplicationGroupData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<bool> isEnabled = default;
            Optional<string> clientAppGroupIdentifier = default;
            Optional<IList<EventHubsApplicationGroupPolicy>> policies = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("isEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("clientAppGroupIdentifier"u8))
                        {
                            clientAppGroupIdentifier = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("policies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<EventHubsApplicationGroupPolicy> array = new List<EventHubsApplicationGroupPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EventHubsApplicationGroupPolicy.DeserializeEventHubsApplicationGroupPolicy(item));
                            }
                            policies = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new EventHubsApplicationGroupData(id, name, type, systemData.Value, Optional.ToNullable(isEnabled), clientAppGroupIdentifier.Value, Optional.ToList(policies), Optional.ToNullable(location));
        }
    }
}
