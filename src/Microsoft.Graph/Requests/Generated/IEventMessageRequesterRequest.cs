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
    /// The interface IEventMessageRequesterRequest.
    /// </summary>
    public partial interface IEventMessageRequesterRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EventMessageRequester using PUT.
        /// </summary>
        /// <param name="eventMessageRequesterToCreate">The EventMessageRequester to create.</param>
        /// <returns>The created EventMessageRequester.</returns>
        System.Threading.Tasks.Task<EventMessageRequester> CreateAsync(EventMessageRequester eventMessageRequesterToCreate);        /// <summary>
        /// Creates the specified EventMessageRequester using PUT.
        /// </summary>
        /// <param name="eventMessageRequesterToCreate">The EventMessageRequester to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EventMessageRequester.</returns>
        System.Threading.Tasks.Task<EventMessageRequester> CreateAsync(EventMessageRequester eventMessageRequesterToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EventMessageRequester.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EventMessageRequester.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EventMessageRequester.
        /// </summary>
        /// <returns>The EventMessageRequester.</returns>
        System.Threading.Tasks.Task<EventMessageRequester> GetAsync();

        /// <summary>
        /// Gets the specified EventMessageRequester.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EventMessageRequester.</returns>
        System.Threading.Tasks.Task<EventMessageRequester> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EventMessageRequester using PATCH.
        /// </summary>
        /// <param name="eventMessageRequesterToUpdate">The EventMessageRequester to update.</param>
        /// <returns>The updated EventMessageRequester.</returns>
        System.Threading.Tasks.Task<EventMessageRequester> UpdateAsync(EventMessageRequester eventMessageRequesterToUpdate);

        /// <summary>
        /// Updates the specified EventMessageRequester using PATCH.
        /// </summary>
        /// <param name="eventMessageRequesterToUpdate">The EventMessageRequester to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated EventMessageRequester.</returns>
        System.Threading.Tasks.Task<EventMessageRequester> UpdateAsync(EventMessageRequester eventMessageRequesterToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEventMessageRequesterRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEventMessageRequesterRequest Select(string value);

    }
}
