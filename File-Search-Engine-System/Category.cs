using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Search_Engine_System
{
    public class Category
    {
        public string categoryName;
        public List<string> keywords;
        public Category()
        {
            categoryName = "";
            keywords = new List<string>();
        }
    }
}
