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

namespace Fallout4Cleaner
{
    public partial class Form1 : Form
    {
        string[] fileList = { "atimgpud.dll", "binkw32.dll", "DirFileList.bat", "FileList.txt", "high.ini", "installscript.vdf", "low.ini", "medium.ini", "readme.txt", "SkyrimLauncher.exe", "Skyrim_default.ini", "steam_api.dll", "TESV.exe", "VeryHigh.ini", "Dawnguard.bsa", "Dawnguard.esm", "Dragonborn.bsa", "Dragonborn.esm", "HearthFires.bsa", "HearthFires.esm", "HighResTexturePack01.bsa", "HighResTexturePack01.esp", "HighResTexturePack02.bsa", "HighResTexturePack02.esp", "HighResTexturePack03.bsa", "HighResTexturePack03.esp", "Skyrim - Animations.bsa", "Skyrim - Interface.bsa", "Skyrim - Meshes.bsa", "Skyrim - Misc.bsa", "Skyrim - Shaders.bsa", "Skyrim - Sounds.bsa", "Skyrim - Textures.bsa", "Skyrim - Voices.bsa", "Skyrim - VoicesExtra.bsa", "Skyrim.esm", "Update.bsa", "Update.esm", "Translate_ENGLISH.txt", "Skyrim_English.DLSTRINGS", "Skyrim_English.ILSTRINGS", "Skyrim_English.STRINGS", "Update_English.DLSTRINGS", "Update_English.ILSTRINGS", "Update_English.STRINGS", "BGS_Logo.bik", "Apr2005_d3dx9_25_x64.cab", "Apr2005_d3dx9_25_x86.cab", "Apr2006_d3dx9_30_x64.cab", "Apr2006_d3dx9_30_x86.cab", "Apr2006_MDX1_x86.cab", "Apr2006_MDX1_x86_Archive.cab", "Apr2006_XACT_x64.cab", "Apr2006_XACT_x86.cab", "Apr2006_xinput_x64.cab", "Apr2006_xinput_x86.cab", "APR2007_d3dx10_33_x64.cab", "APR2007_d3dx10_33_x86.cab", "APR2007_d3dx9_33_x64.cab", "APR2007_d3dx9_33_x86.cab", "APR2007_XACT_x64.cab", "APR2007_XACT_x86.cab", "APR2007_xinput_x64.cab", "APR2007_xinput_x86.cab", "Aug2005_d3dx9_27_x64.cab", "Aug2005_d3dx9_27_x86.cab", "AUG2006_XACT_x64.cab", "AUG2006_XACT_x86.cab", "AUG2006_xinput_x64.cab", "AUG2006_xinput_x86.cab", "AUG2007_d3dx10_35_x64.cab", "AUG2007_d3dx10_35_x86.cab", "AUG2007_d3dx9_35_x64.cab", "AUG2007_d3dx9_35_x86.cab", "AUG2007_XACT_x64.cab", "AUG2007_XACT_x86.cab", "Aug2008_d3dx10_39_x64.cab", "Aug2008_d3dx10_39_x86.cab", "Aug2008_d3dx9_39_x64.cab", "Aug2008_d3dx9_39_x86.cab", "Aug2008_XACT_x64.cab", "Aug2008_XACT_x86.cab", "Aug2008_XAudio_x64.cab", "Aug2008_XAudio_x86.cab", "Aug2009_D3DCompiler_42_x64.cab", "Aug2009_D3DCompiler_42_x86.cab", "Aug2009_d3dcsx_42_x64.cab", "Aug2009_d3dcsx_42_x86.cab", "Aug2009_d3dx10_42_x64.cab", "Aug2009_d3dx10_42_x86.cab", "Aug2009_d3dx11_42_x64.cab", "Aug2009_d3dx11_42_x86.cab", "Aug2009_d3dx9_42_x64.cab", "Aug2009_d3dx9_42_x86.cab", "Aug2009_XACT_x64.cab", "Aug2009_XACT_x86.cab", "Aug2009_XAudio_x64.cab", "Aug2009_XAudio_x86.cab", "BDANT.cab", "BDAXP.cab", "Dec2005_d3dx9_28_x64.cab", "Dec2005_d3dx9_28_x86.cab", "DEC2006_d3dx10_00_x64.cab", "DEC2006_d3dx10_00_x86.cab", "DEC2006_d3dx9_32_x64.cab", "DEC2006_d3dx9_32_x86.cab", "DEC2006_XACT_x64.cab", "DEC2006_XACT_x86.cab", "DSETUP.dll", "dsetup32.dll", "dxdllreg_x86.cab", "dxnt.cab", "DXSETUP.exe", "dxupdate.cab", "Feb2005_d3dx9_24_x64.cab", "Feb2005_d3dx9_24_x86.cab", "Feb2006_d3dx9_29_x64.cab", "Feb2006_d3dx9_29_x86.cab", "Feb2006_XACT_x64.cab", "Feb2006_XACT_x86.cab", "FEB2007_XACT_x64.cab", "FEB2007_XACT_x86.cab", "Feb2010_X3DAudio_x64.cab", "Feb2010_X3DAudio_x86.cab", "Feb2010_XACT_x64.cab", "Feb2010_XACT_x86.cab", "Feb2010_XAudio_x64.cab", "Feb2010_XAudio_x86.cab", "Jun2005_d3dx9_26_x64.cab", "Jun2005_d3dx9_26_x86.cab", "JUN2006_XACT_x64.cab", "JUN2006_XACT_x86.cab", "JUN2007_d3dx10_34_x64.cab", "JUN2007_d3dx10_34_x86.cab", "JUN2007_d3dx9_34_x64.cab", "JUN2007_d3dx9_34_x86.cab", "JUN2007_XACT_x64.cab", "JUN2007_XACT_x86.cab", "JUN2008_d3dx10_38_x64.cab", "JUN2008_d3dx10_38_x86.cab", "JUN2008_d3dx9_38_x64.cab", "JUN2008_d3dx9_38_x86.cab", "JUN2008_X3DAudio_x64.cab", "JUN2008_X3DAudio_x86.cab", "JUN2008_XACT_x64.cab", "JUN2008_XACT_x86.cab", "JUN2008_XAudio_x64.cab", "JUN2008_XAudio_x86.cab", "Mar2008_d3dx10_37_x64.cab", "Mar2008_d3dx10_37_x86.cab", "Mar2008_d3dx9_37_x64.cab", "Mar2008_d3dx9_37_x86.cab", "Mar2008_X3DAudio_x64.cab", "Mar2008_X3DAudio_x86.cab", "Mar2008_XACT_x64.cab", "Mar2008_XACT_x86.cab", "Mar2008_XAudio_x64.cab", "Mar2008_XAudio_x86.cab", "Mar2009_d3dx10_41_x64.cab", "Mar2009_d3dx10_41_x86.cab", "Mar2009_d3dx9_41_x64.cab", "Mar2009_d3dx9_41_x86.cab", "Mar2009_X3DAudio_x64.cab", "Mar2009_X3DAudio_x86.cab", "Mar2009_XACT_x64.cab", "Mar2009_XACT_x86.cab", "Mar2009_XAudio_x64.cab", "Mar2009_XAudio_x86.cab", "Nov2007_d3dx10_36_x64.cab", "Nov2007_d3dx10_36_x86.cab", "Nov2007_d3dx9_36_x64.cab", "Nov2007_d3dx9_36_x86.cab", "NOV2007_X3DAudio_x64.cab", "NOV2007_X3DAudio_x86.cab", "NOV2007_XACT_x64.cab", "NOV2007_XACT_x86.cab", "Nov2008_d3dx10_40_x64.cab", "Nov2008_d3dx10_40_x86.cab", "Nov2008_d3dx9_40_x64.cab", "Nov2008_d3dx9_40_x86.cab", "Nov2008_X3DAudio_x64.cab", "Nov2008_X3DAudio_x86.cab", "Nov2008_XACT_x64.cab", "Nov2008_XACT_x86.cab", "Nov2008_XAudio_x64.cab", "Nov2008_XAudio_x86.cab", "Oct2005_xinput_x64.cab", "Oct2005_xinput_x86.cab", "OCT2006_d3dx9_31_x64.cab", "OCT2006_d3dx9_31_x86.cab", "OCT2006_XACT_x64.cab", "OCT2006_XACT_x86.cab", "dotnetfx35setup.exe", "SkyrimPrefs.ini", "vcredist_x86.exe" };
        string folderPath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gamepath = textBox1.Text;

            string[] filePaths = Directory.GetFiles(gamepath, "*", SearchOption.AllDirectories);
            foreach (string fileName in filePaths)
            {

                if (fileList.Contains(Path.GetFileName(fileName)))
                {
                    //System.Console.WriteLine(Path.GetFileName(fileName));
                }
                else
                {
                    System.Console.WriteLine("Found an odd file " + Path.GetFileName(fileName));
                    File.Delete(fileName);
                }
                DirectoryInfo fileFolder = new DirectoryInfo(gamepath);
                Tidy(fileFolder);
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
