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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class DeleteDBProxyEndpointAddressRequest : RpcAcsRequest<DeleteDBProxyEndpointAddressResponse>
    {
        public DeleteDBProxyEndpointAddressRequest()
            : base("Rds", "2014-08-15", "DeleteDBProxyEndpointAddress", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dBProxyConnectStringNetType;

		private string dBProxyEndpointId;

		private string dBInstanceId;

		[JsonProperty(PropertyName = "DBProxyConnectStringNetType")]
		public string DBProxyConnectStringNetType
		{
			get
			{
				return dBProxyConnectStringNetType;
			}
			set	
			{
				dBProxyConnectStringNetType = value;
				DictionaryUtil.Add(QueryParameters, "DBProxyConnectStringNetType", value);
			}
		}

		[JsonProperty(PropertyName = "DBProxyEndpointId")]
		public string DBProxyEndpointId
		{
			get
			{
				return dBProxyEndpointId;
			}
			set	
			{
				dBProxyEndpointId = value;
				DictionaryUtil.Add(QueryParameters, "DBProxyEndpointId", value);
			}
		}

		[JsonProperty(PropertyName = "DBInstanceId")]
		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

        public override DeleteDBProxyEndpointAddressResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteDBProxyEndpointAddressResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
