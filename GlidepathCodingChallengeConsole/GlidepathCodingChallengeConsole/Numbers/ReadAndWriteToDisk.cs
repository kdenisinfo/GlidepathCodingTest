namespace GlidepathCodingChallengeConsole.Numbers
{
    public class ReadAndWriteToDisk : IReadAndWriteToDisk
    {
        private string fileName { get; set; }
        private string FileLocationAtDisk { get; set; }

        public ReadAndWriteToDisk(string filename) { this.fileName = fileName; }

        public int Read() {// read from the dissk 
        }
        public bool Write(int number) { // write to the disk  
        }
    }

    //public class DisplayingNumber {
    //    private int totalnumber { get; set; }

    //    public DisplayingNumber(int totalnumber) { this.totalnumber = totalnumber; }
    }
