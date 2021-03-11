using System.Collections.Generic;
using OrderingApi.Services.Interfaces;
using System;

namespace OrderingApi.Services
{
    public class SortingService : ISortingService
    {
        public SortingService()
        {
        }


        public List<int> SortWithBubbleSort(List<int> list)
        {
            var size = list.Count - 1;
            for (int i = 0; i < size; i++)
            {
                var changed = false;
                for (int j = 0; j < size - i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        changed = true;
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
                if (!changed)
                {
                    break;
                }
            }
            return list;
        }
        public List<int> SortWithInsertionSort(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                var temp = list[i];
                var j = i - 1;
                while (j >= 0 && temp < list[j])
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = temp;
            }
            return list;
        }
        public List<int> SortWithShellSort(List<int> list)
        {
            var n = list.Count;
            var gap = n / 2;
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    var temp = list[i];
                    var j = i;
                    while (j >= gap && list[j - gap] > temp)
                    {
                        list[j] = list[j - gap];
                        j = j - gap;
                    }
                    list[j] = temp;
                }
                gap = gap / 2;
            }

            return list;
        }

        public List<int> SortWithQuickSort(List<int> list)
        {
            return QuickSort(list, 0, list.Count - 1);
        }
        private int Partition(List<int> list, int low, int high)
        {
            var i = low - 1;
            var pivot = list[high];
            for (int j = low; j <= high - 1; j++)
            {
                if (list[j] < pivot)
                {
                    i = i + 1;
                    var temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
            var temp1 = list[i + 1];
            list[i + 1] = list[high];
            list[high] = temp1;
            return i + 1;
        }

        private List<int> QuickSort(List<int> list, int low, int high)
        {
            if (low < high)
            {
                var pi = Partition(list, low, high);
                QuickSort(list, low, pi - 1);
                QuickSort(list, pi + 1, high);
            }
            return list;
        }

    }
}
