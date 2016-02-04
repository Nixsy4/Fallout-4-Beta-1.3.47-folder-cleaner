using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fallout4Cleaner
{
    public partial class Form1 : Form
    {
        
        string folderPath = "";

        public Form1()
        {
            InitializeComponent();

            if (File.Exists("FileMasterlistDoNotEdit.txt"))
            { }
            else
            {
                System.Windows.Forms.MessageBox.Show("FileMasterlistDoNotEdit.txt is missing. This will eat your cat if you try to use it like this!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var fileList = File.ReadAllLines("FileMasterlistDoNotEdit.txt");
            

            var confirmResult = MessageBox.Show("Are you sure you want to remove all mod files?",
                                     "Confirm Clean!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string gamepath = textBox1.Text;
                if (File.Exists("KeepList.txt"))
                {}
                else
                {
                    using (FileStream fs = File.Create("KeepList.txt"))
                    {}
                }
                var userList = File.ReadAllLines("KeepList.txt");
                

                string[] filePaths = Directory.GetFiles(gamepath, "*", SearchOption.AllDirectories);
                foreach (string fileName in filePaths)
                {
                    var regex = new Regex("[0-9]{4}_[0-9]{2}_[0-9]{2}_[0-9]{2}_[0-9]{2}_[0-9]{2}");
                    var testfo5 = regex.Match(Path.GetFileName(fileName));
                    if (testfo5.Success)
                    {
                        //System.Console.WriteLine(Path.GetFileName(fileName));
                        //tes5Edit or fo4Edit backup
                    }
                    else if (fileList.Contains(Path.GetFileName(fileName)) || userList.Contains(Path.GetFileName(fileName)))
                    {
                        //System.Console.WriteLine(Path.GetFileName(fileName));
                    }
                    else
                    {
                        System.Console.WriteLine("Found an odd file " + Path.GetFileName(fileName));                       
                        try
                        {
                            File.Delete(fileName);
                        }
                        catch (UnauthorizedAccessException err)
                        {
                            System.Windows.Forms.MessageBox.Show("Error:" + err.Message);
                        }
                    }
                    DirectoryInfo fileFolder = new DirectoryInfo(gamepath);
                    Tidy(fileFolder);                    
                }
                System.Windows.Forms.MessageBox.Show("Game folder cleaned");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Cleaning canceled!");
            }

        }

        static void Tidy(DirectoryInfo tree)
        {
            foreach (DirectoryInfo di in tree.EnumerateDirectories())
            {
                Tidy(di);
            }
            tree.Refresh();
            if (!tree.EnumerateFileSystemInfos().Any())
            {
                tree.Delete();
            }
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
                textBox1.Text = folderPath;
            }
        }

    }
}
