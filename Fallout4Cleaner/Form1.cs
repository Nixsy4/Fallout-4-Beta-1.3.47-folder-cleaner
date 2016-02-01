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
        string[] fileList = { "bink2w64.dll", "cudart64_75.dll", "Fallout4.exe", "Fallout4Launcher.exe", "Fallout4_Default.ini", "FileList.txt", "flexExtRelease_x64.dll", "flexRelease_x64.dll", "GFSDK_GodraysLib.x64.dll", "GFSDK_SSAO_D3D11.win64.dll", "High.ini", "installscript.vdf", "libScePad.dll", "List.bat", "Low.ini", "Medium.ini", "msvcp110.dll", "msvcr110.dll", "nvdebris.txt", "nvToolsExt64_1.dll", "steam_api64.dll", "Ultra.ini", "Fallout4 - Animations.ba2", "Fallout4 - Geometry.csg", "Fallout4 - Interface.ba2", "Fallout4 - Materials.ba2", "Fallout4 - Meshes.ba2", "Fallout4 - MeshesExtra.ba2", "Fallout4 - Misc.ba2", "Fallout4 - Nvflex.ba2", "Fallout4 - Shaders.ba2", "Fallout4 - Sounds.ba2", "Fallout4 - Startup.ba2", "Fallout4 - Textures1.ba2", "Fallout4 - Textures2.ba2", "Fallout4 - Textures3.ba2", "Fallout4 - Textures4.ba2", "Fallout4 - Textures5.ba2", "Fallout4 - Textures6.ba2", "Fallout4 - Textures7.ba2", "Fallout4 - Textures8.ba2", "Fallout4 - Textures9.ba2", "Fallout4 - Voices.ba2", "Fallout4.cdx", "Fallout4.esm", "Fallout4_en.DLSTRINGS", "Fallout4_en.ILSTRINGS", "Fallout4_en.STRINGS", "AGILITY.bk2", "CHARISMA.bk2", "Endgame_FEMALE_A.bk2", "Endgame_FEMALE_B.bk2", "Endgame_MALE_A.bk2", "Endgame_MALE_B.bk2", "ENDURANCE.bk2", "GameIntro_V3_B.bk2", "INTELLIGENCE.bk2", "Intro.bk2", "LUCK.bk2", "MainMenuLoop.bk2", "PERCEPTION.bk2", "STRENGTH.bk2", "Fallout4Prefs.ini", "Apr2005_d3dx9_25_x64.cab", "Apr2005_d3dx9_25_x86.cab", "Apr2006_d3dx9_30_x64.cab", "Apr2006_d3dx9_30_x86.cab", "Apr2006_MDX1_x86.cab", "Apr2006_MDX1_x86_Archive.cab", "Apr2006_XACT_x64.cab", "Apr2006_XACT_x86.cab", "Apr2006_xinput_x64.cab", "Apr2006_xinput_x86.cab", "APR2007_d3dx10_33_x64.cab", "APR2007_d3dx10_33_x86.cab", "APR2007_d3dx9_33_x64.cab", "APR2007_d3dx9_33_x86.cab", "APR2007_XACT_x64.cab", "APR2007_XACT_x86.cab", "APR2007_xinput_x64.cab", "APR2007_xinput_x86.cab", "Aug2005_d3dx9_27_x64.cab", "Aug2005_d3dx9_27_x86.cab", "AUG2006_XACT_x64.cab", "AUG2006_XACT_x86.cab", "AUG2006_xinput_x64.cab", "AUG2006_xinput_x86.cab", "AUG2007_d3dx10_35_x64.cab", "AUG2007_d3dx10_35_x86.cab", "AUG2007_d3dx9_35_x64.cab", "AUG2007_d3dx9_35_x86.cab", "AUG2007_XACT_x64.cab", "AUG2007_XACT_x86.cab", "Aug2008_d3dx10_39_x64.cab", "Aug2008_d3dx10_39_x86.cab", "Aug2008_d3dx9_39_x64.cab", "Aug2008_d3dx9_39_x86.cab", "Aug2008_XACT_x64.cab", "Aug2008_XACT_x86.cab", "Aug2008_XAudio_x64.cab", "Aug2008_XAudio_x86.cab", "Aug2009_D3DCompiler_42_x64.cab", "Aug2009_D3DCompiler_42_x86.cab", "Aug2009_d3dcsx_42_x64.cab", "Aug2009_d3dcsx_42_x86.cab", "Aug2009_d3dx10_42_x64.cab", "Aug2009_d3dx10_42_x86.cab", "Aug2009_d3dx11_42_x64.cab", "Aug2009_d3dx11_42_x86.cab", "Aug2009_d3dx9_42_x64.cab", "Aug2009_d3dx9_42_x86.cab", "Aug2009_XACT_x64.cab", "Aug2009_XACT_x86.cab", "Aug2009_XAudio_x64.cab", "Aug2009_XAudio_x86.cab", "Dec2005_d3dx9_28_x64.cab", "Dec2005_d3dx9_28_x86.cab", "DEC2006_d3dx10_00_x64.cab", "DEC2006_d3dx10_00_x86.cab", "DEC2006_d3dx9_32_x64.cab", "DEC2006_d3dx9_32_x86.cab", "DEC2006_XACT_x64.cab", "DEC2006_XACT_x86.cab", "DSETUP.dll", "dsetup32.dll", "dxdllreg_x86.cab", "DXSETUP.exe", "dxupdate.cab", "Feb2005_d3dx9_24_x64.cab", "Feb2005_d3dx9_24_x86.cab", "Feb2006_d3dx9_29_x64.cab", "Feb2006_d3dx9_29_x86.cab", "Feb2006_XACT_x64.cab", "Feb2006_XACT_x86.cab", "FEB2007_XACT_x64.cab", "FEB2007_XACT_x86.cab", "Feb2010_X3DAudio_x64.cab", "Feb2010_X3DAudio_x86.cab", "Feb2010_XACT_x64.cab", "Feb2010_XACT_x86.cab", "Feb2010_XAudio_x64.cab", "Feb2010_XAudio_x86.cab", "installscript.vdf", "Jun2005_d3dx9_26_x64.cab", "Jun2005_d3dx9_26_x86.cab", "JUN2006_XACT_x64.cab", "JUN2006_XACT_x86.cab", "JUN2007_d3dx10_34_x64.cab", "JUN2007_d3dx10_34_x86.cab", "JUN2007_d3dx9_34_x64.cab", "JUN2007_d3dx9_34_x86.cab", "JUN2007_XACT_x64.cab", "JUN2007_XACT_x86.cab", "JUN2008_d3dx10_38_x64.cab", "JUN2008_d3dx10_38_x86.cab", "JUN2008_d3dx9_38_x64.cab", "JUN2008_d3dx9_38_x86.cab", "JUN2008_X3DAudio_x64.cab", "JUN2008_X3DAudio_x86.cab", "JUN2008_XACT_x64.cab", "JUN2008_XACT_x86.cab", "JUN2008_XAudio_x64.cab", "JUN2008_XAudio_x86.cab", "Jun2010_D3DCompiler_43_x64.cab", "Jun2010_D3DCompiler_43_x86.cab", "Jun2010_d3dcsx_43_x64.cab", "Jun2010_d3dcsx_43_x86.cab", "Jun2010_d3dx10_43_x64.cab", "Jun2010_d3dx10_43_x86.cab", "Jun2010_d3dx11_43_x64.cab", "Jun2010_d3dx11_43_x86.cab", "Jun2010_d3dx9_43_x64.cab", "Jun2010_d3dx9_43_x86.cab", "Jun2010_XACT_x64.cab", "Jun2010_XACT_x86.cab", "Jun2010_XAudio_x64.cab", "Jun2010_XAudio_x86.cab", "Mar2008_d3dx10_37_x64.cab", "Mar2008_d3dx10_37_x86.cab", "Mar2008_d3dx9_37_x64.cab", "Mar2008_d3dx9_37_x86.cab", "Mar2008_X3DAudio_x64.cab", "Mar2008_X3DAudio_x86.cab", "Mar2008_XACT_x64.cab", "Mar2008_XACT_x86.cab", "Mar2008_XAudio_x64.cab", "Mar2008_XAudio_x86.cab", "Mar2009_d3dx10_41_x64.cab", "Mar2009_d3dx10_41_x86.cab", "Mar2009_d3dx9_41_x64.cab", "Mar2009_d3dx9_41_x86.cab", "Mar2009_X3DAudio_x64.cab", "Mar2009_X3DAudio_x86.cab", "Mar2009_XACT_x64.cab", "Mar2009_XACT_x86.cab", "Mar2009_XAudio_x64.cab", "Mar2009_XAudio_x86.cab", "Nov2007_d3dx10_36_x64.cab", "Nov2007_d3dx10_36_x86.cab", "Nov2007_d3dx9_36_x64.cab", "Nov2007_d3dx9_36_x86.cab", "NOV2007_X3DAudio_x64.cab", "NOV2007_X3DAudio_x86.cab", "NOV2007_XACT_x64.cab", "NOV2007_XACT_x86.cab", "Nov2008_d3dx10_40_x64.cab", "Nov2008_d3dx10_40_x86.cab", "Nov2008_d3dx9_40_x64.cab", "Nov2008_d3dx9_40_x86.cab", "Nov2008_X3DAudio_x64.cab", "Nov2008_X3DAudio_x86.cab", "Nov2008_XACT_x64.cab", "Nov2008_XACT_x86.cab", "Nov2008_XAudio_x64.cab", "Nov2008_XAudio_x86.cab", "Oct2005_xinput_x64.cab", "Oct2005_xinput_x86.cab", "OCT2006_d3dx9_31_x64.cab", "OCT2006_d3dx9_31_x86.cab", "OCT2006_XACT_x64.cab", "OCT2006_XACT_x86.cab", "installscript.vdf", "vcredist_x64.exe", "vcredist_x86.exe" };
        string folderPath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure you want to remove all mod files?",
                                     "Confirm Clean!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string gamepath = textBox1.Text;
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
                        File.Delete(fileName);
                    }
                    DirectoryInfo fileFolder = new DirectoryInfo(gamepath);
                    Tidy(fileFolder);
                    System.Windows.Forms.MessageBox.Show("Game folder cleaned");
                }
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
