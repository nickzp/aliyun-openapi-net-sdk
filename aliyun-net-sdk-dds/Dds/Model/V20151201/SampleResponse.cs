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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class SampleResponse : AcsResponse
	{

		private string requestId;

		private string securityIps;

		private List<Sample_SecurityIpGroup> securityIpGroups;

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

		public string SecurityIps
		{
			get
			{
				return securityIps;
			}
			set	
			{
				securityIps = value;
			}
		}

		public List<Sample_SecurityIpGroup> SecurityIpGroups
		{
			get
			{
				return securityIpGroups;
			}
			set	
			{
				securityIpGroups = value;
			}
		}

		public class Sample_SecurityIpGroup
		{

			private string securityIpGroupName;

			private string securityIpGroupAttribute;

			private string securityIpList;

			public string SecurityIpGroupName
			{
				get
				{
					return securityIpGroupName;
				}
				set	
				{
					securityIpGroupName = value;
				}
			}

			public string SecurityIpGroupAttribute
			{
				get
				{
					return securityIpGroupAttribute;
				}
				set	
				{
					securityIpGroupAttribute = value;
				}
			}

			public string SecurityIpList
			{
				get
				{
					return securityIpList;
				}
				set	
				{
					securityIpList = value;
				}
			}
		}
	}
}
