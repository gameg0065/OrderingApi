using System;
using Xunit;
using System.Collections.Generic;
using OrderingApi.Services;
using System.Linq;

namespace OrderingApi.Tests
{
    public class SortingServiceTest
    {
        [Fact]
        public void BubbleSortTest1()
        {
            var input = new List<int>(new int[] { 2, 1, 3 });
            var output = new List<int>(new int[] { 1, 2, 3 });

            var sortingService = new SortingService();
            var list = sortingService.SortWithBubbleSort(input);

            var firstNotSecond = list.Except(output).ToList();
            var secondNotFirst = output.Except(list).ToList();

            bool result = !firstNotSecond.Any() && !secondNotFirst.Any();

            Assert.True(result, "Sorted value is not correct !");
        }
        [Fact]
        public void BubbleSortTest2()
        {
            var input = new List<int>(new int[] { 2, 1, 3, 66, 33, 22, 12, 453, 53, 54, 87, 43 });
            var output = new List<int>(new int[] { 1, 2, 3, 12, 22, 33, 43, 53, 54, 66, 87, 453 });

            var sortingService = new SortingService();
            var list = sortingService.SortWithBubbleSort(input);

            var firstNotSecond = list.Except(output).ToList();
            var secondNotFirst = output.Except(list).ToList();

            bool result = !firstNotSecond.Any() && !secondNotFirst.Any();

            Assert.True(result, "Sorted value is not correct !");
        }

        [Fact]
        public void InsertionSortTest1()
        {
            var input = new List<int>(new int[] { 2, 1, 3 });
            var output = new List<int>(new int[] { 1, 2, 3 });

            var sortingService = new SortingService();
            var list = sortingService.SortWithInsertionSort(input);

            var firstNotSecond = list.Except(output).ToList();
            var secondNotFirst = output.Except(list).ToList();

            bool result = !firstNotSecond.Any() && !secondNotFirst.Any();

            Assert.True(result, "Sorted value is not correct !");
        }

        [Fact]
        public void InsertionSortTest2()
        {
            var input = new List<int>(new int[] { 2, 1, 3 });
            var output = new List<int>(new int[] { 1, 2, 3 });

            var sortingService = new SortingService();
            var list = sortingService.SortWithInsertionSort(input);

            var firstNotSecond = list.Except(output).ToList();
            var secondNotFirst = output.Except(list).ToList();

            bool result = !firstNotSecond.Any() && !secondNotFirst.Any();

            Assert.True(result, "Sorted value is not correct !");
        }

        [Fact]
        public void ShellSortTest1()
        {
            var input = new List<int>(new int[] { 2, 1, 3 });
            var output = new List<int>(new int[] { 1, 2, 3 });

            var sortingService = new SortingService();
            var list = sortingService.SortWithShellSort(input);

            var firstNotSecond = list.Except(output).ToList();
            var secondNotFirst = output.Except(list).ToList();

            bool result = !firstNotSecond.Any() && !secondNotFirst.Any();

            Assert.True(result, "Sorted value is not correct !");
        }

        [Fact]
        public void ShellSortTest2()
        {
            var input = new List<int>(new int[] { 2, 1, 3, 66, 33, 22, 12, 453, 53, 54, 87, 43 });
            var output = new List<int>(new int[] { 1, 2, 3, 12, 22, 33, 43, 53, 54, 66, 87, 453 });

            var sortingService = new SortingService();
            var list = sortingService.SortWithShellSort(input);

            var firstNotSecond = list.Except(output).ToList();
            var secondNotFirst = output.Except(list).ToList();

            bool result = !firstNotSecond.Any() && !secondNotFirst.Any();

            Assert.True(result, "Sorted value is not correct !");
        }

        [Fact]
        public void ShellQuickTest1()
        {
            var input = new List<int>(new int[] { 2, 1, 3 });
            var output = new List<int>(new int[] { 1, 2, 3 });

            var sortingService = new SortingService();
            var list = sortingService.SortWithQuickSort(input);

            var firstNotSecond = list.Except(output).ToList();
            var secondNotFirst = output.Except(list).ToList();

            bool result = !firstNotSecond.Any() && !secondNotFirst.Any();

            Assert.True(result, "Sorted value is not correct !");
        }

        [Fact]
        public void ShellQuickTest2()
        {
            var input = new List<int>(new int[] { 2, 1, 3, 66, 33, 22, 12, 453, 53, 54, 87, 43 });
            var output = new List<int>(new int[] { 1, 2, 3, 12, 22, 33, 43, 53, 54, 66, 87, 453 });

            var sortingService = new SortingService();
            var list = sortingService.SortWithQuickSort(input);

            var firstNotSecond = list.Except(output).ToList();
            var secondNotFirst = output.Except(list).ToList();

            bool result = !firstNotSecond.Any() && !secondNotFirst.Any();

            Assert.True(result, "Sorted value is not correct !");
        }
    }
}
