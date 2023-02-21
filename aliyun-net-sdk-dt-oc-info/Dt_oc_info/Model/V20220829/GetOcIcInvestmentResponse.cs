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
	public class GetOcIcInvestmentResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcIcInvestment_DataItem> data;

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

		public List<GetOcIcInvestment_DataItem> Data
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

		public class GetOcIcInvestment_DataItem
		{

			private string entName;

			private string investName;

			private string investCreditCode;

			private string investLicenseNo;

			private string investEsDate;

			private string investLegalName;

			private string investRegCap;

			private string investStatus;

			private string shouldCap;

			private string stockPercentage;

			public string EntName
			{
				get
				{
					return entName;
				}
				set	
				{
					entName = value;
				}
			}

			public string InvestName
			{
				get
				{
					return investName;
				}
				set	
				{
					investName = value;
				}
			}

			public string InvestCreditCode
			{
				get
				{
					return investCreditCode;
				}
				set	
				{
					investCreditCode = value;
				}
			}

			public string InvestLicenseNo
			{
				get
				{
					return investLicenseNo;
				}
				set	
				{
					investLicenseNo = value;
				}
			}

			public string InvestEsDate
			{
				get
				{
					return investEsDate;
				}
				set	
				{
					investEsDate = value;
				}
			}

			public string InvestLegalName
			{
				get
				{
					return investLegalName;
				}
				set	
				{
					investLegalName = value;
				}
			}

			public string InvestRegCap
			{
				get
				{
					return investRegCap;
				}
				set	
				{
					investRegCap = value;
				}
			}

			public string InvestStatus
			{
				get
				{
					return investStatus;
				}
				set	
				{
					investStatus = value;
				}
			}

			public string ShouldCap
			{
				get
				{
					return shouldCap;
				}
				set	
				{
					shouldCap = value;
				}
			}

			public string StockPercentage
			{
				get
				{
					return stockPercentage;
				}
				set	
				{
					stockPercentage = value;
				}
			}
		}
	}
}
