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
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// Describes the base OS profile.
    /// </summary>
    public partial class OSProfileBase
    {
        private string _adminPassword;
        
        /// <summary>
        /// Optional. Gets or sets the admin user password.
        /// </summary>
        public string AdminPassword
        {
            get { return this._adminPassword; }
            set { this._adminPassword = value; }
        }
        
        private string _adminUsername;
        
        /// <summary>
        /// Optional. Gets or sets the admin user name.
        /// </summary>
        public string AdminUsername
        {
            get { return this._adminUsername; }
            set { this._adminUsername = value; }
        }
        
        private string _customData;
        
        /// <summary>
        /// Optional. Gets or sets a base-64 encoded string of custom data.
        /// </summary>
        public string CustomData
        {
            get { return this._customData; }
            set { this._customData = value; }
        }
        
        private LinuxConfiguration _linuxConfiguration;
        
        /// <summary>
        /// Optional. Gets or sets the Linux Configuration of the OS profile.
        /// </summary>
        public LinuxConfiguration LinuxConfiguration
        {
            get { return this._linuxConfiguration; }
            set { this._linuxConfiguration = value; }
        }
        
        private IList<VaultSecretGroup> _secrets;
        
        /// <summary>
        /// Optional. Gets or sets the List of certificates for addition to the
        /// VM.
        /// </summary>
        public IList<VaultSecretGroup> Secrets
        {
            get { return this._secrets; }
            set { this._secrets = value; }
        }
        
        private WindowsConfiguration _windowsConfiguration;
        
        /// <summary>
        /// Optional. Gets or sets the Windows Configuration of the OS profile.
        /// </summary>
        public WindowsConfiguration WindowsConfiguration
        {
            get { return this._windowsConfiguration; }
            set { this._windowsConfiguration = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the OSProfileBase class.
        /// </summary>
        public OSProfileBase()
        {
            this.Secrets = new LazyList<VaultSecretGroup>();
        }
    }
}
