// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type BindingRequestBuilder.
    /// </summary>
    public partial class BindingRequestBuilder : EntityRequestBuilder, IBindingRequestBuilder
    {

        /// <summary>
        /// Constructs a new BindingRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public BindingRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IBindingRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IBindingRequest Request(IEnumerable<Option> options)
        {
            return new BindingRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for BindingItemAt.
        /// </summary>
        /// <returns>The <see cref="IBindingItemAtRequestBuilder"/>.</returns>
        public IBindingItemAtRequestBuilder ItemAt(
            Int32 index)
        {
            return new BindingItemAtRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.itemAt"),
                this.Client,
                index);
        }

        /// <summary>
        /// Gets the request builder for BindingCount.
        /// </summary>
        /// <returns>The <see cref="IBindingCountRequestBuilder"/>.</returns>
        public IBindingCountRequestBuilder Count()
        {
            return new BindingCountRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.count"),
                this.Client);
        }
    
    }
}
