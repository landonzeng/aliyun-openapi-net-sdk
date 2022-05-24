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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeBinlogFilesResponse : AcsResponse
	{

		private long? totalFileSize;

		private int? pageNumber;

		private string requestId;

		private int? pageRecordCount;

		private int? totalRecordCount;

		private List<DescribeBinlogFiles_BinLogFile> items;

		[JsonProperty(PropertyName = "TotalFileSize")]
		public long? TotalFileSize
		{
			get
			{
				return totalFileSize;
			}
			set	
			{
				totalFileSize = value;
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "PageRecordCount")]
		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		[JsonProperty(PropertyName = "TotalRecordCount")]
		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeBinlogFiles_BinLogFile> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeBinlogFiles_BinLogFile
		{

			private string remoteStatus;

			private string intranetDownloadLink;

			private string logBeginTime;

			private string linkExpiredTime;

			private string downloadLink;

			private string logFileName;

			private string checksum;

			private string logEndTime;

			private string hostInstanceID;

			private long? fileSize;

			[JsonProperty(PropertyName = "RemoteStatus")]
			public string RemoteStatus
			{
				get
				{
					return remoteStatus;
				}
				set	
				{
					remoteStatus = value;
				}
			}

			[JsonProperty(PropertyName = "IntranetDownloadLink")]
			public string IntranetDownloadLink
			{
				get
				{
					return intranetDownloadLink;
				}
				set	
				{
					intranetDownloadLink = value;
				}
			}

			[JsonProperty(PropertyName = "LogBeginTime")]
			public string LogBeginTime
			{
				get
				{
					return logBeginTime;
				}
				set	
				{
					logBeginTime = value;
				}
			}

			[JsonProperty(PropertyName = "LinkExpiredTime")]
			public string LinkExpiredTime
			{
				get
				{
					return linkExpiredTime;
				}
				set	
				{
					linkExpiredTime = value;
				}
			}

			[JsonProperty(PropertyName = "DownloadLink")]
			public string DownloadLink
			{
				get
				{
					return downloadLink;
				}
				set	
				{
					downloadLink = value;
				}
			}

			[JsonProperty(PropertyName = "LogFileName")]
			public string LogFileName
			{
				get
				{
					return logFileName;
				}
				set	
				{
					logFileName = value;
				}
			}

			[JsonProperty(PropertyName = "Checksum")]
			public string Checksum
			{
				get
				{
					return checksum;
				}
				set	
				{
					checksum = value;
				}
			}

			[JsonProperty(PropertyName = "LogEndTime")]
			public string LogEndTime
			{
				get
				{
					return logEndTime;
				}
				set	
				{
					logEndTime = value;
				}
			}

			[JsonProperty(PropertyName = "HostInstanceID")]
			public string HostInstanceID
			{
				get
				{
					return hostInstanceID;
				}
				set	
				{
					hostInstanceID = value;
				}
			}

			[JsonProperty(PropertyName = "FileSize")]
			public long? FileSize
			{
				get
				{
					return fileSize;
				}
				set	
				{
					fileSize = value;
				}
			}
		}
	}
}
