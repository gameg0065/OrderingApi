using System;
using System.Collections.Generic;

namespace OrderingApi.Models
{
    public class SortingMeasureModel
    {
        public long BubbleSortTime { get; set; }
        public long InsertionSortTime { get; set; }
        public long ShellSortTime { get; set; }
        public long QuickSortTime { get; set; }
        public string result { get; set; }
    }
}
