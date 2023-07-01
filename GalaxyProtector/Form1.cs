using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using dnlib.DotNet;
using dnlib.DotNet.Writer;

namespace GalaxyProtector
{
    public partial class Form1 : Form
    {
        public static string outputString = "Loaded";
        public static void Print(string text)
        {
            outputString += "\n" + text;
        }

        public Form1()
        {
            InitializeComponent();

            this.Text = "GalaxyProtector [Public] | License: <" + Undetected.RandomString() + ">";
            ReText.Start();
            WebClient wc = new WebClient();
            if (!wc.DownloadString("https://raw.githubusercontent.com/ilikebanas/notes/main/note").Contains("1"))
            {
                MessageBox.Show("Seems like this program has enabled it's killswitch, ask desync for more info.");
                Environment.Exit(0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(604, 323);
        }

        private void ReText_Tick(object sender, EventArgs e)
        {
            this.Text = "GalaxyProtector [Free] | License: <" + Undetected.RandomString() + ">";
            if (output.Text != outputString)
            {
                output.Text = outputString;
            }
            if (df.Checked)
            {
                setting.field = true;
            }
            else
            {
                setting.field = false;
            }
            if (dm.Checked)
            {
                setting.method = true;
            }
            else
            {
                setting.method = false;
            }
            if (de.Checked)
            {
                setting.eventb = true;
            }
            else
            {
                setting.eventb = false;
            }
            if (dp.Checked)
            {
                setting.prop = true;
            }
            else
            {
                setting.prop = false;
            }
            if (dn.Checked)
            {
                setting.names = true;
            }
            else
            {
                setting.names = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(0);
            }
            catch (Exception ex)
            {

            }
        }

        string pfile = "";

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "dll file (*.dll)|*.dll|exe file (*.exe)|*.exe";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Title = "Select a file";


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        listBox1.Items.RemoveAt(0);
                    }catch (Exception ex)
                    {

                    }
                    listBox1.Items.Add(openFileDialog.SafeFileName);
                    pfile = openFileDialog.FileName;

                    Print($"Added file : {openFileDialog.SafeFileName} ({openFileDialog.FileName})");

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//build
        {
            if (pfile == "")
            {
                Print("\nProtection Attempt");
                Print("Protection Failed!");
                Print("Please select a file to protect!");
            }
            else
            {
                Print("\nProtection Attempt");
                try
                {
                    //LOAD FILE INTO STRING (DRAG & DROP)
                    string file_to_obf = pfile;

                    //CREATE SOME CONTEXT (IDK WHAT THE HELL THAT IS)
                    ModuleContext modCtx = ModuleDef.CreateModuleContext();
                    Print("Created Context");

                    //LOAD FILE TO MODULE
                    var module = ModuleDefMD.Load(file_to_obf, modCtx);
                    Print("Loaded Module");

                    //OBFUSCATION METHODS
                    if (antispy.Checked)
                    {
                        AntiDnspy.Execute(module.Assembly);
                    }
                    if (rename2.Checked)
                    {
                        RenamerPhase.Execute(module);
                    }
                    if (df.Checked || dm.Checked || de.Checked || dp.Checked || dn.Checked)
                    {
                        RenameProtector.Execute(module);
                    }
                    if (ad.Checked)
                    {
                        AntiDebug.Execute(module);
                    }
                    if (antidump.Checked)
                    {
                        AntiDump.Execute(module);
                    }
                    if (junk.Checked)
                    {
                        JunkProtect.Execute(module, module.Assembly);
                    }
                    if (LF.Checked)
                    {
                        LocalField.Execute(module);
                    }
                    
                    if (ic.Checked)
                    {
                        IntConfusion.Execute(module);
                    }
                    if (sufcon.Checked)
                    {
                        SUFconfusion.Execute(module);
                    }
                    if (se.Checked)
                    {
                        StringStrongerEnc.Execute(module);
                    }
                    if (refp.Checked)
                    {
                        StringProxy.Execute(module);
                        IntProxy.Execute(module);
                    }
                    if (pi.Checked)
                    {
                        IntProxy.Execute(module);
                    }
                    if (pm.Checked)
                    {
                        MethodProxy.Execute(module);
                    }
                    if (at.Checked)
                    {
                        AntiTamper.Execute(module);
                    }
                    if (cf.Checked)
                    {
                        ControlFlow.Execute(module);
                        JControlFlow.Execute(module);
                    }
                    if (call.Checked)
                    {
                        Calli.Execute(module);
                    }
                    /*if (jcontrolflow.Checked)
                    {
                        JControlFlow.Execute(module);
                    }*/
                    if (hidecode.Checked)
                    {
                        InvalidMetadata.Execute(module.Assembly);
                    }

                    /*
                    if (df.Checked || dm.Checked || de.Checked || dp.Checked || dn.Checked)
                    {
                        RenameProtector.Execute(module);
                    }
                    if (junk.Checked)
                    {
                        JunkProtect.Execute(module, module.Assembly);
                    }
                    if (ic.Checked)
                    {
                        IntConfusion.Execute(module);
                    }
                    if (cf.Checked)
                    {
                        ControlFlow.Execute(module);
                    }
                    if (se.Checked)
                    {
                        StringStrongerEnc.Execute(module);
                    }
                    if (hidecode.Checked)
                    {
                        InvalidMetadata.Execute(module.Assembly);
                    }*/


                    //SAVE FILE TO PATH EXE
                    Print("Trying to save to file.");
                    if (file_to_obf.EndsWith(".exe"))
                    {
                        var path = file_to_obf.Remove(file_to_obf.Length - 4) + ".gp.exe";
                        module.Write(path, new ModuleWriterOptions(module) { Logger = DummyLogger.NoThrowInstance });
                        Print("Saved to : " + path);
                        Print("Added Protection Successfully!\n");
                    }

                    //SAVE FILE TO PATH DLL
                    if (file_to_obf.EndsWith(".dll"))
                    {
                        var path = file_to_obf.Remove(file_to_obf.Length - 4) + ".gp.dll";
                        module.Write(path, new ModuleWriterOptions(module) { Logger = DummyLogger.NoThrowInstance });
                        Print("Saved to : " + path);
                        Print("Added Protection Successfully!\n");
                    }
                }
                catch (Exception ex)
                {
                    Print("Protection Failed!");
                    Print(ex + "");
                }
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void tabPage1_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData((DataFormats.FileDrop), false);
            foreach(string file in files)
            {
                listBox1.Items.Clear();
                pfile = file;
                listBox1.Items.Add(Path.GetFileName(file));
                Print($"Added file : {Path.GetFileName(file)} ({file})");
            }
        }

        private void de_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
