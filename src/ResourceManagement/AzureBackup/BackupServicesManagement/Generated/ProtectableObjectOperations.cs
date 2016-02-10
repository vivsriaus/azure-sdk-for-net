// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.BackupServices;
using Microsoft.Azure.Management.BackupServices.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.BackupServices
{
    /// <summary>
    /// Definition of Protectable ObjectOperation operations for the Azure
    /// Backup extension.
    /// </summary>
    internal partial class ProtectableObjectOperations : IServiceOperations<BackupServicesManagementClient>, IProtectableObjectOperations
    {
        /// <summary>
        /// Initializes a new instance of the ProtectableObjectOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal ProtectableObjectOperations(BackupServicesManagementClient client)
        {
            this._client = client;
        }
        
        private BackupServicesManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.BackupServices.BackupServicesManagementClient.
        /// </summary>
        public BackupServicesManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Get the list of all items
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='csmparameters'>
        /// Optional. Protectable objects query parameter.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a CSMItemListOperationResponse.
        /// </returns>
        public async Task<CSMItemListOperationResponse> ListCSMAsync(string resourceGroupName, string resourceName, CSMItemQueryObject csmparameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("resourceName", resourceName);
                tracingParameters.Add("csmparameters", csmparameters);
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "ListCSMAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            url = url + "Microsoft.Backup";
            url = url + "/";
            url = url + "BackupVault";
            url = url + "/";
            url = url + Uri.EscapeDataString(resourceName);
            url = url + "/items";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2014-09-01");
            List<string> odataFilter = new List<string>();
            if (csmparameters != null && csmparameters.Status != null)
            {
                odataFilter.Add("status eq '" + Uri.EscapeDataString(csmparameters.Status) + "'");
            }
            if (csmparameters != null && csmparameters.Type != null)
            {
                odataFilter.Add("itemType eq '" + Uri.EscapeDataString(csmparameters.Type) + "'");
            }
            if (odataFilter.Count > 0)
            {
                queryParameters.Add("$filter=" + string.Join(" and ", odataFilter));
            }
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", "en-us");
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    CSMItemListOperationResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new CSMItemListOperationResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            CSMItemListResponse cSMItemListResponseInstance = new CSMItemListResponse();
                            result.CSMItemListResponse = cSMItemListResponseInstance;
                            
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    CSMItemResponse cSMItemResponseInstance = new CSMItemResponse();
                                    cSMItemListResponseInstance.Value.Add(cSMItemResponseInstance);
                                    
                                    JToken propertiesValue = valueValue["properties"];
                                    if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                                    {
                                        CSMItemProperties propertiesInstance = new CSMItemProperties();
                                        cSMItemResponseInstance.Properties = propertiesInstance;
                                        
                                        JToken friendlyNameValue = propertiesValue["friendlyName"];
                                        if (friendlyNameValue != null && friendlyNameValue.Type != JTokenType.Null)
                                        {
                                            string friendlyNameInstance = ((string)friendlyNameValue);
                                            propertiesInstance.FriendlyName = friendlyNameInstance;
                                        }
                                        
                                        JToken itemTypeValue = propertiesValue["itemType"];
                                        if (itemTypeValue != null && itemTypeValue.Type != JTokenType.Null)
                                        {
                                            string itemTypeInstance = ((string)itemTypeValue);
                                            propertiesInstance.ItemType = itemTypeInstance;
                                        }
                                        
                                        JToken statusValue = propertiesValue["status"];
                                        if (statusValue != null && statusValue.Type != JTokenType.Null)
                                        {
                                            string statusInstance = ((string)statusValue);
                                            propertiesInstance.Status = statusInstance;
                                        }
                                        
                                        JToken containerIdValue = propertiesValue["containerId"];
                                        if (containerIdValue != null && containerIdValue.Type != JTokenType.Null)
                                        {
                                            string containerIdInstance = ((string)containerIdValue);
                                            propertiesInstance.ContainerId = containerIdInstance;
                                        }
                                    }
                                    
                                    JToken idValue = valueValue["id"];
                                    if (idValue != null && idValue.Type != JTokenType.Null)
                                    {
                                        string idInstance = ((string)idValue);
                                        cSMItemResponseInstance.Id = idInstance;
                                    }
                                    
                                    JToken nameValue = valueValue["name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        string nameInstance = ((string)nameValue);
                                        cSMItemResponseInstance.Name = nameInstance;
                                    }
                                    
                                    JToken typeValue = valueValue["type"];
                                    if (typeValue != null && typeValue.Type != JTokenType.Null)
                                    {
                                        string typeInstance = ((string)typeValue);
                                        cSMItemResponseInstance.Type = typeInstance;
                                    }
                                }
                            }
                            
                            JToken nextLinkValue = responseDoc["nextLink"];
                            if (nextLinkValue != null && nextLinkValue.Type != JTokenType.Null)
                            {
                                string nextLinkInstance = ((string)nextLinkValue);
                                cSMItemListResponseInstance.NextLink = nextLinkInstance;
                            }
                            
                            JToken idValue2 = responseDoc["id"];
                            if (idValue2 != null && idValue2.Type != JTokenType.Null)
                            {
                                string idInstance2 = ((string)idValue2);
                                cSMItemListResponseInstance.Id = idInstance2;
                            }
                            
                            JToken nameValue2 = responseDoc["name"];
                            if (nameValue2 != null && nameValue2.Type != JTokenType.Null)
                            {
                                string nameInstance2 = ((string)nameValue2);
                                cSMItemListResponseInstance.Name = nameInstance2;
                            }
                            
                            JToken typeValue2 = responseDoc["type"];
                            if (typeValue2 != null && typeValue2.Type != JTokenType.Null)
                            {
                                string typeInstance2 = ((string)typeValue2);
                                cSMItemListResponseInstance.Type = typeInstance2;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
