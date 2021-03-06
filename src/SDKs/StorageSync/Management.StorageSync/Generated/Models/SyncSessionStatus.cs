// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Sync Session status object.
    /// </summary>
    public partial class SyncSessionStatus
    {
        /// <summary>
        /// Initializes a new instance of the SyncSessionStatus class.
        /// </summary>
        public SyncSessionStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SyncSessionStatus class.
        /// </summary>
        /// <param name="lastSyncResult">Last sync status</param>
        /// <param name="lastSyncTimestamp">Last sync timestamp</param>
        /// <param name="lastSyncSuccessTimestamp">Last sync success
        /// timestamp</param>
        /// <param name="lastSyncPerItemErrorCount">Last sync per item error
        /// count.</param>
        public SyncSessionStatus(int? lastSyncResult = default(int?), System.DateTime? lastSyncTimestamp = default(System.DateTime?), System.DateTime? lastSyncSuccessTimestamp = default(System.DateTime?), int? lastSyncPerItemErrorCount = default(int?))
        {
            LastSyncResult = lastSyncResult;
            LastSyncTimestamp = lastSyncTimestamp;
            LastSyncSuccessTimestamp = lastSyncSuccessTimestamp;
            LastSyncPerItemErrorCount = lastSyncPerItemErrorCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets last sync status
        /// </summary>
        [JsonProperty(PropertyName = "lastSyncResult")]
        public int? LastSyncResult { get; set; }

        /// <summary>
        /// Gets or sets last sync timestamp
        /// </summary>
        [JsonProperty(PropertyName = "lastSyncTimestamp")]
        public System.DateTime? LastSyncTimestamp { get; set; }

        /// <summary>
        /// Gets or sets last sync success timestamp
        /// </summary>
        [JsonProperty(PropertyName = "lastSyncSuccessTimestamp")]
        public System.DateTime? LastSyncSuccessTimestamp { get; set; }

        /// <summary>
        /// Gets or sets last sync per item error count.
        /// </summary>
        [JsonProperty(PropertyName = "lastSyncPerItemErrorCount")]
        public int? LastSyncPerItemErrorCount { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LastSyncPerItemErrorCount > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "LastSyncPerItemErrorCount", 2147483647);
            }
            if (LastSyncPerItemErrorCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "LastSyncPerItemErrorCount", 0);
            }
        }
    }
}
