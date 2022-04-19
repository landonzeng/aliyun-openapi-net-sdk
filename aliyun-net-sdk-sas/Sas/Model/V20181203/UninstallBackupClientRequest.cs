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
    public class UninstallBackupClientRequest : RpcAcsRequest<UninstallBackupClientResponse>
    {
        public UninstallBackupClientRequest()
            : base("Sas", "2018-12-03", "UninstallBackupClient")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string uuid;

		private List<string> uuidLists = new List<string>(){ };

		private string policyVersion;

		public string Uuid
		{
			get
			{
				return uuid;
			}
			set	
			{
				uuid = value;
				DictionaryUtil.Add(QueryParameters, "Uuid", value);
			}
		}

		public List<string> UuidLists
		{
			get
			{
				return uuidLists;
			}

			set
			{
				uuidLists = value;
				for (int i = 0; i < uuidLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"UuidList." + (i + 1) , uuidLists[i]);
				}
			}
		}

		public string PolicyVersion
		{
			get
			{
				return policyVersion;
			}
			set	
			{
				policyVersion = value;
				DictionaryUtil.Add(QueryParameters, "PolicyVersion", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UninstallBackupClientResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UninstallBackupClientResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
