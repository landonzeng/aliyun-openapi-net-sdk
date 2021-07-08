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
using Aliyun.Acs.Cassandra.Model.V20190101;

namespace Aliyun.Acs.Cassandra.Transform.V20190101
{
    public class DescribeIpWhitelistResponseUnmarshaller
    {
        public static DescribeIpWhitelistResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIpWhitelistResponse describeIpWhitelistResponse = new DescribeIpWhitelistResponse();

			describeIpWhitelistResponse.HttpResponse = _ctx.HttpResponse;
			describeIpWhitelistResponse.RequestId = _ctx.StringValue("DescribeIpWhitelist.RequestId");

			List<string> describeIpWhitelistResponse_ipList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeIpWhitelist.IpList.Length"); i++) {
				describeIpWhitelistResponse_ipList.Add(_ctx.StringValue("DescribeIpWhitelist.IpList["+ i +"]"));
			}
			describeIpWhitelistResponse.IpList = describeIpWhitelistResponse_ipList;
        
			return describeIpWhitelistResponse;
        }
    }
}
