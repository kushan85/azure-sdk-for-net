// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Additional parameters for the JobSchedule_Delete operation.
    /// </summary>
    public partial class JobScheduleDeleteOptions
    {
        /// <summary>
        /// Initializes a new instance of the JobScheduleDeleteOptions class.
        /// </summary>
        public JobScheduleDeleteOptions() { }

        /// <summary>
        /// Initializes a new instance of the JobScheduleDeleteOptions class.
        /// </summary>
        /// <param name="timeout">The maximum time that the server can spend
        /// processing the request, in seconds. The default is 30
        /// seconds.</param>
        /// <param name="clientRequestId">The caller-generated request
        /// identity, in the form of a GUID with no decoration such as curly
        /// braces, e.g. 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0.</param>
        /// <param name="returnClientRequestId">Whether the server should
        /// return the client-request-id in the response.</param>
        /// <param name="ocpDate">The time the request was issued. Client
        /// libraries typically set this to the current system clock time; set
        /// it explicitly if you are calling the REST API directly.</param>
        /// <param name="ifMatch">An ETag value associated with the version of
        /// the resource known to the client. The operation will be performed
        /// only if the resource's current ETag on the service exactly matches
        /// the value specified by the client.</param>
        /// <param name="ifNoneMatch">An ETag value associated with the version
        /// of the resource known to the client. The operation will be
        /// performed only if the resource's current ETag on the service does
        /// not match the value specified by the client.</param>
        /// <param name="ifModifiedSince">A timestamp indicating the last
        /// modified time of the resource known to the client. The operation
        /// will be performed only if the resource on the service has been
        /// modified since the specified time.</param>
        /// <param name="ifUnmodifiedSince">A timestamp indicating the last
        /// modified time of the resource known to the client. The operation
        /// will be performed only if the resource on the service has not been
        /// modified since the specified time.</param>
        public JobScheduleDeleteOptions(int? timeout = default(int?), System.Guid? clientRequestId = default(System.Guid?), bool? returnClientRequestId = default(bool?), System.DateTime? ocpDate = default(System.DateTime?), string ifMatch = default(string), string ifNoneMatch = default(string), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?))
        {
            Timeout = timeout;
            ClientRequestId = clientRequestId;
            ReturnClientRequestId = returnClientRequestId;
            OcpDate = ocpDate;
            IfMatch = ifMatch;
            IfNoneMatch = ifNoneMatch;
            IfModifiedSince = ifModifiedSince;
            IfUnmodifiedSince = ifUnmodifiedSince;
        }

        /// <summary>
        /// Gets or sets the maximum time that the server can spend processing
        /// the request, in seconds. The default is 30 seconds.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Gets or sets the caller-generated request identity, in the form of
        /// a GUID with no decoration such as curly braces, e.g.
        /// 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public System.Guid? ClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets whether the server should return the client-request-id
        /// in the response.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public bool? ReturnClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets the time the request was issued. Client libraries
        /// typically set this to the current system clock time; set it
        /// explicitly if you are calling the REST API directly.
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.DateTimeRfc1123JsonConverter))]
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public System.DateTime? OcpDate { get; set; }

        /// <summary>
        /// Gets or sets an ETag value associated with the version of the
        /// resource known to the client. The operation will be performed only
        /// if the resource's current ETag on the service exactly matches the
        /// value specified by the client.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public string IfMatch { get; set; }

        /// <summary>
        /// Gets or sets an ETag value associated with the version of the
        /// resource known to the client. The operation will be performed only
        /// if the resource's current ETag on the service does not match the
        /// value specified by the client.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public string IfNoneMatch { get; set; }

        /// <summary>
        /// Gets or sets a timestamp indicating the last modified time of the
        /// resource known to the client. The operation will be performed only
        /// if the resource on the service has been modified since the
        /// specified time.
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.DateTimeRfc1123JsonConverter))]
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public System.DateTime? IfModifiedSince { get; set; }

        /// <summary>
        /// Gets or sets a timestamp indicating the last modified time of the
        /// resource known to the client. The operation will be performed only
        /// if the resource on the service has not been modified since the
        /// specified time.
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.DateTimeRfc1123JsonConverter))]
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public System.DateTime? IfUnmodifiedSince { get; set; }

    }
}
