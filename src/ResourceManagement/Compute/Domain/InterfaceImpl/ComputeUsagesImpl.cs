// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Compute.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Microsoft.Azure.Management.Compute.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;

    internal partial class ComputeUsagesImpl 
    {
        /// <summary>
        /// Lists all the resources of the specified type in the specified region.
        /// </summary>
        /// <param name="region">The selected Azure region.</param>
        /// <return>List of resources.</return>
        System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Compute.Fluent.IComputeUsage> Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListingByRegion<Microsoft.Azure.Management.Compute.Fluent.IComputeUsage>.ListByRegion(Region region)
        {
            return this.ListByRegion(region) as System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Compute.Fluent.IComputeUsage>;
        }

        /// <summary>
        /// List all the resources of the specified type in the specified region.
        /// </summary>
        /// <param name="regionName">The name of an Azure region.</param>
        /// <return>List of resources.</return>
        System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Compute.Fluent.IComputeUsage> Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListingByRegion<Microsoft.Azure.Management.Compute.Fluent.IComputeUsage>.ListByRegion(string regionName)
        {
            return this.ListByRegion(regionName) as System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Compute.Fluent.IComputeUsage>;
        }

        /// <summary>
        /// Lists all the resources of the specified type in the specified region.
        /// </summary>
        /// <param name="region">The selected Azure region.</param>
        /// <return>A representation of the deferred computation of this call, returning the requested resources.</return>
        async Task<IPagedCollection<Microsoft.Azure.Management.Compute.Fluent.IComputeUsage>> Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListingByRegion<Microsoft.Azure.Management.Compute.Fluent.IComputeUsage>.ListByRegionAsync(Region region, CancellationToken cancellationToken)
        {
            return await this.ListByRegionAsync(region, cancellationToken) as IPagedCollection<Microsoft.Azure.Management.Compute.Fluent.IComputeUsage>;
        }

        

        /// <summary>
        /// List all the resources of the specified type in the specified region.
        /// </summary>
        /// <param name="regionName">The name of an Azure region.</param>
        /// <return>A representation of the deferred computation of this call, returning the requested resources.</return>
        async Task<IPagedCollection<Microsoft.Azure.Management.Compute.Fluent.IComputeUsage>> Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListingByRegion<Microsoft.Azure.Management.Compute.Fluent.IComputeUsage>.ListByRegionAsync(string regionName, CancellationToken cancellationToken)
        {
            return await this.ListByRegionAsync(regionName, cancellationToken) as IPagedCollection<Microsoft.Azure.Management.Compute.Fluent.IComputeUsage>;
        }
    }
}