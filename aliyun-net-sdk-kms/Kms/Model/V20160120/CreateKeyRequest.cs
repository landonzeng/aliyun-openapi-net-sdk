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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Kms.Transform;
using Aliyun.Acs.Kms.Transform.V20160120;

namespace Aliyun.Acs.Kms.Model.V20160120
{
    public class CreateKeyRequest : RpcAcsRequest<CreateKeyResponse>
    {
        public CreateKeyRequest()
            : base("Kms", "2016-01-20", "CreateKey", "kms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Kms.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Kms.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string origin;

		private string description;

		private string keySpec;

		private string rotationInterval;

		private bool? enableAutomaticRotation;

		private string tags;

		private string protectionLevel;

		private string keyUsage;

		private string dKMSInstanceId;

		private string policy;

		[JsonProperty(PropertyName = "Origin")]
		public string Origin
		{
			get
			{
				return origin;
			}
			set	
			{
				origin = value;
				DictionaryUtil.Add(QueryParameters, "Origin", value);
			}
		}

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "KeySpec")]
		public string KeySpec
		{
			get
			{
				return keySpec;
			}
			set	
			{
				keySpec = value;
				DictionaryUtil.Add(QueryParameters, "KeySpec", value);
			}
		}

		[JsonProperty(PropertyName = "RotationInterval")]
		public string RotationInterval
		{
			get
			{
				return rotationInterval;
			}
			set	
			{
				rotationInterval = value;
				DictionaryUtil.Add(QueryParameters, "RotationInterval", value);
			}
		}

		[JsonProperty(PropertyName = "EnableAutomaticRotation")]
		public bool? EnableAutomaticRotation
		{
			get
			{
				return enableAutomaticRotation;
			}
			set	
			{
				enableAutomaticRotation = value;
				DictionaryUtil.Add(QueryParameters, "EnableAutomaticRotation", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Tags")]
		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
			}
		}

		[JsonProperty(PropertyName = "ProtectionLevel")]
		public string ProtectionLevel
		{
			get
			{
				return protectionLevel;
			}
			set	
			{
				protectionLevel = value;
				DictionaryUtil.Add(QueryParameters, "ProtectionLevel", value);
			}
		}

		[JsonProperty(PropertyName = "KeyUsage")]
		public string KeyUsage
		{
			get
			{
				return keyUsage;
			}
			set	
			{
				keyUsage = value;
				DictionaryUtil.Add(QueryParameters, "KeyUsage", value);
			}
		}

		[JsonProperty(PropertyName = "DKMSInstanceId")]
		public string DKMSInstanceId
		{
			get
			{
				return dKMSInstanceId;
			}
			set	
			{
				dKMSInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DKMSInstanceId", value);
			}
		}

		[JsonProperty(PropertyName = "Policy")]
		public string Policy
		{
			get
			{
				return policy;
			}
			set	
			{
				policy = value;
				DictionaryUtil.Add(QueryParameters, "Policy", value);
			}
		}

        public override CreateKeyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateKeyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
