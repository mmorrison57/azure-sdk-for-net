// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobReleaseTaskState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobReleaseTaskState
    {
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "completed")]
        Completed
    }
    internal static class JobReleaseTaskStateEnumExtension
    {
        internal static string ToSerializedValue(this JobReleaseTaskState? value)  =>
            value == null ? null : ((JobReleaseTaskState)value).ToSerializedValue();

        internal static string ToSerializedValue(this JobReleaseTaskState value)
        {
            switch( value )
            {
                case JobReleaseTaskState.Running:
                    return "running";
                case JobReleaseTaskState.Completed:
                    return "completed";
            }
            return null;
        }

        internal static JobReleaseTaskState? ParseJobReleaseTaskState(this string value)
        {
            switch( value )
            {
                case "running":
                    return JobReleaseTaskState.Running;
                case "completed":
                    return JobReleaseTaskState.Completed;
            }
            return null;
        }
    }
}
