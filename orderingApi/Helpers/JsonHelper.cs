using System;
using System.Text.Json;
using System.Collections.Generic;

namespace OrderingApi.Helpers
{
    public static class JsonHelper
    {
        public static string CreateJsonString(List<int> list)
        {
            if (list.Count == 0)
            {
                return string.Empty;
            }

            return JsonSerializer.Serialize(list);
        }

        public static List<int> DeserializeJsonToIntList(this string list)
        {
            List<int> listOfNumbers = JsonSerializer.Deserialize<List<int>>(list);

            return listOfNumbers;
        }
    }
}
