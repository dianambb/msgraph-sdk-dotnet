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
    /// The type FilterDatetime.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class FilterDatetime
    {
    
        /// <summary>
        /// Gets or sets date.
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false, IsRequired = false)]
        public string Date { get; set; }
    
        /// <summary>
        /// Gets or sets specificity.
        /// </summary>
        [DataMember(Name = "specificity", EmitDefaultValue = false, IsRequired = false)]
        public string Specificity { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}