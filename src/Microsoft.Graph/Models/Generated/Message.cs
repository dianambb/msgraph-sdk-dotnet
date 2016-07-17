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
    /// The type Message.
    /// </summary>
    [DataContract]
    public partial class Message : OutlookItem
    {
    
        /// <summary>
        /// Gets or sets received date time.
        /// </summary>
        [DataMember(Name = "receivedDateTime", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeOffset? ReceivedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets sent date time.
        /// </summary>
        [DataMember(Name = "sentDateTime", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeOffset? SentDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets has attachments.
        /// </summary>
        [DataMember(Name = "hasAttachments", EmitDefaultValue = false, IsRequired = false)]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets internet message id.
        /// </summary>
        [DataMember(Name = "internetMessageId", EmitDefaultValue = false, IsRequired = false)]
        public string InternetMessageId { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = false, IsRequired = false)]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets body.
        /// </summary>
        [DataMember(Name = "body", EmitDefaultValue = false, IsRequired = false)]
        public ItemBody Body { get; set; }
    
        /// <summary>
        /// Gets or sets body preview.
        /// </summary>
        [DataMember(Name = "bodyPreview", EmitDefaultValue = false, IsRequired = false)]
        public string BodyPreview { get; set; }
    
        /// <summary>
        /// Gets or sets importance.
        /// </summary>
        [DataMember(Name = "importance", EmitDefaultValue = false, IsRequired = false)]
        public Importance? Importance { get; set; }
    
        /// <summary>
        /// Gets or sets parent folder id.
        /// </summary>
        [DataMember(Name = "parentFolderId", EmitDefaultValue = false, IsRequired = false)]
        public string ParentFolderId { get; set; }
    
        /// <summary>
        /// Gets or sets sender.
        /// </summary>
        [DataMember(Name = "sender", EmitDefaultValue = false, IsRequired = false)]
        public Recipient Sender { get; set; }
    
        /// <summary>
        /// Gets or sets from.
        /// </summary>
        [DataMember(Name = "from", EmitDefaultValue = false, IsRequired = false)]
        public Recipient From { get; set; }
    
        /// <summary>
        /// Gets or sets to recipients.
        /// </summary>
        [DataMember(Name = "toRecipients", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<Recipient> ToRecipients { get; set; }
    
        /// <summary>
        /// Gets or sets cc recipients.
        /// </summary>
        [DataMember(Name = "ccRecipients", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<Recipient> CcRecipients { get; set; }
    
        /// <summary>
        /// Gets or sets bcc recipients.
        /// </summary>
        [DataMember(Name = "bccRecipients", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<Recipient> BccRecipients { get; set; }
    
        /// <summary>
        /// Gets or sets reply to.
        /// </summary>
        [DataMember(Name = "replyTo", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<Recipient> ReplyTo { get; set; }
    
        /// <summary>
        /// Gets or sets conversation id.
        /// </summary>
        [DataMember(Name = "conversationId", EmitDefaultValue = false, IsRequired = false)]
        public string ConversationId { get; set; }
    
        /// <summary>
        /// Gets or sets conversation index.
        /// </summary>
        [DataMember(Name = "conversationIndex", EmitDefaultValue = false, IsRequired = false)]
        public byte[] ConversationIndex { get; set; }
    
        /// <summary>
        /// Gets or sets unique body.
        /// </summary>
        [DataMember(Name = "uniqueBody", EmitDefaultValue = false, IsRequired = false)]
        public ItemBody UniqueBody { get; set; }
    
        /// <summary>
        /// Gets or sets is delivery receipt requested.
        /// </summary>
        [DataMember(Name = "isDeliveryReceiptRequested", EmitDefaultValue = false, IsRequired = false)]
        public bool? IsDeliveryReceiptRequested { get; set; }
    
        /// <summary>
        /// Gets or sets is read receipt requested.
        /// </summary>
        [DataMember(Name = "isReadReceiptRequested", EmitDefaultValue = false, IsRequired = false)]
        public bool? IsReadReceiptRequested { get; set; }
    
        /// <summary>
        /// Gets or sets is read.
        /// </summary>
        [DataMember(Name = "isRead", EmitDefaultValue = false, IsRequired = false)]
        public bool? IsRead { get; set; }
    
        /// <summary>
        /// Gets or sets is draft.
        /// </summary>
        [DataMember(Name = "isDraft", EmitDefaultValue = false, IsRequired = false)]
        public bool? IsDraft { get; set; }
    
        /// <summary>
        /// Gets or sets web link.
        /// </summary>
        [DataMember(Name = "webLink", EmitDefaultValue = false, IsRequired = false)]
        public string WebLink { get; set; }
    
        /// <summary>
        /// Gets or sets inference classification.
        /// </summary>
        [DataMember(Name = "inferenceClassification", EmitDefaultValue = false, IsRequired = false)]
        public InferenceClassificationType? InferenceClassification { get; set; }
    
        /// <summary>
        /// Gets or sets unsubscribe data.
        /// </summary>
        [DataMember(Name = "unsubscribeData", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<string> UnsubscribeData { get; set; }
    
        /// <summary>
        /// Gets or sets unsubscribe enabled.
        /// </summary>
        [DataMember(Name = "unsubscribeEnabled", EmitDefaultValue = false, IsRequired = false)]
        public bool? UnsubscribeEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets flag.
        /// </summary>
        [DataMember(Name = "flag", EmitDefaultValue = false, IsRequired = false)]
        public FollowupFlag Flag { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// </summary>
        [DataMember(Name = "extensions", EmitDefaultValue = false, IsRequired = false)]
        public IMessageExtensionsCollectionPage Extensions { get; set; }
    
        /// <summary>
        /// Gets or sets attachments.
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = false, IsRequired = false)]
        public IMessageAttachmentsCollectionPage Attachments { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// </summary>
        [DataMember(Name = "singleValueExtendedProperties", EmitDefaultValue = false, IsRequired = false)]
        public IMessageSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// </summary>
        [DataMember(Name = "multiValueExtendedProperties", EmitDefaultValue = false, IsRequired = false)]
        public IMessageMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }
    
    }
}

