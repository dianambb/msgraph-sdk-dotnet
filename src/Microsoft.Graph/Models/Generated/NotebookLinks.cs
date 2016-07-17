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
    /// The type NotebookLinks.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class NotebookLinks
    {
    
        /// <summary>
        /// Gets or sets oneNoteClientUrl.
        /// </summary>
        [DataMember(Name = "oneNoteClientUrl", EmitDefaultValue = false, IsRequired = false)]
        public ExternalLink OneNoteClientUrl { get; set; }
    
        /// <summary>
        /// Gets or sets oneNoteWebUrl.
        /// </summary>
        [DataMember(Name = "oneNoteWebUrl", EmitDefaultValue = false, IsRequired = false)]
        public ExternalLink OneNoteWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}