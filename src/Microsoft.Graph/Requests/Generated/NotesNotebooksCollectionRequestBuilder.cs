// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type NotesNotebooksCollectionRequestBuilder.
    /// </summary>
    public partial class NotesNotebooksCollectionRequestBuilder : BaseRequestBuilder, INotesNotebooksCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new NotesNotebooksCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public NotesNotebooksCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public INotesNotebooksCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public INotesNotebooksCollectionRequest Request(IEnumerable<Option> options)
        {
            return new NotesNotebooksCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="INotebookRequestBuilder"/> for the specified NotesNotebook.
        /// </summary>
        /// <param name="id">The ID for the NotesNotebook.</param>
        /// <returns>The <see cref="INotebookRequestBuilder"/>.</returns>
        public INotebookRequestBuilder this[string id]
        {
            get
            {
                return new NotebookRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}