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
    /// The type Org Contact.
    /// </summary>
    [DataContract]
    public partial class OrgContact : DirectoryObject
    {
    
        /// <summary>
        /// Gets or sets business phones.
        /// </summary>
        [DataMember(Name = "businessPhones", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<string> BusinessPhones { get; set; }
    
        /// <summary>
        /// Gets or sets city.
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false, IsRequired = false)]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or sets company name.
        /// </summary>
        [DataMember(Name = "companyName", EmitDefaultValue = false, IsRequired = false)]
        public string CompanyName { get; set; }
    
        /// <summary>
        /// Gets or sets country.
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false, IsRequired = false)]
        public string Country { get; set; }
    
        /// <summary>
        /// Gets or sets department.
        /// </summary>
        [DataMember(Name = "department", EmitDefaultValue = false, IsRequired = false)]
        public string Department { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false, IsRequired = false)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets given name.
        /// </summary>
        [DataMember(Name = "givenName", EmitDefaultValue = false, IsRequired = false)]
        public string GivenName { get; set; }
    
        /// <summary>
        /// Gets or sets job title.
        /// </summary>
        [DataMember(Name = "jobTitle", EmitDefaultValue = false, IsRequired = false)]
        public string JobTitle { get; set; }
    
        /// <summary>
        /// Gets or sets mail.
        /// </summary>
        [DataMember(Name = "mail", EmitDefaultValue = false, IsRequired = false)]
        public string Mail { get; set; }
    
        /// <summary>
        /// Gets or sets mail nickname.
        /// </summary>
        [DataMember(Name = "mailNickname", EmitDefaultValue = false, IsRequired = false)]
        public string MailNickname { get; set; }
    
        /// <summary>
        /// Gets or sets mobile phone.
        /// </summary>
        [DataMember(Name = "mobilePhone", EmitDefaultValue = false, IsRequired = false)]
        public string MobilePhone { get; set; }
    
        /// <summary>
        /// Gets or sets on premises sync enabled.
        /// </summary>
        [DataMember(Name = "onPremisesSyncEnabled", EmitDefaultValue = false, IsRequired = false)]
        public bool? OnPremisesSyncEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets on premises last sync date time.
        /// </summary>
        [DataMember(Name = "onPremisesLastSyncDateTime", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets office location.
        /// </summary>
        [DataMember(Name = "officeLocation", EmitDefaultValue = false, IsRequired = false)]
        public string OfficeLocation { get; set; }
    
        /// <summary>
        /// Gets or sets postal code.
        /// </summary>
        [DataMember(Name = "postalCode", EmitDefaultValue = false, IsRequired = false)]
        public string PostalCode { get; set; }
    
        /// <summary>
        /// Gets or sets proxy addresses.
        /// </summary>
        [DataMember(Name = "proxyAddresses", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<string> ProxyAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false, IsRequired = false)]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or sets street address.
        /// </summary>
        [DataMember(Name = "streetAddress", EmitDefaultValue = false, IsRequired = false)]
        public string StreetAddress { get; set; }
    
        /// <summary>
        /// Gets or sets surname.
        /// </summary>
        [DataMember(Name = "surname", EmitDefaultValue = false, IsRequired = false)]
        public string Surname { get; set; }
    
        /// <summary>
        /// Gets or sets manager.
        /// </summary>
        [DataMember(Name = "manager", EmitDefaultValue = false, IsRequired = false)]
        public DirectoryObject Manager { get; set; }
    
        /// <summary>
        /// Gets or sets direct reports.
        /// </summary>
        [DataMember(Name = "directReports", EmitDefaultValue = false, IsRequired = false)]
        public IOrgContactDirectReportsCollectionWithReferencesPage DirectReports { get; set; }
    
        /// <summary>
        /// Gets or sets member of.
        /// </summary>
        [DataMember(Name = "memberOf", EmitDefaultValue = false, IsRequired = false)]
        public IOrgContactMemberOfCollectionWithReferencesPage MemberOf { get; set; }
    
    }
}
