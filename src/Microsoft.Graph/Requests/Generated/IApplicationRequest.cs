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
    /// The interface IApplicationRequest.
    /// </summary>
    public partial interface IApplicationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Application using PUT.
        /// </summary>
        /// <param name="applicationToCreate">The Application to create.</param>
        /// <returns>The created Application.</returns>
        System.Threading.Tasks.Task<Application> CreateAsync(Application applicationToCreate);        /// <summary>
        /// Creates the specified Application using PUT.
        /// </summary>
        /// <param name="applicationToCreate">The Application to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Application.</returns>
        System.Threading.Tasks.Task<Application> CreateAsync(Application applicationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Application.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Application.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Application.
        /// </summary>
        /// <returns>The Application.</returns>
        System.Threading.Tasks.Task<Application> GetAsync();

        /// <summary>
        /// Gets the specified Application.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Application.</returns>
        System.Threading.Tasks.Task<Application> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Application using PATCH.
        /// </summary>
        /// <param name="applicationToUpdate">The Application to update.</param>
        /// <returns>The updated Application.</returns>
        System.Threading.Tasks.Task<Application> UpdateAsync(Application applicationToUpdate);

        /// <summary>
        /// Updates the specified Application using PATCH.
        /// </summary>
        /// <param name="applicationToUpdate">The Application to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Application.</returns>
        System.Threading.Tasks.Task<Application> UpdateAsync(Application applicationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IApplicationRequest Select(string value);

    }
}