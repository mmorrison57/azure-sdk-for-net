// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Gallery.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a REST operation.
    /// </summary>
    public partial class Operation
    {
        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        /// <param name="name">Name of the REST operation.</param>
        /// <param name="origin">Origin of the REST operation.</param>
        /// <param name="display">Information about the REST operation.</param>
        public Operation(string name = default(string), string origin = default(string), OperationDisplayDefinition display = default(OperationDisplayDefinition))
        {
            Name = name;
            Origin = origin;
            Display = display;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the REST operation.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets origin of the REST operation.
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets information about the REST operation.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationDisplayDefinition Display { get; set; }

    }
}
