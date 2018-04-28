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

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            //string path = @"C:\Users\Menna\Source\Repos\File-Search-Engine-System\Files\";
            string Url = path + str + ".txt";
            str = str + ".txt";
            bool fg = false;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    fg = true;
                    break;
                }
            }
            if (str == ".txt")
            {
                MessageBox.Show("Please Enter A Valid Name");
            }
            else if (fg == false)
            {
                MessageBox.Show("Please Select At Least 1 Category To Add File ");
            }
            else
            {
                if (!File.Exists(Url))
                {
                    File.Create(Url).Dispose();

                    MessageBox.Show("File Added Successfully.. Click Edit File To Start Write ");
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
                        for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        {
                            if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
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
                        f.fileCategories = categories;
                        Home.mapOfFiles[f.fileName] = f;

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
                        for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        {
                            if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
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
                        ff.fileCategories = categories;
                        Home.mapOfFiles[ff.fileName] = ff;

                    }
                }
                else { MessageBox.Show("This File Is Already Added.. If You Want To Edit This File Click On Edit File"); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            //string path = @"C:\Users\Menna\Source\Repos\File-Search-Engine-System\Files\";
            string Url = path + str + ".txt";
            str = str + ".txt";
            if (str == ".txt")
            {
                MessageBox.Show("Please Enter A Valid Name");
            }
            else if (!File.Exists(Url))
            {
                MessageBox.Show("This File Is Not Added.. If You Want To Add This File Click On Add File");

            }
            else { Process.Start(Url); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            //string path = @"C:\Users\Menna\Source\Repos\File-Search-Engine-System\Files\";
            string Url = path + str + ".txt";
            if (str == ".txt")
            {
                MessageBox.Show("Please Enter A Valid Name");
            }
            else if (File.Exists(Url))
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want TO Delete The File ?", "Warning", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    File.Delete(Url);
                    Home.mapOfFiles.Remove(str);
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
                    MessageBox.Show(" File Successfully Deleted ");
                }
            }
            else
            {
                MessageBox.Show(" No File Exists With That Name ");
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddFile_Load(object sender, EventArgs e)
        {
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
                    checkedListBox1.Items.Add(Category);
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
    }
}
