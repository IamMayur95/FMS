using System;
using System.Collections.Generic;

namespace FMS.Core.Common.Utils
{
    /// <summary>
    /// Simple hash calculator helper
    /// </summary>
    public static class HashCalculator
    {
        /// <summary>
        /// Calculates hash of integer array
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns></returns>
        public static int GetIntArrayHash(IList<int> array)
        {
            var hc = array.Count;
            for (var i = 0; i < array.Count; ++i)
            {
                hc = unchecked(hc * 314159 + array[i]);
            }
            return hc;
        }

        /// <summary>
        /// Prepends date to int array in mmddyyyy format and returns has from <see cref="HashCalculator.GetIntArrayHash"/>
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="array">The array.</param>
        /// <param name="sort">if set to <c>true</c> array will be sorted prior to calculation</param>
        /// <returns></returns>
        public static int GetIntArrayHash(DateTime? date, IList<int> array, bool sort = true)
        {
            var newArray = new List<int>();
            if (date.HasValue)
            {
                var dd = date.Value.Day;
                var mm = date.Value.Month;
                var yy = date.Value.Year;
                newArray.AddRange(new[] { dd, mm, yy });
            }

            newArray.AddRange(array);

            if (sort)
                newArray.Sort();

            return GetIntArrayHash(newArray);
        }
    }
}
