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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveStreamTranscodeInfoResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo> domainTranscodeList;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo> DomainTranscodeList
		{
			get
			{
				return domainTranscodeList;
			}
			set	
			{
				domainTranscodeList = value;
			}
		}

		public class DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo
		{

			private string transcodeApp;

			private string transcodeTemplate;

			private string transcodeName;

			private DescribeLiveStreamTranscodeInfo_CustomTranscodeParameters customTranscodeParameters;

			private DescribeLiveStreamTranscodeInfo_EncryptParameters encryptParameters;

			public string TranscodeApp
			{
				get
				{
					return transcodeApp;
				}
				set	
				{
					transcodeApp = value;
				}
			}

			public string TranscodeTemplate
			{
				get
				{
					return transcodeTemplate;
				}
				set	
				{
					transcodeTemplate = value;
				}
			}

			public string TranscodeName
			{
				get
				{
					return transcodeName;
				}
				set	
				{
					transcodeName = value;
				}
			}

			public DescribeLiveStreamTranscodeInfo_CustomTranscodeParameters CustomTranscodeParameters
			{
				get
				{
					return customTranscodeParameters;
				}
				set	
				{
					customTranscodeParameters = value;
				}
			}

			public DescribeLiveStreamTranscodeInfo_EncryptParameters EncryptParameters
			{
				get
				{
					return encryptParameters;
				}
				set	
				{
					encryptParameters = value;
				}
			}

			public class DescribeLiveStreamTranscodeInfo_CustomTranscodeParameters
			{

				private string videoProfile;

				private int? audioBitrate;

				private string rtsFlag;

				private int? height;

				private string templateType;

				private string bframes;

				private int? audioRate;

				private int? fPS;

				private string audioCodec;

				private string gop;

				private int? videoBitrate;

				private int? width;

				private int? audioChannelNum;

				private string audioProfile;

				public string VideoProfile
				{
					get
					{
						return videoProfile;
					}
					set	
					{
						videoProfile = value;
					}
				}

				public int? AudioBitrate
				{
					get
					{
						return audioBitrate;
					}
					set	
					{
						audioBitrate = value;
					}
				}

				public string RtsFlag
				{
					get
					{
						return rtsFlag;
					}
					set	
					{
						rtsFlag = value;
					}
				}

				public int? Height
				{
					get
					{
						return height;
					}
					set	
					{
						height = value;
					}
				}

				public string TemplateType
				{
					get
					{
						return templateType;
					}
					set	
					{
						templateType = value;
					}
				}

				public string Bframes
				{
					get
					{
						return bframes;
					}
					set	
					{
						bframes = value;
					}
				}

				public int? AudioRate
				{
					get
					{
						return audioRate;
					}
					set	
					{
						audioRate = value;
					}
				}

				public int? FPS
				{
					get
					{
						return fPS;
					}
					set	
					{
						fPS = value;
					}
				}

				public string AudioCodec
				{
					get
					{
						return audioCodec;
					}
					set	
					{
						audioCodec = value;
					}
				}

				public string Gop
				{
					get
					{
						return gop;
					}
					set	
					{
						gop = value;
					}
				}

				public int? VideoBitrate
				{
					get
					{
						return videoBitrate;
					}
					set	
					{
						videoBitrate = value;
					}
				}

				public int? Width
				{
					get
					{
						return width;
					}
					set	
					{
						width = value;
					}
				}

				public int? AudioChannelNum
				{
					get
					{
						return audioChannelNum;
					}
					set	
					{
						audioChannelNum = value;
					}
				}

				public string AudioProfile
				{
					get
					{
						return audioProfile;
					}
					set	
					{
						audioProfile = value;
					}
				}
			}

			public class DescribeLiveStreamTranscodeInfo_EncryptParameters
			{

				private string encryptType;

				private string kmsKeyID;

				private string kmsKeyExpireInterval;

				public string EncryptType
				{
					get
					{
						return encryptType;
					}
					set	
					{
						encryptType = value;
					}
				}

				public string KmsKeyID
				{
					get
					{
						return kmsKeyID;
					}
					set	
					{
						kmsKeyID = value;
					}
				}

				public string KmsKeyExpireInterval
				{
					get
					{
						return kmsKeyExpireInterval;
					}
					set	
					{
						kmsKeyExpireInterval = value;
					}
				}
			}
		}
	}
}
