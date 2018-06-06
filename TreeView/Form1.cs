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

namespace TreeView
{
    public partial class Form1 : Form
    {
        List<Info> info = new List<Info>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BBrowser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                FolderBrowser.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BFind_Click(object sender, EventArgs e)
        {

            DirectoryInfo Info = new DirectoryInfo(FolderBrowser.Text);
            foreach (var item in Info.EnumerateDirectories())
                info.Add(new Info() { Name = item.Name });
            SizeFolders(Info);
            Folders1(Info);
            foreach (var item in info)
            {
                listView1.Items.Add(new ListViewItem(new string[] { item.Name, item.Size.ToString(), item.Folders.ToString(), ""}));
            }

        }

       

        private void Folders1(DirectoryInfo df)
        {
           
            foreach (var item1 in df.EnumerateDirectories())
            {
                info.First(x => x.Name == item1.Name).Folders = Folders2(item1);
            }
        }

        private int Folders2(DirectoryInfo df)
        {
            int folders = 0;
         
            foreach (var item in df.EnumerateDirectories())
            {
                folders++;
                Folders2(item);
            }
            return folders;
        }

        private void SizeFolders(DirectoryInfo df)
        {
            foreach (var item in df.EnumerateDirectories())
            {
                info.First(x => x.Name == item.Name).Size = SizeFolders1(item);
            }
        }
        private long SizeFolders1(DirectoryInfo df)
        {
            long size = 0;

            foreach (var item in df.EnumerateDirectories())
            {
                SizeFolders1(item);
            }
             foreach (var item in df.GetFiles())
              {
                    size += item.Length;
              }
            return size;

        }
    }
}
