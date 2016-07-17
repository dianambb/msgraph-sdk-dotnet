// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UserScopedAdministratorOfCollectionRequestBuilder.
    /// </summary>
    public partial class UserScopedAdministratorOfCollectionRequestBuilder : BaseRequestBuilder, IUserScopedAdministratorOfCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UserScopedAdministratorOfCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserScopedAdministratorOfCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserScopedAdministratorOfCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserScopedAdministratorOfCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserScopedAdministratorOfCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IScopedRoleMembershipRequestBuilder"/> for the specified UserScopedRoleMembership.
        /// </summary>
        /// <param name="id">The ID for the UserScopedRoleMembership.</param>
        /// <returns>The <see cref="IScopedRoleMembershipRequestBuilder"/>.</returns>
        public IScopedRoleMembershipRequestBuilder this[string id]
        {
            get
            {
                return new ScopedRoleMembershipRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}
