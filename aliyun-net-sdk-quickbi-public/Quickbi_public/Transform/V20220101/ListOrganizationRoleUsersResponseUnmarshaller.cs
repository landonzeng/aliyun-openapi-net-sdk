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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class ListOrganizationRoleUsersResponseUnmarshaller
    {
        public static ListOrganizationRoleUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOrganizationRoleUsersResponse listOrganizationRoleUsersResponse = new ListOrganizationRoleUsersResponse();

			listOrganizationRoleUsersResponse.HttpResponse = _ctx.HttpResponse;
			listOrganizationRoleUsersResponse.RequestId = _ctx.StringValue("ListOrganizationRoleUsers.RequestId");
			listOrganizationRoleUsersResponse.Success = _ctx.BooleanValue("ListOrganizationRoleUsers.Success");

			ListOrganizationRoleUsersResponse.ListOrganizationRoleUsers_Result result = new ListOrganizationRoleUsersResponse.ListOrganizationRoleUsers_Result();
			result.TotalNum = _ctx.IntegerValue("ListOrganizationRoleUsers.Result.TotalNum");
			result.TotalPages = _ctx.IntegerValue("ListOrganizationRoleUsers.Result.TotalPages");
			result.PageNum = _ctx.IntegerValue("ListOrganizationRoleUsers.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("ListOrganizationRoleUsers.Result.PageSize");

			List<ListOrganizationRoleUsersResponse.ListOrganizationRoleUsers_Result.ListOrganizationRoleUsers_DataItem> result_data = new List<ListOrganizationRoleUsersResponse.ListOrganizationRoleUsers_Result.ListOrganizationRoleUsers_DataItem>();
			for (int i = 0; i < _ctx.Length("ListOrganizationRoleUsers.Result.Data.Length"); i++) {
				ListOrganizationRoleUsersResponse.ListOrganizationRoleUsers_Result.ListOrganizationRoleUsers_DataItem dataItem = new ListOrganizationRoleUsersResponse.ListOrganizationRoleUsers_Result.ListOrganizationRoleUsers_DataItem();
				dataItem.UserId = _ctx.StringValue("ListOrganizationRoleUsers.Result.Data["+ i +"].UserId");
				dataItem.NickName = _ctx.StringValue("ListOrganizationRoleUsers.Result.Data["+ i +"].NickName");

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			listOrganizationRoleUsersResponse.Result = result;
        
			return listOrganizationRoleUsersResponse;
        }
    }
}
