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
using Microsoft.Azure.Management.DataLake.Analytics.Models;

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    /// <summary>
    /// Generic resource error information.
    /// </summary>
    public partial class Error
    {
        private string _code;
        
        /// <summary>
        /// Required. Gets or sets the HTTP status code or error code
        /// associated with this error
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }
        
        private IList<ErrorDetails> _details;
        
        /// <summary>
        /// Optional. Gets or sets the list of error details
        /// </summary>
        public IList<ErrorDetails> Details
        {
            get { return this._details; }
            set { this._details = value; }
        }
        
        private InnerError _innerError;
        
        /// <summary>
        /// Optional. Gets or sets the inner exceptions or errors, if any
        /// </summary>
        public InnerError InnerError
        {
            get { return this._innerError; }
            set { this._innerError = value; }
        }
        
        private string _message;
        
        /// <summary>
        /// Required. Gets or sets the error message to display.
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }
        
        private string _target;
        
        /// <summary>
        /// Optional. Gets or sets the target of the error.
        /// </summary>
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        public Error()
        {
            this.Details = new LazyList<ErrorDetails>();
        }
        
        /// <summary>
        /// Initializes a new instance of the Error class with required
        /// arguments.
        /// </summary>
        public Error(string code, string message)
            : this()
        {
            if (code == null)
            {
                throw new ArgumentNullException("code");
            }
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }
            this.Code = code;
            this.Message = message;
        }
    }
}
