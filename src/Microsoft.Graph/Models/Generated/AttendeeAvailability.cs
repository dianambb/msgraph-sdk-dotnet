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
    /// The type AttendeeAvailability.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AttendeeAvailability
    {
    
        /// <summary>
        /// Gets or sets attendee.
        /// </summary>
        [DataMember(Name = "attendee", EmitDefaultValue = false, IsRequired = false)]
        public AttendeeBase Attendee { get; set; }
    
        /// <summary>
        /// Gets or sets availability.
        /// </summary>
        [DataMember(Name = "availability", EmitDefaultValue = false, IsRequired = false)]
        public FreeBusyStatus? Availability { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}