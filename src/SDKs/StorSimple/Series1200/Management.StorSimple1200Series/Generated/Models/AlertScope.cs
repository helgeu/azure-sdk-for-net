// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AlertScope.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AlertScope
    {
        [EnumMember(Value = "Resource")]
        Resource,
        [EnumMember(Value = "Device")]
        Device
    }
    internal static class AlertScopeEnumExtension
    {
        internal static string ToSerializedValue(this AlertScope? value)
        {
            return value == null ? null : ((AlertScope)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AlertScope value)
        {
            switch( value )
            {
                case AlertScope.Resource:
                    return "Resource";
                case AlertScope.Device:
                    return "Device";
            }
            return null;
        }

        internal static AlertScope? ParseAlertScope(this string value)
        {
            switch( value )
            {
                case "Resource":
                    return AlertScope.Resource;
                case "Device":
                    return AlertScope.Device;
            }
            return null;
        }
    }
}