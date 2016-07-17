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
    /// The type MultiValueLegacyExtendedPropertyRequest.
    /// </summary>
    public partial class MultiValueLegacyExtendedPropertyRequest : BaseRequest, IMultiValueLegacyExtendedPropertyRequest
    {
        /// <summary>
        /// Constructs a new MultiValueLegacyExtendedPropertyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MultiValueLegacyExtendedPropertyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MultiValueLegacyExtendedProperty using PUT.
        /// </summary>
        /// <param name="multiValueLegacyExtendedPropertyToCreate">The MultiValueLegacyExtendedProperty to create.</param>
        /// <returns>The created MultiValueLegacyExtendedProperty.</returns>
        public System.Threading.Tasks.Task<MultiValueLegacyExtendedProperty> CreateAsync(MultiValueLegacyExtendedProperty multiValueLegacyExtendedPropertyToCreate)
        {
            return this.CreateAsync(multiValueLegacyExtendedPropertyToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MultiValueLegacyExtendedProperty using PUT.
        /// </summary>
        /// <param name="multiValueLegacyExtendedPropertyToCreate">The MultiValueLegacyExtendedProperty to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MultiValueLegacyExtendedProperty.</returns>
        public async System.Threading.Tasks.Task<MultiValueLegacyExtendedProperty> CreateAsync(MultiValueLegacyExtendedProperty multiValueLegacyExtendedPropertyToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PUT";
            var newEntity = await this.SendAsync<MultiValueLegacyExtendedProperty>(multiValueLegacyExtendedPropertyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified MultiValueLegacyExtendedProperty.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MultiValueLegacyExtendedProperty.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MultiValueLegacyExtendedProperty>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MultiValueLegacyExtendedProperty.
        /// </summary>
        /// <returns>The MultiValueLegacyExtendedProperty.</returns>
        public System.Threading.Tasks.Task<MultiValueLegacyExtendedProperty> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MultiValueLegacyExtendedProperty.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MultiValueLegacyExtendedProperty.</returns>
        public async System.Threading.Tasks.Task<MultiValueLegacyExtendedProperty> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MultiValueLegacyExtendedProperty>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified MultiValueLegacyExtendedProperty using PATCH.
        /// </summary>
        /// <param name="multiValueLegacyExtendedPropertyToUpdate">The MultiValueLegacyExtendedProperty to update.</param>
        /// <returns>The updated MultiValueLegacyExtendedProperty.</returns>
        public System.Threading.Tasks.Task<MultiValueLegacyExtendedProperty> UpdateAsync(MultiValueLegacyExtendedProperty multiValueLegacyExtendedPropertyToUpdate)
        {
            return this.UpdateAsync(multiValueLegacyExtendedPropertyToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MultiValueLegacyExtendedProperty using PATCH.
        /// </summary>
        /// <param name="multiValueLegacyExtendedPropertyToUpdate">The MultiValueLegacyExtendedProperty to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated MultiValueLegacyExtendedProperty.</returns>
        public async System.Threading.Tasks.Task<MultiValueLegacyExtendedProperty> UpdateAsync(MultiValueLegacyExtendedProperty multiValueLegacyExtendedPropertyToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MultiValueLegacyExtendedProperty>(multiValueLegacyExtendedPropertyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMultiValueLegacyExtendedPropertyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IMultiValueLegacyExtendedPropertyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="multiValueLegacyExtendedPropertyToInitialize">The <see cref="MultiValueLegacyExtendedProperty"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MultiValueLegacyExtendedProperty multiValueLegacyExtendedPropertyToInitialize)
        {

        }
    }
}
