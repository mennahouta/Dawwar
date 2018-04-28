using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Diagnostics;

namespace File_Search_Engine_System
{
    public partial class Home : Form
    { 
        public static Dictionary<string, FILE> mapOfFiles = new Dictionary<string, FILE>();
        public static Dictionary<string, Category> mapOfCategories = new Dictionary<string, Category>();

        public Home()
        {
            InitializeComponent();
            fillFilesMap();
            fillCatMap();
        }

        public void fillFilesMap()
        {
            if (File.Exists("TextFiles.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("TextFiles.xml");
                XmlNodeList files = doc.GetElementsByTagName("FileInfo");
                foreach (XmlNode n in files)
                {
                    XmlNodeList attributes = n.ChildNodes;
                    FILE f = new FILE();
                    f.fileName = attributes[0].InnerText;
                    f.path = attributes[1].InnerText;
                    //MessageBox.Show(attributes[2].InnerText);
                    string [] cats = attributes[2].InnerText.Split(' ');
                    foreach(string c in cats)
                    {
                        if(c.Length!=0)
                            f.fileCategories.Add(c);
                        //MessageBox.Show(c);
                    }
                    mapOfFiles[f.fileName] = f;
                    //MessageBox.Show(f.fileName + ' ' + mapOfFiles[f.fileName].fileCategories.Count.ToString());
                }

            }

        }

        public void fillCatMap()
        {
            if(File.Exists("Categories.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Categories.xml");
                XmlNodeList cats = doc.GetElementsByTagName("Category");
                foreach(XmlNode cat in cats)
                {
                    XmlNodeList attributes = cat.ChildNodes;
                    Category C = new Category();
                    C.categoryName = attributes[0].InnerText;
                    for(int i=1; i<attributes.Count; i++)
                    {
                        C.keywords.Add(attributes[i].InnerText);
                    }
                    mapOfCategories[C.categoryName] = C;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddFile form = new AddFile();
            form.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchRichTextBox.Clear();
            string selectedCategory = searchCombo.Text;
            if (!File.Exists("TextFiles.xml"))
            {
                MessageBox.Show("Please add file(s) before searching.");
            }

            else
            {
                searchRichTextBox.Visible = true;
                XmlDocument filesDoc = new XmlDocument();
                filesDoc.Load("TextFiles.xml");
                XmlNodeList files = filesDoc.GetElementsByTagName("FileInfo");
                List<string> filesList = new List<string>();
                //DataRow row = searchGrid.Rows.Add();
                foreach (XmlNode file in files)
                {
                    XmlNodeList fileAttributes = file.ChildNodes;
                    string fileName = fileAttributes[0].InnerText;
                    string categories = fileAttributes[2].InnerText;
                    string[] catArr = categories.Split(' ');
                    foreach(string category in catArr)
                    {
                        if (category == selectedCategory)
                        {
                            filesList.Add(fileName);
                            break;
                        }
                            
                    }
                }

                List<string> keywords = new List<string>();
                keywords = mapOfCategories[selectedCategory].keywords;
                for(int i=0; i < keywords.Count(); i++)
                {
                    searchRichTextBox.Text += keywords[i] + ":\n";
                    foreach (string file in filesList)
                    {
                        List<int> lineNumbers = mapOfFiles[file].countKeyword(keywords[i]);
                        if (lineNumbers.Count == 0)
                        {
                            searchRichTextBox.Text += "     No occurrences found.\n";
                            continue;
                        }
                        searchRichTextBox.Text += "     File: " + file + '\n';
                        searchRichTextBox.Text += "     Number of occurrences: " + lineNumbers.Count().ToString() + '\n';              
                        searchRichTextBox.Text += "     Line number(s): ";
                        for (int j = 0; j < lineNumbers.Count(); j++)
                        {
                            if (j != 0)
                                searchRichTextBox.Text += ", ";
                            searchRichTextBox.Text += lineNumbers[j];
                        }
                        searchRichTextBox.Text += "\n";
                        
                    }
                    
                    
                }
            }

        }

        private void CategoryEditComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddCategory form = new AddCategory();
            form.Show();
            this.Hide();

        }

    }
}
