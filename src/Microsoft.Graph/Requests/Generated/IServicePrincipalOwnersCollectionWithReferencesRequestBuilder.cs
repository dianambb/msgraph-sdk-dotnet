// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IServicePrincipalOwnersCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IServicePrincipalOwnersCollectionWithReferencesRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IServicePrincipalOwnersCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IServicePrincipalOwnersCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDirectoryObjectRequestBuilder"/> for the specified DirectoryObject.
        /// </summary>
        /// <param name="id">The ID for the DirectoryObject.</param>
        /// <returns>The <see cref="IDirectoryObjectRequestBuilder"/>.</returns>
        IDirectoryObjectRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IServicePrincipalOwnersCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalOwnersCollectionReferencesRequestBuilder"/>.</returns>
        IServicePrincipalOwnersCollectionReferencesRequestBuilder References { get; }

    }
}
