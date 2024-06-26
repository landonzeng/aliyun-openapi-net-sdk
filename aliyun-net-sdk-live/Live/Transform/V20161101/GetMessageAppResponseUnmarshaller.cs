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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class GetMessageAppResponseUnmarshaller
    {
        public static GetMessageAppResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMessageAppResponse getMessageAppResponse = new GetMessageAppResponse();

			getMessageAppResponse.HttpResponse = _ctx.HttpResponse;
			getMessageAppResponse.RequestId = _ctx.StringValue("GetMessageApp.RequestId");

			GetMessageAppResponse.GetMessageApp_Result result = new GetMessageAppResponse.GetMessageApp_Result();
			result.AppConfig = _ctx.StringValue("GetMessageApp.Result.AppConfig");
			result.AppId = _ctx.StringValue("GetMessageApp.Result.AppId");
			result.AppName = _ctx.StringValue("GetMessageApp.Result.AppName");
			result.CreateTime = _ctx.LongValue("GetMessageApp.Result.CreateTime");
			result.Extension = _ctx.StringValue("GetMessageApp.Result.Extension");
			result.Status = _ctx.IntegerValue("GetMessageApp.Result.Status");
			getMessageAppResponse.Result = result;
        
			return getMessageAppResponse;
        }
    }
}
