namespace KasperskyTestTask
{
    public interface IFileSource
    {
        bool CanProcess(string fileName);
        void Process(string fileName);
    }
}
