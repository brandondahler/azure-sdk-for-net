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
using Hyak.Common;

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// Dns Settings of a network interface
    /// </summary>
    public partial class NetworkInterfaceDnsSettings
    {
        private IList<string> _appliedDnsServers;
        
        /// <summary>
        /// Optional. Gets or sets list of Applied DNS servers IP addresses
        /// </summary>
        public IList<string> AppliedDnsServers
        {
            get { return this._appliedDnsServers; }
            set { this._appliedDnsServers = value; }
        }
        
        private IList<string> _dnsServers;
        
        /// <summary>
        /// Optional. Gets or sets list of DNS servers IP addresses
        /// </summary>
        public IList<string> DnsServers
        {
            get { return this._dnsServers; }
            set { this._dnsServers = value; }
        }
        
        private string _internalDnsNameLabel;
        
        /// <summary>
        /// Optional. Gets or sets the Internal DNS name
        /// </summary>
        public string InternalDnsNameLabel
        {
            get { return this._internalDnsNameLabel; }
            set { this._internalDnsNameLabel = value; }
        }
        
        private string _internalFqdn;
        
        /// <summary>
        /// Optional. Gets or sets full IDNS name in the form,
        /// DnsName.VnetId.ZoneId.TopleveSuffix. This is set when the NIC is
        /// associated to a VM
        /// </summary>
        public string InternalFqdn
        {
            get { return this._internalFqdn; }
            set { this._internalFqdn = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceDnsSettings class.
        /// </summary>
        public NetworkInterfaceDnsSettings()
        {
            this.AppliedDnsServers = new LazyList<string>();
            this.DnsServers = new LazyList<string>();
        }
    }
}