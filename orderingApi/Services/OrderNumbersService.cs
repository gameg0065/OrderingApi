using System.Collections.Generic;
using OrderingApi.Services.Interfaces;
using OrderingApi.Helpers;
using System;
using System.IO;

namespace OrderingApi.Services
{
    public class OrderNumbersService : IOrderNumbersService
    {
        public OrderNumbersService()
        {

        }

        public List<int> SortListOfNumbers(List<int> list)
        {
            Console.WriteLine("works List!!");
            SaveToFile(list);
            return new List<int>(new int[] { 9, 9, 9 });
        }


        public List<int> GetLastResult()
        {
            return ReadFromFile();
        }

        private void SaveToFile(List<int> sortedList)
        {
            File.WriteAllTextAsync("result.txt", JsonHelper.CreateJsonString(sortedList));
        }

        private List<int> ReadFromFile()
        {
            var textFromFile = File.ReadAllText(@"result.txt");
            var list = JsonHelper.DeserializeJsonToIntList(textFromFile);
            return list;
        }

    }
}
