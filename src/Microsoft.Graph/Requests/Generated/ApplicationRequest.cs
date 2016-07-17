// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type ApplicationRequest.
    /// </summary>
    public partial class ApplicationRequest : BaseRequest, IApplicationRequest
    {
        /// <summary>
        /// Constructs a new ApplicationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ApplicationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Application using PUT.
        /// </summary>
        /// <param name="applicationToCreate">The Application to create.</param>
        /// <returns>The created Application.</returns>
        public System.Threading.Tasks.Task<Application> CreateAsync(Application applicationToCreate)
        {
            return this.CreateAsync(applicationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Application using PUT.
        /// </summary>
        /// <param name="applicationToCreate">The Application to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Application.</returns>
        public async System.Threading.Tasks.Task<Application> CreateAsync(Application applicationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PUT";
            var newEntity = await this.SendAsync<Application>(applicationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Application.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Application.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Application>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Application.
        /// </summary>
        /// <returns>The Application.</returns>
        public System.Threading.Tasks.Task<Application> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Application.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Application.</returns>
        public async System.Threading.Tasks.Task<Application> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Application>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Application using PATCH.
        /// </summary>
        /// <param name="applicationToUpdate">The Application to update.</param>
        /// <returns>The updated Application.</returns>
        public System.Threading.Tasks.Task<Application> UpdateAsync(Application applicationToUpdate)
        {
            return this.UpdateAsync(applicationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Application using PATCH.
        /// </summary>
        /// <param name="applicationToUpdate">The Application to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Application.</returns>
        public async System.Threading.Tasks.Task<Application> UpdateAsync(Application applicationToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Application>(applicationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IApplicationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="applicationToInitialize">The <see cref="Application"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Application applicationToInitialize)
        {

            if (applicationToInitialize != null && applicationToInitialize.AdditionalData != null)
            {

                if (applicationToInitialize.ExtensionProperties != null && applicationToInitialize.ExtensionProperties.CurrentPage != null)
                {
                    applicationToInitialize.ExtensionProperties.AdditionalData = applicationToInitialize.AdditionalData;

                    object nextPageLink;
                    applicationToInitialize.AdditionalData.TryGetValue("extensionProperties@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        applicationToInitialize.ExtensionProperties.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (applicationToInitialize.Owners != null && applicationToInitialize.Owners.CurrentPage != null)
                {
                    applicationToInitialize.Owners.AdditionalData = applicationToInitialize.AdditionalData;

                    object nextPageLink;
                    applicationToInitialize.AdditionalData.TryGetValue("owners@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        applicationToInitialize.Owners.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (applicationToInitialize.Policies != null && applicationToInitialize.Policies.CurrentPage != null)
                {
                    applicationToInitialize.Policies.AdditionalData = applicationToInitialize.AdditionalData;

                    object nextPageLink;
                    applicationToInitialize.AdditionalData.TryGetValue("policies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        applicationToInitialize.Policies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
