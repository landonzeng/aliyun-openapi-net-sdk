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
using Aliyun.Acs.OpenSearch;
using Aliyun.Acs.OpenSearch.Transform;
using Aliyun.Acs.OpenSearch.Transform.V20171225;

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
    public class ListAppGroupsRequest : RoaAcsRequest<ListAppGroupsResponse>
    {
        public ListAppGroupsRequest()
            : base("OpenSearch", "2017-12-25", "ListAppGroups")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OpenSearch.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OpenSearch.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/v4/openapi/app-groups";
			Method = MethodType.GET;
        }

		private string resourceGroupId;

		private string instanceId;

		private int? pageSize;

		private string name;

		private int? sortBy;

		private string type;

		private int? pageNumber;

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "resourceGroupId", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "instanceId", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "pageSize", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "name", value);
			}
		}

		public int? SortBy
		{
			get
			{
				return sortBy;
			}
			set	
			{
				sortBy = value;
				DictionaryUtil.Add(QueryParameters, "sortBy", value.ToString());
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "type", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "pageNumber", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListAppGroupsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListAppGroupsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
