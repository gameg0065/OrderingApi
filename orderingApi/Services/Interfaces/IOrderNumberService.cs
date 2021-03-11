using System.Collections.Generic;


namespace OrderingApi.Services.Interfaces
{
    public interface IOrderNumbersService
    {
        List<int> GetLastResult();
        List<int> SortListOfNumbers(List<int> list);

    }
}
