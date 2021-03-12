using OrderingApi.Services.Interfaces;
using OrderingApi.Helpers;

namespace OrderingApi.Services
{
    public class OrderNumbersService : IOrderNumbersService
    {
        private readonly ISortingService _sortingService;
        private readonly IFileService _fileService;
        public OrderNumbersService(ISortingService sortingService, IFileService fileService)
        {
            _sortingService = sortingService;
            _fileService = fileService;
        }

        public string SortListOfNumbers(string numbersToSort)
        {
            var list = TextHelper.ConvertStringToArray(numbersToSort);

            var watch = System.Diagnostics.Stopwatch.StartNew();

            var sortedList = _sortingService.SortWithQuickSort(list);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            var sortedListAsString = TextHelper.ConvertListToString(sortedList);

            _fileService.SaveToFile(sortedListAsString);

            return sortedListAsString;
        }

        public string GetLastResult()
        {
            return _fileService.ReadFromFile();
        }

    }
}
