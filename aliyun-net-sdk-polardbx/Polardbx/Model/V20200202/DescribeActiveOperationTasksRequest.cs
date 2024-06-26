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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.polardbx.Transform;
using Aliyun.Acs.polardbx.Transform.V20200202;

namespace Aliyun.Acs.polardbx.Model.V20200202
{
    public class DescribeActiveOperationTasksRequest : RpcAcsRequest<DescribeActiveOperationTasksResponse>
    {
        public DescribeActiveOperationTasksRequest()
            : base("polardbx", "2020-02-02", "DescribeActiveOperationTasks", "polardbx", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointRegionalType, null);
            }
        }

		private string productId;

		private string changeLevel;

		private long? pageNumber;

		private string insName;

		private long? pageSize;

		private string taskType;

		private long? allowCancel;

		private string dbType;

		private long? allowChange;

		private string region;

		private long? status;

		public string ProductId
		{
			get
			{
				return productId;
			}
			set	
			{
				productId = value;
				DictionaryUtil.Add(QueryParameters, "ProductId", value);
			}
		}

		public string ChangeLevel
		{
			get
			{
				return changeLevel;
			}
			set	
			{
				changeLevel = value;
				DictionaryUtil.Add(QueryParameters, "ChangeLevel", value);
			}
		}

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string InsName
		{
			get
			{
				return insName;
			}
			set	
			{
				insName = value;
				DictionaryUtil.Add(QueryParameters, "InsName", value);
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string TaskType
		{
			get
			{
				return taskType;
			}
			set	
			{
				taskType = value;
				DictionaryUtil.Add(QueryParameters, "TaskType", value);
			}
		}

		public long? AllowCancel
		{
			get
			{
				return allowCancel;
			}
			set	
			{
				allowCancel = value;
				DictionaryUtil.Add(QueryParameters, "AllowCancel", value.ToString());
			}
		}

		public string DbType
		{
			get
			{
				return dbType;
			}
			set	
			{
				dbType = value;
				DictionaryUtil.Add(QueryParameters, "DbType", value);
			}
		}

		public long? AllowChange
		{
			get
			{
				return allowChange;
			}
			set	
			{
				allowChange = value;
				DictionaryUtil.Add(QueryParameters, "AllowChange", value.ToString());
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		public long? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeActiveOperationTasksResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeActiveOperationTasksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
