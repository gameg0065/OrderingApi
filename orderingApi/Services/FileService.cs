
using OrderingApi.Services.Interfaces;
using System.IO;

namespace OrderingApi.Services
{
    public class FileService : IFileService
    {
        public FileService()
        {
        }

        public void SaveToFile(string sortedList)
        {
            File.WriteAllTextAsync("result.txt", sortedList);
        }

        public string ReadFromFile()
        {
            var textFromFile = File.ReadAllText(@"result.txt");
            return textFromFile;
        }

    }
}
