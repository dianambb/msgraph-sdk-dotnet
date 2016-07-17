// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ServicePrincipalOwnersCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class ServicePrincipalOwnersCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IServicePrincipalOwnersCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ServicePrincipalOwnersCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ServicePrincipalOwnersCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IServicePrincipalOwnersCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IServicePrincipalOwnersCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new ServicePrincipalOwnersCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDirectoryObjectRequestBuilder"/> for the specified ServicePrincipalDirectoryObject.
        /// </summary>
        /// <param name="id">The ID for the ServicePrincipalDirectoryObject.</param>
        /// <returns>The <see cref="IDirectoryObjectRequestBuilder"/>.</returns>
        public IDirectoryObjectRequestBuilder this[string id]
        {
            get
            {
                return new DirectoryObjectRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IServicePrincipalOwnersCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalOwnersCollectionReferencesRequestBuilder"/>.</returns>
        public IServicePrincipalOwnersCollectionReferencesRequestBuilder References
        {
            get
            {
                return new ServicePrincipalOwnersCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
