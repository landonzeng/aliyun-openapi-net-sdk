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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class UpdateK8sSecretResponseUnmarshaller
    {
        public static UpdateK8sSecretResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateK8sSecretResponse updateK8sSecretResponse = new UpdateK8sSecretResponse();

			updateK8sSecretResponse.HttpResponse = _ctx.HttpResponse;
			updateK8sSecretResponse.RequestId = _ctx.StringValue("UpdateK8sSecret.RequestId");
			updateK8sSecretResponse.Code = _ctx.IntegerValue("UpdateK8sSecret.Code");
			updateK8sSecretResponse.Message = _ctx.StringValue("UpdateK8sSecret.Message");
        
			return updateK8sSecretResponse;
        }
    }
}
