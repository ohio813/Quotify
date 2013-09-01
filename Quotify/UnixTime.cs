using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotify
{
    /// <summary>
    /// Utility class for converting to and from UNIX timestamps.
    /// </summary>
    static class UnixTime
    {
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// Converts a UNIX timestamp to a .NET DateTime in UTC.
        /// </summary>
        /// <param name="timestamp">The UNIX timestamp.</param>
        /// <returns>The .NET DateTime in UTC.</returns>
        public static DateTime ToDateTime(long timestamp)
        {
            return Epoch.AddSeconds(timestamp);
        }

        /// <summary>
        /// Converts a .NET DateTime to a UNIX timestamp.
        /// </summary>
        /// <param name="time">The DateTime to convert.</param>
        /// <returns>The equivalent UNIX timestamp.</returns>
        public static long FromDateTime(DateTime time)
        {
            return (long)time.ToUniversalTime().Subtract(Epoch).TotalSeconds;
        }
    }
}
