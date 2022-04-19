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
using Aliyun.Acs.Sas;
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class ModifyCreateVulWhitelistRequest : RpcAcsRequest<ModifyCreateVulWhitelistResponse>
    {
        public ModifyCreateVulWhitelistRequest()
            : base("Sas", "2018-12-03", "ModifyCreateVulWhitelist")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string reason;

		private string whitelist;

		private string targetInfo;

		public string Reason
		{
			get
			{
				return reason;
			}
			set	
			{
				reason = value;
				DictionaryUtil.Add(QueryParameters, "Reason", value);
			}
		}

		public string Whitelist
		{
			get
			{
				return whitelist;
			}
			set	
			{
				whitelist = value;
				DictionaryUtil.Add(QueryParameters, "Whitelist", value);
			}
		}

		public string TargetInfo
		{
			get
			{
				return targetInfo;
			}
			set	
			{
				targetInfo = value;
				DictionaryUtil.Add(QueryParameters, "TargetInfo", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyCreateVulWhitelistResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyCreateVulWhitelistResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
