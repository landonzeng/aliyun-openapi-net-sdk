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
using Aliyun.Acs.Linkvisual.Transform;
using Aliyun.Acs.Linkvisual.Transform.V20180120;

namespace Aliyun.Acs.Linkvisual.Model.V20180120
{
    public class DeleteFaceDeviceGroupRequest : RpcAcsRequest<DeleteFaceDeviceGroupResponse>
    {
        public DeleteFaceDeviceGroupRequest()
            : base("Linkvisual", "2018-01-20", "DeleteFaceDeviceGroup", "Linkvisual", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Linkvisual.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Linkvisual.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string isolationId;

		private string deviceGroupId;

		public string IsolationId
		{
			get
			{
				return isolationId;
			}
			set	
			{
				isolationId = value;
				DictionaryUtil.Add(QueryParameters, "IsolationId", value);
			}
		}

		public string DeviceGroupId
		{
			get
			{
				return deviceGroupId;
			}
			set	
			{
				deviceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "DeviceGroupId", value);
			}
		}

        public override DeleteFaceDeviceGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteFaceDeviceGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
