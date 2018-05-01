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
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.IO;

namespace File_Search_Engine_System
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        public static Dictionary<string, List<string>> D = new Dictionary<string, List<string>>();
        Dictionary<string, bool> CheckDict = new Dictionary<string, bool>();

        string categoryname, keyword;
        List<string> l = new List<string>();

        private void AddKeywordButton_Click(object sender, EventArgs e)
        {
            if (KeywordtextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid keyword.");
                return;
            }
            if (!File.Exists("Categories.xml"))
            {

                keyword = KeywordtextBox.Text;

                l.Add(keyword);
                KeywordtextBox.Clear();
            }
            else
            {
                if (!D.ContainsKey(CategorytextBox.Text))
                {
                    keyword = KeywordtextBox.Text;

                    l.Add(keyword);
                    KeywordtextBox.Clear();

                }

            }
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            fillCatCombo();

            if (File.Exists("Categories.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Categories.xml");

                XmlNodeList list = doc.GetElementsByTagName("Category");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList child = list[i].ChildNodes;
                    for (int j = 0; j < child.Count; j++)
                    {

                        string value = child[0].InnerText;

                        CheckDict[value] = true;

                    }

                }
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Home home = new File_Search_Engine_System.Home();
            home.Show();
            this.Hide();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
           
            catCombo.Items.Add(CategorytextBox.Text);

            if (!File.Exists("Categories.xml"))
            {
                XmlWriter writer = XmlWriter.Create("Categories.xml");
                writer.WriteStartDocument();
                List<string> newlist = new List<string>();
                if (CheckDict.ContainsKey(CategorytextBox.Text))
                    MessageBox.Show("This Category is already added!");
                else
                {
                    categoryname = CategorytextBox.Text;
                    D.Add(categoryname, l);
                    CheckDict[categoryname] = true;

                    Category C = new Category();
                    C.categoryName = categoryname;
                    Home.mapOfCategories[C.categoryName] = C;
                    foreach (string keyword in l)
                    {
                        Home.mapOfCategories[C.categoryName].keywords.Add(keyword);
                    }

                    MessageBox.Show("This category is successfully added!");
                    writer.WriteStartElement("Categories");
                    writer.WriteStartElement("Category");

                    writer.WriteStartElement("CategoryName");
                    writer.WriteString(categoryname);
                    writer.WriteEndElement();
                    foreach (var x in D[categoryname])
                    {
                        writer.WriteStartElement("Keyword");
                        writer.WriteString(x);
                        writer.WriteEndElement();

                    }


                    writer.WriteEndElement();

                    writer.WriteEndElement();

                    writer.WriteEndDocument();
                    writer.Close();

                    l.Clear();
                }
            }

            else
            {

                XmlDocument doc = new XmlDocument();
                doc.Load("Categories.xml");
                List<string> newlist = new List<string>();
                if (CheckDict.ContainsKey(CategorytextBox.Text))
                    MessageBox.Show("This Category is already added!");
                else
                {
                    categoryname = CategorytextBox.Text;
                    D.Add(categoryname, l);
                    CheckDict[categoryname] = true;

                    Category C = new Category();
                    C.categoryName = categoryname; ;
                    Home.mapOfCategories[C.categoryName] = C;
                    foreach(string keyword in l)
                    {
                        Home.mapOfCategories[C.categoryName].keywords.Add(keyword);
                    }

                    XmlElement cat = doc.CreateElement("Category");

                    XmlElement node = doc.CreateElement("CategoryName");
                    node.InnerText = categoryname;
                    cat.AppendChild(node);

                    foreach (var x in D[categoryname])
                    {
                        XmlElement node1 = doc.CreateElement("Keyword");
                        node1.InnerText = x;
                        cat.AppendChild(node1);

                    }
                    XmlElement root = doc.DocumentElement;
                    root.AppendChild(cat);
                    doc.Save("Categories.xml");

                    l.Clear();
                }

            }
        }

        private void catCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoRichTextBox.Visible = true;
            infoRichTextBox.Clear();

            string selectedCat = catCombo.SelectedItem.ToString();


            List<string> keywords = new List<string>();
            keywords = Home.mapOfCategories[selectedCat].keywords;

            string CatNameValue = Home.mapOfCategories[selectedCat].categoryName;

            infoRichTextBox.Text += "Category Name: " + CatNameValue + Environment.NewLine;
            infoRichTextBox.Text += "Keywords: ";

            for (int i = 0; i < keywords.Count; i++)
            {
                if (i != keywords.Count - 1)
                    infoRichTextBox.Text += keywords[i] + ", ";

                else
                    infoRichTextBox.Text += keywords[i] + ".";

            }


            //coloring tag names
            int start = 0;
            int end = infoRichTextBox.Text.LastOrDefault();

            while (start < end)
            {
                infoRichTextBox.Find("Category Name:", start, infoRichTextBox.TextLength, RichTextBoxFinds.MatchCase);
                infoRichTextBox.SelectionColor = Color.DarkMagenta;
                infoRichTextBox.Find("Keywords:", start, infoRichTextBox.TextLength, RichTextBoxFinds.MatchCase);
                infoRichTextBox.SelectionColor = Color.DarkMagenta;


                start = infoRichTextBox.Text.LastOrDefault() + 1;
            }

        }

        private void filesButton_Click(object sender, EventArgs e)
        {
            AddFile form = new AddFile();
            form.Show();
            this.Hide();
        }

        private void AddCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fillCatCombo()
        {
            foreach (KeyValuePair<string, Category> KVP in Home.mapOfCategories)
            {
                catCombo.Items.Add(KVP.Key);
            }
        }

    }

}

