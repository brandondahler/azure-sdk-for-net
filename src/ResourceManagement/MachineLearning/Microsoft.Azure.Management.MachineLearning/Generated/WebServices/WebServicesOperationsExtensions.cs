// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for WebServicesOperations.
    /// </summary>
    public static partial class WebServicesOperationsExtensions
    {
            /// <summary>
            /// Create or update a web service. This call will overwrite an existing web
            /// service. Note that there is no warning or confirmation. This is a
            /// nonrecoverable operation. If your intent is to create a new web service,
            /// call the Get operation first to verify that it does not exist.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='webServiceName'>
            /// The name of the web service.
            /// </param>
            /// <param name='createOrUpdatePayload'>
            /// The payload that is used to create or update the web service.
            /// </param>
            public static WebService CreateOrUpdate(this IWebServicesOperations operations, string resourceGroupName, string webServiceName, WebService createOrUpdatePayload)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebServicesOperations)s).CreateOrUpdateAsync(resourceGroupName, webServiceName, createOrUpdatePayload), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a web service. This call will overwrite an existing web
            /// service. Note that there is no warning or confirmation. This is a
            /// nonrecoverable operation. If your intent is to create a new web service,
            /// call the Get operation first to verify that it does not exist.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='webServiceName'>
            /// The name of the web service.
            /// </param>
            /// <param name='createOrUpdatePayload'>
            /// The payload that is used to create or update the web service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<WebService> CreateOrUpdateAsync(this IWebServicesOperations operations, string resourceGroupName, string webServiceName, WebService createOrUpdatePayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, webServiceName, createOrUpdatePayload, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a web service. This call will overwrite an existing web
            /// service. Note that there is no warning or confirmation. This is a
            /// nonrecoverable operation. If your intent is to create a new web service,
            /// call the Get operation first to verify that it does not exist.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='webServiceName'>
            /// The name of the web service.
            /// </param>
            /// <param name='createOrUpdatePayload'>
            /// The payload that is used to create or update the web service.
            /// </param>
            public static WebService BeginCreateOrUpdate(this IWebServicesOperations operations, string resourceGroupName, string webServiceName, WebService createOrUpdatePayload)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebServicesOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, webServiceName, createOrUpdatePayload), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a web service. This call will overwrite an existing web
            /// service. Note that there is no warning or confirmation. This is a
            /// nonrecoverable operation. If your intent is to create a new web service,
            /// call the Get operation first to verify that it does not exist.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='webServiceName'>
            /// The name of the web service.
            /// </param>
            /// <param name='createOrUpdatePayload'>
            /// The payload that is used to create or update the web service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<WebService> BeginCreateOrUpdateAsync(this IWebServicesOperations operations, string resourceGroupName, string webServiceName, WebService createOrUpdatePayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, webServiceName, createOrUpdatePayload, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the Web Service Definiton as specified by a subscription, resource
            /// group, and name. Note that the storage credentials and web service keys
            /// are not returned by this call. To get the web service access keys, call
            /// List Keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='webServiceName'>
            /// The name of the web service.
            /// </param>
            public static WebService Get(this IWebServicesOperations operations, string resourceGroupName, string webServiceName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebServicesOperations)s).GetAsync(resourceGroupName, webServiceName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Web Service Definiton as specified by a subscription, resource
            /// group, and name. Note that the storage credentials and web service keys
            /// are not returned by this call. To get the web service access keys, call
            /// List Keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='webServiceName'>
            /// The name of the web service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<WebService> GetAsync(this IWebServicesOperations operations, string resourceGroupName, string webServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, webServiceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Modifies an existing web service resource. The PATCH API call is an
            /// asynchronous operation. To determine whether it has completed
            /// successfully, you must perform a Get operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='webServiceName'>
            /// The name of the web service.
            /// </param>
            /// <param name='patchPayload'>
            /// The payload to use to patch the web service.
            /// </param>
            public static WebService Patch(this IWebServicesOperations operations, string resourceGroupName, string webServiceName, WebService patchPayload)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebServicesOperations)s).PatchAsync(resourceGroupName, webServiceName, patchPayload), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modifies an existing web service resource. The PATCH API call is an
            /// asynchronous operation. To determine whether it has completed
            /// successfully, you must perform a Get operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='webServiceName'>
            /// The name of the web service.
            /// </param>
            /// <param name='patchPayload'>
            /// The payload to use to patch the web service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<WebService> PatchAsync(this IWebServicesOperations operations, string resourceGroupName, string webServiceName, WebService patchPayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PatchWithHttpMessagesAsync(resourceGroupName, webServiceName, patchPayload, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Modifies an existing web service resource. The PATCH API call is an
            /// asynchronous operation. To determine whether it has completed
            /// successfully, you must perform a Get operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='webServiceName'>
            /// The name of the web service.
            /// </param>
            /// <param name='patchPayload'>
            /// The payload to use to patch the web service.
            /// </param>
            public static WebService BeginPatch(this IWebServicesOperations operations, string resourceGroupName, string webServiceName, WebService patchPayload)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebServicesOperations)s).BeginPatchAsync(resourceGroupName, webServiceName, patchPayload), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modifies an existing web service resource. The PATCH API call is an
            /// asynchronous operation. To determine whether it has completed
            /// successfully, you must perform a Get operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='webServiceName'>
            /// The name of the web service.
            /// </param>
            /// <param name='patchPayload'>
            /// The payload to use to patch the web service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<WebService> BeginPatchAsync(this IWebServicesOperations operations, string resourceGroupName, string webServiceName, WebService patchPayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginPatchWithHttpMessagesAsync(resourceGroupName, webServiceName, patchPayload, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified web service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='webServiceName'>
            /// The name of the web service.
            /// </param>
            public static void Remove(this IWebServicesOperations operations, string resourceGroupName, string webServiceName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebServicesOperations)s).RemoveAsync(resourceGroupName, webServiceName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified web service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='webServiceName'>
            /// The name of the web service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task RemoveAsync(this IWebServicesOperations operations, string resourceGroupName, string webServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.RemoveWithHttpMessagesAsync(resourceGroupName, webServiceName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Deletes the specified web service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='webServiceName'>
            /// The name of the web service.
            /// </param>
            public static void BeginRemove(this IWebServicesOperations operations, string resourceGroupName, string webServiceName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebServicesOperations)s).BeginRemoveAsync(resourceGroupName, webServiceName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified web service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='webServiceName'>
            /// The name of the web service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginRemoveAsync(this IWebServicesOperations operations, string resourceGroupName, string webServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.BeginRemoveWithHttpMessagesAsync(resourceGroupName, webServiceName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the access keys for the specified web service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='webServiceName'>
            /// The name of the web service.
            /// </param>
            public static WebServiceKeys ListKeys(this IWebServicesOperations operations, string resourceGroupName, string webServiceName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebServicesOperations)s).ListKeysAsync(resourceGroupName, webServiceName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the access keys for the specified web service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='webServiceName'>
            /// The name of the web service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<WebServiceKeys> ListKeysAsync(this IWebServicesOperations operations, string resourceGroupName, string webServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, webServiceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the web services in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='skiptoken'>
            /// Continuation token for pagination.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<WebService> ListByResourceGroup(this IWebServicesOperations operations, string resourceGroupName, string skiptoken = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebServicesOperations)s).ListByResourceGroupAsync(resourceGroupName, skiptoken), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the web services in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group in which the web service is located.
            /// </param>
            /// <param name='skiptoken'>
            /// Continuation token for pagination.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<WebService>> ListByResourceGroupAsync(this IWebServicesOperations operations, string resourceGroupName, string skiptoken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, skiptoken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the web services in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skiptoken'>
            /// Continuation token for pagination.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<WebService> List(this IWebServicesOperations operations, string skiptoken = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebServicesOperations)s).ListAsync(skiptoken), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the web services in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skiptoken'>
            /// Continuation token for pagination.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<WebService>> ListAsync(this IWebServicesOperations operations, string skiptoken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(skiptoken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the web services in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<WebService> ListByResourceGroupNext(this IWebServicesOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebServicesOperations)s).ListByResourceGroupNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the web services in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<WebService>> ListByResourceGroupNextAsync(this IWebServicesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the web services in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<WebService> ListNext(this IWebServicesOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebServicesOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the web services in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<WebService>> ListNextAsync(this IWebServicesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}