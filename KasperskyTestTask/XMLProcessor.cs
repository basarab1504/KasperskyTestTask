using System.IO;

namespace KasperskyTestTask
{
    public class XMLSource : IFileSource
    {
        public bool CanProcess(string fileName)
        {
            return Path.GetExtension(fileName) == ".xml";
        }

        public void Process(string fileName)
        {
            System.Console.WriteLine("it's a xml!");
        }
    }
}
