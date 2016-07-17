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
    /// The interface IGroupRequestBuilder.
    /// </summary>
    public partial interface IGroupRequestBuilder : IDirectoryObjectRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IGroupRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IGroupRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Members.
        /// </summary>
        /// <returns>The <see cref="IGroupMembersCollectionWithReferencesRequestBuilder"/>.</returns>
        IGroupMembersCollectionWithReferencesRequestBuilder Members { get; }

        /// <summary>
        /// Gets the request builder for MemberOf.
        /// </summary>
        /// <returns>The <see cref="IGroupMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        IGroupMemberOfCollectionWithReferencesRequestBuilder MemberOf { get; }

        /// <summary>
        /// Gets the request builder for CreatedOnBehalfOf.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        IDirectoryObjectWithReferenceRequestBuilder CreatedOnBehalfOf { get; }

        /// <summary>
        /// Gets the request builder for Owners.
        /// </summary>
        /// <returns>The <see cref="IGroupOwnersCollectionWithReferencesRequestBuilder"/>.</returns>
        IGroupOwnersCollectionWithReferencesRequestBuilder Owners { get; }

        /// <summary>
        /// Gets the request builder for Settings.
        /// </summary>
        /// <returns>The <see cref="IGroupSettingsCollectionRequestBuilder"/>.</returns>
        IGroupSettingsCollectionRequestBuilder Settings { get; }

        /// <summary>
        /// Gets the request builder for Threads.
        /// </summary>
        /// <returns>The <see cref="IGroupThreadsCollectionRequestBuilder"/>.</returns>
        IGroupThreadsCollectionRequestBuilder Threads { get; }

        /// <summary>
        /// Gets the request builder for Calendar.
        /// </summary>
        /// <returns>The <see cref="ICalendarRequestBuilder"/>.</returns>
        ICalendarRequestBuilder Calendar { get; }

        /// <summary>
        /// Gets the request builder for CalendarView.
        /// </summary>
        /// <returns>The <see cref="IGroupCalendarViewCollectionRequestBuilder"/>.</returns>
        IGroupCalendarViewCollectionRequestBuilder CalendarView { get; }

        /// <summary>
        /// Gets the request builder for Events.
        /// </summary>
        /// <returns>The <see cref="IGroupEventsCollectionRequestBuilder"/>.</returns>
        IGroupEventsCollectionRequestBuilder Events { get; }

        /// <summary>
        /// Gets the request builder for Conversations.
        /// </summary>
        /// <returns>The <see cref="IGroupConversationsCollectionRequestBuilder"/>.</returns>
        IGroupConversationsCollectionRequestBuilder Conversations { get; }

        /// <summary>
        /// Gets the request builder for Photo.
        /// </summary>
        /// <returns>The <see cref="IProfilePhotoRequestBuilder"/>.</returns>
        IProfilePhotoRequestBuilder Photo { get; }

        /// <summary>
        /// Gets the request builder for Photos.
        /// </summary>
        /// <returns>The <see cref="IGroupPhotosCollectionRequestBuilder"/>.</returns>
        IGroupPhotosCollectionRequestBuilder Photos { get; }

        /// <summary>
        /// Gets the request builder for AcceptedSenders.
        /// </summary>
        /// <returns>The <see cref="IGroupAcceptedSendersCollectionRequestBuilder"/>.</returns>
        IGroupAcceptedSendersCollectionRequestBuilder AcceptedSenders { get; }

        /// <summary>
        /// Gets the request builder for RejectedSenders.
        /// </summary>
        /// <returns>The <see cref="IGroupRejectedSendersCollectionRequestBuilder"/>.</returns>
        IGroupRejectedSendersCollectionRequestBuilder RejectedSenders { get; }

        /// <summary>
        /// Gets the request builder for Drive.
        /// </summary>
        /// <returns>The <see cref="IDriveRequestBuilder"/>.</returns>
        IDriveRequestBuilder Drive { get; }

        /// <summary>
        /// Gets the request builder for Plans.
        /// </summary>
        /// <returns>The <see cref="IGroupPlansCollectionWithReferencesRequestBuilder"/>.</returns>
        IGroupPlansCollectionWithReferencesRequestBuilder Plans { get; }

        /// <summary>
        /// Gets the request builder for Notes.
        /// </summary>
        /// <returns>The <see cref="INotesRequestBuilder"/>.</returns>
        INotesRequestBuilder Notes { get; }
    
        /// <summary>
        /// Gets the request builder for GroupSubscribeByMail.
        /// </summary>
        /// <returns>The <see cref="IGroupSubscribeByMailRequestBuilder"/>.</returns>
        IGroupSubscribeByMailRequestBuilder SubscribeByMail();

        /// <summary>
        /// Gets the request builder for GroupUnsubscribeByMail.
        /// </summary>
        /// <returns>The <see cref="IGroupUnsubscribeByMailRequestBuilder"/>.</returns>
        IGroupUnsubscribeByMailRequestBuilder UnsubscribeByMail();

        /// <summary>
        /// Gets the request builder for GroupAddFavorite.
        /// </summary>
        /// <returns>The <see cref="IGroupAddFavoriteRequestBuilder"/>.</returns>
        IGroupAddFavoriteRequestBuilder AddFavorite();

        /// <summary>
        /// Gets the request builder for GroupRemoveFavorite.
        /// </summary>
        /// <returns>The <see cref="IGroupRemoveFavoriteRequestBuilder"/>.</returns>
        IGroupRemoveFavoriteRequestBuilder RemoveFavorite();

        /// <summary>
        /// Gets the request builder for GroupResetUnseenCount.
        /// </summary>
        /// <returns>The <see cref="IGroupResetUnseenCountRequestBuilder"/>.</returns>
        IGroupResetUnseenCountRequestBuilder ResetUnseenCount();
    
    }
}
