// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// AutoHealTriggers - describes the triggers for auto-heal.
    /// </summary>
    public partial class AutoHealTriggers
    {
        /// <summary>
        /// Initializes a new instance of the AutoHealTriggers class.
        /// </summary>
        public AutoHealTriggers() { }

        /// <summary>
        /// Initializes a new instance of the AutoHealTriggers class.
        /// </summary>
        public AutoHealTriggers(RequestsBasedTrigger requests = default(RequestsBasedTrigger), int? privateBytesInKB = default(int?), IList<StatusCodesBasedTrigger> statusCodes = default(IList<StatusCodesBasedTrigger>), SlowRequestsBasedTrigger slowRequests = default(SlowRequestsBasedTrigger))
        {
            Requests = requests;
            PrivateBytesInKB = privateBytesInKB;
            StatusCodes = statusCodes;
            SlowRequests = slowRequests;
        }

        /// <summary>
        /// Requests - Defines a rule based on total requests
        /// </summary>
        [JsonProperty(PropertyName = "requests")]
        public RequestsBasedTrigger Requests { get; set; }

        /// <summary>
        /// PrivateBytesInKB - Defines a rule based on private bytes
        /// </summary>
        [JsonProperty(PropertyName = "privateBytesInKB")]
        public int? PrivateBytesInKB { get; set; }

        /// <summary>
        /// StatusCodes - Defines a rule based on status codes
        /// </summary>
        [JsonProperty(PropertyName = "statusCodes")]
        public IList<StatusCodesBasedTrigger> StatusCodes { get; set; }

        /// <summary>
        /// SlowRequests - Defines a rule based on request execution time
        /// </summary>
        [JsonProperty(PropertyName = "slowRequests")]
        public SlowRequestsBasedTrigger SlowRequests { get; set; }

    }
}