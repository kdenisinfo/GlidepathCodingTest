using System;
using System.IO;

namespace GlidepathCodingChallengeConsole.Numbers
{
    public class ReaderAndWriterToDisk : IReaderAndWriterToDisk
    {
        private string fileName { get; set; }
        private string fileLocation { get; set; }

        public ReaderAndWriterToDisk(string filename, string filelocation)
        {
            this.fileName = filename;
            this.fileLocation = filelocation;
        }

        public int ParseLast()
        {
            var texts = File.ReadAllLines(fileName);
            var id = Convert.ToInt32(texts[texts.Length - 1]);
            return id;
        }

        public int ParsePrevious()
        {
            var texts = File.ReadAllLines(fileName);
            int? id = Convert.ToInt32(texts[texts.Length - 2]);
            if (id == null)
                id = 0;
            return (int)id;
        }

        public bool AppendLast(int number) {
            // write to the disk  
            var resultcode = false;
            using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                //sw.WriteLine('\n');
                sw.WriteLine(number);

                resultcode = true;
            }

            return resultcode;
        }
    }
}
