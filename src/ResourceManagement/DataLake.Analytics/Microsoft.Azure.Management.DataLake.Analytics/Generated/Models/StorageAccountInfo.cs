// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Analytics;
    using Azure;
    using DataLake;
    using Management;
    using Azure;
    using Management;
    using DataLake;
    using Analytics;
    using Newtonsoft.Json;
    using Rest;
    using Rest.Serialization;
    using System.Linq;

    /// <summary>
    /// Azure Storage account information.
    /// </summary>
    [JsonTransformation]
    public partial class StorageAccountInfo : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountInfo class.
        /// </summary>
        public StorageAccountInfo() { }

        /// <summary>
        /// Initializes a new instance of the StorageAccountInfo class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="accessKey">the access key associated with this Azure
        /// Storage account that will be used to connect to it.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="type">Resource type</param>
        /// <param name="suffix">the optional suffix for the storage
        /// account.</param>
        public StorageAccountInfo(string name, string accessKey, string id = default(string), string type = default(string), string suffix = default(string))
            : base(name, id, type)
        {
            AccessKey = accessKey;
            Suffix = suffix;
        }

        /// <summary>
        /// Gets or sets the access key associated with this Azure Storage
        /// account that will be used to connect to it.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessKey")]
        public string AccessKey { get; set; }

        /// <summary>
        /// Gets or sets the optional suffix for the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.suffix")]
        public string Suffix { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (AccessKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccessKey");
            }
        }
    }
}


