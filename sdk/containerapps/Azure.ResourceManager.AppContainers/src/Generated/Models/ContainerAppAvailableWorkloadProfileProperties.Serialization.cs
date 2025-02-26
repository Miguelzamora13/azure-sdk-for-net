// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppAvailableWorkloadProfileProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BillingMeterCategory))
            {
                writer.WritePropertyName("billingMeterCategory"u8);
                writer.WriteStringValue(BillingMeterCategory.Value.ToString());
            }
            if (Optional.IsDefined(Applicability))
            {
                writer.WritePropertyName("applicability"u8);
                writer.WriteStringValue(Applicability.Value.ToString());
            }
            if (Optional.IsDefined(Cores))
            {
                writer.WritePropertyName("cores"u8);
                writer.WriteNumberValue(Cores.Value);
            }
            if (Optional.IsDefined(MemoryInGiB))
            {
                writer.WritePropertyName("memoryGiB"u8);
                writer.WriteNumberValue(MemoryInGiB.Value);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppAvailableWorkloadProfileProperties DeserializeContainerAppAvailableWorkloadProfileProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerAppBillingMeterCategory> billingMeterCategory = default;
            Optional<ContainerAppAvailableWorkloadProfileApplicability> applicability = default;
            Optional<int> cores = default;
            Optional<int> memoryGiB = default;
            Optional<string> displayName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingMeterCategory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    billingMeterCategory = new ContainerAppBillingMeterCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applicability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    applicability = new ContainerAppAvailableWorkloadProfileApplicability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("memoryGiB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    memoryGiB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerAppAvailableWorkloadProfileProperties(Optional.ToNullable(billingMeterCategory), Optional.ToNullable(applicability), Optional.ToNullable(cores), Optional.ToNullable(memoryGiB), displayName.Value);
        }
    }
}
