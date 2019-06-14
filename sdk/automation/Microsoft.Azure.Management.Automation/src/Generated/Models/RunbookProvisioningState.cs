// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for RunbookProvisioningState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RunbookProvisioningState
    {
        [EnumMember(Value = "Succeeded")]
        Succeeded
    }
    internal static class RunbookProvisioningStateEnumExtension
    {
        internal static string ToSerializedValue(this RunbookProvisioningState? value)
        {
            return value == null ? null : ((RunbookProvisioningState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this RunbookProvisioningState value)
        {
            switch( value )
            {
                case RunbookProvisioningState.Succeeded:
                    return "Succeeded";
            }
            return null;
        }

        internal static RunbookProvisioningState? ParseRunbookProvisioningState(this string value)
        {
            switch( value )
            {
                case "Succeeded":
                    return RunbookProvisioningState.Succeeded;
            }
            return null;
        }
    }
}