namespace KasperskyTestTask
{
    public class FileProcessor
    {
        public IFileSource FileSource { get; set; }

        public void ProcessFile(string fileName)
        {
            if (FileSource.CanProcess(fileName))
                FileSource.Process(fileName);
        }
    }
}
