namespace GlidepathCodingChallengeConsole.Numbers
{
    public interface IReaderAndWriterToDisk
    {
        int ParseLast();
        int ParsePrevious();
        bool AppendLast(int number);
    }
}