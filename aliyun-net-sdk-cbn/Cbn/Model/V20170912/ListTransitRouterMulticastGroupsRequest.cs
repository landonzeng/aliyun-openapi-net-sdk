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
using Aliyun.Acs.Cbn.Transform;
using Aliyun.Acs.Cbn.Transform.V20170912;

namespace Aliyun.Acs.Cbn.Model.V20170912
{
    public class ListTransitRouterMulticastGroupsRequest : RpcAcsRequest<ListTransitRouterMulticastGroupsResponse>
    {
        public ListTransitRouterMulticastGroupsRequest()
            : base("Cbn", "2017-09-12", "ListTransitRouterMulticastGroups", "cbn", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private List<string> vSwitchIdss = new List<string>(){ };

		private string transitRouterMulticastDomainId;

		private string nextToken;

		private string groupIpAddress;

		private string resourceId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private List<string> peerTransitRouterMulticastDomainss = new List<string>(){ };

		private long? ownerId;

		private string resourceType;

		private string transitRouterAttachmentId;

		private long? maxResults;

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

		public List<string> VSwitchIdss
		{
			get
			{
				return vSwitchIdss;
			}

			set
			{
				vSwitchIdss = value;
			}
		}

		public string TransitRouterMulticastDomainId
		{
			get
			{
				return transitRouterMulticastDomainId;
			}
			set	
			{
				transitRouterMulticastDomainId = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterMulticastDomainId", value);
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

		public string GroupIpAddress
		{
			get
			{
				return groupIpAddress;
			}
			set	
			{
				groupIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "GroupIpAddress", value);
			}
		}

		public string ResourceId
		{
			get
			{
				return resourceId;
			}
			set	
			{
				resourceId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId", value);
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

		public List<string> PeerTransitRouterMulticastDomainss
		{
			get
			{
				return peerTransitRouterMulticastDomainss;
			}

			set
			{
				peerTransitRouterMulticastDomainss = value;
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

		public string TransitRouterAttachmentId
		{
			get
			{
				return transitRouterAttachmentId;
			}
			set	
			{
				transitRouterAttachmentId = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterAttachmentId", value);
			}
		}

		public long? MaxResults
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

        public override ListTransitRouterMulticastGroupsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListTransitRouterMulticastGroupsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
