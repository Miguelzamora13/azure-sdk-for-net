// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> The FrontDoorExperimentResourceGetTimeSeriesReportOptions. </summary>
    public partial class FrontDoorExperimentResourceGetTimeSeriesReportOptions
    {
        /// <summary> Initializes a new instance of FrontDoorExperimentResourceGetTimeSeriesReportOptions. </summary>
        /// <param name="startOn"> The start DateTime of the Timeseries in UTC. </param>
        /// <param name="endOn"> The end DateTime of the Timeseries in UTC. </param>
        /// <param name="aggregationInterval"> The aggregation interval of the Timeseries. </param>
        /// <param name="timeSeriesType"> The type of Timeseries. </param>
        public FrontDoorExperimentResourceGetTimeSeriesReportOptions(DateTimeOffset startOn, DateTimeOffset endOn, FrontDoorTimeSeriesAggregationInterval aggregationInterval, FrontDoorTimeSeriesType timeSeriesType)
        {
            StartOn = startOn;
            EndOn = endOn;
            AggregationInterval = aggregationInterval;
            TimeSeriesType = timeSeriesType;
        }

        /// <summary> The start DateTime of the Timeseries in UTC. </summary>
        public DateTimeOffset StartOn { get; }
        /// <summary> The end DateTime of the Timeseries in UTC. </summary>
        public DateTimeOffset EndOn { get; }
        /// <summary> The aggregation interval of the Timeseries. </summary>
        public FrontDoorTimeSeriesAggregationInterval AggregationInterval { get; }
        /// <summary> The type of Timeseries. </summary>
        public FrontDoorTimeSeriesType TimeSeriesType { get; }
        /// <summary> The specific endpoint. </summary>
        public string Endpoint { get; set; } = null;

        /// <summary> The country associated with the Timeseries. Values are country ISO codes as specified here- https://www.iso.org/iso-3166-country-codes.html. </summary>
        public string Country { get; set; } = null;
    }
}
