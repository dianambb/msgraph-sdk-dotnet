// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    using System.Collections.Generic;

    /// <summary>
    /// The base method request builder class.
    /// </summary>
    public abstract class BaseGetMethodRequestBuilder<T> : BaseRequestBuilder where T : IBaseRequest
    {
        private List<string> _parameters = new List<string>();

        /// <summary>
        /// Constructs a new <see cref="BaseMethodRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public BaseGetMethodRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Derived classes implement this function to construct the specific request class instance
        /// when a request object is required.
        /// </summary>
        /// <param name="functionUrl">The URL to use for the request.</param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of the request class.</returns>
        protected abstract T CreateRequest(string functionUrl, IEnumerable<Option> options);

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public T Request(IEnumerable<Option> options = null)
        {
            string fnUrl = this.RequestUrl;
            if (_parameters.Count > 0)
            {
                fnUrl = string.Format("{0}({1})", fnUrl, string.Join(",", _parameters));
            }

            return CreateRequest(fnUrl, options);
        }

        /// <summary>
        /// A helper method for injecting a parameter string for a given name and value
        /// pair. This method handles the nullable case and properly wrapped and escaping
        /// string values.
        /// </summary>
        /// <param name="name">The parameter name.<param>
        /// <param name="value">The parameter value.</param>
        /// <param name="nullable">A flag specifying whether the parameter is allowed to be null.</param>
        /// <returns>A string representing the parameter for an OData method call.</returns>
        protected void SetParameter(string name, object value, bool nullable)
        {
            if (value == null && !nullable)
            {
                throw new ServiceException(
                    new Error
                    {
                        Code = "invalidRequest",
                        Message = string.Format("{0} is a required parameter for this method request.", name),
                    });
            }

            string valueAsString = value != null ? value.ToString() : "null";
            if (value != null && value is string)
            {
                valueAsString = "'" + EscapeStringValue(valueAsString) + "'";
            }

            _parameters.Add(string.Format("{0}={1}", name, valueAsString));
        }

        /// <summary>
        /// Escapes a string value to be safe for OData method calls.
        /// </summary>
        /// <param name="value">The value of the string.</param>
        /// <returns>A properly escaped string.</returns>
        private string EscapeStringValue(string value)
        {
            // Per OData spec, single quotes within a string must be escaped with a second single quote.
            return value.Replace("'", "''");
        }
    }
}
