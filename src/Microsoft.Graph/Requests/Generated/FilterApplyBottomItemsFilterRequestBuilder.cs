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
    /// The type FilterApplyBottomItemsFilterRequestBuilder.
    /// </summary>
    public partial class FilterApplyBottomItemsFilterRequestBuilder : BasePostMethodRequestBuilder<IFilterApplyBottomItemsFilterRequest>, IFilterApplyBottomItemsFilterRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="FilterApplyBottomItemsFilterRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="count">A count parameter for the OData method call.</param>
        public FilterApplyBottomItemsFilterRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Int32 count)
            : base(requestUrl, client)
        {
            this.SetParameter("count", count, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IFilterApplyBottomItemsFilterRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new FilterApplyBottomItemsFilterRequest(functionUrl, this.Client, options);

            if (this.HasParameter("count"))
            {
                request.RequestBody.Count = this.GetParameter<Int32>("count");
            }

            return request;
        }
    }
}
