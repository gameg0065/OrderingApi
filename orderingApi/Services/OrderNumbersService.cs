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

        public string SortListOfNumbers(string numbersToSort)
        {
            var list = TextHelper.ConvertStringToArray(numbersToSort);

            var watch = System.Diagnostics.Stopwatch.StartNew();

            var sortedList = _sortingService.SortWithQuickSort(list);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            var sortedListAsString = TextHelper.ConvertListToString(sortedList);

            SaveToFile(sortedListAsString);

            return sortedListAsString;
        }


        public string GetLastResult()
        {
            return ReadFromFile();
        }

        private void SaveToFile(string sortedList)
        {
            File.WriteAllTextAsync("result.txt", sortedList);
        }

        private string ReadFromFile()
        {
            var textFromFile = File.ReadAllText(@"result.txt");
            return textFromFile;
        }

    }
}
