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
    /// The type LocationConstraint.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class LocationConstraint
    {
    
        /// <summary>
        /// Gets or sets isRequired.
        /// </summary>
        [DataMember(Name = "isRequired", EmitDefaultValue = false, IsRequired = false)]
        public bool? IsRequired { get; set; }
    
        /// <summary>
        /// Gets or sets suggestLocation.
        /// </summary>
        [DataMember(Name = "suggestLocation", EmitDefaultValue = false, IsRequired = false)]
        public bool? SuggestLocation { get; set; }
    
        /// <summary>
        /// Gets or sets locations.
        /// </summary>
        [DataMember(Name = "locations", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<LocationConstraintItem> Locations { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}