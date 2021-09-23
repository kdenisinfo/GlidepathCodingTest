
using GlidepathCodingChallengeConsole.Numbers;
using System;

namespace GlidepathCodingChallengeConsole
{
    class Program
    {
        public const string filepath = @"C:\Users\denis\Source\Repos\kdenisinfo\GlidepathCodingTest\GlidepathCodingChallengeConsole\GlidepathCodingChallengeConsole\test.txt";

        static void Main(string[] args)
        {
            var entryline =  Console.ReadLine();

            var readerWriter = new ReaderAndWriterToDisk(filepath, @"./");
            var entrying = new EntryingNumber(entryline);
            var numberPrevious = readerWriter.ParsePrevious();

            var addingNumbers = new AddingNumbers(entrying.Number, numberPrevious);
            readerWriter.AppendLast(addingNumbers.TotalNumber);

            addingNumbers.DisplayingNumber();

            var exitline = Console.ReadKey();
        }
    }
}
