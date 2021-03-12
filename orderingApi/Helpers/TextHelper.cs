using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

namespace OrderingApi.Helpers
{
    public static class TextHelper
    {
        public static string ConvertListToString(List<int> list)
        {
            if (list.Count == 0)
            {
                return string.Empty;
            }

            return string.Join(" ", list);
        }

        public static List<int> ConvertStringToArray(this string list)
        {
            List<int> listOfNumbers = list.Split(' ').Select(Int32.Parse).ToList();

            return listOfNumbers;
        }
    }
}
