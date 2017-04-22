// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Azure;
    using Management;
    using Network;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of ApplicationGatewayBackendHealthPool resources.
    /// </summary>
    public partial class ApplicationGatewayBackendHealth
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayBackendHealth
        /// class.
        /// </summary>
        public ApplicationGatewayBackendHealth() { }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayBackendHealth
        /// class.
        /// </summary>
        public ApplicationGatewayBackendHealth(IList<ApplicationGatewayBackendHealthPool> backendAddressPools = default(IList<ApplicationGatewayBackendHealthPool>))
        {
            BackendAddressPools = backendAddressPools;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "backendAddressPools")]
        public IList<ApplicationGatewayBackendHealthPool> BackendAddressPools { get; set; }

    }
}
