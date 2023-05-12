using System;

namespace FMS.Core.Common.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime MaxOf(this DateTime @this, DateTime d) => @this > d ? @this : d;
        public static DateTime MaxOf(this DateTime @this, DateTime? d) => d == null ? @this : @this.MaxOf(d.Value);
        public static DateTime? Max(DateTime? d1, DateTime? d2) => d1 == null ? d2 : d1.Value.MaxOf(d2);

        public static DateTime MinOf(this DateTime @this, DateTime d) => @this < d ? @this : d;
        public static DateTime MinOf(this DateTime @this, DateTime? d) => d == null ? @this : @this.MinOf(d.Value);
        public static DateTime? Min(DateTime? d1, DateTime? d2) => d1 == null ? d2 : d1.Value.MinOf(d2);

        public static DateTime LastTickOfDay(this DateTime @this) => @this.Date.AddDays(1).AddTicks(-1);
    }
}
