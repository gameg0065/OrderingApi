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
    }
}
