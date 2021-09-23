namespace GlidepathCodingChallengeConsole.Numbers
{
    public class ReadAndWriteToDisk : IReadAndWriteToDisk
    {
        private string fileName { get; set; }
        private string fileLocation { get; set; }

        public ReadAndWriteToDisk(string filename, string filelocation)
        {
            this.fileName = fileName;
            this.fileLocation = filelocation;
        }

        public int Read() {
            // read from the dissk 
        }
        public bool Write(int number) { 
            // write to the disk  
        }
    }
}
