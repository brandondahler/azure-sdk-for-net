// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Hyper V VM network input details.
    /// </summary>
    public partial class VMNicInputDetails
    {
        /// <summary>
        /// Initializes a new instance of the VMNicInputDetails class.
        /// </summary>
        public VMNicInputDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMNicInputDetails class.
        /// </summary>
        /// <param name="nicId">The nic Id.</param>
        /// <param name="recoveryVMSubnetName">Recovery VM subnet name.</param>
        /// <param name="replicaNicStaticIPAddress">Replica nic static IP
        /// address.</param>
        /// <param name="selectionType">Selection type for failover.</param>
        /// <param name="recoveryPublicIpAddressId">The id of the public IP
        /// address resource associated with the NIC.</param>
        /// <param name="recoveryNetworkSecurityGroupId">The id of the NSG
        /// associated with the NIC.</param>
        /// <param name="recoveryLBBackendAddressPoolIds">The target backend
        /// address pools for the NIC.</param>
        /// <param name="enableAcceleratedNetworkingOnRecovery">Whether the NIC
        /// has accelerated networking enabled.</param>
        public VMNicInputDetails(string nicId = default(string), string recoveryVMSubnetName = default(string), string replicaNicStaticIPAddress = default(string), string selectionType = default(string), string recoveryPublicIpAddressId = default(string), string recoveryNetworkSecurityGroupId = default(string), IList<string> recoveryLBBackendAddressPoolIds = default(IList<string>), bool? enableAcceleratedNetworkingOnRecovery = default(bool?))
        {
            NicId = nicId;
            RecoveryVMSubnetName = recoveryVMSubnetName;
            ReplicaNicStaticIPAddress = replicaNicStaticIPAddress;
            SelectionType = selectionType;
            RecoveryPublicIpAddressId = recoveryPublicIpAddressId;
            RecoveryNetworkSecurityGroupId = recoveryNetworkSecurityGroupId;
            RecoveryLBBackendAddressPoolIds = recoveryLBBackendAddressPoolIds;
            EnableAcceleratedNetworkingOnRecovery = enableAcceleratedNetworkingOnRecovery;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the nic Id.
        /// </summary>
        [JsonProperty(PropertyName = "nicId")]
        public string NicId { get; set; }

        /// <summary>
        /// Gets or sets recovery VM subnet name.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryVMSubnetName")]
        public string RecoveryVMSubnetName { get; set; }

        /// <summary>
        /// Gets or sets replica nic static IP address.
        /// </summary>
        [JsonProperty(PropertyName = "replicaNicStaticIPAddress")]
        public string ReplicaNicStaticIPAddress { get; set; }

        /// <summary>
        /// Gets or sets selection type for failover.
        /// </summary>
        [JsonProperty(PropertyName = "selectionType")]
        public string SelectionType { get; set; }

        /// <summary>
        /// Gets or sets the id of the public IP address resource associated
        /// with the NIC.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPublicIpAddressId")]
        public string RecoveryPublicIpAddressId { get; set; }

        /// <summary>
        /// Gets or sets the id of the NSG associated with the NIC.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryNetworkSecurityGroupId")]
        public string RecoveryNetworkSecurityGroupId { get; set; }

        /// <summary>
        /// Gets or sets the target backend address pools for the NIC.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryLBBackendAddressPoolIds")]
        public IList<string> RecoveryLBBackendAddressPoolIds { get; set; }

        /// <summary>
        /// Gets or sets whether the NIC has accelerated networking enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enableAcceleratedNetworkingOnRecovery")]
        public bool? EnableAcceleratedNetworkingOnRecovery { get; set; }

    }
}
