using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Xml;
namespace File_Search_Engine_System
{

    public partial class AddFile : Form
    {
        public static List<string> Categories_Name = new List<string>();
        public static string path = @"C:\Users\Menna\Source\Repos\File-Search-Engine-System\Files\";

        public AddFile()
        {
            InitializeComponent();

        }

        private void loadFilesCombo()
        {
            foreach(KeyValuePair<string,FILE> KVP in Home.mapOfFiles)
            {
                fileCombo.Items.Add(KVP.Key);
            }
        }

        private void AddFile_Load(object sender, EventArgs e)
        {
            loadFilesCombo();

            if (!File.Exists("Categories.xml"))
            { MessageBox.Show("Please Add Categories First"); }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Categories.xml");
                XmlNodeList List = doc.GetElementsByTagName("Category");
                for (int i = 0; i < List.Count; i++)
                {
                    XmlNodeList child = List[i].ChildNodes;
                    string Category = child[0].InnerText;
                    catCheckList.Items.Add(Category);
                    Categories_Name.Add(Category);
                }

            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Home home = new File_Search_Engine_System.Home();
            home.Show();
            this.Hide();
        }

        private void catButton_Click(object sender, EventArgs e)
        {
            AddCategory cat = new File_Search_Engine_System.AddCategory();
            cat.Show();
            this.Hide();
        }

        private void newFileButton_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            //string path = @"C:\Users\Menna\Source\Repos\File-Search-Engine-System\Files\";
            string Url = path + str + ".txt";
            str = str + ".txt";
            bool fg = false;

            for (int i = 0; i < catCheckList.Items.Count; i++)
            {
                if (catCheckList.GetItemCheckState(i) == CheckState.Checked)
                {
                    fg = true;
                    break;
                }
            }
            if (str == ".txt")
            {
                MessageBox.Show("Please Enter A Valid Name.");
            }
            else if (fg == false)
            {
                MessageBox.Show("Please Select At Least 1 Category For The File.");
            }
            else
            {
                if (!File.Exists(Url))
                {
                    File.Create(Url).Dispose();

                    MessageBox.Show("File Added Successfully. Click On Edit To Start Writing In The File.");
                    if (!File.Exists("TextFiles.xml"))
                    {
                        List<string> categories = new List<string>();
                        XmlWriter writer = XmlWriter.Create("TextFiles.xml");
                        writer.WriteStartDocument();
                        writer.WriteStartElement("Table");
                        writer.WriteAttributeString("Name", "Files");
                        writer.WriteStartElement("FileInfo");
                        writer.WriteStartElement("FileName");
                        writer.WriteString(textBox1.Text);
                        writer.WriteEndElement();
                        writer.WriteStartElement("Path");
                        writer.WriteString(Url);
                        writer.WriteEndElement();
                        writer.WriteStartElement("Categories");
                        for (int i = 0; i < catCheckList.Items.Count; i++)
                        {
                            if (catCheckList.GetItemCheckState(i) == CheckState.Checked)
                            {
                                writer.WriteString(Categories_Name[i]);
                                writer.WriteString(" ");
                                categories.Add(Categories_Name[i]);
                            }
                        }

                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndDocument();

                        writer.Dispose();

                        FILE f = new FILE();
                        f.fileName = textBox1.Text;
                        f.path = Url;
                        Home.mapOfFiles[f.fileName] = f;
                        foreach (string cat in categories)
                        {
                            Home.mapOfFiles[f.fileName].fileCategories.Add(cat);
                        }

                        fileCombo.Items.Add(f.fileName);

                    }
                    else
                    {
                        List<string> categories = new List<string>();
                        XmlDocument doc = new XmlDocument();
                        XmlElement FileInfo = doc.CreateElement("FileInfo");
                        XmlElement node = doc.CreateElement("FileName");
                        node.InnerText = textBox1.Text;
                        FileInfo.AppendChild(node);
                        node = doc.CreateElement("Path");
                        node.InnerText = Url;
                        FileInfo.AppendChild(node);
                        node = doc.CreateElement("Categories");
                        bool f = false;
                        string node_text = "";
                        for (int i = 0; i < catCheckList.Items.Count; i++)
                        {
                            if (catCheckList.GetItemCheckState(i) == CheckState.Checked)
                            {
                                if (f == false)
                                {
                                    node_text = Categories_Name[i];
                                    node_text += " ";
                                    f = true;
                                }
                                else
                                {
                                    node_text += Categories_Name[i];
                                    node_text += " ";
                                }
                                categories.Add(Categories_Name[i]);
                            }
                        }
                        node.InnerText = node_text;
                        FileInfo.AppendChild(node);
                        doc.Load("TextFiles.xml");
                        XmlElement root = doc.DocumentElement;
                        root.AppendChild(FileInfo);
                        doc.Save("TextFiles.xml");

                        FILE ff = new FILE();
                        ff.fileName = textBox1.Text;
                        ff.path = Url;
                        Home.mapOfFiles[ff.fileName] = ff;
                        foreach (string cat in categories)
                        {
                            Home.mapOfFiles[ff.fileName].fileCategories.Add(cat);
                        }

                        fileCombo.Items.Add(ff.fileName);

                    }
                }
                else { MessageBox.Show("This File Already Exists. If You Want To Edit This File Click On Edit."); }
            }

        }

