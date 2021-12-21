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

namespace Aliyun.Acs.Cbn.Model.V20170912
{
	public class DescribeCenRouteMapsResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeCenRouteMaps_RouteMap> routeMaps;

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<DescribeCenRouteMaps_RouteMap> RouteMaps
		{
			get
			{
				return routeMaps;
			}
			set	
			{
				routeMaps = value;
			}
		}

		public class DescribeCenRouteMaps_RouteMap
		{

			private string routeMapId;

			private string status;

			private string transmitDirection;

			private bool? sourceInstanceIdsReverseMatch;

			private string cenRegionId;

			private string cenId;

			private int? priority;

			private string transitRouterRouteTableId;

			private string communityOperateMode;

			private string mapResult;

			private string communityMatchMode;

			private string description;

			private string asPathMatchMode;

			private int? preference;

			private bool? destinationInstanceIdsReverseMatch;

			private string cidrMatchMode;

			private int? nextPriority;

			private string matchAddressType;

			private string gatewayZoneId;

			private List<string> sourceRegionIds;

			private List<string> sourceChildInstanceTypes;

			private List<string> destinationRouteTableIds;

			private List<string> sourceInstanceIds;

			private List<string> destinationCidrBlocks;

			private List<string> destinationRegionIds;

			private List<string> sourceRouteTableIds;

			private List<string> matchCommunitySet;

			private List<string> prependAsPath;

			private List<string> routeTypes;

			private List<string> originalRouteTableIds;

			private List<string> destinationChildInstanceTypes;

			private List<string> destinationInstanceIds;

			private List<string> matchAsns;

			private List<string> operateCommunitySet;

			private List<string> srcZoneIds;

			public string RouteMapId
			{
				get
				{
					return routeMapId;
				}
				set	
				{
					routeMapId = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string TransmitDirection
			{
				get
				{
					return transmitDirection;
				}
				set	
				{
					transmitDirection = value;
				}
			}

			public bool? SourceInstanceIdsReverseMatch
			{
				get
				{
					return sourceInstanceIdsReverseMatch;
				}
				set	
				{
					sourceInstanceIdsReverseMatch = value;
				}
			}

			public string CenRegionId
			{
				get
				{
					return cenRegionId;
				}
				set	
				{
					cenRegionId = value;
				}
			}

			public string CenId
			{
				get
				{
					return cenId;
				}
				set	
				{
					cenId = value;
				}
			}

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public string TransitRouterRouteTableId
			{
				get
				{
					return transitRouterRouteTableId;
				}
				set	
				{
					transitRouterRouteTableId = value;
				}
			}

			public string CommunityOperateMode
			{
				get
				{
					return communityOperateMode;
				}
				set	
				{
					communityOperateMode = value;
				}
			}

			public string MapResult
			{
				get
				{
					return mapResult;
				}
				set	
				{
					mapResult = value;
				}
			}

			public string CommunityMatchMode
			{
				get
				{
					return communityMatchMode;
				}
				set	
				{
					communityMatchMode = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string AsPathMatchMode
			{
				get
				{
					return asPathMatchMode;
				}
				set	
				{
					asPathMatchMode = value;
				}
			}

			public int? Preference
			{
				get
				{
					return preference;
				}
				set	
				{
					preference = value;
				}
			}

			public bool? DestinationInstanceIdsReverseMatch
			{
				get
				{
					return destinationInstanceIdsReverseMatch;
				}
				set	
				{
					destinationInstanceIdsReverseMatch = value;
				}
			}

			public string CidrMatchMode
			{
				get
				{
					return cidrMatchMode;
				}
				set	
				{
					cidrMatchMode = value;
				}
			}

			public int? NextPriority
			{
				get
				{
					return nextPriority;
				}
				set	
				{
					nextPriority = value;
				}
			}

			public string MatchAddressType
			{
				get
				{
					return matchAddressType;
				}
				set	
				{
					matchAddressType = value;
				}
			}

			public string GatewayZoneId
			{
				get
				{
					return gatewayZoneId;
				}
				set	
				{
					gatewayZoneId = value;
				}
			}

			public List<string> SourceRegionIds
			{
				get
				{
					return sourceRegionIds;
				}
				set	
				{
					sourceRegionIds = value;
				}
			}

			public List<string> SourceChildInstanceTypes
			{
				get
				{
					return sourceChildInstanceTypes;
				}
				set	
				{
					sourceChildInstanceTypes = value;
				}
			}

			public List<string> DestinationRouteTableIds
			{
				get
				{
					return destinationRouteTableIds;
				}
				set	
				{
					destinationRouteTableIds = value;
				}
			}

			public List<string> SourceInstanceIds
			{
				get
				{
					return sourceInstanceIds;
				}
				set	
				{
					sourceInstanceIds = value;
				}
			}

			public List<string> DestinationCidrBlocks
			{
				get
				{
					return destinationCidrBlocks;
				}
				set	
				{
					destinationCidrBlocks = value;
				}
			}

			public List<string> DestinationRegionIds
			{
				get
				{
					return destinationRegionIds;
				}
				set	
				{
					destinationRegionIds = value;
				}
			}

			public List<string> SourceRouteTableIds
			{
				get
				{
					return sourceRouteTableIds;
				}
				set	
				{
					sourceRouteTableIds = value;
				}
			}

			public List<string> MatchCommunitySet
			{
				get
				{
					return matchCommunitySet;
				}
				set	
				{
					matchCommunitySet = value;
				}
			}

			public List<string> PrependAsPath
			{
				get
				{
					return prependAsPath;
				}
				set	
				{
					prependAsPath = value;
				}
			}

			public List<string> RouteTypes
			{
				get
				{
					return routeTypes;
				}
				set	
				{
					routeTypes = value;
				}
			}

			public List<string> OriginalRouteTableIds
			{
				get
				{
					return originalRouteTableIds;
				}
				set	
				{
					originalRouteTableIds = value;
				}
			}

			public List<string> DestinationChildInstanceTypes
			{
				get
				{
					return destinationChildInstanceTypes;
				}
				set	
				{
					destinationChildInstanceTypes = value;
				}
			}

			public List<string> DestinationInstanceIds
			{
				get
				{
					return destinationInstanceIds;
				}
				set	
				{
					destinationInstanceIds = value;
				}
			}

			public List<string> MatchAsns
			{
				get
				{
					return matchAsns;
				}
				set	
				{
					matchAsns = value;
				}
			}

			public List<string> OperateCommunitySet
			{
				get
				{
					return operateCommunitySet;
				}
				set	
				{
					operateCommunitySet = value;
				}
			}

			public List<string> SrcZoneIds
			{
				get
				{
					return srcZoneIds;
				}
				set	
				{
					srcZoneIds = value;
				}
			}
		}
	}
}
