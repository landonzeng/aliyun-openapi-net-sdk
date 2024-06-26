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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveUpVideoAudioInfoResponseUnmarshaller
    {
        public static DescribeLiveUpVideoAudioInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveUpVideoAudioInfoResponse describeLiveUpVideoAudioInfoResponse = new DescribeLiveUpVideoAudioInfoResponse();

			describeLiveUpVideoAudioInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveUpVideoAudioInfoResponse.RequestId = _ctx.StringValue("DescribeLiveUpVideoAudioInfo.RequestId");

			List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem> describeLiveUpVideoAudioInfoResponse_upItems = new List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem>();
			for (int i = 0; i < _ctx.Length("DescribeLiveUpVideoAudioInfo.UpItems.Length"); i++) {
				DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem publishItem = new DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem();
				publishItem.AppName = _ctx.StringValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AppName");
				publishItem.CodecInfo = _ctx.StringValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].CodecInfo");
				publishItem.DomainName = _ctx.StringValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].DomainName");
				publishItem.PublishInterval = _ctx.StringValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].PublishInterval");
				publishItem.PublishIp = _ctx.StringValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].PublishIp");
				publishItem.PublishStatus = _ctx.StringValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].PublishStatus");
				publishItem.PublishTime = _ctx.StringValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].PublishTime");
				publishItem.StopTime = _ctx.StringValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].StopTime");
				publishItem.StreamName = _ctx.StringValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].StreamName");
				publishItem.UniqueId = _ctx.StringValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].UniqueId");

				List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AacHeadersItem> publishItem_aacHeaders = new List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AacHeadersItem>();
				for (int j = 0; j < _ctx.Length("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AacHeaders.Length"); j++) {
					DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AacHeadersItem aacHeadersItem = new DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AacHeadersItem();
					aacHeadersItem.Time = _ctx.LongValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AacHeaders["+ j +"].Time");
					aacHeadersItem._Value = _ctx.IntegerValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AacHeaders["+ j +"].Value");

					publishItem_aacHeaders.Add(aacHeadersItem);
				}
				publishItem.AacHeaders = publishItem_aacHeaders;

				List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AudioBitRateItem> publishItem_audioBitRate = new List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AudioBitRateItem>();
				for (int j = 0; j < _ctx.Length("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AudioBitRate.Length"); j++) {
					DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AudioBitRateItem audioBitRateItem = new DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AudioBitRateItem();
					audioBitRateItem.Time = _ctx.LongValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AudioBitRate["+ j +"].Time");
					audioBitRateItem._Value = _ctx.IntegerValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AudioBitRate["+ j +"].Value");

					publishItem_audioBitRate.Add(audioBitRateItem);
				}
				publishItem.AudioBitRate = publishItem_audioBitRate;

				List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AudioFramesItem> publishItem_audioFrames = new List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AudioFramesItem>();
				for (int j = 0; j < _ctx.Length("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AudioFrames.Length"); j++) {
					DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AudioFramesItem audioFramesItem = new DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AudioFramesItem();
					audioFramesItem.Time = _ctx.LongValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AudioFrames["+ j +"].Time");
					audioFramesItem._Value = _ctx.IntegerValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AudioFrames["+ j +"].Value");

					publishItem_audioFrames.Add(audioFramesItem);
				}
				publishItem.AudioFrames = publishItem_audioFrames;

				List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AudioIntervalItem> publishItem_audioInterval = new List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AudioIntervalItem>();
				for (int j = 0; j < _ctx.Length("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AudioInterval.Length"); j++) {
					DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AudioIntervalItem audioIntervalItem = new DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AudioIntervalItem();
					audioIntervalItem.Time = _ctx.LongValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AudioInterval["+ j +"].Time");
					audioIntervalItem._Value = _ctx.IntegerValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AudioInterval["+ j +"].Value");

					publishItem_audioInterval.Add(audioIntervalItem);
				}
				publishItem.AudioInterval = publishItem_audioInterval;

				List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AudioStampsItem> publishItem_audioStamps = new List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AudioStampsItem>();
				for (int j = 0; j < _ctx.Length("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AudioStamps.Length"); j++) {
					DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AudioStampsItem audioStampsItem = new DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AudioStampsItem();
					audioStampsItem.Time = _ctx.LongValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AudioStamps["+ j +"].Time");
					audioStampsItem._Value = _ctx.IntegerValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AudioStamps["+ j +"].Value");

					publishItem_audioStamps.Add(audioStampsItem);
				}
				publishItem.AudioStamps = publishItem_audioStamps;

				List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AvcHeadersItem> publishItem_avcHeaders = new List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AvcHeadersItem>();
				for (int j = 0; j < _ctx.Length("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AvcHeaders.Length"); j++) {
					DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AvcHeadersItem avcHeadersItem = new DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_AvcHeadersItem();
					avcHeadersItem.Time = _ctx.LongValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AvcHeaders["+ j +"].Time");
					avcHeadersItem._Value = _ctx.IntegerValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].AvcHeaders["+ j +"].Value");

					publishItem_avcHeaders.Add(avcHeadersItem);
				}
				publishItem.AvcHeaders = publishItem_avcHeaders;

				List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_ErrorFlagsItem> publishItem_errorFlags = new List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_ErrorFlagsItem>();
				for (int j = 0; j < _ctx.Length("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].ErrorFlags.Length"); j++) {
					DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_ErrorFlagsItem errorFlagsItem = new DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_ErrorFlagsItem();
					errorFlagsItem.Time = _ctx.LongValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].ErrorFlags["+ j +"].Time");
					errorFlagsItem._Value = _ctx.IntegerValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].ErrorFlags["+ j +"].Value");

					publishItem_errorFlags.Add(errorFlagsItem);
				}
				publishItem.ErrorFlags = publishItem_errorFlags;

				List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_V_AStamp> publishItem_videoAndAudioStamp = new List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_V_AStamp>();
				for (int j = 0; j < _ctx.Length("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].VideoAndAudioStamp.Length"); j++) {
					DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_V_AStamp v_AStamp = new DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_V_AStamp();
					v_AStamp.Time = _ctx.LongValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].VideoAndAudioStamp["+ j +"].Time");
					v_AStamp._Value = _ctx.IntegerValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].VideoAndAudioStamp["+ j +"].Value");

					publishItem_videoAndAudioStamp.Add(v_AStamp);
				}
				publishItem.VideoAndAudioStamp = publishItem_videoAndAudioStamp;

				List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_VideoBitRateItem> publishItem_videoBitRate = new List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_VideoBitRateItem>();
				for (int j = 0; j < _ctx.Length("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].VideoBitRate.Length"); j++) {
					DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_VideoBitRateItem videoBitRateItem = new DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_VideoBitRateItem();
					videoBitRateItem.Time = _ctx.LongValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].VideoBitRate["+ j +"].Time");
					videoBitRateItem._Value = _ctx.IntegerValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].VideoBitRate["+ j +"].Value");

					publishItem_videoBitRate.Add(videoBitRateItem);
				}
				publishItem.VideoBitRate = publishItem_videoBitRate;

				List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_VideoFramesItem> publishItem_videoFrames = new List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_VideoFramesItem>();
				for (int j = 0; j < _ctx.Length("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].VideoFrames.Length"); j++) {
					DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_VideoFramesItem videoFramesItem = new DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_VideoFramesItem();
					videoFramesItem.Time = _ctx.LongValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].VideoFrames["+ j +"].Time");
					videoFramesItem._Value = _ctx.IntegerValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].VideoFrames["+ j +"].Value");

					publishItem_videoFrames.Add(videoFramesItem);
				}
				publishItem.VideoFrames = publishItem_videoFrames;

				List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_VideoIntervalItem> publishItem_videoInterval = new List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_VideoIntervalItem>();
				for (int j = 0; j < _ctx.Length("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].VideoInterval.Length"); j++) {
					DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_VideoIntervalItem videoIntervalItem = new DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_VideoIntervalItem();
					videoIntervalItem.Time = _ctx.LongValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].VideoInterval["+ j +"].Time");
					videoIntervalItem._Value = _ctx.IntegerValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].VideoInterval["+ j +"].Value");

					publishItem_videoInterval.Add(videoIntervalItem);
				}
				publishItem.VideoInterval = publishItem_videoInterval;

				List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_VideoStampsItem> publishItem_videoStamps = new List<DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_VideoStampsItem>();
				for (int j = 0; j < _ctx.Length("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].VideoStamps.Length"); j++) {
					DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_VideoStampsItem videoStampsItem = new DescribeLiveUpVideoAudioInfoResponse.DescribeLiveUpVideoAudioInfo_PublishItem.DescribeLiveUpVideoAudioInfo_VideoStampsItem();
					videoStampsItem.Time = _ctx.LongValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].VideoStamps["+ j +"].Time");
					videoStampsItem._Value = _ctx.IntegerValue("DescribeLiveUpVideoAudioInfo.UpItems["+ i +"].VideoStamps["+ j +"].Value");

					publishItem_videoStamps.Add(videoStampsItem);
				}
				publishItem.VideoStamps = publishItem_videoStamps;

				describeLiveUpVideoAudioInfoResponse_upItems.Add(publishItem);
			}
			describeLiveUpVideoAudioInfoResponse.UpItems = describeLiveUpVideoAudioInfoResponse_upItems;
        
			return describeLiveUpVideoAudioInfoResponse;
        }
    }
}
