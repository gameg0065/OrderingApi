using System.Collections.Generic;


namespace OrderingApi.Services.Interfaces
{
    public interface ISortingService
    {
        List<int> SortWithBubbleSort(List<int> list);
        List<int> SortWithInsertionSort(List<int> list);
        List<int> SortWithShellSort(List<int> list);
        List<int> SortWithQuickSort(List<int> list);
    }
}
