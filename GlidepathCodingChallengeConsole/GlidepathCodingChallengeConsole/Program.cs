
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

            var readAWrite = new ReadAndWriteToDisk(filepath, @"./");
            var entrying = new EntryingNumber(entryline);
            var numberPrevious = readAWrite.ParsePrevious();

            var addingNumbers = new AddingNumbers(entrying.Number, numberPrevious);
            readAWrite.AppendLast(addingNumbers.TotalNumber);

            addingNumbers.DisplayingNumber();

            var exitline = Console.ReadKey();
        }
    }
}
