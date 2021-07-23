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

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class ListIntervalAgentReportResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private List<ListIntervalAgentReport_DataItem> data;

		public string Code
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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public List<ListIntervalAgentReport_DataItem> Data
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

		public class ListIntervalAgentReport_DataItem
		{

			private long? statsTime;

			private ListIntervalAgentReport_Inbound inbound;

			private ListIntervalAgentReport_Outbound outbound;

			private ListIntervalAgentReport_Overall overall;

			public long? StatsTime
			{
				get
				{
					return statsTime;
				}
				set	
				{
					statsTime = value;
				}
			}

			public ListIntervalAgentReport_Inbound Inbound
			{
				get
				{
					return inbound;
				}
				set	
				{
					inbound = value;
				}
			}

			public ListIntervalAgentReport_Outbound Outbound
			{
				get
				{
					return outbound;
				}
				set	
				{
					outbound = value;
				}
			}

			public ListIntervalAgentReport_Overall Overall
			{
				get
				{
					return overall;
				}
				set	
				{
					overall = value;
				}
			}

			public class ListIntervalAgentReport_Inbound
			{

				private float? averageHoldTime;

				private float? averageRingTime;

				private float? averageTalkTime;

				private float? averageWorkTime;

				private long? callsAttendedTransferIn;

				private long? callsAttendedTransferOut;

				private long? callsBlindTransferIn;

				private long? callsBlindTransferOut;

				private long? callsHandled;

				private long? callsHold;

				private long? callsOffered;

				private long? callsRinged;

				private float? handleRate;

				private long? maxHoldTime;

				private long? maxRingTime;

				private long? maxTalkTime;

				private long? maxWorkTime;

				private float? satisfactionIndex;

				private float? satisfactionRate;

				private long? satisfactionSurveysOffered;

				private long? satisfactionSurveysResponded;

				private long? totalHoldTime;

				private long? totalRingTime;

				private long? totalTalkTime;

				private long? totalWorkTime;

				public float? AverageHoldTime
				{
					get
					{
						return averageHoldTime;
					}
					set	
					{
						averageHoldTime = value;
					}
				}

				public float? AverageRingTime
				{
					get
					{
						return averageRingTime;
					}
					set	
					{
						averageRingTime = value;
					}
				}

				public float? AverageTalkTime
				{
					get
					{
						return averageTalkTime;
					}
					set	
					{
						averageTalkTime = value;
					}
				}

				public float? AverageWorkTime
				{
					get
					{
						return averageWorkTime;
					}
					set	
					{
						averageWorkTime = value;
					}
				}

				public long? CallsAttendedTransferIn
				{
					get
					{
						return callsAttendedTransferIn;
					}
					set	
					{
						callsAttendedTransferIn = value;
					}
				}

				public long? CallsAttendedTransferOut
				{
					get
					{
						return callsAttendedTransferOut;
					}
					set	
					{
						callsAttendedTransferOut = value;
					}
				}

				public long? CallsBlindTransferIn
				{
					get
					{
						return callsBlindTransferIn;
					}
					set	
					{
						callsBlindTransferIn = value;
					}
				}

				public long? CallsBlindTransferOut
				{
					get
					{
						return callsBlindTransferOut;
					}
					set	
					{
						callsBlindTransferOut = value;
					}
				}

				public long? CallsHandled
				{
					get
					{
						return callsHandled;
					}
					set	
					{
						callsHandled = value;
					}
				}

				public long? CallsHold
				{
					get
					{
						return callsHold;
					}
					set	
					{
						callsHold = value;
					}
				}

				public long? CallsOffered
				{
					get
					{
						return callsOffered;
					}
					set	
					{
						callsOffered = value;
					}
				}

				public long? CallsRinged
				{
					get
					{
						return callsRinged;
					}
					set	
					{
						callsRinged = value;
					}
				}

				public float? HandleRate
				{
					get
					{
						return handleRate;
					}
					set	
					{
						handleRate = value;
					}
				}

				public long? MaxHoldTime
				{
					get
					{
						return maxHoldTime;
					}
					set	
					{
						maxHoldTime = value;
					}
				}

				public long? MaxRingTime
				{
					get
					{
						return maxRingTime;
					}
					set	
					{
						maxRingTime = value;
					}
				}

				public long? MaxTalkTime
				{
					get
					{
						return maxTalkTime;
					}
					set	
					{
						maxTalkTime = value;
					}
				}

				public long? MaxWorkTime
				{
					get
					{
						return maxWorkTime;
					}
					set	
					{
						maxWorkTime = value;
					}
				}

				public float? SatisfactionIndex
				{
					get
					{
						return satisfactionIndex;
					}
					set	
					{
						satisfactionIndex = value;
					}
				}

				public float? SatisfactionRate
				{
					get
					{
						return satisfactionRate;
					}
					set	
					{
						satisfactionRate = value;
					}
				}

				public long? SatisfactionSurveysOffered
				{
					get
					{
						return satisfactionSurveysOffered;
					}
					set	
					{
						satisfactionSurveysOffered = value;
					}
				}

				public long? SatisfactionSurveysResponded
				{
					get
					{
						return satisfactionSurveysResponded;
					}
					set	
					{
						satisfactionSurveysResponded = value;
					}
				}

				public long? TotalHoldTime
				{
					get
					{
						return totalHoldTime;
					}
					set	
					{
						totalHoldTime = value;
					}
				}

				public long? TotalRingTime
				{
					get
					{
						return totalRingTime;
					}
					set	
					{
						totalRingTime = value;
					}
				}

				public long? TotalTalkTime
				{
					get
					{
						return totalTalkTime;
					}
					set	
					{
						totalTalkTime = value;
					}
				}

				public long? TotalWorkTime
				{
					get
					{
						return totalWorkTime;
					}
					set	
					{
						totalWorkTime = value;
					}
				}
			}

			public class ListIntervalAgentReport_Outbound
			{

				private float? answerRate;

				private float? averageDialingTime;

				private float? averageHoldTime;

				private float? averageRingTime;

				private float? averageTalkTime;

				private float? averageWorkTime;

				private long? callsAnswered;

				private long? callsAttendedTransferIn;

				private long? callsAttendedTransferOut;

				private long? callsBlindTransferIn;

				private long? callsBlindTransferOut;

				private long? callsDialed;

				private long? callsHold;

				private long? callsRinged;

				private long? maxDialingTime;

				private long? maxHoldTime;

				private long? maxRingTime;

				private long? maxTalkTime;

				private long? maxWorkTime;

				private float? satisfactionIndex;

				private float? satisfactionRate;

				private long? satisfactionSurveysOffered;

				private long? satisfactionSurveysResponded;

				private long? totalDialingTime;

				private long? totalHoldTime;

				private long? totalRingTime;

				private long? totalTalkTime;

				private long? totalWorkTime;

				public float? AnswerRate
				{
					get
					{
						return answerRate;
					}
					set	
					{
						answerRate = value;
					}
				}

				public float? AverageDialingTime
				{
					get
					{
						return averageDialingTime;
					}
					set	
					{
						averageDialingTime = value;
					}
				}

				public float? AverageHoldTime
				{
					get
					{
						return averageHoldTime;
					}
					set	
					{
						averageHoldTime = value;
					}
				}

				public float? AverageRingTime
				{
					get
					{
						return averageRingTime;
					}
					set	
					{
						averageRingTime = value;
					}
				}

				public float? AverageTalkTime
				{
					get
					{
						return averageTalkTime;
					}
					set	
					{
						averageTalkTime = value;
					}
				}

				public float? AverageWorkTime
				{
					get
					{
						return averageWorkTime;
					}
					set	
					{
						averageWorkTime = value;
					}
				}

				public long? CallsAnswered
				{
					get
					{
						return callsAnswered;
					}
					set	
					{
						callsAnswered = value;
					}
				}

				public long? CallsAttendedTransferIn
				{
					get
					{
						return callsAttendedTransferIn;
					}
					set	
					{
						callsAttendedTransferIn = value;
					}
				}

				public long? CallsAttendedTransferOut
				{
					get
					{
						return callsAttendedTransferOut;
					}
					set	
					{
						callsAttendedTransferOut = value;
					}
				}

				public long? CallsBlindTransferIn
				{
					get
					{
						return callsBlindTransferIn;
					}
					set	
					{
						callsBlindTransferIn = value;
					}
				}

				public long? CallsBlindTransferOut
				{
					get
					{
						return callsBlindTransferOut;
					}
					set	
					{
						callsBlindTransferOut = value;
					}
				}

				public long? CallsDialed
				{
					get
					{
						return callsDialed;
					}
					set	
					{
						callsDialed = value;
					}
				}

				public long? CallsHold
				{
					get
					{
						return callsHold;
					}
					set	
					{
						callsHold = value;
					}
				}

				public long? CallsRinged
				{
					get
					{
						return callsRinged;
					}
					set	
					{
						callsRinged = value;
					}
				}

				public long? MaxDialingTime
				{
					get
					{
						return maxDialingTime;
					}
					set	
					{
						maxDialingTime = value;
					}
				}

				public long? MaxHoldTime
				{
					get
					{
						return maxHoldTime;
					}
					set	
					{
						maxHoldTime = value;
					}
				}

				public long? MaxRingTime
				{
					get
					{
						return maxRingTime;
					}
					set	
					{
						maxRingTime = value;
					}
				}

				public long? MaxTalkTime
				{
					get
					{
						return maxTalkTime;
					}
					set	
					{
						maxTalkTime = value;
					}
				}

				public long? MaxWorkTime
				{
					get
					{
						return maxWorkTime;
					}
					set	
					{
						maxWorkTime = value;
					}
				}

				public float? SatisfactionIndex
				{
					get
					{
						return satisfactionIndex;
					}
					set	
					{
						satisfactionIndex = value;
					}
				}

				public float? SatisfactionRate
				{
					get
					{
						return satisfactionRate;
					}
					set	
					{
						satisfactionRate = value;
					}
				}

				public long? SatisfactionSurveysOffered
				{
					get
					{
						return satisfactionSurveysOffered;
					}
					set	
					{
						satisfactionSurveysOffered = value;
					}
				}

				public long? SatisfactionSurveysResponded
				{
					get
					{
						return satisfactionSurveysResponded;
					}
					set	
					{
						satisfactionSurveysResponded = value;
					}
				}

				public long? TotalDialingTime
				{
					get
					{
						return totalDialingTime;
					}
					set	
					{
						totalDialingTime = value;
					}
				}

				public long? TotalHoldTime
				{
					get
					{
						return totalHoldTime;
					}
					set	
					{
						totalHoldTime = value;
					}
				}

				public long? TotalRingTime
				{
					get
					{
						return totalRingTime;
					}
					set	
					{
						totalRingTime = value;
					}
				}

				public long? TotalTalkTime
				{
					get
					{
						return totalTalkTime;
					}
					set	
					{
						totalTalkTime = value;
					}
				}

				public long? TotalWorkTime
				{
					get
					{
						return totalWorkTime;
					}
					set	
					{
						totalWorkTime = value;
					}
				}
			}

			public class ListIntervalAgentReport_Overall
			{

				private float? averageBreakTime;

				private float? averageHoldTime;

				private float? averageReadyTime;

				private float? averageTalkTime;

				private float? averageWorkTime;

				private long? firstCheckInTime;

				private long? lastCheckoutTime;

				private long? maxBreakTime;

				private long? maxHoldTime;

				private long? maxReadyTime;

				private long? maxTalkTime;

				private long? maxWorkTime;

				private float? occupancyRate;

				private float? satisfactionIndex;

				private float? satisfactionRate;

				private long? satisfactionSurveysOffered;

				private long? satisfactionSurveysResponded;

				private long? totalBreakTime;

				private long? totalCalls;

				private long? totalHoldTime;

				private long? totalLoggedInTime;

				private long? totalReadyTime;

				private long? totalTalkTime;

				private long? totalWorkTime;

				public float? AverageBreakTime
				{
					get
					{
						return averageBreakTime;
					}
					set	
					{
						averageBreakTime = value;
					}
				}

				public float? AverageHoldTime
				{
					get
					{
						return averageHoldTime;
					}
					set	
					{
						averageHoldTime = value;
					}
				}

				public float? AverageReadyTime
				{
					get
					{
						return averageReadyTime;
					}
					set	
					{
						averageReadyTime = value;
					}
				}

				public float? AverageTalkTime
				{
					get
					{
						return averageTalkTime;
					}
					set	
					{
						averageTalkTime = value;
					}
				}

				public float? AverageWorkTime
				{
					get
					{
						return averageWorkTime;
					}
					set	
					{
						averageWorkTime = value;
					}
				}

				public long? FirstCheckInTime
				{
					get
					{
						return firstCheckInTime;
					}
					set	
					{
						firstCheckInTime = value;
					}
				}

				public long? LastCheckoutTime
				{
					get
					{
						return lastCheckoutTime;
					}
					set	
					{
						lastCheckoutTime = value;
					}
				}

				public long? MaxBreakTime
				{
					get
					{
						return maxBreakTime;
					}
					set	
					{
						maxBreakTime = value;
					}
				}

				public long? MaxHoldTime
				{
					get
					{
						return maxHoldTime;
					}
					set	
					{
						maxHoldTime = value;
					}
				}

				public long? MaxReadyTime
				{
					get
					{
						return maxReadyTime;
					}
					set	
					{
						maxReadyTime = value;
					}
				}

				public long? MaxTalkTime
				{
					get
					{
						return maxTalkTime;
					}
					set	
					{
						maxTalkTime = value;
					}
				}

				public long? MaxWorkTime
				{
					get
					{
						return maxWorkTime;
					}
					set	
					{
						maxWorkTime = value;
					}
				}

				public float? OccupancyRate
				{
					get
					{
						return occupancyRate;
					}
					set	
					{
						occupancyRate = value;
					}
				}

				public float? SatisfactionIndex
				{
					get
					{
						return satisfactionIndex;
					}
					set	
					{
						satisfactionIndex = value;
					}
				}

				public float? SatisfactionRate
				{
					get
					{
						return satisfactionRate;
					}
					set	
					{
						satisfactionRate = value;
					}
				}

				public long? SatisfactionSurveysOffered
				{
					get
					{
						return satisfactionSurveysOffered;
					}
					set	
					{
						satisfactionSurveysOffered = value;
					}
				}

				public long? SatisfactionSurveysResponded
				{
					get
					{
						return satisfactionSurveysResponded;
					}
					set	
					{
						satisfactionSurveysResponded = value;
					}
				}

				public long? TotalBreakTime
				{
					get
					{
						return totalBreakTime;
					}
					set	
					{
						totalBreakTime = value;
					}
				}

				public long? TotalCalls
				{
					get
					{
						return totalCalls;
					}
					set	
					{
						totalCalls = value;
					}
				}

				public long? TotalHoldTime
				{
					get
					{
						return totalHoldTime;
					}
					set	
					{
						totalHoldTime = value;
					}
				}

				public long? TotalLoggedInTime
				{
					get
					{
						return totalLoggedInTime;
					}
					set	
					{
						totalLoggedInTime = value;
					}
				}

				public long? TotalReadyTime
				{
					get
					{
						return totalReadyTime;
					}
					set	
					{
						totalReadyTime = value;
					}
				}

				public long? TotalTalkTime
				{
					get
					{
						return totalTalkTime;
					}
					set	
					{
						totalTalkTime = value;
					}
				}

				public long? TotalWorkTime
				{
					get
					{
						return totalWorkTime;
					}
					set	
					{
						totalWorkTime = value;
					}
				}
			}
		}
	}
}
