using System.Collections.Generic;


namespace OrderingApi.Services.Interfaces
{
    public interface IFileService
    {
        void SaveToFile(string sortedList);
        string ReadFromFile();
    }
}
