// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeRemoteSupportSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RemoteApplicationType))
            {
                writer.WritePropertyName("remoteApplicationType"u8);
                writer.WriteStringValue(RemoteApplicationType.Value.ToString());
            }
            if (Optional.IsDefined(AccessLevel))
            {
                writer.WritePropertyName("accessLevel"u8);
                writer.WriteStringValue(AccessLevel.Value.ToString());
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationTimeStampInUTC"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static EdgeRemoteSupportSettings DeserializeEdgeRemoteSupportSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EdgeRemoteApplicationType> remoteApplicationType = default;
            Optional<EdgeRemoteApplicationAccessLevel> accessLevel = default;
            Optional<DateTimeOffset> expirationTimeStampInUtc = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("remoteApplicationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    remoteApplicationType = new EdgeRemoteApplicationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accessLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    accessLevel = new EdgeRemoteApplicationAccessLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expirationTimeStampInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expirationTimeStampInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new EdgeRemoteSupportSettings(Optional.ToNullable(remoteApplicationType), Optional.ToNullable(accessLevel), Optional.ToNullable(expirationTimeStampInUtc));
        }
    }
}
