// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type FilterApplyFontColorFilterRequest.
    /// </summary>
    public partial class FilterApplyFontColorFilterRequest : BaseRequest, IFilterApplyFontColorFilterRequest
    {
        /// <summary>
        /// Constructs a new FilterApplyFontColorFilterRequest.
        /// </summary>
        public FilterApplyFontColorFilterRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
            this.Method = "POST";
            this.ContentType = "application/json";
            this.RequestBody = new FilterApplyFontColorFilterRequestBody();
        }

        /// <summary>
        /// Gets the request body.
        /// </summary>
        public FilterApplyFontColorFilterRequestBody RequestBody { get; private set; }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        public System.Threading.Tasks.Task PostAsync()
        {
            return this.PostAsync(CancellationToken.None);
        }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// <param name=""cancellationToken"">The <see cref=""CancellationToken""/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task PostAsync(
            CancellationToken cancellationToken)
        {
            return this.SendAsync(this.RequestBody, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IFilterApplyFontColorFilterRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IFilterApplyFontColorFilterRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    }
}