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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeOssCallbackSettingResponseUnmarshaller
    {
        public static DescribeOssCallbackSettingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOssCallbackSettingResponse describeOssCallbackSettingResponse = new DescribeOssCallbackSettingResponse();

			describeOssCallbackSettingResponse.HttpResponse = _ctx.HttpResponse;
			describeOssCallbackSettingResponse.AuditCallback = _ctx.BooleanValue("DescribeOssCallbackSetting.AuditCallback");
			describeOssCallbackSettingResponse.CallbackUrl = _ctx.StringValue("DescribeOssCallbackSetting.CallbackUrl");
			describeOssCallbackSettingResponse.RequestId = _ctx.StringValue("DescribeOssCallbackSetting.RequestId");
			describeOssCallbackSettingResponse.ScanCallback = _ctx.BooleanValue("DescribeOssCallbackSetting.ScanCallback");
			describeOssCallbackSettingResponse.CallbackSeed = _ctx.StringValue("DescribeOssCallbackSetting.CallbackSeed");

			List<string> describeOssCallbackSettingResponse_scanCallbackSuggestions = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssCallbackSetting.ScanCallbackSuggestions.Length"); i++) {
				describeOssCallbackSettingResponse_scanCallbackSuggestions.Add(_ctx.StringValue("DescribeOssCallbackSetting.ScanCallbackSuggestions["+ i +"]"));
			}
			describeOssCallbackSettingResponse.ScanCallbackSuggestions = describeOssCallbackSettingResponse_scanCallbackSuggestions;

			List<string> describeOssCallbackSettingResponse_serviceModules = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssCallbackSetting.ServiceModules.Length"); i++) {
				describeOssCallbackSettingResponse_serviceModules.Add(_ctx.StringValue("DescribeOssCallbackSetting.ServiceModules["+ i +"]"));
			}
			describeOssCallbackSettingResponse.ServiceModules = describeOssCallbackSettingResponse_serviceModules;
        
			return describeOssCallbackSettingResponse;
        }
    }
}