        private void editFileButton_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            //string path = @"C:\Users\Menna\Source\Repos\File-Search-Engine-System\Files\";
            string Url = path + str + ".txt";
            str = str + ".txt";
            if (str == ".txt")
            {
                MessageBox.Show("Please Enter A Valid Name.");
            }
            else if (!File.Exists(Url))
            {
                MessageBox.Show("This File Does Not Exist. If You Want To Add This File Click On Add.");

            }
            else { Process.Start(Url); }

        }

        private void deleteFileButton_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            //string path = @"C:\Users\Menna\Source\Repos\File-Search-Engine-System\Files\";
            string Url = path + str + ".txt";
            if (str == ".txt")
            {
                MessageBox.Show("Please Enter A Valid Name.");
            }
            else if (File.Exists(Url))
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want TO Delete The File?", "Warning", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    File.Delete(Url);
                    Home.mapOfFiles.Remove(str);
                    fileCombo.Items.Remove(str);
                    XmlDocument doc = new XmlDocument();
                    doc.Load("TextFiles.xml");
                    XmlNodeList nodes = doc.GetElementsByTagName("FileInfo");

                    for (int i = nodes.Count - 1; i >= 0; i--)
                    {
                        XmlNodeList childrens = nodes[i].ChildNodes;
                        string filename = childrens[0].InnerText;
                        if (filename == textBox1.Text)
                        { nodes[i].ParentNode.RemoveChild(nodes[i]); }
                    }
                    doc.Save("TextFiles.xml");
                    MessageBox.Show("File Successfully Deleted.");
                }
            }
            else
            {
                MessageBox.Show("No File With That Name Exists.");
            }

        }

        private void fileCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoRichTextBox.Visible = true;

            infoRichTextBox.Clear();

            string selcteditem = fileCombo.SelectedItem.ToString();

            XmlDocument doc = new XmlDocument();
            doc.Load("TextFiles.xml");
            XmlNodeList list = doc.GetElementsByTagName("FileInfo");

            string FileTagName, FileNameValue, PathTagName, pathValue, CatTagName, CatValue;
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList node = list[i].ChildNodes;

                //tags name
                FileTagName = node[0].Name + ": ";
                PathTagName = node[1].Name + ": ";
                CatTagName = node[2].Name + ": ";

                FileNameValue = node[0].InnerText;

                if (selcteditem == FileNameValue)
                {

                    pathValue = node[1].InnerText;
                    CatValue = node[2].InnerText;

                    string[] categories = CatValue.Split(' ');

                    infoRichTextBox.Text += FileTagName + FileNameValue + Environment.NewLine;
                    infoRichTextBox.Text += PathTagName + pathValue + Environment.NewLine;
                    infoRichTextBox.Text += CatTagName;

                    for (int j = 0; j < categories.Length - 1; j++)
                    {
                        if (j != categories.Length - 2)
                            infoRichTextBox.Text += categories[j] + "  &  ";
                        else
                            infoRichTextBox.Text += categories[j];
                    }

                }

                //coloring tag names
                int start = 0;
                int end = infoRichTextBox.Text.LastOrDefault();

                while (start < end)
                {
                    infoRichTextBox.Find(FileTagName, start, infoRichTextBox.TextLength, RichTextBoxFinds.MatchCase);
                    infoRichTextBox.SelectionColor = Color.DarkMagenta;
                    infoRichTextBox.Find(PathTagName, start, infoRichTextBox.TextLength, RichTextBoxFinds.MatchCase);
                    infoRichTextBox.SelectionColor = Color.DarkMagenta;

                    infoRichTextBox.Find(CatTagName, start, infoRichTextBox.TextLength, RichTextBoxFinds.MatchCase);
                    infoRichTextBox.SelectionColor = Color.DarkMagenta;
                    start = infoRichTextBox.Text.LastOrDefault() + 1;
                }
            }

        }

        private void AddFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
