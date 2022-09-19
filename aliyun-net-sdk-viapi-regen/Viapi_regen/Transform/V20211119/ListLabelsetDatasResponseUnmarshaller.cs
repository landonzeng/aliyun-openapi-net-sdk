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
using Aliyun.Acs.viapi_regen.Model.V20211119;

namespace Aliyun.Acs.viapi_regen.Transform.V20211119
{
    public class ListLabelsetDatasResponseUnmarshaller
    {
        public static ListLabelsetDatasResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLabelsetDatasResponse listLabelsetDatasResponse = new ListLabelsetDatasResponse();

			listLabelsetDatasResponse.HttpResponse = _ctx.HttpResponse;
			listLabelsetDatasResponse.Message = _ctx.StringValue("ListLabelsetDatas.Message");
			listLabelsetDatasResponse.RequestId = _ctx.StringValue("ListLabelsetDatas.RequestId");
			listLabelsetDatasResponse.Code = _ctx.StringValue("ListLabelsetDatas.Code");

			ListLabelsetDatasResponse.ListLabelsetDatas_Data data = new ListLabelsetDatasResponse.ListLabelsetDatas_Data();
			data.CurrentPage = _ctx.LongValue("ListLabelsetDatas.Data.CurrentPage");
			data.PageSize = _ctx.LongValue("ListLabelsetDatas.Data.PageSize");
			data.TotalPage = _ctx.LongValue("ListLabelsetDatas.Data.TotalPage");
			data.TotalCount = _ctx.LongValue("ListLabelsetDatas.Data.TotalCount");

			List<Dictionary<string, string>> data_elements = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("ListLabelsetDatas.Data.Elements.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "ListLabelsetDatas.Data.Elements["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					data_elements.Add(tmp);
				}
			}
			data.Elements = data_elements;
			listLabelsetDatasResponse.Data = data;
        
			return listLabelsetDatasResponse;
        }
    }
}
