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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class GetBackupStorageCountResponse : AcsResponse
	{

		private string requestId;

		private GetBackupStorageCount_BackupStorageCount backupStorageCount;

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

		public GetBackupStorageCount_BackupStorageCount BackupStorageCount
		{
			get
			{
				return backupStorageCount;
			}
			set	
			{
				backupStorageCount = value;
			}
		}

		public class GetBackupStorageCount_BackupStorageCount
		{

			private long? buyStorageByte;

			private long? usageStorageByte;

			private long? ecsUsageStorageByte;

			private long? uniUsageStorageByte;

			private int? overflow;

			public long? BuyStorageByte
			{
				get
				{
					return buyStorageByte;
				}
				set	
				{
					buyStorageByte = value;
				}
			}

			public long? UsageStorageByte
			{
				get
				{
					return usageStorageByte;
				}
				set	
				{
					usageStorageByte = value;
				}
			}

			public long? EcsUsageStorageByte
			{
				get
				{
					return ecsUsageStorageByte;
				}
				set	
				{
					ecsUsageStorageByte = value;
				}
			}

			public long? UniUsageStorageByte
			{
				get
				{
					return uniUsageStorageByte;
				}
				set	
				{
					uniUsageStorageByte = value;
				}
			}

			public int? Overflow
			{
				get
				{
					return overflow;
				}
				set	
				{
					overflow = value;
				}
			}
		}
	}
}
