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
    /// The type MessageCreateReplyAllRequestBuilder.
    /// </summary>
    public partial class MessageCreateReplyAllRequestBuilder : BasePostMethodRequestBuilder<IMessageCreateReplyAllRequest>, IMessageCreateReplyAllRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="MessageCreateReplyAllRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="Message">A Message parameter for the OData method call.</param>
        /// <param name="Comment">A Comment parameter for the OData method call.</param>
        public MessageCreateReplyAllRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Message Message,
            string Comment)
            : base(requestUrl, client)
        {
            this.SetParameter("message", Message, true);
            this.SetParameter("comment", Comment, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IMessageCreateReplyAllRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new MessageCreateReplyAllRequest(functionUrl, this.Client, options);

            if (this.HasParameter("message"))
            {
                request.RequestBody.Message = this.GetParameter<Message>("message");
            }

            if (this.HasParameter("comment"))
            {
                request.RequestBody.Comment = this.GetParameter<string>("comment");
            }

            return request;
        }
    }
}
