// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Batch;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LocationOperations.
    /// </summary>
    public static partial class LocationOperationsExtensions
    {
            
            /// <summary>
            /// Gets the Batch service quotas for the specified subscription at the given
            /// location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// The region for which to retrieve Batch service quotas.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BatchLocationQuotaInner> GetQuotasAsync(this ILocationOperations operations, string locationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetQuotasWithHttpMessagesAsync(locationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
