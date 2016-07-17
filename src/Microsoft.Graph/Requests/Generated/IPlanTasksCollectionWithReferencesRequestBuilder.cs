// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IPlanTasksCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IPlanTasksCollectionWithReferencesRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IPlanTasksCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IPlanTasksCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ITaskRequestBuilder"/> for the specified Task.
        /// </summary>
        /// <param name="id">The ID for the Task.</param>
        /// <returns>The <see cref="ITaskRequestBuilder"/>.</returns>
        ITaskRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IPlanTasksCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IPlanTasksCollectionReferencesRequestBuilder"/>.</returns>
        IPlanTasksCollectionReferencesRequestBuilder References { get; }

    }
}