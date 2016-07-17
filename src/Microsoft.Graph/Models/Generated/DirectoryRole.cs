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
    /// The type Directory Role.
    /// </summary>
    [DataContract]
    public partial class DirectoryRole : DirectoryObject
    {
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false, IsRequired = false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false, IsRequired = false)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets role template id.
        /// </summary>
        [DataMember(Name = "roleTemplateId", EmitDefaultValue = false, IsRequired = false)]
        public string RoleTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// </summary>
        [DataMember(Name = "members", EmitDefaultValue = false, IsRequired = false)]
        public IDirectoryRoleMembersCollectionWithReferencesPage Members { get; set; }
    
        /// <summary>
        /// Gets or sets scoped administrators.
        /// </summary>
        [DataMember(Name = "scopedAdministrators", EmitDefaultValue = false, IsRequired = false)]
        public IDirectoryRoleScopedAdministratorsCollectionPage ScopedAdministrators { get; set; }
    
    }
}

