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

namespace Aliyun.Acs.Linkvisual.Model.V20180120
{
	public class QueryDeviceEventResponse : AcsResponse
	{

		private string code;

		private string requestId;

		private string errorMessage;

		private bool? success;

		private QueryDeviceEvent_Data data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public QueryDeviceEvent_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryDeviceEvent_Data
		{

			private int? pageSize;

			private int? pageCount;

			private int? total;

			private int? page;

			private List<QueryDeviceEvent_ListItem> list;

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

			public int? PageCount
			{
				get
				{
					return pageCount;
				}
				set	
				{
					pageCount = value;
				}
			}

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public int? Page
			{
				get
				{
					return page;
				}
				set	
				{
					page = value;
				}
			}

			public List<QueryDeviceEvent_ListItem> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class QueryDeviceEvent_ListItem
			{

				private string eventId;

				private string eventTime;

				private int? eventType;

				private string eventPicId;

				private string eventDesc;

				private string eventData;

				public string EventId
				{
					get
					{
						return eventId;
					}
					set	
					{
						eventId = value;
					}
				}

				public string EventTime
				{
					get
					{
						return eventTime;
					}
					set	
					{
						eventTime = value;
					}
				}

				public int? EventType
				{
					get
					{
						return eventType;
					}
					set	
					{
						eventType = value;
					}
				}

				public string EventPicId
				{
					get
					{
						return eventPicId;
					}
					set	
					{
						eventPicId = value;
					}
				}

				public string EventDesc
				{
					get
					{
						return eventDesc;
					}
					set	
					{
						eventDesc = value;
					}
				}

				public string EventData
				{
					get
					{
						return eventData;
					}
					set	
					{
						eventData = value;
					}
				}
			}
		}
	}
}
