// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MultiMetricCriteria : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("criterionType"u8);
            writer.WriteStringValue(CriterionType.ToString());
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("metricName"u8);
            writer.WriteStringValue(MetricName);
            if (Optional.IsDefined(MetricNamespace))
            {
                writer.WritePropertyName("metricNamespace"u8);
                writer.WriteStringValue(MetricNamespace);
            }
            writer.WritePropertyName("timeAggregation"u8);
            writer.WriteStringValue(TimeAggregation.ToString());
            if (Optional.IsCollectionDefined(Dimensions))
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteStartArray();
                foreach (var item in Dimensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SkipMetricValidation))
            {
                writer.WritePropertyName("skipMetricValidation"u8);
                writer.WriteBooleanValue(SkipMetricValidation.Value);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static MultiMetricCriteria DeserializeMultiMetricCriteria(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("criterionType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DynamicThresholdCriterion": return DynamicMetricCriteria.DeserializeDynamicMetricCriteria(element);
                    case "StaticThresholdCriterion": return MetricCriteria.DeserializeMetricCriteria(element);
                }
            }
            return UnknownMultiMetricCriteria.DeserializeUnknownMultiMetricCriteria(element);
        }
    }
}
