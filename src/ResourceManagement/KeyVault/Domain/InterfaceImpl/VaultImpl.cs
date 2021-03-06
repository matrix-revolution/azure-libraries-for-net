// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.KeyVault.Fluent
{

    using Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions;
    using System.Collections.Generic;
    using Microsoft.Azure.Management.KeyVault.Fluent.Models;
    using Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update;
    using Microsoft.Azure.Management.Graph.RBAC.Fluent.Models;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    internal partial class VaultImpl 
    {
        /// <summary>
        /// Refreshes the resource to sync with Azure.
        /// </summary>
        /// <returns>the refreshed resource</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.IVault Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IRefreshable<Microsoft.Azure.Management.KeyVault.Fluent.IVault>.Refresh () {
            return this.Refresh() as Microsoft.Azure.Management.KeyVault.Fluent.IVault;
        }

        /// <returns>the Azure Active Directory tenant ID that should be used for</returns>
        /// <returns>authenticating requests to the key vault.</returns>
        string Microsoft.Azure.Management.KeyVault.Fluent.IVault.TenantId
        {
            get
            {
                return this.TenantId as string;
            }
        }
        /// <returns>whether Azure Resource Manager is permitted to</returns>
        /// <returns>retrieve secrets from the key vault.</returns>
        bool Microsoft.Azure.Management.KeyVault.Fluent.IVault.EnabledForTemplateDeployment
        {
            get
            {
                return this.EnabledForTemplateDeployment;
            }
        }
        /// <returns>whether Azure Disk Encryption is permitted to</returns>
        /// <returns>retrieve secrets from the vault and unwrap keys.</returns>
        bool Microsoft.Azure.Management.KeyVault.Fluent.IVault.EnabledForDiskEncryption
        {
            get
            {
                return this.EnabledForDiskEncryption;
            }
        }
        /// <returns>the URI of the vault for performing operations on keys and secrets.</returns>
        string Microsoft.Azure.Management.KeyVault.Fluent.IVault.VaultUri
        {
            get
            {
                return this.VaultUri as string;
            }
        }
        /// <returns>SKU details.</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Models.Sku Microsoft.Azure.Management.KeyVault.Fluent.IVault.Sku
        {
            get
            {
                return this.Sku as Microsoft.Azure.Management.KeyVault.Fluent.Models.Sku;
            }
        }
        /// <returns>whether Azure Virtual Machines are permitted to</returns>
        /// <returns>retrieve certificates stored as secrets from the key vault.</returns>
        bool Microsoft.Azure.Management.KeyVault.Fluent.IVault.EnabledForDeployment
        {
            get
            {
                return this.EnabledForDeployment;
            }
        }
        /// <returns>an array of 0 to 16 identities that have access to the key vault. All</returns>
        /// <returns>identities in the array must use the same tenant ID as the key vault's</returns>
        /// <returns>tenant ID.</returns>
        System.Collections.Generic.IList<Microsoft.Azure.Management.KeyVault.Fluent.IAccessPolicy> Microsoft.Azure.Management.KeyVault.Fluent.IVault.AccessPolicies {
            get
            {
                return this.AccessPolicies as System.Collections.Generic.IList<Microsoft.Azure.Management.KeyVault.Fluent.IAccessPolicy>;
            }
        }

        /// <summary>
        /// Enable Azure Disk Encryption to retrieve secrets from the vault and unwrap keys.
        /// </summary>
        /// <returns>the next stage of key vault definition</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithConfigurations.WithDiskEncryptionEnabled () {
            return this.WithDiskEncryptionEnabled() as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate;
        }

        /// <summary>
        /// Enable Azure Resource Manager to retrieve secrets from the key vault.
        /// </summary>
        /// <returns>the next stage of key vault definition</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithConfigurations.WithTemplateDeploymentEnabled () {
            return this.WithTemplateDeploymentEnabled() as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate;
        }

        /// <summary>
        /// Enable Azure Virtual Machines to retrieve certificates stored as secrets from the key vault.
        /// </summary>
        /// <returns>the next stage of key vault definition</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithConfigurations.WithDeploymentEnabled () {
            return this.WithDeploymentEnabled() as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate;
        }

        /// <summary>
        /// Disable Azure Virtual Machines to retrieve certificates stored as secrets from the key vault.
        /// </summary>
        /// <returns>the next stage of key vault definition</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithConfigurations.WithDeploymentDisabled () {
            return this.WithDeploymentDisabled() as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate;
        }

        /// <summary>
        /// Disable Azure Resource Manager to retrieve secrets from the key vault.
        /// </summary>
        /// <returns>the next stage of key vault definition</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithConfigurations.WithTemplateDeploymentDisabled () {
            return this.WithTemplateDeploymentDisabled() as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate;
        }

        /// <summary>
        /// Disable Azure Disk Encryption to retrieve secrets from the vault and unwrap keys.
        /// </summary>
        /// <returns>the next stage of key vault definition</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithConfigurations.WithDiskEncryptionDisabled () {
            return this.WithDiskEncryptionDisabled() as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate;
        }

        /// <summary>
        /// Enable Azure Disk Encryption to retrieve secrets from the vault and unwrap keys.
        /// </summary>
        /// <returns>the key vault update stage</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IWithConfigurations.WithDiskEncryptionEnabled () {
            return this.WithDiskEncryptionEnabled() as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate;
        }

        /// <summary>
        /// Enable Azure Resource Manager to retrieve secrets from the key vault.
        /// </summary>
        /// <returns>the key vault update stage</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IWithConfigurations.WithTemplateDeploymentEnabled () {
            return this.WithTemplateDeploymentEnabled() as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate;
        }

        /// <summary>
        /// Enable Azure Virtual Machines to retrieve certificates stored as secrets from the key vault.
        /// </summary>
        /// <returns>the key vault update stage</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IWithConfigurations.WithDeploymentEnabled () {
            return this.WithDeploymentEnabled() as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate;
        }

        /// <summary>
        /// Disable Azure Virtual Machines to retrieve certificates stored as secrets from the key vault.
        /// </summary>
        /// <returns>the key vault update stage</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IWithConfigurations.WithDeploymentDisabled () {
            return this.WithDeploymentDisabled() as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate;
        }

        /// <summary>
        /// Disable Azure Resource Manager to retrieve secrets from the key vault.
        /// </summary>
        /// <returns>the key vault update stage</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IWithConfigurations.WithTemplateDeploymentDisabled () {
            return this.WithTemplateDeploymentDisabled() as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate;
        }

        /// <summary>
        /// Disable Azure Disk Encryption to retrieve secrets from the vault and unwrap keys.
        /// </summary>
        /// <returns>the next stage of key vault definition</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IWithConfigurations.WithDiskEncryptionDisabled () {
            return this.WithDiskEncryptionDisabled() as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate;
        }

        /// <summary>
        /// Attach no access policy.
        /// </summary>
        /// <returns>the next stage of key vault definition</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithAccessPolicy.WithEmptyAccessPolicy () {
            return this.WithEmptyAccessPolicy() as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate;
        }

        /// <summary>
        /// Begins the definition of a new access policy to be added to this key vault.
        /// </summary>
        /// <returns>the first stage of the access policy definition</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.AccessPolicy.Definition.IBlank<Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate> Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithAccessPolicy.DefineAccessPolicy()
        {
            return this.DefineAccessPolicy() as Microsoft.Azure.Management.KeyVault.Fluent.AccessPolicy.Definition.IBlank<Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate>;
        }
        /// <summary>
        /// Attach an existing access policy.
        /// </summary>
        /// <param name="accessPolicy">accessPolicy the existing access policy</param>
        /// <returns>the next stage of key vault definition</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithAccessPolicy.WithAccessPolicy (IAccessPolicy accessPolicy) {
            return this.WithAccessPolicy( accessPolicy) as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate;
        }

        /// <summary>
        /// Remove an access policy from the access policy list.
        /// </summary>
        /// <param name="objectId">objectId the object ID of the Active Directory identity the access policy is for</param>
        /// <returns>the key vault update stage</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IWithAccessPolicy.WithoutAccessPolicy (string objectId) {
            return this.WithoutAccessPolicy( objectId) as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate;
        }

        /// <summary>
        /// Begins the definition of a new access policy to be added to this key vault.
        /// </summary>
        /// <returns>the first stage of the access policy definition</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.AccessPolicy.UpdateDefinition.IBlank<Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate> Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IWithAccessPolicy.DefineAccessPolicy () {
            return this.DefineAccessPolicy() as Microsoft.Azure.Management.KeyVault.Fluent.AccessPolicy.UpdateDefinition.IBlank<Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate>;
        }

        /// <summary>
        /// Begins the update of an existing access policy attached to this key vault.
        /// </summary>
        /// <param name="objectId">objectId the object ID of the Active Directory identity the access policy is for</param>
        /// <returns>the update stage of the access policy definition</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.AccessPolicy.Update.IUpdate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IWithAccessPolicy.UpdateAccessPolicy (string objectId) {
            return this.UpdateAccessPolicy( objectId) as Microsoft.Azure.Management.KeyVault.Fluent.AccessPolicy.Update.IUpdate;
        }

        /// <summary>
        /// Attach an existing access policy.
        /// </summary>
        /// <param name="accessPolicy">accessPolicy the existing access policy</param>
        /// <returns>the key vault update stage</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IWithAccessPolicy.WithAccessPolicy (IAccessPolicy accessPolicy) {
            return this.WithAccessPolicy( accessPolicy) as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Update.IUpdate;
        }

        /// <summary>
        /// Specifies the sku of the key vault.
        /// </summary>
        /// <param name="skuName">skuName the sku</param>
        /// <returns>the next stage of key vault definition</returns>
        Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithSku.WithSku (SkuName skuName) {
            return this.WithSku( skuName) as Microsoft.Azure.Management.KeyVault.Fluent.Vault.Definition.IWithCreate;
        }

    }
}