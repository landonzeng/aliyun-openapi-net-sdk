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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class BatchGetOnlineUsersResponse : AcsResponse
	{

		private string requestId;

		private BatchGetOnlineUsers_Result result;

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

		[JsonProperty(PropertyName = "Result")]
		public BatchGetOnlineUsers_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class BatchGetOnlineUsers_Result
		{

			private List<BatchGetOnlineUsers_OnlineUsersItem> onlineUsers;

			[JsonProperty(PropertyName = "OnlineUsers")]
			public List<BatchGetOnlineUsers_OnlineUsersItem> OnlineUsers
			{
				get
				{
					return onlineUsers;
				}
				set	
				{
					onlineUsers = value;
				}
			}

			public class BatchGetOnlineUsers_OnlineUsersItem
			{

				private long? joinTime;

				private bool? online;

				private string userId;

				[JsonProperty(PropertyName = "JoinTime")]
				public long? JoinTime
				{
					get
					{
						return joinTime;
					}
					set	
					{
						joinTime = value;
					}
				}

				[JsonProperty(PropertyName = "Online")]
				public bool? Online
				{
					get
					{
						return online;
					}
					set	
					{
						online = value;
					}
				}

				[JsonProperty(PropertyName = "UserId")]
				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}
			}
		}
	}
}
