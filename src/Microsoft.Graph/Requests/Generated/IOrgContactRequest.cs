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
    /// The interface IOrgContactRequest.
    /// </summary>
    public partial interface IOrgContactRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OrgContact using PUT.
        /// </summary>
        /// <param name="orgContactToCreate">The OrgContact to create.</param>
        /// <returns>The created OrgContact.</returns>
        System.Threading.Tasks.Task<OrgContact> CreateAsync(OrgContact orgContactToCreate);        /// <summary>
        /// Creates the specified OrgContact using PUT.
        /// </summary>
        /// <param name="orgContactToCreate">The OrgContact to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OrgContact.</returns>
        System.Threading.Tasks.Task<OrgContact> CreateAsync(OrgContact orgContactToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OrgContact.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OrgContact.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OrgContact.
        /// </summary>
        /// <returns>The OrgContact.</returns>
        System.Threading.Tasks.Task<OrgContact> GetAsync();

        /// <summary>
        /// Gets the specified OrgContact.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OrgContact.</returns>
        System.Threading.Tasks.Task<OrgContact> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OrgContact using PATCH.
        /// </summary>
        /// <param name="orgContactToUpdate">The OrgContact to update.</param>
        /// <returns>The updated OrgContact.</returns>
        System.Threading.Tasks.Task<OrgContact> UpdateAsync(OrgContact orgContactToUpdate);

        /// <summary>
        /// Updates the specified OrgContact using PATCH.
        /// </summary>
        /// <param name="orgContactToUpdate">The OrgContact to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated OrgContact.</returns>
        System.Threading.Tasks.Task<OrgContact> UpdateAsync(OrgContact orgContactToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOrgContactRequest Select(string value);

    }
}
