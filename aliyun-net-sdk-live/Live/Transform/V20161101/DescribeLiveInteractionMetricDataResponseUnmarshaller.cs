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
    public class DescribeLiveInteractionMetricDataResponseUnmarshaller
    {
        public static DescribeLiveInteractionMetricDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveInteractionMetricDataResponse describeLiveInteractionMetricDataResponse = new DescribeLiveInteractionMetricDataResponse();

			describeLiveInteractionMetricDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveInteractionMetricDataResponse.RequestId = _ctx.StringValue("DescribeLiveInteractionMetricData.RequestId");
			describeLiveInteractionMetricDataResponse.SummaryData = _ctx.StringValue("DescribeLiveInteractionMetricData.SummaryData");

			List<DescribeLiveInteractionMetricDataResponse.DescribeLiveInteractionMetricData_Data> describeLiveInteractionMetricDataResponse_nodes = new List<DescribeLiveInteractionMetricDataResponse.DescribeLiveInteractionMetricData_Data>();
			for (int i = 0; i < _ctx.Length("DescribeLiveInteractionMetricData.Nodes.Length"); i++) {
				DescribeLiveInteractionMetricDataResponse.DescribeLiveInteractionMetricData_Data data = new DescribeLiveInteractionMetricDataResponse.DescribeLiveInteractionMetricData_Data();
				data.Timestamp = _ctx.StringValue("DescribeLiveInteractionMetricData.Nodes["+ i +"].Timestamp");
				data._Value = _ctx.StringValue("DescribeLiveInteractionMetricData.Nodes["+ i +"].Value");

				describeLiveInteractionMetricDataResponse_nodes.Add(data);
			}
			describeLiveInteractionMetricDataResponse.Nodes = describeLiveInteractionMetricDataResponse_nodes;
        
			return describeLiveInteractionMetricDataResponse;
        }
    }
}
