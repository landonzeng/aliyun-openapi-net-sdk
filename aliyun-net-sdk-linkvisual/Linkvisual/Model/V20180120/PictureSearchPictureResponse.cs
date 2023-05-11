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
	public class PictureSearchPictureResponse : AcsResponse
	{

		private string code;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private PictureSearchPicture_Data data;

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

		public PictureSearchPicture_Data Data
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

		public class PictureSearchPicture_Data
		{

			private int? currentPage;

			private int? pageSize;

			private int? total;

			private int? pageCount;

			private List<PictureSearchPicture_SearchData> pageData;

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}

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

			public List<PictureSearchPicture_SearchData> PageData
			{
				get
				{
					return pageData;
				}
				set	
				{
					pageData = value;
				}
			}

			public class PictureSearchPicture_SearchData
			{

				private string picUrl;

				private long? eventTime;

				private string gatewayIotId;

				private string vectorId;

				private float? threshold;

				private int? vectorType;

				private string iotId;

				public string PicUrl
				{
					get
					{
						return picUrl;
					}
					set	
					{
						picUrl = value;
					}
				}

				public long? EventTime
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

				public string GatewayIotId
				{
					get
					{
						return gatewayIotId;
					}
					set	
					{
						gatewayIotId = value;
					}
				}

				public string VectorId
				{
					get
					{
						return vectorId;
					}
					set	
					{
						vectorId = value;
					}
				}

				public float? Threshold
				{
					get
					{
						return threshold;
					}
					set	
					{
						threshold = value;
					}
				}

				public int? VectorType
				{
					get
					{
						return vectorType;
					}
					set	
					{
						vectorType = value;
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
}
