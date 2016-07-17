// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IMailFolderRequestBuilder.
    /// </summary>
    public partial interface IMailFolderRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IMailFolderRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IMailFolderRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Messages.
        /// </summary>
        /// <returns>The <see cref="IMailFolderMessagesCollectionRequestBuilder"/>.</returns>
        IMailFolderMessagesCollectionRequestBuilder Messages { get; }

        /// <summary>
        /// Gets the request builder for ChildFolders.
        /// </summary>
        /// <returns>The <see cref="IMailFolderChildFoldersCollectionRequestBuilder"/>.</returns>
        IMailFolderChildFoldersCollectionRequestBuilder ChildFolders { get; }

        /// <summary>
        /// Gets the request builder for UserConfigurations.
        /// </summary>
        /// <returns>The <see cref="IMailFolderUserConfigurationsCollectionRequestBuilder"/>.</returns>
        IMailFolderUserConfigurationsCollectionRequestBuilder UserConfigurations { get; }

        /// <summary>
        /// Gets the request builder for SingleValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IMailFolderSingleValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        IMailFolderSingleValueExtendedPropertiesCollectionRequestBuilder SingleValueExtendedProperties { get; }

        /// <summary>
        /// Gets the request builder for MultiValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IMailFolderMultiValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        IMailFolderMultiValueExtendedPropertiesCollectionRequestBuilder MultiValueExtendedProperties { get; }
    
        /// <summary>
        /// Gets the request builder for MailFolderCopy.
        /// </summary>
        /// <returns>The <see cref="IMailFolderCopyRequestBuilder"/>.</returns>
        IMailFolderCopyRequestBuilder Copy(
            string DestinationId = null);

        /// <summary>
        /// Gets the request builder for MailFolderMove.
        /// </summary>
        /// <returns>The <see cref="IMailFolderMoveRequestBuilder"/>.</returns>
        IMailFolderMoveRequestBuilder Move(
            string DestinationId = null);
    
    }
}
