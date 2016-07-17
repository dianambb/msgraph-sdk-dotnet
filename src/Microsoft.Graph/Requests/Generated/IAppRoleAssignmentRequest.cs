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
    /// The interface IAppRoleAssignmentRequest.
    /// </summary>
    public partial interface IAppRoleAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AppRoleAssignment using PUT.
        /// </summary>
        /// <param name="appRoleAssignmentToCreate">The AppRoleAssignment to create.</param>
        /// <returns>The created AppRoleAssignment.</returns>
        System.Threading.Tasks.Task<AppRoleAssignment> CreateAsync(AppRoleAssignment appRoleAssignmentToCreate);        /// <summary>
        /// Creates the specified AppRoleAssignment using PUT.
        /// </summary>
        /// <param name="appRoleAssignmentToCreate">The AppRoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AppRoleAssignment.</returns>
        System.Threading.Tasks.Task<AppRoleAssignment> CreateAsync(AppRoleAssignment appRoleAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AppRoleAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AppRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AppRoleAssignment.
        /// </summary>
        /// <returns>The AppRoleAssignment.</returns>
        System.Threading.Tasks.Task<AppRoleAssignment> GetAsync();

        /// <summary>
        /// Gets the specified AppRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AppRoleAssignment.</returns>
        System.Threading.Tasks.Task<AppRoleAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AppRoleAssignment using PATCH.
        /// </summary>
        /// <param name="appRoleAssignmentToUpdate">The AppRoleAssignment to update.</param>
        /// <returns>The updated AppRoleAssignment.</returns>
        System.Threading.Tasks.Task<AppRoleAssignment> UpdateAsync(AppRoleAssignment appRoleAssignmentToUpdate);

        /// <summary>
        /// Updates the specified AppRoleAssignment using PATCH.
        /// </summary>
        /// <param name="appRoleAssignmentToUpdate">The AppRoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated AppRoleAssignment.</returns>
        System.Threading.Tasks.Task<AppRoleAssignment> UpdateAsync(AppRoleAssignment appRoleAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppRoleAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAppRoleAssignmentRequest Select(string value);

    }
}