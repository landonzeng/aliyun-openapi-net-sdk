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
	public class ListPlaylistResponse : AcsResponse
	{

		private int? total;

		private string requestId;

		private List<ListPlaylist_ProgramInfo> programList;

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

		public List<ListPlaylist_ProgramInfo> ProgramList
		{
			get
			{
				return programList;
			}
			set	
			{
				programList = value;
			}
		}

		public class ListPlaylist_ProgramInfo
		{

			private int? status;

			private int? repeatNumber;

			private string programName;

			private string programId;

			private string casterId;

			private string domainName;

			public int? Status
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

			public int? RepeatNumber
			{
				get
				{
					return repeatNumber;
				}
				set	
				{
					repeatNumber = value;
				}
			}

			public string ProgramName
			{
				get
				{
					return programName;
				}
				set	
				{
					programName = value;
				}
			}

			public string ProgramId
			{
				get
				{
					return programId;
				}
				set	
				{
					programId = value;
				}
			}

			public string CasterId
			{
				get
				{
					return casterId;
				}
				set	
				{
					casterId = value;
				}
			}

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
		}
	}
}
