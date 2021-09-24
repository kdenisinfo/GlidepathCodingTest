using System;
using System.IO;

namespace GlidepathCodingChallengeConsole.Numbers
{
    public class FilesHandler : IFilesHadler
    {
        public string FileName { get; private set; }
        public string FilePath { get; private  set; }
        public string FullPathName { get; private set; }

        public FilesHandler(string name, string path)
        {
            // both must be provided 
            if (name.Equals("") || path.Equals("")) return; 

            this.FileName = name;
            this.FilePath = path;
            this.FullPathName = String.Format("{1}{0}", FileName, FilePath);
        }

        public int ParseLast()
        {
            var texts = File.ReadAllLines(this.FullPathName);
            var id = Convert.ToInt32(texts[texts.Length - 1]);
            return id;
        }

        public int ParsePrevious()
        {
            var texts = File.ReadAllLines(this.FullPathName);
            int? id = Convert.ToInt32(texts[texts.Length - 2]);
            if (id == null)
                id = 0;
            return (int)id;
        }

        public bool AppendLast(int number) {
            // write to the disk  
            var resultcode = false;
            using (FileStream fs = new FileStream(this.FullPathName, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(number);
                resultcode = true;
            }

            return resultcode;
        }
    }
}
