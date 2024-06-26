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
    public class RetryDatabaseRequest : RpcAcsRequest<RetryDatabaseResponse>
    {
        public RetryDatabaseRequest()
            : base("dms-dg", "2023-09-14", "RetryDatabase")
        {
			Method = MethodType.POST;
        }

		private string clientToken;

		private string host;

		private string dbUserName;

		private string dbDescription;

		private string gatewayId;

		private string dbName;

		private int? port;

		private string dbPassword;

		private string dbType;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(BodyParameters, "ClientToken", value);
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

		public string DbUserName
		{
			get
			{
				return dbUserName;
			}
			set	
			{
				dbUserName = value;
				DictionaryUtil.Add(BodyParameters, "DbUserName", value);
			}
		}

		public string DbDescription
		{
			get
			{
				return dbDescription;
			}
			set	
			{
				dbDescription = value;
				DictionaryUtil.Add(BodyParameters, "DbDescription", value);
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

		public string DbName
		{
			get
			{
				return dbName;
			}
			set	
			{
				dbName = value;
				DictionaryUtil.Add(BodyParameters, "DbName", value);
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

		public string DbPassword
		{
			get
			{
				return dbPassword;
			}
			set	
			{
				dbPassword = value;
				DictionaryUtil.Add(BodyParameters, "DbPassword", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RetryDatabaseResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RetryDatabaseResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
