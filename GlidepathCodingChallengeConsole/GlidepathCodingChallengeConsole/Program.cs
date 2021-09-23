
using GlidepathCodingChallengeConsole.Numbers;

namespace GlidepathCodingChallengeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var ReadAWrite = new ReadAndWriteToDisk("test.txt");
            var Entrying = new EntryingNumber(args);
            
            var NumberTwo = ReadAWrite.Read();
            var AddingNumbers = new AddingNumbers(Entrying.Number, NumberTwo);

            AddingNumbers.DisplayingNumber();
        }
    }
}
