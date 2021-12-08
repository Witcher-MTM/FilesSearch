using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    enum ListStatus
    {
        AllFiles,
        PatternFiles
    }
    public partial class Form1 : Form
    {
        ListStatus list;
        List<string> FilesForRename = new List<string>();
        public Form1()
        {
            InitializeComponent();
            list = ListStatus.AllFiles;
        }

        private void NewNameTB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void SwapList_Click(object sender, EventArgs e)
        {
            if (list == ListStatus.AllFiles)
            {
                this.SwapList.Text = "AllFiles";
                list = ListStatus.PatternFiles;

                ResultFindFilesList.Visible = false;
                AllFiles.Visible = true;
            }
            else
            {
                this.SwapList.Text = "PatternFiles";
                list = ListStatus.AllFiles;

                AllFiles.Visible = false;
                ResultFindFilesList.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilesForRename.Clear();
            ResultFindFilesList.Items.Clear();
            AllFiles.Items.Clear();

            Task.Factory.StartNew(() => {

                if (this.OldNameTB.Text != string.Empty && this.NewNameTB.Text != string.Empty)
                {
                    if (this.OldNameTB.Text == this.NewNameTB.Text)
                    {
                        MessageBox.Show("Good try!");
                    }
                    else
                    {
                        List<string> files = new List<string>();

                        foreach (var item in Environment.GetLogicalDrives())
                        {
                            files = getFilesInDir(item);
                            if (item.Contains("D"))
                            {
                                foreach (var elem in files)
                                {
                                    if (Path.GetFileName(elem) == this.OldNameTB.Text)
                                    {
                                        FilesForRename.Add(elem);
                                        ResultFindFilesList.Items.Add(elem);
                                    }
                                    else if (Path.GetFileNameWithoutExtension(elem) == this.OldNameTB.Text)
                                    {
                                        FilesForRename.Add(elem);
                                        ResultFindFilesList.Items.Add(elem);
                                    }
                                    AllFiles.Items.Add(elem);
                                }
                                FoundFiles();
                            }
                           
                        }
                       
                    }
                }
                else
                {
                    MessageBox.Show("Fill all fields");
                }


            });
        }
        private List<string> getFilesInDir(string dirPath)
        {
            List<string> retVal = new List<string>();
            try
            {
                retVal = Directory.GetFiles(dirPath, "*.*", SearchOption.TopDirectoryOnly).ToList();
                foreach (DirectoryInfo d in new DirectoryInfo(dirPath).GetDirectories("*", SearchOption.TopDirectoryOnly))
                {
                    retVal.AddRange(getFilesInDir(d.FullName));
                }
            }
            catch (Exception ex) { }
            return retVal;
        }
        private void Rename()
        {
            foreach (var item in FilesForRename)
            {
                if (File.Exists($@"{Path.GetDirectoryName(item)}\{this.NewNameTB.Text}"))
                {
                    File.Delete($@"{Path.GetDirectoryName(item)}\{this.NewNameTB.Text}");
                }
                try
                {
                    File.Move(item, $@"{Path.GetDirectoryName(item)}\{this.NewNameTB.Text}{Path.GetExtension(item)}");
                    MessageBox.Show("File renamed!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void FoundFiles()
        {
            if (FilesForRename.Count > 0)
            {
                Rename();
            }
            else
                MessageBox.Show("Not found!");
        }
    }
}
