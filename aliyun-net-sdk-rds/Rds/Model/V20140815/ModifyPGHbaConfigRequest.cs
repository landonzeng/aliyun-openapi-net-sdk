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
using Aliyun.Acs.Rds;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class ModifyPGHbaConfigRequest : RpcAcsRequest<ModifyPGHbaConfigResponse>
    {
        public ModifyPGHbaConfigRequest()
            : base("Rds", "2014-08-15", "ModifyPGHbaConfig")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string opsType;

		private string dBInstanceId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private List<string> hbaItems = new List<string>(){ };

		[JsonProperty(PropertyName = "ResourceOwnerId")]
		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ClientToken")]
		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		[JsonProperty(PropertyName = "OpsType")]
		public string OpsType
		{
			get
			{
				return opsType;
			}
			set	
			{
				opsType = value;
				DictionaryUtil.Add(QueryParameters, "OpsType", value);
			}
		}

		[JsonProperty(PropertyName = "DBInstanceId")]
		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerAccount")]
		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "HbaItem")]
		public List<string> HbaItems
		{
			get
			{
				return hbaItems;
			}

			set
			{
				hbaItems = value;
				if(hbaItems != null)
				{
					for (int depth1 = 0; depth1 < hbaItems.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"HbaItem." + (depth1 + 1), hbaItems[depth1]);
						DictionaryUtil.Add(QueryParameters,"HbaItem." + (depth1 + 1), hbaItems[depth1]);
						DictionaryUtil.Add(QueryParameters,"HbaItem." + (depth1 + 1), hbaItems[depth1]);
						DictionaryUtil.Add(QueryParameters,"HbaItem." + (depth1 + 1), hbaItems[depth1]);
						DictionaryUtil.Add(QueryParameters,"HbaItem." + (depth1 + 1), hbaItems[depth1]);
						DictionaryUtil.Add(QueryParameters,"HbaItem." + (depth1 + 1), hbaItems[depth1]);
						DictionaryUtil.Add(QueryParameters,"HbaItem." + (depth1 + 1), hbaItems[depth1]);
						DictionaryUtil.Add(QueryParameters,"HbaItem." + (depth1 + 1), hbaItems[depth1]);
					}
				}
			}
		}

		public class HbaItem
		{

			private string database;

			private string address;

			private string method;

			private string type;

			private string user;

			private string mask;

			private int? priorityId;

			private string option;

			[JsonProperty(PropertyName = "Database")]
			public string Database
			{
				get
				{
					return database;
				}
				set	
				{
					database = value;
				}
			}

			[JsonProperty(PropertyName = "Address")]
			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}

			[JsonProperty(PropertyName = "Method")]
			public string Method
			{
				get
				{
					return method;
				}
				set	
				{
					method = value;
				}
			}

			[JsonProperty(PropertyName = "Type")]
			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			[JsonProperty(PropertyName = "User")]
			public string User
			{
				get
				{
					return user;
				}
				set	
				{
					user = value;
				}
			}

			[JsonProperty(PropertyName = "Mask")]
			public string Mask
			{
				get
				{
					return mask;
				}
				set	
				{
					mask = value;
				}
			}

			[JsonProperty(PropertyName = "PriorityId")]
			public int? PriorityId
			{
				get
				{
					return priorityId;
				}
				set	
				{
					priorityId = value;
				}
			}

			[JsonProperty(PropertyName = "Option")]
			public string Option
			{
				get
				{
					return option;
				}
				set	
				{
					option = value;
				}
			}
		}

        public override ModifyPGHbaConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyPGHbaConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
