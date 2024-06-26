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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class CreateApplicationScalingRuleResponseUnmarshaller
    {
        public static CreateApplicationScalingRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateApplicationScalingRuleResponse createApplicationScalingRuleResponse = new CreateApplicationScalingRuleResponse();

			createApplicationScalingRuleResponse.HttpResponse = _ctx.HttpResponse;
			createApplicationScalingRuleResponse.RequestId = _ctx.StringValue("CreateApplicationScalingRule.RequestId");
			createApplicationScalingRuleResponse.TraceId = _ctx.StringValue("CreateApplicationScalingRule.TraceId");
			createApplicationScalingRuleResponse.Message = _ctx.StringValue("CreateApplicationScalingRule.Message");
			createApplicationScalingRuleResponse.ErrorCode = _ctx.StringValue("CreateApplicationScalingRule.ErrorCode");
			createApplicationScalingRuleResponse.Code = _ctx.StringValue("CreateApplicationScalingRule.Code");
			createApplicationScalingRuleResponse.Success = _ctx.BooleanValue("CreateApplicationScalingRule.Success");

			CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_Data data = new CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_Data();
			data.UpdateTime = _ctx.LongValue("CreateApplicationScalingRule.Data.UpdateTime");
			data.AppId = _ctx.StringValue("CreateApplicationScalingRule.Data.AppId");
			data.CreateTime = _ctx.LongValue("CreateApplicationScalingRule.Data.CreateTime");
			data.LastDisableTime = _ctx.LongValue("CreateApplicationScalingRule.Data.LastDisableTime");
			data.ScaleRuleEnabled = _ctx.BooleanValue("CreateApplicationScalingRule.Data.ScaleRuleEnabled");
			data.ScaleRuleType = _ctx.StringValue("CreateApplicationScalingRule.Data.ScaleRuleType");
			data.ScaleRuleName = _ctx.StringValue("CreateApplicationScalingRule.Data.ScaleRuleName");

			CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_Data.CreateApplicationScalingRule_Timer timer = new CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_Data.CreateApplicationScalingRule_Timer();
			timer.EndDate = _ctx.StringValue("CreateApplicationScalingRule.Data.Timer.EndDate");
			timer.BeginDate = _ctx.StringValue("CreateApplicationScalingRule.Data.Timer.BeginDate");
			timer.Period = _ctx.StringValue("CreateApplicationScalingRule.Data.Timer.Period");

			List<CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_Data.CreateApplicationScalingRule_Timer.CreateApplicationScalingRule_Schedule> timer_schedules = new List<CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_Data.CreateApplicationScalingRule_Timer.CreateApplicationScalingRule_Schedule>();
			for (int i = 0; i < _ctx.Length("CreateApplicationScalingRule.Data.Timer.Schedules.Length"); i++) {
				CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_Data.CreateApplicationScalingRule_Timer.CreateApplicationScalingRule_Schedule schedule = new CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_Data.CreateApplicationScalingRule_Timer.CreateApplicationScalingRule_Schedule();
				schedule.AtTime = _ctx.StringValue("CreateApplicationScalingRule.Data.Timer.Schedules["+ i +"].AtTime");
				schedule.TargetReplicas = _ctx.IntegerValue("CreateApplicationScalingRule.Data.Timer.Schedules["+ i +"].TargetReplicas");
				schedule.MaxReplicas = _ctx.IntegerValue("CreateApplicationScalingRule.Data.Timer.Schedules["+ i +"].MaxReplicas");
				schedule.MinReplicas = _ctx.IntegerValue("CreateApplicationScalingRule.Data.Timer.Schedules["+ i +"].MinReplicas");

				timer_schedules.Add(schedule);
			}
			timer.Schedules = timer_schedules;
			data.Timer = timer;

			CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_Data.CreateApplicationScalingRule_Metric metric = new CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_Data.CreateApplicationScalingRule_Metric();
			metric.MaxReplicas = _ctx.IntegerValue("CreateApplicationScalingRule.Data.Metric.MaxReplicas");
			metric.MinReplicas = _ctx.IntegerValue("CreateApplicationScalingRule.Data.Metric.MinReplicas");

			List<CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_Data.CreateApplicationScalingRule_Metric.CreateApplicationScalingRule_Metric1> metric_metrics = new List<CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_Data.CreateApplicationScalingRule_Metric.CreateApplicationScalingRule_Metric1>();
			for (int i = 0; i < _ctx.Length("CreateApplicationScalingRule.Data.Metric.Metrics.Length"); i++) {
				CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_Data.CreateApplicationScalingRule_Metric.CreateApplicationScalingRule_Metric1 metric1 = new CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_Data.CreateApplicationScalingRule_Metric.CreateApplicationScalingRule_Metric1();
				metric1.MetricTargetAverageUtilization = _ctx.IntegerValue("CreateApplicationScalingRule.Data.Metric.Metrics["+ i +"].MetricTargetAverageUtilization");
				metric1.MetricType = _ctx.StringValue("CreateApplicationScalingRule.Data.Metric.Metrics["+ i +"].MetricType");
				metric1.SlbProject = _ctx.StringValue("CreateApplicationScalingRule.Data.Metric.Metrics["+ i +"].SlbProject");
				metric1.SlbLogstore = _ctx.StringValue("CreateApplicationScalingRule.Data.Metric.Metrics["+ i +"].SlbLogstore");
				metric1.Vport = _ctx.StringValue("CreateApplicationScalingRule.Data.Metric.Metrics["+ i +"].Vport");
				metric1.SlbId = _ctx.StringValue("CreateApplicationScalingRule.Data.Metric.Metrics["+ i +"].SlbId");

				metric_metrics.Add(metric1);
			}
			metric.Metrics = metric_metrics;
			data.Metric = metric;
			createApplicationScalingRuleResponse.Data = data;
        
			return createApplicationScalingRuleResponse;
        }
    }
}
