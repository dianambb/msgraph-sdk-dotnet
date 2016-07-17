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
    /// The type Plan.
    /// </summary>
    [DataContract]
    public partial class Plan : Entity
    {
    
        /// <summary>
        /// Gets or sets created by.
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false, IsRequired = false)]
        public string CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets owner.
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = false, IsRequired = false)]
        public string Owner { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false, IsRequired = false)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets tasks.
        /// </summary>
        [DataMember(Name = "tasks", EmitDefaultValue = false, IsRequired = false)]
        public IPlanTasksCollectionWithReferencesPage Tasks { get; set; }
    
        /// <summary>
        /// Gets or sets buckets.
        /// </summary>
        [DataMember(Name = "buckets", EmitDefaultValue = false, IsRequired = false)]
        public IPlanBucketsCollectionWithReferencesPage Buckets { get; set; }
    
        /// <summary>
        /// Gets or sets details.
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = false, IsRequired = false)]
        public PlanDetails Details { get; set; }
    
        /// <summary>
        /// Gets or sets assigned to task board.
        /// </summary>
        [DataMember(Name = "assignedToTaskBoard", EmitDefaultValue = false, IsRequired = false)]
        public PlanTaskBoard AssignedToTaskBoard { get; set; }
    
        /// <summary>
        /// Gets or sets progress task board.
        /// </summary>
        [DataMember(Name = "progressTaskBoard", EmitDefaultValue = false, IsRequired = false)]
        public PlanTaskBoard ProgressTaskBoard { get; set; }
    
        /// <summary>
        /// Gets or sets bucket task board.
        /// </summary>
        [DataMember(Name = "bucketTaskBoard", EmitDefaultValue = false, IsRequired = false)]
        public PlanTaskBoard BucketTaskBoard { get; set; }
    
    }
}
