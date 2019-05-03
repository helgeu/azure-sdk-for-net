// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Job Output Progress Event Data.
    /// </summary>
    public partial class MediaJobOutputProgressEventData
    {
        /// <summary>
        /// Initializes a new instance of the MediaJobOutputProgressEventData
        /// class.
        /// </summary>
        public MediaJobOutputProgressEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaJobOutputProgressEventData
        /// class.
        /// </summary>
        /// <param name="label">Gets the Job output label.</param>
        /// <param name="progress">Gets the Job output progress.</param>
        /// <param name="jobCorrelationData">Gets the Job correlation
        /// data.</param>
        public MediaJobOutputProgressEventData(string label = default(string), long? progress = default(long?), IDictionary<string, string> jobCorrelationData = default(IDictionary<string, string>))
        {
            Label = label;
            Progress = progress;
            JobCorrelationData = jobCorrelationData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the Job output label.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Gets the Job output progress.
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public long? Progress { get; set; }

        /// <summary>
        /// Gets the Job correlation data.
        /// </summary>
        [JsonProperty(PropertyName = "jobCorrelationData")]
        public IDictionary<string, string> JobCorrelationData { get; set; }

    }
}