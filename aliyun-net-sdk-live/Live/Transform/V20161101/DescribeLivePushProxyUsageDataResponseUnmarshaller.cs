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
    public class DescribeLivePushProxyUsageDataResponseUnmarshaller
    {
        public static DescribeLivePushProxyUsageDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLivePushProxyUsageDataResponse describeLivePushProxyUsageDataResponse = new DescribeLivePushProxyUsageDataResponse();

			describeLivePushProxyUsageDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLivePushProxyUsageDataResponse.EndTime = _ctx.StringValue("DescribeLivePushProxyUsageData.EndTime");
			describeLivePushProxyUsageDataResponse.RequestId = _ctx.StringValue("DescribeLivePushProxyUsageData.RequestId");
			describeLivePushProxyUsageDataResponse.StartTime = _ctx.StringValue("DescribeLivePushProxyUsageData.StartTime");

			List<DescribeLivePushProxyUsageDataResponse.DescribeLivePushProxyUsageData_PushProxyDataItem> describeLivePushProxyUsageDataResponse_pushProxyData = new List<DescribeLivePushProxyUsageDataResponse.DescribeLivePushProxyUsageData_PushProxyDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeLivePushProxyUsageData.PushProxyData.Length"); i++) {
				DescribeLivePushProxyUsageDataResponse.DescribeLivePushProxyUsageData_PushProxyDataItem pushProxyDataItem = new DescribeLivePushProxyUsageDataResponse.DescribeLivePushProxyUsageData_PushProxyDataItem();
				pushProxyDataItem.DomainName = _ctx.StringValue("DescribeLivePushProxyUsageData.PushProxyData["+ i +"].DomainName");
				pushProxyDataItem.Region = _ctx.StringValue("DescribeLivePushProxyUsageData.PushProxyData["+ i +"].Region");
				pushProxyDataItem.StreamCount = _ctx.LongValue("DescribeLivePushProxyUsageData.PushProxyData["+ i +"].StreamCount");
				pushProxyDataItem.TimeStamp = _ctx.StringValue("DescribeLivePushProxyUsageData.PushProxyData["+ i +"].TimeStamp");

				describeLivePushProxyUsageDataResponse_pushProxyData.Add(pushProxyDataItem);
			}
			describeLivePushProxyUsageDataResponse.PushProxyData = describeLivePushProxyUsageDataResponse_pushProxyData;
        
			return describeLivePushProxyUsageDataResponse;
        }
    }
}
