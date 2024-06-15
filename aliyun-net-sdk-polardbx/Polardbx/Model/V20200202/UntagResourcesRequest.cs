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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.polardbx.Transform;
using Aliyun.Acs.polardbx.Transform.V20200202;

namespace Aliyun.Acs.polardbx.Model.V20200202
{
    public class UntagResourcesRequest : RpcAcsRequest<UntagResourcesResponse>
    {
        public UntagResourcesRequest()
            : base("polardbx", "2020-02-02", "UntagResources", "polardbx", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? all;

		private List<string> resourceIds = new List<string>(){ };

		private string resourceType;

		private List<string> tagKeys = new List<string>(){ };

		public bool? All
		{
			get
			{
				return all;
			}
			set	
			{
				all = value;
				DictionaryUtil.Add(QueryParameters, "All", value.ToString());
			}
		}

		public List<string> ResourceIds
		{
			get
			{
				return resourceIds;
			}

			set
			{
				resourceIds = value;
			}
		}

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		public List<string> TagKeys
		{
			get
			{
				return tagKeys;
			}

			set
			{
				tagKeys = value;
			}
		}

        public override UntagResourcesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UntagResourcesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
