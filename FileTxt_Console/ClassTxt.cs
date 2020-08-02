using System;
using System.IO;

namespace FileTxt_Console
{
    class ClassTxt
    {
        private string _path;
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        public void txtsile(string Content, string str)
        {
            if (!File.Exists(Path))
            {
                using (StreamWriter sw = File.CreateText(Path))
                {
                    if (str == "yes")
                    {
                        sw.WriteLine(Content);
                    }
                }
            }

        }
        public void ShowFile(string Path)
        {
            using (StreamReader sr = File.OpenText(Path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
