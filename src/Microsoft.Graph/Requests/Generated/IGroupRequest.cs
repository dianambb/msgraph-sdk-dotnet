// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IGroupRequest.
    /// </summary>
    public partial interface IGroupRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Group using PUT.
        /// </summary>
        /// <param name="groupToCreate">The Group to create.</param>
        /// <returns>The created Group.</returns>
        System.Threading.Tasks.Task<Group> CreateAsync(Group groupToCreate);        /// <summary>
        /// Creates the specified Group using PUT.
        /// </summary>
        /// <param name="groupToCreate">The Group to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Group.</returns>
        System.Threading.Tasks.Task<Group> CreateAsync(Group groupToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Group.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Group.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Group.
        /// </summary>
        /// <returns>The Group.</returns>
        System.Threading.Tasks.Task<Group> GetAsync();

        /// <summary>
        /// Gets the specified Group.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Group.</returns>
        System.Threading.Tasks.Task<Group> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Group using PATCH.
        /// </summary>
        /// <param name="groupToUpdate">The Group to update.</param>
        /// <returns>The updated Group.</returns>
        System.Threading.Tasks.Task<Group> UpdateAsync(Group groupToUpdate);

        /// <summary>
        /// Updates the specified Group using PATCH.
        /// </summary>
        /// <param name="groupToUpdate">The Group to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Group.</returns>
        System.Threading.Tasks.Task<Group> UpdateAsync(Group groupToUpdate, CancellationToken cancellationToken);

    }
}
