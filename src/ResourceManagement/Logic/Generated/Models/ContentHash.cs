// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The content hash.
    /// </summary>
    public partial class ContentHash
    {
        /// <summary>
        /// Initializes a new instance of the ContentHash class.
        /// </summary>
        public ContentHash()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContentHash class.
        /// </summary>
        /// <param name="algorithm">The algorithm of the content hash.</param>
        /// <param name="value">The value of the content hash.</param>
        public ContentHash(string algorithm = default(string), string value = default(string))
        {
            Algorithm = algorithm;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the algorithm of the content hash.
        /// </summary>
        [JsonProperty(PropertyName = "algorithm")]
        public string Algorithm { get; set; }

        /// <summary>
        /// Gets or sets the value of the content hash.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}