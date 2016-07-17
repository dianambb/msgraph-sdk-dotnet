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
    /// The type Event Message Requester.
    /// </summary>
    [DataContract]
    public partial class EventMessageRequester : EventMessage
    {
    
        /// <summary>
        /// Gets or sets previous location.
        /// </summary>
        [DataMember(Name = "previousLocation", EmitDefaultValue = false, IsRequired = false)]
        public Location PreviousLocation { get; set; }
    
        /// <summary>
        /// Gets or sets previous start date time.
        /// </summary>
        [DataMember(Name = "previousStartDateTime", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeTimeZone PreviousStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets previous end date time.
        /// </summary>
        [DataMember(Name = "previousEndDateTime", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeTimeZone PreviousEndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets response requested.
        /// </summary>
        [DataMember(Name = "responseRequested", EmitDefaultValue = false, IsRequired = false)]
        public bool? ResponseRequested { get; set; }
    
    }
}
