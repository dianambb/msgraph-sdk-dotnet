// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The interface IUserPhotosCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<UserPhotosCollectionPage>))]
    public interface IUserPhotosCollectionPage : ICollectionPage<ProfilePhoto>
    {
        /// <summary>
        /// Gets the next page <see cref="IUserPhotosCollectionRequest"/> instance.
        /// </summary>
        IUserPhotosCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}