using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Utility
{
    public static class DateTimeExtensions
    {
        public static DateTime? ToViDate(this string input)
        {
            DateTime dt;
            if (DateTime.TryParseExact(input, "dd/MM/yyyy", null,
                                   DateTimeStyles.None,
                out dt))
            {
                //valid date
                return dt;
            }

            return null;
        }

        public static string ToViDate(this DateTime date)
        {

            return string.Format("{0: dd/MM/yyyy}", date);
        }
    }
}
