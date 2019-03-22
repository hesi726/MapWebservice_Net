using System;
using System.Collections.Generic;
using System.Text;

namespace Mapservice_Core
{
    public static class DateTimeExtension
    {
        public static long ToTimestamp(this DateTime dateTime)
        {
            TimeSpan ts = dateTime - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds);
        }
    }
}
