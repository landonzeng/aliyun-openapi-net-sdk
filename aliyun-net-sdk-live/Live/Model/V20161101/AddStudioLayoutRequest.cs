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
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class AddStudioLayoutRequest : RpcAcsRequest<AddStudioLayoutResponse>
    {
        public AddStudioLayoutRequest()
            : base("live", "2016-11-01", "AddStudioLayout", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string screenInputConfigList;

		private string layoutType;

		private string layoutName;

		private string layerOrderConfigList;

		private string mediaInputConfigList;

		private string casterId;

		private string bgImageConfig;

		private long? ownerId;

		private string commonConfig;

		[JsonProperty(PropertyName = "ScreenInputConfigList")]
		public string ScreenInputConfigList
		{
			get
			{
				return screenInputConfigList;
			}
			set	
			{
				screenInputConfigList = value;
				DictionaryUtil.Add(QueryParameters, "ScreenInputConfigList", value);
			}
		}

		[JsonProperty(PropertyName = "LayoutType")]
		public string LayoutType
		{
			get
			{
				return layoutType;
			}
			set	
			{
				layoutType = value;
				DictionaryUtil.Add(QueryParameters, "LayoutType", value);
			}
		}

		[JsonProperty(PropertyName = "LayoutName")]
		public string LayoutName
		{
			get
			{
				return layoutName;
			}
			set	
			{
				layoutName = value;
				DictionaryUtil.Add(QueryParameters, "LayoutName", value);
			}
		}

		[JsonProperty(PropertyName = "LayerOrderConfigList")]
		public string LayerOrderConfigList
		{
			get
			{
				return layerOrderConfigList;
			}
			set	
			{
				layerOrderConfigList = value;
				DictionaryUtil.Add(QueryParameters, "LayerOrderConfigList", value);
			}
		}

		[JsonProperty(PropertyName = "MediaInputConfigList")]
		public string MediaInputConfigList
		{
			get
			{
				return mediaInputConfigList;
			}
			set	
			{
				mediaInputConfigList = value;
				DictionaryUtil.Add(QueryParameters, "MediaInputConfigList", value);
			}
		}

		[JsonProperty(PropertyName = "CasterId")]
		public string CasterId
		{
			get
			{
				return casterId;
			}
			set	
			{
				casterId = value;
				DictionaryUtil.Add(QueryParameters, "CasterId", value);
			}
		}

		[JsonProperty(PropertyName = "BgImageConfig")]
		public string BgImageConfig
		{
			get
			{
				return bgImageConfig;
			}
			set	
			{
				bgImageConfig = value;
				DictionaryUtil.Add(QueryParameters, "BgImageConfig", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "CommonConfig")]
		public string CommonConfig
		{
			get
			{
				return commonConfig;
			}
			set	
			{
				commonConfig = value;
				DictionaryUtil.Add(QueryParameters, "CommonConfig", value);
			}
		}

        public override AddStudioLayoutResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddStudioLayoutResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
