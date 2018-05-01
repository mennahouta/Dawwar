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
        }

        private void fillFilesMap()
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
                    string[] cats = attributes[2].InnerText.Split(' ');
                    foreach (string c in cats)
                    {
                        if (c.Length != 0)
                            f.fileCategories.Add(c);
                        //MessageBox.Show(c);
                    }
                    mapOfFiles[f.fileName] = f;
                    //MessageBox.Show(f.fileName + ' ' + mapOfFiles[f.fileName].fileCategories.Count.ToString());
                }

            }

        }

        private void fillCatMapAndCombo()
        {
            if (File.Exists("Categories.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Categories.xml");
                XmlNodeList cats = doc.GetElementsByTagName("Category");
                foreach (XmlNode cat in cats)
                {
                    XmlNodeList attributes = cat.ChildNodes;
                    Category C = new Category();
                    C.categoryName = attributes[0].InnerText;
                    searchCombo.Items.Add(C.categoryName);
                    for (int i = 1; i < attributes.Count; i++)
                    {
                        C.keywords.Add(attributes[i].InnerText);
                    }
                    mapOfCategories[C.categoryName] = C;
                }
            }
        }

        private void clearRich()
        {
            searchRichTextBox.Clear();
            searchRichTextBox.SelectionStart = 0;
            searchRichTextBox.SelectAll();
            searchRichTextBox.SelectionBackColor = Color.White;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            fillFilesMap();
            fillCatMapAndCombo();
        }

        private void catButton_Click(object sender, EventArgs e)
        {
            AddCategory form = new AddCategory();
            form.Show();
            this.Hide();
        }

        private void filesButton_Click(object sender, EventArgs e)
        {
            AddFile form = new AddFile();
            form.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(searchCombo.SelectedIndex==-1)
            {
                MessageBox.Show("Please select a category first.");
                return;
            }

            clearRich();
            fileCombo.SelectedIndex = -1;
            fileCombo.Items.Clear();

            string selectedCategory = searchCombo.Text;
            if (!File.Exists("TextFiles.xml") || mapOfFiles.Count==0)
            {
                MessageBox.Show("Please add file(s) before searching.");
            }

            else
            {
                searchRichTextBox.Visible = true;
                List<string> filesList = new List<string>();
                foreach (KeyValuePair<string,FILE> KVP in mapOfFiles)
                {
                    foreach (string category in KVP.Value.fileCategories)
                    {
                        if (category == selectedCategory)
                        {
                            filesList.Add(KVP.Key);
                            break;
                        }

                    }
                }

                List<string> keywords = new List<string>();
                keywords = mapOfCategories[selectedCategory].keywords;
                bool occurred;
                for (int i = 0; i < keywords.Count(); i++)
                {
                    occurred = false;
                    searchRichTextBox.Text += keywords[i] + ":\n";
                    foreach (string file in filesList)
                    {
                        List<int> lineNumbers = mapOfFiles[file].countKeyword(keywords[i]);
                        if (lineNumbers.Count != 0)
                        {
                            occurred = true;
                            searchRichTextBox.Text += "     File: " + file + '\n';
                            searchRichTextBox.Text += "         Number of occurrences: " + lineNumbers.Count().ToString() + '\n';
                            searchRichTextBox.Text += "         Line number(s): ";
                            for (int j = 0; j < lineNumbers.Count(); j++)
                            {
                                if (j != 0)
                                    searchRichTextBox.Text += ", ";
                                searchRichTextBox.Text += lineNumbers[j];
                            }
                            searchRichTextBox.Text += "\n";

                            fileLabel.Visible = true;
                            fileCombo.Visible = true;
                            viewButton.Visible = true;
                            if (!fileCombo.Items.Contains(file))
                                fileCombo.Items.Add(file);
                        }
                    }
                    if(!occurred)
                    {
                        searchRichTextBox.Text += "     No occurrences found.\n";
                    }

                }

                //coloring keywords
                int startIndex = 0;
                foreach (string s in keywords)
                {
                    while (startIndex < searchRichTextBox.TextLength)
                    {
                        int returnedIndex = searchRichTextBox.Find(s, startIndex, RichTextBoxFinds.None);
                        if (returnedIndex != -1)
                        {
                            searchRichTextBox.SelectionStart = returnedIndex;
                            searchRichTextBox.SelectionLength = s.Length;
                            searchRichTextBox.SelectionColor = Color.DarkMagenta;
                            startIndex = returnedIndex + s.Length;
                            break;
                        }
                    }
                }

            }

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (fileCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a file first.");
                return;
            }

            clearRich();

            FileStream fs = new FileStream(mapOfFiles[fileCombo.SelectedItem.ToString()].path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                searchRichTextBox.Text += line + '\n';
            }

            List<string> keywords = mapOfCategories[searchCombo.SelectedItem.ToString()].keywords;
            foreach (string keyword in keywords)
            {
                int startIndex = 0;
                while (startIndex < searchRichTextBox.TextLength)
                {
                    int returnedIndex = searchRichTextBox.Find(keyword, startIndex, RichTextBoxFinds.None);
                    if (returnedIndex != -1)
                    {
                        searchRichTextBox.SelectionStart = returnedIndex;
                        searchRichTextBox.SelectionLength = keyword.Length;
                        searchRichTextBox.SelectionBackColor = Color.Yellow;
                        startIndex = returnedIndex + keyword.Length;
                    }
                    else
                        break;

                }
            }
            sr.Close();
        }

    }
}
