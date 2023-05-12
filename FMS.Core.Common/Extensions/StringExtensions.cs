using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS.Core.Common.Extensions
{
    public static class StringExtensions
    {
        public static string ReduceLength(this string text, int maxLength)
        {
            return string.IsNullOrWhiteSpace(text) ? string.Empty : text.Substring(0, text.Length > maxLength ? maxLength : text.Length);
        }
    }
}
