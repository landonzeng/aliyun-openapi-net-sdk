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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class PreCheckCreateOrderForDeleteDBNodesResponseUnmarshaller
    {
        public static PreCheckCreateOrderForDeleteDBNodesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PreCheckCreateOrderForDeleteDBNodesResponse preCheckCreateOrderForDeleteDBNodesResponse = new PreCheckCreateOrderForDeleteDBNodesResponse();

			preCheckCreateOrderForDeleteDBNodesResponse.HttpResponse = _ctx.HttpResponse;
			preCheckCreateOrderForDeleteDBNodesResponse.PreCheckResult = _ctx.BooleanValue("PreCheckCreateOrderForDeleteDBNodes.PreCheckResult");
			preCheckCreateOrderForDeleteDBNodesResponse.RequestId = _ctx.StringValue("PreCheckCreateOrderForDeleteDBNodes.RequestId");

			List<PreCheckCreateOrderForDeleteDBNodesResponse.PreCheckCreateOrderForDeleteDBNodes_FailuresItem> preCheckCreateOrderForDeleteDBNodesResponse_failures = new List<PreCheckCreateOrderForDeleteDBNodesResponse.PreCheckCreateOrderForDeleteDBNodes_FailuresItem>();
			for (int i = 0; i < _ctx.Length("PreCheckCreateOrderForDeleteDBNodes.Failures.Length"); i++) {
				PreCheckCreateOrderForDeleteDBNodesResponse.PreCheckCreateOrderForDeleteDBNodes_FailuresItem failuresItem = new PreCheckCreateOrderForDeleteDBNodesResponse.PreCheckCreateOrderForDeleteDBNodes_FailuresItem();
				failuresItem.Code = _ctx.StringValue("PreCheckCreateOrderForDeleteDBNodes.Failures["+ i +"].Code");
				failuresItem.Message = _ctx.StringValue("PreCheckCreateOrderForDeleteDBNodes.Failures["+ i +"].Message");

				preCheckCreateOrderForDeleteDBNodesResponse_failures.Add(failuresItem);
			}
			preCheckCreateOrderForDeleteDBNodesResponse.Failures = preCheckCreateOrderForDeleteDBNodesResponse_failures;
        
			return preCheckCreateOrderForDeleteDBNodesResponse;
        }
    }
}
