using OrderingApi.Services.Interfaces;
using OrderingApi.Helpers;
using OrderingApi.Models;

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

            var sortedList = _sortingService.SortWithQuickSort(list);

            var sortedListAsString = TextHelper.ConvertListToString(sortedList);

            _fileService.SaveToFile(sortedListAsString);

            return sortedListAsString;
        }

        public SortingMeasureModel MeasureSortListOfNumbers(string numbersToSort)
        {
            var sortingMeasureModel = new SortingMeasureModel();
            var list = TextHelper.ConvertStringToArray(numbersToSort);


            var watch = System.Diagnostics.Stopwatch.StartNew();

            _sortingService.SortWithBubbleSort(list);

            watch.Stop();
            sortingMeasureModel.BubbleSortTime = watch.ElapsedMilliseconds;

            watch = System.Diagnostics.Stopwatch.StartNew();

            _sortingService.SortWithInsertionSort(list);

            watch.Stop();
            sortingMeasureModel.InsertionSortTime = watch.ElapsedMilliseconds;

            watch = System.Diagnostics.Stopwatch.StartNew();

            _sortingService.SortWithShellSort(list);

            watch.Stop();
            sortingMeasureModel.ShellSortTime = watch.ElapsedMilliseconds;

            watch = System.Diagnostics.Stopwatch.StartNew();

            var sortedList = _sortingService.SortWithQuickSort(list);

            watch.Stop();
            sortingMeasureModel.QuickSortTime = watch.ElapsedMilliseconds;



            var sortedListAsString = TextHelper.ConvertListToString(sortedList);

            _fileService.SaveToFile(sortedListAsString);

            sortingMeasureModel.result = sortedListAsString;

            return sortingMeasureModel;
        }

        public string GetLastResult()
        {
            return _fileService.ReadFromFile();
        }

    }
}
