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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network
{
    /// <summary>
    /// The Windows Azure Network management API provides a RESTful set of web
    /// services that interact with Windows Azure Networks service to manage
    /// your network resrources. The API has entities that capture the
    /// relationship between an end user and the Windows Azure Networks
    /// service.
    /// </summary>
    public static partial class VirtualNetworkGatewayOperationsExtensions
    {
        /// <summary>
        /// The Put VirtualNetworkGateway operation creates/updates a virtual
        /// network gateway in the specified resource group through Network
        /// resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkGatewayOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayName'>
        /// Required. The name of the virtual network gateway.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Begin Create or update Virtual
        /// Network Gateway operation through Network resource provider.
        /// </param>
        /// <returns>
        /// Response for PutVirtualNetworkGateway Api servive call
        /// </returns>
        public static VirtualNetworkGatewayPutResponse BeginCreateOrUpdating(this IVirtualNetworkGatewayOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGateway parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualNetworkGatewayOperations)s).BeginCreateOrUpdatingAsync(resourceGroupName, virtualNetworkGatewayName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Put VirtualNetworkGateway operation creates/updates a virtual
        /// network gateway in the specified resource group through Network
        /// resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkGatewayOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayName'>
        /// Required. The name of the virtual network gateway.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Begin Create or update Virtual
        /// Network Gateway operation through Network resource provider.
        /// </param>
        /// <returns>
        /// Response for PutVirtualNetworkGateway Api servive call
        /// </returns>
        public static Task<VirtualNetworkGatewayPutResponse> BeginCreateOrUpdatingAsync(this IVirtualNetworkGatewayOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGateway parameters)
        {
            return operations.BeginCreateOrUpdatingAsync(resourceGroupName, virtualNetworkGatewayName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Delete VirtualNetworkGateway operation deletes the specifed
        /// virtual network Gateway through Network resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkGatewayOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayName'>
        /// Required. The name of the virtual network gateway.
        /// </param>
        /// <returns>
        /// If the resource provide needs to return an error to any operation,
        /// it should return the appropriate HTTP error code and a message
        /// body as can be seen below.The message should be localized per the
        /// Accept-Language header specified in the original request such
        /// thatit could be directly be exposed to users
        /// </returns>
        public static UpdateOperationResponse BeginDeleting(this IVirtualNetworkGatewayOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualNetworkGatewayOperations)s).BeginDeletingAsync(resourceGroupName, virtualNetworkGatewayName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Delete VirtualNetworkGateway operation deletes the specifed
        /// virtual network Gateway through Network resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkGatewayOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayName'>
        /// Required. The name of the virtual network gateway.
        /// </param>
        /// <returns>
        /// If the resource provide needs to return an error to any operation,
        /// it should return the appropriate HTTP error code and a message
        /// body as can be seen below.The message should be localized per the
        /// Accept-Language header specified in the original request such
        /// thatit could be directly be exposed to users
        /// </returns>
        public static Task<UpdateOperationResponse> BeginDeletingAsync(this IVirtualNetworkGatewayOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
        {
            return operations.BeginDeletingAsync(resourceGroupName, virtualNetworkGatewayName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Reset VirtualNetworkGateway operation resets the primary of the
        /// virtual network gatewayin the specified resource group through
        /// Network resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkGatewayOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayName'>
        /// Required. The name of the virtual network gateway.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Begin Reset Virtual Network
        /// Gateway operation through Network resource provider.
        /// </param>
        /// <returns>
        /// Response for PutVirtualNetworkGateway Api servive call
        /// </returns>
        public static VirtualNetworkGatewayPutResponse BeginReset(this IVirtualNetworkGatewayOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGateway parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualNetworkGatewayOperations)s).BeginResetAsync(resourceGroupName, virtualNetworkGatewayName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Reset VirtualNetworkGateway operation resets the primary of the
        /// virtual network gatewayin the specified resource group through
        /// Network resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkGatewayOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayName'>
        /// Required. The name of the virtual network gateway.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Begin Reset Virtual Network
        /// Gateway operation through Network resource provider.
        /// </param>
        /// <returns>
        /// Response for PutVirtualNetworkGateway Api servive call
        /// </returns>
        public static Task<VirtualNetworkGatewayPutResponse> BeginResetAsync(this IVirtualNetworkGatewayOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGateway parameters)
        {
            return operations.BeginResetAsync(resourceGroupName, virtualNetworkGatewayName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Put VirtualNetworkGateway operation creates/updates a virtual
        /// network gateway in the specified resource group through Network
        /// resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkGatewayOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayName'>
        /// Required. The name of the virtual network gateway.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Begin Create or update Virtual
        /// Network Gateway operation through Network resource provider.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static AzureAsyncOperationResponse CreateOrUpdate(this IVirtualNetworkGatewayOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGateway parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualNetworkGatewayOperations)s).CreateOrUpdateAsync(resourceGroupName, virtualNetworkGatewayName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Put VirtualNetworkGateway operation creates/updates a virtual
        /// network gateway in the specified resource group through Network
        /// resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkGatewayOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayName'>
        /// Required. The name of the virtual network gateway.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Begin Create or update Virtual
        /// Network Gateway operation through Network resource provider.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<AzureAsyncOperationResponse> CreateOrUpdateAsync(this IVirtualNetworkGatewayOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGateway parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, virtualNetworkGatewayName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Delete VirtualNetworkGateway operation deletes the specifed
        /// virtual network Gateway through Network resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkGatewayOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayName'>
        /// Required. The name of the virtual network gateway.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IVirtualNetworkGatewayOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualNetworkGatewayOperations)s).DeleteAsync(resourceGroupName, virtualNetworkGatewayName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Delete VirtualNetworkGateway operation deletes the specifed
        /// virtual network Gateway through Network resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkGatewayOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayName'>
        /// Required. The name of the virtual network gateway.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IVirtualNetworkGatewayOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
        {
            return operations.DeleteAsync(resourceGroupName, virtualNetworkGatewayName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get VirtualNetworkGateway operation retrieves information about
        /// the specified virtual network gateway through Network resource
        /// provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkGatewayOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayName'>
        /// Required. The name of the virtual network gateway.
        /// </param>
        /// <returns>
        /// Response for GetVitualNetworkgateway Api servive call.
        /// </returns>
        public static VirtualNetworkGatewayGetResponse Get(this IVirtualNetworkGatewayOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualNetworkGatewayOperations)s).GetAsync(resourceGroupName, virtualNetworkGatewayName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get VirtualNetworkGateway operation retrieves information about
        /// the specified virtual network gateway through Network resource
        /// provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkGatewayOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayName'>
        /// Required. The name of the virtual network gateway.
        /// </param>
        /// <returns>
        /// Response for GetVitualNetworkgateway Api servive call.
        /// </returns>
        public static Task<VirtualNetworkGatewayGetResponse> GetAsync(this IVirtualNetworkGatewayOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
        {
            return operations.GetAsync(resourceGroupName, virtualNetworkGatewayName, CancellationToken.None);
        }
        
        /// <summary>
        /// The List VirtualNetworkGateways opertion retrieves all the virtual
        /// network gateways stored.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkGatewayOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <returns>
        /// Response for ListVirtualNetworkGateways Api service call
        /// </returns>
        public static VirtualNetworkGatewayListResponse List(this IVirtualNetworkGatewayOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualNetworkGatewayOperations)s).ListAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List VirtualNetworkGateways opertion retrieves all the virtual
        /// network gateways stored.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkGatewayOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <returns>
        /// Response for ListVirtualNetworkGateways Api service call
        /// </returns>
        public static Task<VirtualNetworkGatewayListResponse> ListAsync(this IVirtualNetworkGatewayOperations operations, string resourceGroupName)
        {
            return operations.ListAsync(resourceGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Reset VirtualNetworkGateway operation resets the primary of the
        /// virtual network gateway in the specified resource group through
        /// Network resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkGatewayOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayName'>
        /// Required. The name of the virtual network gateway.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Begin Reset Virtual Network
        /// Gateway operation through Network resource provider.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static AzureAsyncOperationResponse Reset(this IVirtualNetworkGatewayOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGateway parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualNetworkGatewayOperations)s).ResetAsync(resourceGroupName, virtualNetworkGatewayName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Reset VirtualNetworkGateway operation resets the primary of the
        /// virtual network gateway in the specified resource group through
        /// Network resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.IVirtualNetworkGatewayOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayName'>
        /// Required. The name of the virtual network gateway.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Begin Reset Virtual Network
        /// Gateway operation through Network resource provider.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<AzureAsyncOperationResponse> ResetAsync(this IVirtualNetworkGatewayOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGateway parameters)
        {
            return operations.ResetAsync(resourceGroupName, virtualNetworkGatewayName, parameters, CancellationToken.None);
        }
    }
}