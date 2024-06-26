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
    public class DeployApplicationRequest : RoaAcsRequest<DeployApplicationResponse>
    {
        public DeployApplicationRequest()
            : base("sae", "2019-05-06", "DeployApplication", "serverless", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v1/sam/app/deployApplication";
			Method = MethodType.POST;
        }

		private string nasId;

		private string jarStartArgs;

		private string ossAkSecret;

		private string nasConfigs;

		private string mountHost;

		private int? batchWaitTime;

		private string envs;

		private string phpArmsConfigLocation;

		private string customHostAlias;

		private string deploy;

		private string jarStartOptions;

		private string pvtzDiscoverySvc;

		private string configMapMountDesc;

		private string ossMountDescs;

		private string imagePullSecrets;

		private string preStop;

		private string python;

		private int? cpu;

		private string updateStrategy;

		private string vSwitchId;

		private string changeOrderDesc;

		private int? minReadyInstanceRatio;

		private bool? autoEnableApplicationScalingRule;

		private string packageType;

		private string postStart;

		private bool? associateEip;

		private string webContainer;

		private string enableAhas;

		private string slsConfigs;

		private string kafkaConfigs;

		private int? memory;

		private string commandArgs;

		private string acrAssumeRoleArn;

		private string readiness;

		private string timezone;

		private string ossAkId;

		private string liveness;

		private string securityGroupId;

		private string packageVersion;

		private string tomcatConfig;

		private string warStartOptions;

		private string edasContainerVersion;

		private string packageUrl;

		private int? terminationGracePeriodSeconds;

		private string phpConfig;

		private string microRegistration;

		private bool? enableGreyTagRoute;

		private int? replicas;

		private string command;

		private string mountDesc;

		private string jdk;

		private int? minReadyInstances;

		private string acrInstanceId;

		private string appId;

		private string imageUrl;

		private string php;

		private string pythonModules;

		private string phpConfigLocation;

		public string NasId
		{
			get
			{
				return nasId;
			}
			set	
			{
				nasId = value;
				DictionaryUtil.Add(QueryParameters, "NasId", value);
			}
		}

		public string JarStartArgs
		{
			get
			{
				return jarStartArgs;
			}
			set	
			{
				jarStartArgs = value;
				DictionaryUtil.Add(QueryParameters, "JarStartArgs", value);
			}
		}

		public string OssAkSecret
		{
			get
			{
				return ossAkSecret;
			}
			set	
			{
				ossAkSecret = value;
				DictionaryUtil.Add(BodyParameters, "OssAkSecret", value);
			}
		}

		public string NasConfigs
		{
			get
			{
				return nasConfigs;
			}
			set	
			{
				nasConfigs = value;
				DictionaryUtil.Add(QueryParameters, "NasConfigs", value);
			}
		}

		public string MountHost
		{
			get
			{
				return mountHost;
			}
			set	
			{
				mountHost = value;
				DictionaryUtil.Add(QueryParameters, "MountHost", value);
			}
		}

		public int? BatchWaitTime
		{
			get
			{
				return batchWaitTime;
			}
			set	
			{
				batchWaitTime = value;
				DictionaryUtil.Add(QueryParameters, "BatchWaitTime", value.ToString());
			}
		}

		public string Envs
		{
			get
			{
				return envs;
			}
			set	
			{
				envs = value;
				DictionaryUtil.Add(QueryParameters, "Envs", value);
			}
		}

		public string PhpArmsConfigLocation
		{
			get
			{
				return phpArmsConfigLocation;
			}
			set	
			{
				phpArmsConfigLocation = value;
				DictionaryUtil.Add(QueryParameters, "PhpArmsConfigLocation", value);
			}
		}

		public string CustomHostAlias
		{
			get
			{
				return customHostAlias;
			}
			set	
			{
				customHostAlias = value;
				DictionaryUtil.Add(QueryParameters, "CustomHostAlias", value);
			}
		}

		public string Deploy
		{
			get
			{
				return deploy;
			}
			set	
			{
				deploy = value;
				DictionaryUtil.Add(QueryParameters, "Deploy", value);
			}
		}

		public string JarStartOptions
		{
			get
			{
				return jarStartOptions;
			}
			set	
			{
				jarStartOptions = value;
				DictionaryUtil.Add(QueryParameters, "JarStartOptions", value);
			}
		}

		public string PvtzDiscoverySvc
		{
			get
			{
				return pvtzDiscoverySvc;
			}
			set	
			{
				pvtzDiscoverySvc = value;
				DictionaryUtil.Add(QueryParameters, "PvtzDiscoverySvc", value);
			}
		}

		public string ConfigMapMountDesc
		{
			get
			{
				return configMapMountDesc;
			}
			set	
			{
				configMapMountDesc = value;
				DictionaryUtil.Add(BodyParameters, "ConfigMapMountDesc", value);
			}
		}

		public string OssMountDescs
		{
			get
			{
				return ossMountDescs;
			}
			set	
			{
				ossMountDescs = value;
				DictionaryUtil.Add(BodyParameters, "OssMountDescs", value);
			}
		}

		public string ImagePullSecrets
		{
			get
			{
				return imagePullSecrets;
			}
			set	
			{
				imagePullSecrets = value;
				DictionaryUtil.Add(QueryParameters, "ImagePullSecrets", value);
			}
		}

		public string PreStop
		{
			get
			{
				return preStop;
			}
			set	
			{
				preStop = value;
				DictionaryUtil.Add(QueryParameters, "PreStop", value);
			}
		}

		public string Python
		{
			get
			{
				return python;
			}
			set	
			{
				python = value;
				DictionaryUtil.Add(QueryParameters, "Python", value);
			}
		}

		public int? Cpu
		{
			get
			{
				return cpu;
			}
			set	
			{
				cpu = value;
				DictionaryUtil.Add(QueryParameters, "Cpu", value.ToString());
			}
		}

		public string UpdateStrategy
		{
			get
			{
				return updateStrategy;
			}
			set	
			{
				updateStrategy = value;
				DictionaryUtil.Add(QueryParameters, "UpdateStrategy", value);
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		public string ChangeOrderDesc
		{
			get
			{
				return changeOrderDesc;
			}
			set	
			{
				changeOrderDesc = value;
				DictionaryUtil.Add(QueryParameters, "ChangeOrderDesc", value);
			}
		}

		public int? MinReadyInstanceRatio
		{
			get
			{
				return minReadyInstanceRatio;
			}
			set	
			{
				minReadyInstanceRatio = value;
				DictionaryUtil.Add(QueryParameters, "MinReadyInstanceRatio", value.ToString());
			}
		}

		public bool? AutoEnableApplicationScalingRule
		{
			get
			{
				return autoEnableApplicationScalingRule;
			}
			set	
			{
				autoEnableApplicationScalingRule = value;
				DictionaryUtil.Add(QueryParameters, "AutoEnableApplicationScalingRule", value.ToString());
			}
		}

		public string PackageType
		{
			get
			{
				return packageType;
			}
			set	
			{
				packageType = value;
				DictionaryUtil.Add(QueryParameters, "PackageType", value);
			}
		}

		public string PostStart
		{
			get
			{
				return postStart;
			}
			set	
			{
				postStart = value;
				DictionaryUtil.Add(QueryParameters, "PostStart", value);
			}
		}

		public bool? AssociateEip
		{
			get
			{
				return associateEip;
			}
			set	
			{
				associateEip = value;
				DictionaryUtil.Add(BodyParameters, "AssociateEip", value.ToString());
			}
		}

		public string WebContainer
		{
			get
			{
				return webContainer;
			}
			set	
			{
				webContainer = value;
				DictionaryUtil.Add(QueryParameters, "WebContainer", value);
			}
		}

		public string EnableAhas
		{
			get
			{
				return enableAhas;
			}
			set	
			{
				enableAhas = value;
				DictionaryUtil.Add(QueryParameters, "EnableAhas", value);
			}
		}

		public string SlsConfigs
		{
			get
			{
				return slsConfigs;
			}
			set	
			{
				slsConfigs = value;
				DictionaryUtil.Add(QueryParameters, "SlsConfigs", value);
			}
		}

		public string KafkaConfigs
		{
			get
			{
				return kafkaConfigs;
			}
			set	
			{
				kafkaConfigs = value;
				DictionaryUtil.Add(QueryParameters, "KafkaConfigs", value);
			}
		}

		public int? Memory
		{
			get
			{
				return memory;
			}
			set	
			{
				memory = value;
				DictionaryUtil.Add(QueryParameters, "Memory", value.ToString());
			}
		}

		public string CommandArgs
		{
			get
			{
				return commandArgs;
			}
			set	
			{
				commandArgs = value;
				DictionaryUtil.Add(QueryParameters, "CommandArgs", value);
			}
		}

		public string AcrAssumeRoleArn
		{
			get
			{
				return acrAssumeRoleArn;
			}
			set	
			{
				acrAssumeRoleArn = value;
				DictionaryUtil.Add(QueryParameters, "AcrAssumeRoleArn", value);
			}
		}

		public string Readiness
		{
			get
			{
				return readiness;
			}
			set	
			{
				readiness = value;
				DictionaryUtil.Add(QueryParameters, "Readiness", value);
			}
		}

		public string Timezone
		{
			get
			{
				return timezone;
			}
			set	
			{
				timezone = value;
				DictionaryUtil.Add(QueryParameters, "Timezone", value);
			}
		}

		public string OssAkId
		{
			get
			{
				return ossAkId;
			}
			set	
			{
				ossAkId = value;
				DictionaryUtil.Add(BodyParameters, "OssAkId", value);
			}
		}

		public string Liveness
		{
			get
			{
				return liveness;
			}
			set	
			{
				liveness = value;
				DictionaryUtil.Add(QueryParameters, "Liveness", value);
			}
		}

		public string SecurityGroupId
		{
			get
			{
				return securityGroupId;
			}
			set	
			{
				securityGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
			}
		}

		public string PackageVersion
		{
			get
			{
				return packageVersion;
			}
			set	
			{
				packageVersion = value;
				DictionaryUtil.Add(QueryParameters, "PackageVersion", value);
			}
		}

		public string TomcatConfig
		{
			get
			{
				return tomcatConfig;
			}
			set	
			{
				tomcatConfig = value;
				DictionaryUtil.Add(QueryParameters, "TomcatConfig", value);
			}
		}

		public string WarStartOptions
		{
			get
			{
				return warStartOptions;
			}
			set	
			{
				warStartOptions = value;
				DictionaryUtil.Add(QueryParameters, "WarStartOptions", value);
			}
		}

		public string EdasContainerVersion
		{
			get
			{
				return edasContainerVersion;
			}
			set	
			{
				edasContainerVersion = value;
				DictionaryUtil.Add(QueryParameters, "EdasContainerVersion", value);
			}
		}

		public string PackageUrl
		{
			get
			{
				return packageUrl;
			}
			set	
			{
				packageUrl = value;
				DictionaryUtil.Add(QueryParameters, "PackageUrl", value);
			}
		}

		public int? TerminationGracePeriodSeconds
		{
			get
			{
				return terminationGracePeriodSeconds;
			}
			set	
			{
				terminationGracePeriodSeconds = value;
				DictionaryUtil.Add(QueryParameters, "TerminationGracePeriodSeconds", value.ToString());
			}
		}

		public string PhpConfig
		{
			get
			{
				return phpConfig;
			}
			set	
			{
				phpConfig = value;
				DictionaryUtil.Add(BodyParameters, "PhpConfig", value);
			}
		}

		public string MicroRegistration
		{
			get
			{
				return microRegistration;
			}
			set	
			{
				microRegistration = value;
				DictionaryUtil.Add(QueryParameters, "MicroRegistration", value);
			}
		}

		public bool? EnableGreyTagRoute
		{
			get
			{
				return enableGreyTagRoute;
			}
			set	
			{
				enableGreyTagRoute = value;
				DictionaryUtil.Add(QueryParameters, "EnableGreyTagRoute", value.ToString());
			}
		}

		public int? Replicas
		{
			get
			{
				return replicas;
			}
			set	
			{
				replicas = value;
				DictionaryUtil.Add(QueryParameters, "Replicas", value.ToString());
			}
		}

		public string Command
		{
			get
			{
				return command;
			}
			set	
			{
				command = value;
				DictionaryUtil.Add(QueryParameters, "Command", value);
			}
		}

		public string MountDesc
		{
			get
			{
				return mountDesc;
			}
			set	
			{
				mountDesc = value;
				DictionaryUtil.Add(QueryParameters, "MountDesc", value);
			}
		}

		public string Jdk
		{
			get
			{
				return jdk;
			}
			set	
			{
				jdk = value;
				DictionaryUtil.Add(QueryParameters, "Jdk", value);
			}
		}

		public int? MinReadyInstances
		{
			get
			{
				return minReadyInstances;
			}
			set	
			{
				minReadyInstances = value;
				DictionaryUtil.Add(QueryParameters, "MinReadyInstances", value.ToString());
			}
		}

		public string AcrInstanceId
		{
			get
			{
				return acrInstanceId;
			}
			set	
			{
				acrInstanceId = value;
				DictionaryUtil.Add(BodyParameters, "AcrInstanceId", value);
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public string ImageUrl
		{
			get
			{
				return imageUrl;
			}
			set	
			{
				imageUrl = value;
				DictionaryUtil.Add(QueryParameters, "ImageUrl", value);
			}
		}

		public string Php
		{
			get
			{
				return php;
			}
			set	
			{
				php = value;
				DictionaryUtil.Add(BodyParameters, "Php", value);
			}
		}

		public string PythonModules
		{
			get
			{
				return pythonModules;
			}
			set	
			{
				pythonModules = value;
				DictionaryUtil.Add(QueryParameters, "PythonModules", value);
			}
		}

		public string PhpConfigLocation
		{
			get
			{
				return phpConfigLocation;
			}
			set	
			{
				phpConfigLocation = value;
				DictionaryUtil.Add(QueryParameters, "PhpConfigLocation", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeployApplicationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeployApplicationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
