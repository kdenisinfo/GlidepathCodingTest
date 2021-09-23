using GlidepathCodingChallengeConsole;
using System;

namespace GlidepathCodingChallengeConsole
{
    public class EntryingNumber {
        public int Number { get; private set; }

        public EntryingNumber(string[] args) {
            this.Number = Int32.Parse(args[0]);
        }
    }

    public class ReadAndWriteToDisk {
        private string fileName { get; set; }
        private string FileLocationAtDisk { get; set; }

        public ReadAndWriteToDisk(string filename) { this.fileName = fileName; }

        public int Read() {// read from the dissk 
        }
        public Write(int number) { // write to the disk  
        }
    }

    public class AddingNumber {
        private int NumberOne { get; set; }
        private int NumberTwo { get; set; }
        public int TotalNumber { get; private set; }

        public AddingNumber(int numberone, int numbertwo)
        {
            this.NumberOne = numberone;
            this.NumberTwo = numbertwo;

            this.TotalNumber = NumberOne + NumberTwo;

            if (this.TotalNumber > 152) this.TotalNumber -= 152;
        }

        public void DisplayingNumber() { Console.Write("total number is: " + TotalNumber); }
    }

    //public class DisplayingNumber {
    //    private int totalnumber { get; set; }

    //    public DisplayingNumber(int totalnumber) { this.totalnumber = totalnumber; }
    }

    class Program
    {

        static void Main(string[] args)
        {
        var Entrying = new EntryingNumber(args);
        var ReadAndWrite = new ReadAndWriteToDisk("test.txt");
        var NumberTwo = ReadAndWrite.Read(); 
        var AddingNumbers = new AddingNumber(Entrying.Number, NumberTwo);


        }
    }
}
