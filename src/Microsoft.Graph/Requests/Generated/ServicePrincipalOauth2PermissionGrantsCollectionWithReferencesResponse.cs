// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type ServicePrincipalOauth2PermissionGrantsCollectionWithReferencesResponse.
    /// </summary>
    [DataContract]
    public class ServicePrincipalOauth2PermissionGrantsCollectionWithReferencesResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="IServicePrincipalOauth2PermissionGrantsCollectionWithReferencesPage"/> value.
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = false)]
        public IServicePrincipalOauth2PermissionGrantsCollectionWithReferencesPage Value { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}