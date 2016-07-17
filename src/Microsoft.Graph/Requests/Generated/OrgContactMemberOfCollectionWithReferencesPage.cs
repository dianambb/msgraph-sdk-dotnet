// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;

    /// <summary>
    /// The type OrgContactMemberOfCollectionWithReferencesPage.
    /// </summary>
    public partial class OrgContactMemberOfCollectionWithReferencesPage : CollectionPage<DirectoryObject>, IOrgContactMemberOfCollectionWithReferencesPage
    {
        /// <summary>
        /// Gets the next page <see cref="IOrgContactMemberOfCollectionWithReferencesRequest"/> instance.
        /// </summary>
        public IOrgContactMemberOfCollectionWithReferencesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new OrgContactMemberOfCollectionWithReferencesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}