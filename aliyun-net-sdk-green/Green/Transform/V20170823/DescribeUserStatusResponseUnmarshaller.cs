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
    public class DescribeUserStatusResponseUnmarshaller
    {
        public static DescribeUserStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUserStatusResponse describeUserStatusResponse = new DescribeUserStatusResponse();

			describeUserStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeUserStatusResponse.OssVideoSizeLimit = _ctx.IntegerValue("DescribeUserStatus.OssVideoSizeLimit");
			describeUserStatusResponse.OssCheckStatus = _ctx.StringValue("DescribeUserStatus.OssCheckStatus");
			describeUserStatusResponse.RequestId = _ctx.StringValue("DescribeUserStatus.RequestId");
			describeUserStatusResponse.InDept = _ctx.BooleanValue("DescribeUserStatus.InDept");
			describeUserStatusResponse.OpenApiBeginTime = _ctx.StringValue("DescribeUserStatus.OpenApiBeginTime");
			describeUserStatusResponse.Buyed = _ctx.BooleanValue("DescribeUserStatus.Buyed");
			describeUserStatusResponse.OpenApiUsed = _ctx.BooleanValue("DescribeUserStatus.OpenApiUsed");
			describeUserStatusResponse.Uid = _ctx.StringValue("DescribeUserStatus.Uid");
			describeUserStatusResponse.AgreeChannel = _ctx.IntegerValue("DescribeUserStatus.AgreeChannel");
        
			return describeUserStatusResponse;
        }
    }
}
