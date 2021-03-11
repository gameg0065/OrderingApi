using System.Collections.Generic;
using OrderingApi.Services.Interfaces;
using OrderingApi.Helpers;
using System;
using System.IO;

namespace OrderingApi.Services
{
    public class OrderNumbersService : IOrderNumbersService
    {
        private readonly ISortingService _sortingService;
        public OrderNumbersService(ISortingService sortingService)
        {
            _sortingService = sortingService;
        }

        public List<int> SortListOfNumbers(List<int> list)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var sortedList = _sortingService.SortWithQuickSort(list);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            SaveToFile(sortedList);
            return sortedList;
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
