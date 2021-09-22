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
using Aliyun.Acs.Dypnsapi;
using Aliyun.Acs.Dypnsapi.Transform;
using Aliyun.Acs.Dypnsapi.Transform.V20170525;

namespace Aliyun.Acs.Dypnsapi.Model.V20170525
{
    public class GetSmsCodeRequest : RpcAcsRequest<GetSmsCodeResponse>
    {
        public GetSmsCodeRequest()
            : base("Dypnsapi", "2017-05-25", "GetSmsCode")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dypnsapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dypnsapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string phoneNumber;

		private string bizToken;

		private string sceneCode;

		private string osType;

		public string PhoneNumber
		{
			get
			{
				return phoneNumber;
			}
			set	
			{
				phoneNumber = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNumber", value);
			}
		}

		public string BizToken
		{
			get
			{
				return bizToken;
			}
			set	
			{
				bizToken = value;
				DictionaryUtil.Add(QueryParameters, "BizToken", value);
			}
		}

		public string SceneCode
		{
			get
			{
				return sceneCode;
			}
			set	
			{
				sceneCode = value;
				DictionaryUtil.Add(QueryParameters, "SceneCode", value);
			}
		}

		public string OsType
		{
			get
			{
				return osType;
			}
			set	
			{
				osType = value;
				DictionaryUtil.Add(QueryParameters, "OsType", value);
			}
		}

        public override GetSmsCodeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetSmsCodeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
