// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Reference objects for custom activity. </summary>
    public partial class CustomActivityReferenceObject
    {
        /// <summary> Initializes a new instance of CustomActivityReferenceObject. </summary>
        public CustomActivityReferenceObject()
        {
            LinkedServices = new ChangeTrackingList<FactoryLinkedServiceReference>();
            Datasets = new ChangeTrackingList<DatasetReference>();
        }

        /// <summary> Initializes a new instance of CustomActivityReferenceObject. </summary>
        /// <param name="linkedServices"> Linked service references. </param>
        /// <param name="datasets"> Dataset references. </param>
        internal CustomActivityReferenceObject(IList<FactoryLinkedServiceReference> linkedServices, IList<DatasetReference> datasets)
        {
            LinkedServices = linkedServices;
            Datasets = datasets;
        }

        /// <summary> Linked service references. </summary>
        public IList<FactoryLinkedServiceReference> LinkedServices { get; }
        /// <summary> Dataset references. </summary>
        public IList<DatasetReference> Datasets { get; }
    }
}
