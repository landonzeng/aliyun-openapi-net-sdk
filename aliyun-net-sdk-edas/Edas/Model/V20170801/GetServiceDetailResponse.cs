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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class GetServiceDetailResponse : AcsResponse
	{

		private int? code;

		private string message;

		private bool? success;

		private GetServiceDetail_Data data;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public GetServiceDetail_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetServiceDetail_Data
		{

			private string serviceName;

			private string edasAppName;

			private string dubboApplicationName;

			private string springApplicationName;

			private string serviceType;

			private string registryType;

			private string version;

			private string group;

			private string metadata;

			private List<GetServiceDetail_Method> methods;

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}

			public string EdasAppName
			{
				get
				{
					return edasAppName;
				}
				set	
				{
					edasAppName = value;
				}
			}

			public string DubboApplicationName
			{
				get
				{
					return dubboApplicationName;
				}
				set	
				{
					dubboApplicationName = value;
				}
			}

			public string SpringApplicationName
			{
				get
				{
					return springApplicationName;
				}
				set	
				{
					springApplicationName = value;
				}
			}

			public string ServiceType
			{
				get
				{
					return serviceType;
				}
				set	
				{
					serviceType = value;
				}
			}

			public string RegistryType
			{
				get
				{
					return registryType;
				}
				set	
				{
					registryType = value;
				}
			}

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public string Group
			{
				get
				{
					return group;
				}
				set	
				{
					group = value;
				}
			}

			public string Metadata
			{
				get
				{
					return metadata;
				}
				set	
				{
					metadata = value;
				}
			}

			public List<GetServiceDetail_Method> Methods
			{
				get
				{
					return methods;
				}
				set	
				{
					methods = value;
				}
			}

			public class GetServiceDetail_Method
			{

				private string name;

				private string returnType;

				private string methodController;

				private string parameterNames;

				private string nameDetail;

				private string returnDetails;

				private string parameterTypes;

				private string parameterDetails;

				private string requestMethods;

				private string paths;

				private string parameterDefinitions;

				private GetServiceDetail_ReturnDefinition returnDefinition;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string ReturnType
				{
					get
					{
						return returnType;
					}
					set	
					{
						returnType = value;
					}
				}

				public string MethodController
				{
					get
					{
						return methodController;
					}
					set	
					{
						methodController = value;
					}
				}

				public string ParameterNames
				{
					get
					{
						return parameterNames;
					}
					set	
					{
						parameterNames = value;
					}
				}

				public string NameDetail
				{
					get
					{
						return nameDetail;
					}
					set	
					{
						nameDetail = value;
					}
				}

				public string ReturnDetails
				{
					get
					{
						return returnDetails;
					}
					set	
					{
						returnDetails = value;
					}
				}

				public string ParameterTypes
				{
					get
					{
						return parameterTypes;
					}
					set	
					{
						parameterTypes = value;
					}
				}

				public string ParameterDetails
				{
					get
					{
						return parameterDetails;
					}
					set	
					{
						parameterDetails = value;
					}
				}

				public string RequestMethods
				{
					get
					{
						return requestMethods;
					}
					set	
					{
						requestMethods = value;
					}
				}

				public string Paths
				{
					get
					{
						return paths;
					}
					set	
					{
						paths = value;
					}
				}

				public string ParameterDefinitions
				{
					get
					{
						return parameterDefinitions;
					}
					set	
					{
						parameterDefinitions = value;
					}
				}

				public GetServiceDetail_ReturnDefinition ReturnDefinition
				{
					get
					{
						return returnDefinition;
					}
					set	
					{
						returnDefinition = value;
					}
				}

				public class GetServiceDetail_ReturnDefinition
				{

					private string id;

					private string type;

					public string Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
						}
					}

					public string Type
					{
						get
						{
							return type;
						}
						set	
						{
							type = value;
						}
					}
				}
			}
		}
	}
}
