// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Result of the request to list Microsoft.Insights operations. It
    /// contains a list of operations and a URL link to get the next set of
    /// results.
    /// </summary>
    public partial class OperationListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the OperationListResultInner class.
        /// </summary>
        public OperationListResultInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationListResultInner class.
        /// </summary>
        /// <param name="value">List of operations supported by the
        /// Microsoft.Insights provider.</param>
        /// <param name="nextLink">URL to get the next set of operation list
        /// results if there are any.</param>
        public OperationListResultInner(IList<Operation> value = default(IList<Operation>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of operations supported by the Microsoft.Insights
        /// provider.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Operation> Value { get; set; }

        /// <summary>
        /// Gets or sets URL to get the next set of operation list results if
        /// there are any.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
