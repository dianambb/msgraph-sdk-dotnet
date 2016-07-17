// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;

    /// <summary>
    /// The type GroupPhotosCollectionPage.
    /// </summary>
    public partial class GroupPhotosCollectionPage : CollectionPage<ProfilePhoto>, IGroupPhotosCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IGroupPhotosCollectionRequest"/> instance.
        /// </summary>
        public IGroupPhotosCollectionRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new GroupPhotosCollectionRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
