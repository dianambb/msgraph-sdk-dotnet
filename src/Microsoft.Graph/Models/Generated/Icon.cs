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
    /// The type Icon.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Icon
    {
    
        /// <summary>
        /// Gets or sets index.
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false, IsRequired = false)]
        public Int32? Index { get; set; }
    
        /// <summary>
        /// Gets or sets set.
        /// </summary>
        [DataMember(Name = "set", EmitDefaultValue = false, IsRequired = false)]
        public string Set { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
