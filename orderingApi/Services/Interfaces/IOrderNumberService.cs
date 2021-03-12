using System.Collections.Generic;


namespace OrderingApi.Services.Interfaces
{
    public interface IOrderNumbersService
    {
        string GetLastResult();
        string SortListOfNumbers(string numbersToSort);

    }
}
