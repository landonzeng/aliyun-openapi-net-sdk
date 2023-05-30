/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Kms.Model.V20160120
{
	public class GetParametersForImportResponse : AcsResponse
	{

		private string keyId;

		private string importToken;

		private string requestId;

		private string tokenExpireTime;

		private string publicKey;

		[JsonProperty(PropertyName = "KeyId")]
		public string KeyId
		{
			get
			{
				return keyId;
			}
			set	
			{
				keyId = value;
			}
		}

		[JsonProperty(PropertyName = "ImportToken")]
		public string ImportToken
		{
			get
			{
				return importToken;
			}
			set	
			{
				importToken = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		[JsonProperty(PropertyName = "TokenExpireTime")]
		public string TokenExpireTime
		{
			get
			{
				return tokenExpireTime;
			}
			set	
			{
				tokenExpireTime = value;
			}
		}

		[JsonProperty(PropertyName = "PublicKey")]
		public string PublicKey
		{
			get
			{
				return publicKey;
			}
			set	
			{
				publicKey = value;
			}
		}
	}
}
