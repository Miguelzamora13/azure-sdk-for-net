// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningSynapseSparkProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoScaleProperties))
            {
                writer.WritePropertyName("autoScaleProperties"u8);
                writer.WriteObjectValue(AutoScaleProperties);
            }
            if (Optional.IsDefined(AutoPauseProperties))
            {
                writer.WritePropertyName("autoPauseProperties"u8);
                writer.WriteObjectValue(AutoPauseProperties);
            }
            if (Optional.IsDefined(SparkVersion))
            {
                writer.WritePropertyName("sparkVersion"u8);
                writer.WriteStringValue(SparkVersion);
            }
            if (Optional.IsDefined(NodeCount))
            {
                writer.WritePropertyName("nodeCount"u8);
                writer.WriteNumberValue(NodeCount.Value);
            }
            if (Optional.IsDefined(NodeSize))
            {
                writer.WritePropertyName("nodeSize"u8);
                writer.WriteStringValue(NodeSize);
            }
            if (Optional.IsDefined(NodeSizeFamily))
            {
                writer.WritePropertyName("nodeSizeFamily"u8);
                writer.WriteStringValue(NodeSizeFamily);
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(ResourceGroup))
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (Optional.IsDefined(WorkspaceName))
            {
                writer.WritePropertyName("workspaceName"u8);
                writer.WriteStringValue(WorkspaceName);
            }
            if (Optional.IsDefined(PoolName))
            {
                writer.WritePropertyName("poolName"u8);
                writer.WriteStringValue(PoolName);
            }
            writer.WriteEndObject();
        }

        internal static MachineLearningSynapseSparkProperties DeserializeMachineLearningSynapseSparkProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningAutoScaleProperties> autoScaleProperties = default;
            Optional<MachineLearningAutoPauseProperties> autoPauseProperties = default;
            Optional<string> sparkVersion = default;
            Optional<int> nodeCount = default;
            Optional<string> nodeSize = default;
            Optional<string> nodeSizeFamily = default;
            Optional<string> subscriptionId = default;
            Optional<string> resourceGroup = default;
            Optional<string> workspaceName = default;
            Optional<string> poolName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("autoScaleProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    autoScaleProperties = MachineLearningAutoScaleProperties.DeserializeMachineLearningAutoScaleProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("autoPauseProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    autoPauseProperties = MachineLearningAutoPauseProperties.DeserializeMachineLearningAutoPauseProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("sparkVersion"u8))
                {
                    sparkVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nodeSize"u8))
                {
                    nodeSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodeSizeFamily"u8))
                {
                    nodeSizeFamily = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceName"u8))
                {
                    workspaceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("poolName"u8))
                {
                    poolName = property.Value.GetString();
                    continue;
                }
            }
            return new MachineLearningSynapseSparkProperties(autoScaleProperties.Value, autoPauseProperties.Value, sparkVersion.Value, Optional.ToNullable(nodeCount), nodeSize.Value, nodeSizeFamily.Value, subscriptionId.Value, resourceGroup.Value, workspaceName.Value, poolName.Value);
        }
    }
}
