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
using Aliyun.Acs.dms_dg.Model.V20230914;

namespace Aliyun.Acs.dms_dg.Transform.V20230914
{
    public class ConnectDatabaseResponseUnmarshaller
    {
        public static ConnectDatabaseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ConnectDatabaseResponse connectDatabaseResponse = new ConnectDatabaseResponse();

			connectDatabaseResponse.HttpResponse = _ctx.HttpResponse;
			connectDatabaseResponse.Code = _ctx.StringValue("ConnectDatabase.Code");
			connectDatabaseResponse.Data = _ctx.StringValue("ConnectDatabase.Data");
			connectDatabaseResponse.ErrorMsg = _ctx.StringValue("ConnectDatabase.ErrorMsg");
			connectDatabaseResponse.RequestId = _ctx.StringValue("ConnectDatabase.RequestId");
			connectDatabaseResponse.Success = _ctx.BooleanValue("ConnectDatabase.Success");
        
			return connectDatabaseResponse;
        }
    }
}
