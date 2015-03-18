// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Resources.Models;

namespace Microsoft.Azure.Management.Resources.Models
{
    /// <summary>
    /// Resource information.
    /// </summary>
    public partial class GenericResource : ResourceBase
    {
        private string _properties;
        
        /// <summary>
        /// Optional. Gets or sets the resource properties.
        /// </summary>
        public string Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets resource provisioning state.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the GenericResource class.
        /// </summary>
        public GenericResource()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the GenericResource class with
        /// required arguments.
        /// </summary>
        public GenericResource(string location)
            : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.Location = location;
        }
    }
}
