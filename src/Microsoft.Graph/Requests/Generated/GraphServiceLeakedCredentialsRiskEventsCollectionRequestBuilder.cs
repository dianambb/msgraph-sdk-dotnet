// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceLeakedCredentialsRiskEventsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceLeakedCredentialsRiskEventsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceLeakedCredentialsRiskEventsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceLeakedCredentialsRiskEventsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceLeakedCredentialsRiskEventsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceLeakedCredentialsRiskEventsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceLeakedCredentialsRiskEventsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceLeakedCredentialsRiskEventsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ILeakedCredentialsRiskEventRequestBuilder"/> for the specified GraphServiceLeakedCredentialsRiskEvent.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceLeakedCredentialsRiskEvent.</param>
        /// <returns>The <see cref="ILeakedCredentialsRiskEventRequestBuilder"/>.</returns>
        public ILeakedCredentialsRiskEventRequestBuilder this[string id]
        {
            get
            {
                return new LeakedCredentialsRiskEventRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}
