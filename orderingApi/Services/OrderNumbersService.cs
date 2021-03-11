using System.Collections.Generic;
using OrderingApi.Services.Interfaces;
using System;

namespace OrderingApi.Services
{
    public class OrderNumbersService : IOrderNumbersService
    {
        public OrderNumbersService()
        {

        }

        public List<int> SortListOfNumbers(List<int> list)
        {
            Console.WriteLine("works List!!");
            return new List<int>(new int[] { 9, 9, 9 });
        }


        public List<int> GetLastResult()
        {
            Console.WriteLine("works!!");
            return new List<int>(new int[] { 8, 8, 8 });
        }

    }
}
