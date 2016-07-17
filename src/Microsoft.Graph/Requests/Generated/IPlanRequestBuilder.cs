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
    /// The interface IPlanRequestBuilder.
    /// </summary>
    public partial interface IPlanRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IPlanRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IPlanRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Tasks.
        /// </summary>
        /// <returns>The <see cref="IPlanTasksCollectionWithReferencesRequestBuilder"/>.</returns>
        IPlanTasksCollectionWithReferencesRequestBuilder Tasks { get; }

        /// <summary>
        /// Gets the request builder for Buckets.
        /// </summary>
        /// <returns>The <see cref="IPlanBucketsCollectionWithReferencesRequestBuilder"/>.</returns>
        IPlanBucketsCollectionWithReferencesRequestBuilder Buckets { get; }

        /// <summary>
        /// Gets the request builder for Details.
        /// </summary>
        /// <returns>The <see cref="IPlanDetailsRequestBuilder"/>.</returns>
        IPlanDetailsRequestBuilder Details { get; }

        /// <summary>
        /// Gets the request builder for AssignedToTaskBoard.
        /// </summary>
        /// <returns>The <see cref="IPlanTaskBoardRequestBuilder"/>.</returns>
        IPlanTaskBoardRequestBuilder AssignedToTaskBoard { get; }

        /// <summary>
        /// Gets the request builder for ProgressTaskBoard.
        /// </summary>
        /// <returns>The <see cref="IPlanTaskBoardRequestBuilder"/>.</returns>
        IPlanTaskBoardRequestBuilder ProgressTaskBoard { get; }

        /// <summary>
        /// Gets the request builder for BucketTaskBoard.
        /// </summary>
        /// <returns>The <see cref="IPlanTaskBoardRequestBuilder"/>.</returns>
        IPlanTaskBoardRequestBuilder BucketTaskBoard { get; }
    
    }
}
