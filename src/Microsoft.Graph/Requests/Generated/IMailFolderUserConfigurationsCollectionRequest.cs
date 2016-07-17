// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IMailFolderUserConfigurationsCollectionRequest.
    /// </summary>
    public partial interface IMailFolderUserConfigurationsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified UserConfiguration to the collection via POST.
        /// </summary>
        /// <param name="userConfiguration">The UserConfiguration to add.</param>
        /// <returns>The created UserConfiguration.</returns>
        System.Threading.Tasks.Task<UserConfiguration> AddAsync(UserConfiguration userConfiguration);

        /// <summary>
        /// Adds the specified UserConfiguration to the collection via POST.
        /// </summary>
        /// <param name="userConfiguration">The UserConfiguration to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserConfiguration.</returns>
        System.Threading.Tasks.Task<UserConfiguration> AddAsync(UserConfiguration userConfiguration, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IMailFolderUserConfigurationsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IMailFolderUserConfigurationsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMailFolderUserConfigurationsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IMailFolderUserConfigurationsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IMailFolderUserConfigurationsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IMailFolderUserConfigurationsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IMailFolderUserConfigurationsCollectionRequest OrderBy(string value);
    }
}
