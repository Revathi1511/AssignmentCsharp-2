using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentCsharp.Controllers
{
    public class J3Controller : ApiController
    {
        public int GetLocalTime()
        {
            // Get the user's time zone based on their location in Canada
            TimeZoneInfo userTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"); // replace with the user's actual time zone ID

            // Get the current local time in the user's time zone
            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, userTimeZone);

            // Format the local time as an integer in the format YYYYMMDDHHmmss
            int localTimeInt = int.Parse(localTime.ToString("yyyyMMddHHmmss"));

            return localTimeInt;
        }

        public void SendMessage(string text)
        {
            int localTime = GetLocalTime();

            // Attach the local time to the text message
            string message = $"{text} ({localTime})";

            // Send the message
            // ...
        }
    }
}
