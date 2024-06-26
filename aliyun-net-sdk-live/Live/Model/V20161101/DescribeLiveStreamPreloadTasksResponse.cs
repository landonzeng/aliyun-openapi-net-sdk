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
	public class DescribeLiveStreamPreloadTasksResponse : AcsResponse
	{

		private int? pageNum;

		private int? pageSize;

		private string requestId;

		private int? totalNum;

		private int? totalPage;

		private List<DescribeLiveStreamPreloadTasks_PreloadTask> preloadTasks;

		[JsonProperty(PropertyName = "PageNum")]
		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "TotalNum")]
		public int? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		[JsonProperty(PropertyName = "TotalPage")]
		public int? TotalPage
		{
			get
			{
				return totalPage;
			}
			set	
			{
				totalPage = value;
			}
		}

		[JsonProperty(PropertyName = "PreloadTasks")]
		public List<DescribeLiveStreamPreloadTasks_PreloadTask> PreloadTasks
		{
			get
			{
				return preloadTasks;
			}
			set	
			{
				preloadTasks = value;
			}
		}

		public class DescribeLiveStreamPreloadTasks_PreloadTask
		{

			private string area;

			private string createTime;

			private string description;

			private string domainName;

			private string playUrl;

			private string preloadedEndTime;

			private string preloadedStartTime;

			private string process;

			private string status;

			private string taskId;

			[JsonProperty(PropertyName = "Area")]
			public string Area
			{
				get
				{
					return area;
				}
				set	
				{
					area = value;
				}
			}

			[JsonProperty(PropertyName = "CreateTime")]
			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
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
				}
			}

			[JsonProperty(PropertyName = "DomainName")]
			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			[JsonProperty(PropertyName = "PlayUrl")]
			public string PlayUrl
			{
				get
				{
					return playUrl;
				}
				set	
				{
					playUrl = value;
				}
			}

			[JsonProperty(PropertyName = "PreloadedEndTime")]
			public string PreloadedEndTime
			{
				get
				{
					return preloadedEndTime;
				}
				set	
				{
					preloadedEndTime = value;
				}
			}

			[JsonProperty(PropertyName = "PreloadedStartTime")]
			public string PreloadedStartTime
			{
				get
				{
					return preloadedStartTime;
				}
				set	
				{
					preloadedStartTime = value;
				}
			}

			[JsonProperty(PropertyName = "Process")]
			public string Process
			{
				get
				{
					return process;
				}
				set	
				{
					process = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "TaskId")]
			public string TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
				}
			}
		}
	}
}
