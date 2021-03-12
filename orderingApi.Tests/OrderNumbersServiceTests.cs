using System;
using Xunit;
using OrderingApi.Services;
using OrderingApi.Services.Interfaces;

namespace OrderingApi.Tests
{
    public class OrderNumbersServiceTests
    {

        [Fact]
        public void SortStringOfNumbers1()
        {
            var input = "5 2 8 10 1";
            var output = "1 2 5 8 10";

            var orderingService = new OrderNumbersService(new SortingService(), new FileService());

            string sortedValue = orderingService.SortListOfNumbers(input);

            bool result = sortedValue == output;

            Assert.True(result, "Sorted value is not correct");
        }

        [Fact]
        public void SortStringOfNumbers2()
        {
            var input = "2 1 3 66 33 22 12 453 53 54 87 43";
            var output = "1 2 3 12 22 33 43 53 54 66 87 453";

            var orderingService = new OrderNumbersService(new SortingService(), new FileService());

            string sortedValue = orderingService.SortListOfNumbers(input);

            bool result = sortedValue == output;

            Assert.True(result, "Sorted value is not correct");
        }


    }
}
