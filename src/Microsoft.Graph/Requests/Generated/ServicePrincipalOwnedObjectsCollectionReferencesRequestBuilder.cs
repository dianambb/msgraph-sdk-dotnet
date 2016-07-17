// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ServicePrincipalOwnedObjectsCollectionReferencesRequestBuilder.
    /// </summary>
    public partial class ServicePrincipalOwnedObjectsCollectionReferencesRequestBuilder : BaseRequestBuilder, IServicePrincipalOwnedObjectsCollectionReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ServicePrincipalOwnedObjectsCollectionReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ServicePrincipalOwnedObjectsCollectionReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IServicePrincipalOwnedObjectsCollectionReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IServicePrincipalOwnedObjectsCollectionReferencesRequest Request(IEnumerable<Option> options)
        {
            return new ServicePrincipalOwnedObjectsCollectionReferencesRequest(this.RequestUrl, this.Client, options);
        }
    }
}
