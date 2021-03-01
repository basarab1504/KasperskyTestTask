using System.IO;

namespace KasperskyTestTask
{
    public class JSONSource : IFileSource
    {
        public bool CanProcess(string fileName)
        {
            return Path.GetExtension(fileName) == ".json";
        }

        public void Process(string fileName)
        {
            System.Console.WriteLine("it's a json!");
        }
    }
}
