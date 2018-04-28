using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Search_Engine_System
{
    public class FILE
    {
        public string fileName;
        public string path;
        public List<string> fileCategories;
        public FILE()
        {
            fileName = "";
            path = "";
            fileCategories = new List<string>();
        }

        public List<int> countKeyword(string selectedKeyword)
        {
            List<int> list = new List<int>();
            FileStream fs = new FileStream(this.path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            int lineNumber = 0;
            while(sr.Peek()!=-1)
            {
                string line = sr.ReadLine();
                lineNumber++;
                string[] words = line.Split(' ',',','!','@','#','$','%','^','&','*','-','_','+','=','~');
                foreach(string word in words)
                {
                    if (word == selectedKeyword)
                        list.Add(lineNumber);
                }
            }
            return list;          
        }
    }
}
