/*
 * MeetupManager:
 * Copyright (C) 2013 Refractored LLC: 
 * http://github.com/JamesMontemagno
 * http://twitter.com/JamesMontemagno
 * http://refractored.com
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Cirrious.MvvmCross.Community.Plugins.Sqlite;

namespace MeetupManager.Portable.Models.Database
{
	public class EventRSVP : BusinessEntityBase
	{
		public EventRSVP ()
		{
		}

		public EventRSVP (string eventId, string userId, string eventName, string groupId, string groupName, long eventDate)
		{
			EventId = eventId;
			UserId = userId;
		  EventName = eventName;
		  GroupId = groupId;
		  GroupName = groupName;
		  EventDate = eventDate;
		}

		public string UserId { get; set; }

		[Indexed]
		public string EventId { get; set; }

    public string EventName { get; set; }

    [Indexed]
    public string GroupId { get; set; }

    public string GroupName { get; set; }

    public long EventDate { get; set; }
	}
}

