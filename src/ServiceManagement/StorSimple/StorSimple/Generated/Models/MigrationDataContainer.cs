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
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// This class respresents the legacy  appliance's volume container.
    /// </summary>
    public partial class MigrationDataContainer
    {
        private string _backupBucket;
        
        /// <summary>
        /// Required. Gets or sets the backup bucket's name
        /// </summary>
        public string BackupBucket
        {
            get { return this._backupBucket; }
            set { this._backupBucket = value; }
        }
        
        private StorageAccountCredential _backupStorageAccountCredential;
        
        /// <summary>
        /// Required. Gets or sets the Storage Account's Credential where
        /// backup bucket is created
        /// </summary>
        public StorageAccountCredential BackupStorageAccountCredential
        {
            get { return this._backupStorageAccountCredential; }
            set { this._backupStorageAccountCredential = value; }
        }
        
        private BandwidthSetting _bandwidthSetting;
        
        /// <summary>
        /// Required. Gets or sets the bandwidth settings assoiated with volume
        /// container
        /// </summary>
        public BandwidthSetting BandwidthSetting
        {
            get { return this._bandwidthSetting; }
            set { this._bandwidthSetting = value; }
        }
        
        private string _encryptionKey;
        
        /// <summary>
        /// Optional. Gets or sets the data encryption key.
        /// </summary>
        public string EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }
        
        private string _instanceId;
        
        /// <summary>
        /// Optional. Gets or sets the instance id of volume container
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }
        
        private bool _isDefault;
        
        /// <summary>
        /// Required. Gets or sets a value indicating whether this instance is
        /// default.
        /// </summary>
        public bool IsDefault
        {
            get { return this._isDefault; }
            set { this._isDefault = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the name of the volume container
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private OperationInProgress _operationInProgress;
        
        /// <summary>
        /// Optional. Gets or sets a value indicating whether any volume
        /// container operation in progress
        /// </summary>
        public OperationInProgress OperationInProgress
        {
            get { return this._operationInProgress; }
            set { this._operationInProgress = value; }
        }
        
        private bool _owned;
        
        /// <summary>
        /// Optional. Gets or sets a value indicating whether volume container
        /// is owned or not.
        /// </summary>
        public bool Owned
        {
            get { return this._owned; }
            set { this._owned = value; }
        }
        
        private string _primaryBucket;
        
        /// <summary>
        /// Required. Gets or sets the primary bucket's name
        /// </summary>
        public string PrimaryBucket
        {
            get { return this._primaryBucket; }
            set { this._primaryBucket = value; }
        }
        
        private StorageAccountCredential _primaryStorageAccountCredential;
        
        /// <summary>
        /// Required. Gets or sets Storage Account's Credential where the
        /// primary bucket is stored
        /// </summary>
        public StorageAccountCredential PrimaryStorageAccountCredential
        {
            get { return this._primaryStorageAccountCredential; }
            set { this._primaryStorageAccountCredential = value; }
        }
        
        private string _secretsEncryptionThumbprint;
        
        /// <summary>
        /// Required. Gets or sets the secret (credential) encryption
        /// thumbprint.
        /// </summary>
        public string SecretsEncryptionThumbprint
        {
            get { return this._secretsEncryptionThumbprint; }
            set { this._secretsEncryptionThumbprint = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MigrationDataContainer class.
        /// </summary>
        public MigrationDataContainer()
        {
        }
    }
}
