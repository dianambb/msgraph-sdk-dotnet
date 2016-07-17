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
    /// The type MeetingTimeCandidate.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class MeetingTimeCandidate
    {
    
        /// <summary>
        /// Gets or sets meetingTimeSlot.
        /// </summary>
        [DataMember(Name = "meetingTimeSlot", EmitDefaultValue = false, IsRequired = false)]
        public TimeSlot MeetingTimeSlot { get; set; }
    
        /// <summary>
        /// Gets or sets confidence.
        /// </summary>
        [DataMember(Name = "confidence", EmitDefaultValue = false, IsRequired = false)]
        public double? Confidence { get; set; }
    
        /// <summary>
        /// Gets or sets organizerAvailability.
        /// </summary>
        [DataMember(Name = "organizerAvailability", EmitDefaultValue = false, IsRequired = false)]
        public FreeBusyStatus? OrganizerAvailability { get; set; }
    
        /// <summary>
        /// Gets or sets attendeeAvailability.
        /// </summary>
        [DataMember(Name = "attendeeAvailability", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<AttendeeAvailability> AttendeeAvailability { get; set; }
    
        /// <summary>
        /// Gets or sets locations.
        /// </summary>
        [DataMember(Name = "locations", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<Location> Locations { get; set; }
    
        /// <summary>
        /// Gets or sets suggestionHint.
        /// </summary>
        [DataMember(Name = "suggestionHint", EmitDefaultValue = false, IsRequired = false)]
        public string SuggestionHint { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}