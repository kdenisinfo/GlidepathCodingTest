
using GlidepathCodingChallengeConsole.Numbers;
using System;

namespace GlidepathCodingChallengeConsole
{
    class Program
    {
        public const string filepath = @"C:\Users\denis\Source\Repos\kdenisinfo\GlidepathCodingTest\GlidepathCodingChallengeConsole\GlidepathCodingChallengeConsole\";
        public const string filename = @"test.txt";


        static void Main(string[] args)
        {
            var enterline =  Console.ReadLine();

            var readerWriter = new FilesHandler(filename, filepath);
            var entering = new EnteringNumber(enterline);
            entering.ParseNumber();

            var numberPrevious = readerWriter.ParsePrevious();

            var addingNumbers = new AddingNumbers(entering.Number, numberPrevious);
            readerWriter.AppendLast(addingNumbers.TotalNumber);

            addingNumbers.DisplayingNumber();

            var exitline = Console.ReadKey();
        }
    }
}
