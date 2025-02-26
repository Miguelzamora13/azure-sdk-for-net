// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupTargetDiskNetworkAccessSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetDiskNetworkAccessOption))
            {
                writer.WritePropertyName("targetDiskNetworkAccessOption"u8);
                writer.WriteStringValue(TargetDiskNetworkAccessOption.Value.ToSerialString());
            }
            if (Optional.IsDefined(TargetDiskAccessId))
            {
                writer.WritePropertyName("targetDiskAccessId"u8);
                writer.WriteStringValue(TargetDiskAccessId);
            }
            writer.WriteEndObject();
        }

        internal static BackupTargetDiskNetworkAccessSettings DeserializeBackupTargetDiskNetworkAccessSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BackupTargetDiskNetworkAccessOption> targetDiskNetworkAccessOption = default;
            Optional<ResourceIdentifier> targetDiskAccessId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetDiskNetworkAccessOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetDiskNetworkAccessOption = property.Value.GetString().ToBackupTargetDiskNetworkAccessOption();
                    continue;
                }
                if (property.NameEquals("targetDiskAccessId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetDiskAccessId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new BackupTargetDiskNetworkAccessSettings(Optional.ToNullable(targetDiskNetworkAccessOption), targetDiskAccessId.Value);
        }
    }
}
