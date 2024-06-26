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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodDomainRealTimeByteHitRateDataResponseUnmarshaller
    {
        public static DescribeVodDomainRealTimeByteHitRateDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodDomainRealTimeByteHitRateDataResponse describeVodDomainRealTimeByteHitRateDataResponse = new DescribeVodDomainRealTimeByteHitRateDataResponse();

			describeVodDomainRealTimeByteHitRateDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVodDomainRealTimeByteHitRateDataResponse.RequestId = _ctx.StringValue("DescribeVodDomainRealTimeByteHitRateData.RequestId");

			List<DescribeVodDomainRealTimeByteHitRateDataResponse.DescribeVodDomainRealTimeByteHitRateData_ByteHitRateDataModel> describeVodDomainRealTimeByteHitRateDataResponse_data = new List<DescribeVodDomainRealTimeByteHitRateDataResponse.DescribeVodDomainRealTimeByteHitRateData_ByteHitRateDataModel>();
			for (int i = 0; i < _ctx.Length("DescribeVodDomainRealTimeByteHitRateData.Data.Length"); i++) {
				DescribeVodDomainRealTimeByteHitRateDataResponse.DescribeVodDomainRealTimeByteHitRateData_ByteHitRateDataModel byteHitRateDataModel = new DescribeVodDomainRealTimeByteHitRateDataResponse.DescribeVodDomainRealTimeByteHitRateData_ByteHitRateDataModel();
				byteHitRateDataModel.ByteHitRate = _ctx.FloatValue("DescribeVodDomainRealTimeByteHitRateData.Data["+ i +"].ByteHitRate");
				byteHitRateDataModel.TimeStamp = _ctx.StringValue("DescribeVodDomainRealTimeByteHitRateData.Data["+ i +"].TimeStamp");

				describeVodDomainRealTimeByteHitRateDataResponse_data.Add(byteHitRateDataModel);
			}
			describeVodDomainRealTimeByteHitRateDataResponse.Data = describeVodDomainRealTimeByteHitRateDataResponse_data;
        
			return describeVodDomainRealTimeByteHitRateDataResponse;
        }
    }
}
