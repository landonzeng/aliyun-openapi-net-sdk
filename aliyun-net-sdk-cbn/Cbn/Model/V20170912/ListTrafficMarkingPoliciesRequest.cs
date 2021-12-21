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
using Aliyun.Acs.Cbn;
using Aliyun.Acs.Cbn.Transform;
using Aliyun.Acs.Cbn.Transform.V20170912;

namespace Aliyun.Acs.Cbn.Model.V20170912
{
    public class ListTrafficMarkingPoliciesRequest : RpcAcsRequest<ListTrafficMarkingPoliciesResponse>
    {
        public ListTrafficMarkingPoliciesRequest()
            : base("Cbn", "2017-09-12", "ListTrafficMarkingPolicies")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string trafficMarkingPolicyDescription;

		private string trafficMarkingPolicyId;

		private string nextToken;

		private string trafficMarkingPolicyName;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string transitRouterId;

		private int? maxResults;

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

		public string TrafficMarkingPolicyDescription
		{
			get
			{
				return trafficMarkingPolicyDescription;
			}
			set	
			{
				trafficMarkingPolicyDescription = value;
				DictionaryUtil.Add(QueryParameters, "TrafficMarkingPolicyDescription", value);
			}
		}

		public string TrafficMarkingPolicyId
		{
			get
			{
				return trafficMarkingPolicyId;
			}
			set	
			{
				trafficMarkingPolicyId = value;
				DictionaryUtil.Add(QueryParameters, "TrafficMarkingPolicyId", value);
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		public string TrafficMarkingPolicyName
		{
			get
			{
				return trafficMarkingPolicyName;
			}
			set	
			{
				trafficMarkingPolicyName = value;
				DictionaryUtil.Add(QueryParameters, "TrafficMarkingPolicyName", value);
			}
		}

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

		public string TransitRouterId
		{
			get
			{
				return transitRouterId;
			}
			set	
			{
				transitRouterId = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterId", value);
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListTrafficMarkingPoliciesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListTrafficMarkingPoliciesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
