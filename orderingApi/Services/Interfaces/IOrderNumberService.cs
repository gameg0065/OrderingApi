using OrderingApi.Models;


namespace OrderingApi.Services.Interfaces
{
    public interface IOrderNumbersService
    {
        string GetLastResult();
        string SortListOfNumbers(string numbersToSort);
        SortingMeasureModel MeasureSortListOfNumbers(string numbersToSort);

    }
}
