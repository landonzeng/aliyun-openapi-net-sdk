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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.viapi_regen.Model.V20211119;

namespace Aliyun.Acs.viapi_regen.Transform.V20211119
{
    public class DisableDataReflowResponseUnmarshaller
    {
        public static DisableDataReflowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DisableDataReflowResponse disableDataReflowResponse = new DisableDataReflowResponse();

			disableDataReflowResponse.HttpResponse = _ctx.HttpResponse;
			disableDataReflowResponse.Message = _ctx.StringValue("DisableDataReflow.Message");
			disableDataReflowResponse.RequestId = _ctx.StringValue("DisableDataReflow.RequestId");
			disableDataReflowResponse.Code = _ctx.StringValue("DisableDataReflow.Code");

			DisableDataReflowResponse.DisableDataReflow_Data data = new DisableDataReflowResponse.DisableDataReflow_Data();
			data.ServiceId = _ctx.LongValue("DisableDataReflow.Data.ServiceId");
			data.EnableDataReflowFlag = _ctx.BooleanValue("DisableDataReflow.Data.EnableDataReflowFlag");
			disableDataReflowResponse.Data = data;
        
			return disableDataReflowResponse;
        }
    }
}
