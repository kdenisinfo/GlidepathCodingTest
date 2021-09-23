namespace GlidepathCodingChallengeConsole.Numbers
{
    public interface IReadAndWriteToDisk
    {
        int ParseLast();
        int ParsePrevious();
        bool AppendLast(int number);
    }
}