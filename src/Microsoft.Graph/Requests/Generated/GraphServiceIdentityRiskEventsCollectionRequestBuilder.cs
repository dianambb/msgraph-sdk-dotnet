// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceIdentityRiskEventsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceIdentityRiskEventsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceIdentityRiskEventsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceIdentityRiskEventsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceIdentityRiskEventsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceIdentityRiskEventsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceIdentityRiskEventsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceIdentityRiskEventsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IIdentityRiskEventRequestBuilder"/> for the specified GraphServiceIdentityRiskEvent.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceIdentityRiskEvent.</param>
        /// <returns>The <see cref="IIdentityRiskEventRequestBuilder"/>.</returns>
        public IIdentityRiskEventRequestBuilder this[string id]
        {
            get
            {
                return new IdentityRiskEventRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}
