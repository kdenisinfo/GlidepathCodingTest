
using GlidepathCodingChallengeConsole.Numbers;

namespace GlidepathCodingChallengeConsole
{
    //public class DisplayingNumber {
    //    private int totalnumber { get; set; }
    //    public DisplayingNumber(int totalnumber) { this.totalnumber = totalnumber; }

    class Program
    {
        static void Main(string[] args)
        {
            var Entrying = new EntryingNumber(args);
            var ReadAndWrite = new ReadAndWriteToDisk("test.txt");

            var NumberTwo = ReadAndWrite.Read();

            var AddingNumbers = new AddingNumbers(Entrying.Number, NumberTwo);

            AddingNumbers.DisplayingNumber();
        }
    }
}
