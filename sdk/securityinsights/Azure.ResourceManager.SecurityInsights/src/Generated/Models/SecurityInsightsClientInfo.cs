// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Information on the client (user or application) that made some action. </summary>
    public partial class SecurityInsightsClientInfo
    {
        /// <summary> Initializes a new instance of SecurityInsightsClientInfo. </summary>
        internal SecurityInsightsClientInfo()
        {
        }

        /// <summary> Initializes a new instance of SecurityInsightsClientInfo. </summary>
        /// <param name="email"> The email of the client. </param>
        /// <param name="name"> The name of the client. </param>
        /// <param name="objectId"> The object id of the client. </param>
        /// <param name="userPrincipalName"> The user principal name of the client. </param>
        internal SecurityInsightsClientInfo(string email, string name, Guid? objectId, string userPrincipalName)
        {
            Email = email;
            Name = name;
            ObjectId = objectId;
            UserPrincipalName = userPrincipalName;
        }

        /// <summary> The email of the client. </summary>
        public string Email { get; }
        /// <summary> The name of the client. </summary>
        public string Name { get; }
        /// <summary> The object id of the client. </summary>
        public Guid? ObjectId { get; }
        /// <summary> The user principal name of the client. </summary>
        public string UserPrincipalName { get; }
    }
}
