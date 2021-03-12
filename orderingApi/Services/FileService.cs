
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
            try
            {
                File.WriteAllTextAsync("result.txt", sortedList);
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException("Error writing file", e);
            }
        }

        public string ReadFromFile()
        {
            try
            {
                var textFromFile = File.ReadAllText(@"result.txt");
                return textFromFile;
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException("Error reading file", e);
            }
        }

    }
}
