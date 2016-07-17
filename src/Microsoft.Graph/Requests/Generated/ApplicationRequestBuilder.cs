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
    /// The type ApplicationRequestBuilder.
    /// </summary>
    public partial class ApplicationRequestBuilder : DirectoryObjectRequestBuilder, IApplicationRequestBuilder
    {

        /// <summary>
        /// Constructs a new ApplicationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ApplicationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IApplicationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IApplicationRequest Request(IEnumerable<Option> options)
        {
            return new ApplicationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for ExtensionProperties.
        /// </summary>
        /// <returns>The <see cref="IApplicationExtensionPropertiesCollectionRequestBuilder"/>.</returns>
        public IApplicationExtensionPropertiesCollectionRequestBuilder ExtensionProperties
        {
            get
            {
                return new ApplicationExtensionPropertiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("extensionProperties"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for CreatedOnBehalfOf.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        public IDirectoryObjectWithReferenceRequestBuilder CreatedOnBehalfOf
        {
            get
            {
                return new DirectoryObjectWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("createdOnBehalfOf"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Owners.
        /// </summary>
        /// <returns>The <see cref="IApplicationOwnersCollectionWithReferencesRequestBuilder"/>.</returns>
        public IApplicationOwnersCollectionWithReferencesRequestBuilder Owners
        {
            get
            {
                return new ApplicationOwnersCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("owners"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Policies.
        /// </summary>
        /// <returns>The <see cref="IApplicationPoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        public IApplicationPoliciesCollectionWithReferencesRequestBuilder Policies
        {
            get
            {
                return new ApplicationPoliciesCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("policies"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for MainLogo.
        /// </summary>
        /// <returns>The <see cref="IApplicationMainLogoRequestBuilder"/>.</returns>
        public IApplicationMainLogoRequestBuilder MainLogo
        {
            get
            {
                return new ApplicationMainLogoRequestBuilder(this.AppendSegmentToRequestUrl("mainLogo"), this.Client);
            }
        }
    
    }
}
