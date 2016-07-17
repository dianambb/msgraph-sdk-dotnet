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
    /// The interface IDirectorySettingRequest.
    /// </summary>
    public partial interface IDirectorySettingRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DirectorySetting using PUT.
        /// </summary>
        /// <param name="directorySettingToCreate">The DirectorySetting to create.</param>
        /// <returns>The created DirectorySetting.</returns>
        System.Threading.Tasks.Task<DirectorySetting> CreateAsync(DirectorySetting directorySettingToCreate);        /// <summary>
        /// Creates the specified DirectorySetting using PUT.
        /// </summary>
        /// <param name="directorySettingToCreate">The DirectorySetting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DirectorySetting.</returns>
        System.Threading.Tasks.Task<DirectorySetting> CreateAsync(DirectorySetting directorySettingToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DirectorySetting.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DirectorySetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DirectorySetting.
        /// </summary>
        /// <returns>The DirectorySetting.</returns>
        System.Threading.Tasks.Task<DirectorySetting> GetAsync();

        /// <summary>
        /// Gets the specified DirectorySetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DirectorySetting.</returns>
        System.Threading.Tasks.Task<DirectorySetting> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DirectorySetting using PATCH.
        /// </summary>
        /// <param name="directorySettingToUpdate">The DirectorySetting to update.</param>
        /// <returns>The updated DirectorySetting.</returns>
        System.Threading.Tasks.Task<DirectorySetting> UpdateAsync(DirectorySetting directorySettingToUpdate);

        /// <summary>
        /// Updates the specified DirectorySetting using PATCH.
        /// </summary>
        /// <param name="directorySettingToUpdate">The DirectorySetting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DirectorySetting.</returns>
        System.Threading.Tasks.Task<DirectorySetting> UpdateAsync(DirectorySetting directorySettingToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectorySettingRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectorySettingRequest Select(string value);

    }
}