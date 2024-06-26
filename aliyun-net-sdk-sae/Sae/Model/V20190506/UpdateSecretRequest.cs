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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.sae.Transform;
using Aliyun.Acs.sae.Transform.V20190506;

namespace Aliyun.Acs.sae.Model.V20190506
{
    public class UpdateSecretRequest : RoaAcsRequest<UpdateSecretResponse>
    {
        public UpdateSecretRequest()
            : base("sae", "2019-05-06", "UpdateSecret", "serverless", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v1/sam/secret/secret";
			Method = MethodType.PUT;
        }

		private string namespaceId;

		private long? secretId;

		private string secretData;

		public string NamespaceId
		{
			get
			{
				return namespaceId;
			}
			set	
			{
				namespaceId = value;
				DictionaryUtil.Add(QueryParameters, "NamespaceId", value);
			}
		}

		public long? SecretId
		{
			get
			{
				return secretId;
			}
			set	
			{
				secretId = value;
				DictionaryUtil.Add(QueryParameters, "SecretId", value.ToString());
			}
		}

		public string SecretData
		{
			get
			{
				return secretData;
			}
			set	
			{
				secretData = value;
				DictionaryUtil.Add(QueryParameters, "SecretData", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateSecretResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateSecretResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
