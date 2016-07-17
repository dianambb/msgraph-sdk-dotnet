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
    /// The interface ILocatedRiskEventRequest.
    /// </summary>
    public partial interface ILocatedRiskEventRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified LocatedRiskEvent using PUT.
        /// </summary>
        /// <param name="locatedRiskEventToCreate">The LocatedRiskEvent to create.</param>
        /// <returns>The created LocatedRiskEvent.</returns>
        System.Threading.Tasks.Task<LocatedRiskEvent> CreateAsync(LocatedRiskEvent locatedRiskEventToCreate);        /// <summary>
        /// Creates the specified LocatedRiskEvent using PUT.
        /// </summary>
        /// <param name="locatedRiskEventToCreate">The LocatedRiskEvent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created LocatedRiskEvent.</returns>
        System.Threading.Tasks.Task<LocatedRiskEvent> CreateAsync(LocatedRiskEvent locatedRiskEventToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified LocatedRiskEvent.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified LocatedRiskEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified LocatedRiskEvent.
        /// </summary>
        /// <returns>The LocatedRiskEvent.</returns>
        System.Threading.Tasks.Task<LocatedRiskEvent> GetAsync();

        /// <summary>
        /// Gets the specified LocatedRiskEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The LocatedRiskEvent.</returns>
        System.Threading.Tasks.Task<LocatedRiskEvent> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified LocatedRiskEvent using PATCH.
        /// </summary>
        /// <param name="locatedRiskEventToUpdate">The LocatedRiskEvent to update.</param>
        /// <returns>The updated LocatedRiskEvent.</returns>
        System.Threading.Tasks.Task<LocatedRiskEvent> UpdateAsync(LocatedRiskEvent locatedRiskEventToUpdate);

        /// <summary>
        /// Updates the specified LocatedRiskEvent using PATCH.
        /// </summary>
        /// <param name="locatedRiskEventToUpdate">The LocatedRiskEvent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated LocatedRiskEvent.</returns>
        System.Threading.Tasks.Task<LocatedRiskEvent> UpdateAsync(LocatedRiskEvent locatedRiskEventToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ILocatedRiskEventRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ILocatedRiskEventRequest Select(string value);

    }
}
