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

namespace Aliyun.Acs.dt_oc_info.Model.V20220829
{
	public class GetOcIcEquityFrozenResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcIcEquityFrozen_DataItem> data;

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
			}
		}

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

		public List<GetOcIcEquityFrozen_DataItem> Data
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

		public class GetOcIcEquityFrozen_DataItem
		{

			private string status;

			private string freezeExecPerson;

			private string freezeAmount;

			private string freezeCourt;

			private string freezeNoticeNum;

			private string freezePublishDate;

			private string freezeCardType;

			private string freezeCardNum;

			private string freezeExecItem;

			private string freezeStartDate;

			private string freezeEndDate;

			private string unfreezeCourt;

			private string unfreezeAdjustNum;

			private string unfreezeReason;

			private string unfreezeDate;

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

			public string FreezeExecPerson
			{
				get
				{
					return freezeExecPerson;
				}
				set	
				{
					freezeExecPerson = value;
				}
			}

			public string FreezeAmount
			{
				get
				{
					return freezeAmount;
				}
				set	
				{
					freezeAmount = value;
				}
			}

			public string FreezeCourt
			{
				get
				{
					return freezeCourt;
				}
				set	
				{
					freezeCourt = value;
				}
			}

			public string FreezeNoticeNum
			{
				get
				{
					return freezeNoticeNum;
				}
				set	
				{
					freezeNoticeNum = value;
				}
			}

			public string FreezePublishDate
			{
				get
				{
					return freezePublishDate;
				}
				set	
				{
					freezePublishDate = value;
				}
			}

			public string FreezeCardType
			{
				get
				{
					return freezeCardType;
				}
				set	
				{
					freezeCardType = value;
				}
			}

			public string FreezeCardNum
			{
				get
				{
					return freezeCardNum;
				}
				set	
				{
					freezeCardNum = value;
				}
			}

			public string FreezeExecItem
			{
				get
				{
					return freezeExecItem;
				}
				set	
				{
					freezeExecItem = value;
				}
			}

			public string FreezeStartDate
			{
				get
				{
					return freezeStartDate;
				}
				set	
				{
					freezeStartDate = value;
				}
			}

			public string FreezeEndDate
			{
				get
				{
					return freezeEndDate;
				}
				set	
				{
					freezeEndDate = value;
				}
			}

			public string UnfreezeCourt
			{
				get
				{
					return unfreezeCourt;
				}
				set	
				{
					unfreezeCourt = value;
				}
			}

			public string UnfreezeAdjustNum
			{
				get
				{
					return unfreezeAdjustNum;
				}
				set	
				{
					unfreezeAdjustNum = value;
				}
			}

			public string UnfreezeReason
			{
				get
				{
					return unfreezeReason;
				}
				set	
				{
					unfreezeReason = value;
				}
			}

			public string UnfreezeDate
			{
				get
				{
					return unfreezeDate;
				}
				set	
				{
					unfreezeDate = value;
				}
			}
		}
	}
}
