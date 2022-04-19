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
    public class InstallCloudMonitorRequest : RpcAcsRequest<InstallCloudMonitorResponse>
    {
        public InstallCloudMonitorRequest()
            : base("Sas", "2018-12-03", "InstallCloudMonitor")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string agentAccessKey;

		private string agentSecretKey;

		private List<string> uuidLists = new List<string>(){ };

		private string argusVersion;

		private List<string> instanceIdLists = new List<string>(){ };

		public string AgentAccessKey
		{
			get
			{
				return agentAccessKey;
			}
			set	
			{
				agentAccessKey = value;
				DictionaryUtil.Add(QueryParameters, "AgentAccessKey", value);
			}
		}

		public string AgentSecretKey
		{
			get
			{
				return agentSecretKey;
			}
			set	
			{
				agentSecretKey = value;
				DictionaryUtil.Add(QueryParameters, "AgentSecretKey", value);
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

		public string ArgusVersion
		{
			get
			{
				return argusVersion;
			}
			set	
			{
				argusVersion = value;
				DictionaryUtil.Add(QueryParameters, "ArgusVersion", value);
			}
		}

		public List<string> InstanceIdLists
		{
			get
			{
				return instanceIdLists;
			}

			set
			{
				instanceIdLists = value;
				for (int i = 0; i < instanceIdLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceIdList." + (i + 1) , instanceIdLists[i]);
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override InstallCloudMonitorResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InstallCloudMonitorResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
