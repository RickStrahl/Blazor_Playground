using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo
{
    public class InteropFunctions
    {
        public static string FormatDate(DateTime date, string format)
        {
            return date.ToString(format);
        }
    }
}
