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

    /// <summary>
    /// The type MessageCreateReplyAllRequestBody.
    /// </summary>
    [DataContract]
    public partial class MessageCreateReplyAllRequestBody
    {
    
        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [DataMember(Name = "Message", EmitDefaultValue = false, IsRequired = false)]
        public Message Message { get; set; }
    
        /// <summary>
        /// Gets or sets Comment.
        /// </summary>
        [DataMember(Name = "Comment", EmitDefaultValue = false, IsRequired = false)]
        public string Comment { get; set; }
    
    }
}
