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
    /// The type Task Board Task Format.
    /// </summary>
    [DataContract]
    public partial class TaskBoardTaskFormat : Entity
    {
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = false)]
        public TaskBoardType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets order hint.
        /// </summary>
        [DataMember(Name = "orderHint", EmitDefaultValue = false, IsRequired = false)]
        public string OrderHint { get; set; }
    
    }
}

