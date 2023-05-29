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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribeProjectMessagesResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private bool? success;

		private List<DescribeProjectMessages_ProjectMessage> result;

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

		[JsonProperty(PropertyName = "TotalCount")]
		public long? TotalCount
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "Result")]
		public List<DescribeProjectMessages_ProjectMessage> Result
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

		public class DescribeProjectMessages_ProjectMessage
		{

			private long? gmtCreate;

			private long? _operator;

			private string operatorRole;

			private string content;

			private string operatorName;

			[JsonProperty(PropertyName = "GmtCreate")]
			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			[JsonProperty(PropertyName = "_Operator")]
			public long? _Operator
			{
				get
				{
					return _operator;
				}
				set	
				{
					_operator = value;
				}
			}

			[JsonProperty(PropertyName = "OperatorRole")]
			public string OperatorRole
			{
				get
				{
					return operatorRole;
				}
				set	
				{
					operatorRole = value;
				}
			}

			[JsonProperty(PropertyName = "Content")]
			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			[JsonProperty(PropertyName = "OperatorName")]
			public string OperatorName
			{
				get
				{
					return operatorName;
				}
				set	
				{
					operatorName = value;
				}
			}
		}
	}
}
