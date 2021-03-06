﻿// <copyright file="SendAssess.cs" company="Email Hippo Ltd">
// (c) 2017, Email Hippo Ltd
// </copyright>

// Copyright 2017 Email Hippo Ltd
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.MailSend
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using ProtoBuf;

    /// <summary>
    /// Send assesment.
    /// </summary>
    [ProtoContract]
    [Serializable]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "SendAssess")]
    public sealed class SendAssess
    {
        /// <summary>
        /// Gets or sets the inbox quality score.
        /// </summary>
        /// <value>
        /// The inbox quality score.
        /// </value>
        [ProtoMember(1)]
        [JsonProperty(PropertyName = @"inboxQualityScore", Order = 1)]
        [DataMember(Name = @"InboxQualityScore", Order = 1)]
        public double InboxQualityScore { get; set; }

        /// <summary>
        /// Gets or sets the send recommendation.
        /// </summary>
        /// <value>
        /// The send recommendation.
        /// </value>
        [ProtoMember(2)]
        [JsonProperty(PropertyName = @"sendRecommendation", Order = 2)]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = @"SendRecommendation", Order = 2)]
        public SendAssessType SendRecommendation { get; set; }
    }
}