namespace GlidepathCodingChallengeConsole.Numbers
{
    public interface IFilesHadler
    {
        int ParseLast();
        int ParsePrevious();
        bool AppendLast(int number);
    }
}