using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System;


namespace OrderingApi.Services.Interfaces
{
    public interface IOrderNumbersService
    {
        List<int> GetLastResult();
        List<int> SortListOfNumbers(List<int> list);

    }
}
