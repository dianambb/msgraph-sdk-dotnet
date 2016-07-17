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
    /// The type TaskRequest.
    /// </summary>
    public partial class TaskRequest : BaseRequest, ITaskRequest
    {
        /// <summary>
        /// Constructs a new TaskRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TaskRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Task using PUT.
        /// </summary>
        /// <param name="taskToCreate">The Task to create.</param>
        /// <returns>The created Task.</returns>
        public System.Threading.Tasks.Task<Task> CreateAsync(Task taskToCreate)
        {
            return this.CreateAsync(taskToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Task using PUT.
        /// </summary>
        /// <param name="taskToCreate">The Task to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Task.</returns>
        public async System.Threading.Tasks.Task<Task> CreateAsync(Task taskToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PUT";
            var newEntity = await this.SendAsync<Task>(taskToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Task.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Task.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Task>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Task.
        /// </summary>
        /// <returns>The Task.</returns>
        public System.Threading.Tasks.Task<Task> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Task.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Task.</returns>
        public async System.Threading.Tasks.Task<Task> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Task>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Task using PATCH.
        /// </summary>
        /// <param name="taskToUpdate">The Task to update.</param>
        /// <returns>The updated Task.</returns>
        public System.Threading.Tasks.Task<Task> UpdateAsync(Task taskToUpdate)
        {
            return this.UpdateAsync(taskToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Task using PATCH.
        /// </summary>
        /// <param name="taskToUpdate">The Task to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Task.</returns>
        public async System.Threading.Tasks.Task<Task> UpdateAsync(Task taskToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Task>(taskToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITaskRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public ITaskRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="taskToInitialize">The <see cref="Task"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Task taskToInitialize)
        {

        }
    }
}
