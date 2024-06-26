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
using Aliyun.Acs.ComputeNest.Model.V20210601;

namespace Aliyun.Acs.ComputeNest.Transform.V20210601
{
    public class ListServiceInstancesResponseUnmarshaller
    {
        public static ListServiceInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListServiceInstancesResponse listServiceInstancesResponse = new ListServiceInstancesResponse();

			listServiceInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listServiceInstancesResponse.NextToken = _ctx.StringValue("ListServiceInstances.NextToken");
			listServiceInstancesResponse.RequestId = _ctx.StringValue("ListServiceInstances.RequestId");
			listServiceInstancesResponse.TotalCount = _ctx.LongValue("ListServiceInstances.TotalCount");
			listServiceInstancesResponse.MaxResults = _ctx.IntegerValue("ListServiceInstances.MaxResults");

			List<ListServiceInstancesResponse.ListServiceInstances_ServiceInstance> listServiceInstancesResponse_serviceInstances = new List<ListServiceInstancesResponse.ListServiceInstances_ServiceInstance>();
			for (int i = 0; i < _ctx.Length("ListServiceInstances.ServiceInstances.Length"); i++) {
				ListServiceInstancesResponse.ListServiceInstances_ServiceInstance serviceInstance = new ListServiceInstancesResponse.ListServiceInstances_ServiceInstance();
				serviceInstance.Name = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Name");
				serviceInstance.Status = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Status");
				serviceInstance.Outputs = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Outputs");
				serviceInstance.UpdateTime = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].UpdateTime");
				serviceInstance.Parameters = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Parameters");
				serviceInstance.ServiceInstanceId = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].ServiceInstanceId");
				serviceInstance.CreateTime = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].CreateTime");
				serviceInstance.StatusDetail = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].StatusDetail");
				serviceInstance.Progress = _ctx.LongValue("ListServiceInstances.ServiceInstances["+ i +"].Progress");
				serviceInstance.Resources = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Resources");
				serviceInstance.TemplateName = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].TemplateName");
				serviceInstance.OperatedServiceInstanceId = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].OperatedServiceInstanceId");
				serviceInstance.OperationStartTime = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].OperationStartTime");
				serviceInstance.OperationEndTime = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].OperationEndTime");
				serviceInstance.EnableInstanceOps = _ctx.BooleanValue("ListServiceInstances.ServiceInstances["+ i +"].EnableInstanceOps");
				serviceInstance.Source = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Source");
				serviceInstance.EndTime = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].EndTime");
				serviceInstance.ServiceType = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].ServiceType");
				serviceInstance.PayType = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].PayType");
				serviceInstance.MarketInstanceId = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].MarketInstanceId");
				serviceInstance.ResourceGroupId = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].ResourceGroupId");
				serviceInstance.BizStatus = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].BizStatus");

				ListServiceInstancesResponse.ListServiceInstances_ServiceInstance.ListServiceInstances_Service service = new ListServiceInstancesResponse.ListServiceInstances_ServiceInstance.ListServiceInstances_Service();
				service.Status = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Service.Status");
				service.PublishTime = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Service.PublishTime");
				service.Version = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Service.Version");
				service.DeployType = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Service.DeployType");
				service.ServiceId = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Service.ServiceId");
				service.SupplierUrl = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Service.SupplierUrl");
				service.ServiceType = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Service.ServiceType");
				service.SupplierName = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Service.SupplierName");
				service.VersionName = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Service.VersionName");

				List<ListServiceInstancesResponse.ListServiceInstances_ServiceInstance.ListServiceInstances_Service.ListServiceInstances_ServiceInfo> service_serviceInfos = new List<ListServiceInstancesResponse.ListServiceInstances_ServiceInstance.ListServiceInstances_Service.ListServiceInstances_ServiceInfo>();
				for (int j = 0; j < _ctx.Length("ListServiceInstances.ServiceInstances["+ i +"].Service.ServiceInfos.Length"); j++) {
					ListServiceInstancesResponse.ListServiceInstances_ServiceInstance.ListServiceInstances_Service.ListServiceInstances_ServiceInfo serviceInfo = new ListServiceInstancesResponse.ListServiceInstances_ServiceInstance.ListServiceInstances_Service.ListServiceInstances_ServiceInfo();
					serviceInfo.Locale = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Service.ServiceInfos["+ j +"].Locale");
					serviceInfo.Image = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Service.ServiceInfos["+ j +"].Image");
					serviceInfo.Name = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Service.ServiceInfos["+ j +"].Name");
					serviceInfo.ShortDescription = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Service.ServiceInfos["+ j +"].ShortDescription");

					service_serviceInfos.Add(serviceInfo);
				}
				service.ServiceInfos = service_serviceInfos;
				serviceInstance.Service = service;

				List<ListServiceInstancesResponse.ListServiceInstances_ServiceInstance.ListServiceInstances_Tag> serviceInstance_tags = new List<ListServiceInstancesResponse.ListServiceInstances_ServiceInstance.ListServiceInstances_Tag>();
				for (int j = 0; j < _ctx.Length("ListServiceInstances.ServiceInstances["+ i +"].Tags.Length"); j++) {
					ListServiceInstancesResponse.ListServiceInstances_ServiceInstance.ListServiceInstances_Tag tag = new ListServiceInstancesResponse.ListServiceInstances_ServiceInstance.ListServiceInstances_Tag();
					tag.Key = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("ListServiceInstances.ServiceInstances["+ i +"].Tags["+ j +"].Value");

					serviceInstance_tags.Add(tag);
				}
				serviceInstance.Tags = serviceInstance_tags;

				listServiceInstancesResponse_serviceInstances.Add(serviceInstance);
			}
			listServiceInstancesResponse.ServiceInstances = listServiceInstancesResponse_serviceInstances;
        
			return listServiceInstancesResponse;
        }
    }
}
