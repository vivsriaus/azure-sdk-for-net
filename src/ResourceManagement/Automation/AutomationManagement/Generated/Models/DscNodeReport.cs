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

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Definition of the dsc node report type.
    /// </summary>
    public partial class DscNodeReport
    {
        private string _configurationVersion;
        
        /// <summary>
        /// Optional. Gets or sets the configurationVersion of the node report.
        /// </summary>
        public string ConfigurationVersion
        {
            get { return this._configurationVersion; }
            set { this._configurationVersion = value; }
        }
        
        private DateTimeOffset _endTime;
        
        /// <summary>
        /// Optional. Gets or sets the end time of the node report.
        /// </summary>
        public DateTimeOffset EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private Guid _id;
        
        /// <summary>
        /// Optional. Gets or sets the id of the node report.
        /// </summary>
        public Guid Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private DateTimeOffset _lastModifiedTime;
        
        /// <summary>
        /// Optional. Gets or sets the lastModifiedTime of the node report.
        /// </summary>
        public DateTimeOffset LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }
        
        private string _rebootRequested;
        
        /// <summary>
        /// Optional. Gets or sets the rebootRequested of the node report.
        /// </summary>
        public string RebootRequested
        {
            get { return this._rebootRequested; }
            set { this._rebootRequested = value; }
        }
        
        private string _refreshMode;
        
        /// <summary>
        /// Optional. Gets or sets the refreshMode of the node report.
        /// </summary>
        public string RefreshMode
        {
            get { return this._refreshMode; }
            set { this._refreshMode = value; }
        }
        
        private string _reportFormatVersion;
        
        /// <summary>
        /// Optional. Gets or sets the reportFormatVersion of the node report.
        /// </summary>
        public string ReportFormatVersion
        {
            get { return this._reportFormatVersion; }
            set { this._reportFormatVersion = value; }
        }
        
        private DateTimeOffset _startTime;
        
        /// <summary>
        /// Optional. Gets or sets the start time of the node report.
        /// </summary>
        public DateTimeOffset StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Gets or sets the status of the node report.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. Gets or sets the type of the node report.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DscNodeReport class.
        /// </summary>
        public DscNodeReport()
        {
        }
    }
}
