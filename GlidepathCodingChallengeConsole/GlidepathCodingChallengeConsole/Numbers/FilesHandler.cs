using System;
using System.IO;

namespace GlidepathCodingChallengeConsole.Numbers
{
    public class FilesHandler : IFilesHadler
    {
        public string filename { get; private set; }
        public string filepath { get; private  set; }

        public FilesHandler(string filename, string filelocation)
        {
            this.filename = filename;
            this.filepath = filelocation;
        }

        public int ParseLast()
        {
            var texts = File.ReadAllLines(filename);
            var id = Convert.ToInt32(texts[texts.Length - 1]);
            return id;
        }

        public int ParsePrevious()
        {
            var texts = File.ReadAllLines(filename);
            int? id = Convert.ToInt32(texts[texts.Length - 2]);
            if (id == null)
                id = 0;
            return (int)id;
        }

        public bool AppendLast(int number) {
            // write to the disk  
            var resultcode = false;
            using (FileStream fs = new FileStream(filename, FileMode.Append, FileAccess.Write))
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
