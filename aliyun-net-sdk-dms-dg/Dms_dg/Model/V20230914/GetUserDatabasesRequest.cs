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
using Aliyun.Acs.dms_dg;
using Aliyun.Acs.dms_dg.Transform;
using Aliyun.Acs.dms_dg.Transform.V20230914;

namespace Aliyun.Acs.dms_dg.Model.V20230914
{
    public class GetUserDatabasesRequest : RpcAcsRequest<GetUserDatabasesResponse>
    {
        public GetUserDatabasesRequest()
            : base("dms-dg", "2023-09-14", "GetUserDatabases")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string searchKey;

		private string pageNumber;

		private string pageSize;

		private string host;

		private string gatewayId;

		private string instanceId;

		private int? port;

		private string dbType;

		public string SearchKey
		{
			get
			{
				return searchKey;
			}
			set	
			{
				searchKey = value;
				DictionaryUtil.Add(BodyParameters, "SearchKey", value);
			}
		}

		public string PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value);
			}
		}

		public string PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value);
			}
		}

		public string Host
		{
			get
			{
				return host;
			}
			set	
			{
				host = value;
				DictionaryUtil.Add(BodyParameters, "Host", value);
			}
		}

		public string GatewayId
		{
			get
			{
				return gatewayId;
			}
			set	
			{
				gatewayId = value;
				DictionaryUtil.Add(BodyParameters, "GatewayId", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(BodyParameters, "InstanceId", value);
			}
		}

		public int? Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
				DictionaryUtil.Add(BodyParameters, "Port", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "DbType", value);
			}
		}

        public override GetUserDatabasesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetUserDatabasesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
