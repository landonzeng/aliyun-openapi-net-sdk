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
	public class QueryDeviceRecordLifeCycleResponse : AcsResponse
	{

		private int? code;

		private string requestId;

		private string errorMessage;

		private bool? success;

		private List<QueryDeviceRecordLifeCycle_DataItem> data;

		public int? Code
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

		public List<QueryDeviceRecordLifeCycle_DataItem> Data
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

		public class QueryDeviceRecordLifeCycle_DataItem
		{

			private int? day;

			private string iotId;

			public int? Day
			{
				get
				{
					return day;
				}
				set	
				{
					day = value;
				}
			}

			public string IotId
			{
				get
				{
					return iotId;
				}
				set	
				{
					iotId = value;
				}
			}
		}
	}
}
