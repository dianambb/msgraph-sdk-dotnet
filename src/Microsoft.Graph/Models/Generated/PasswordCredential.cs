// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type PasswordCredential.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class PasswordCredential
    {
    
        /// <summary>
        /// Gets or sets customKeyIdentifier.
        /// </summary>
        [DataMember(Name = "customKeyIdentifier", EmitDefaultValue = false, IsRequired = false)]
        public byte[] CustomKeyIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets endDate.
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeOffset? EndDate { get; set; }
    
        /// <summary>
        /// Gets or sets keyId.
        /// </summary>
        [DataMember(Name = "keyId", EmitDefaultValue = false, IsRequired = false)]
        public Guid? KeyId { get; set; }
    
        /// <summary>
        /// Gets or sets startDate.
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeOffset? StartDate { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = false)]
        public string Value { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}