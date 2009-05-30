using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SoftwareTelephone
{
    public partial class Main : Form
    {
        Config mConfig;
        List<IPlugin> mPlugins;
        public Main()
        {
            InitializeComponent();

            bStartWithText.Checked = true;
            StartWithText.Enabled = true;

            bStartWithSpeech.Checked = false;
            StartWithSpeechFile.Enabled = false;
            browseStartWithSpeechFile.Enabled = false;

            mConfig = new Config(Properties.Settings.Default);

            mPlugins = new List<IPlugin>();

            string path = Application.StartupPath;
            string[] pluginFiles = System.IO.Directory.GetFiles(path, "*.DLL");
            for (int i = 0; i < pluginFiles.Length; i++)
            {
                string AssemblyName = System.IO.Path.GetFileNameWithoutExtension(pluginFiles[i]);

                System.Reflection.Assembly ass = null;
                ass = System.Reflection.Assembly.Load(AssemblyName);
                List<Type> availableTypes = new List<Type>(ass.GetTypes());
                foreach (Type availableType in availableTypes)
                {
                    if (!availableType.IsAbstract)
                    {
                        List<Type> InterfaceTypes = new List<Type>(availableType.GetInterfaces());
                        if (InterfaceTypes.Contains(typeof(IPlugin)))
                        {
                            try
                            {
                                mPlugins.Add((IPlugin)Activator.CreateInstance(availableType));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private void clickbStartWithText(object sender, EventArgs e)
        {
            ProcessList.Items.Clear();

            StartWithText.Enabled = true;

            bStartWithSpeech.Checked = false;
            StartWithSpeechFile.Enabled = false;
            browseStartWithSpeechFile.Enabled = false;
        }

        private void clickbStartWithSpeech(object sender, EventArgs e)
        {
            ProcessList.Items.Clear();

            StartWithSpeechFile.Enabled = true;
            browseStartWithSpeechFile.Enabled = true;

            bStartWithText.Checked = false;
            StartWithText.Enabled = false;
        }

        private void clickStartWithSpeechFile(object sender, EventArgs e)
        {
            if (StartWithSpeechFile.Text.Length == 0)
            {
                selectStartWithSpeechFile();
            }
        }

        private void clickbrowseStartWithSpeechFile(object sender, EventArgs e)
        {
            selectStartWithSpeechFile();
        }

        public void selectStartWithSpeechFile()
        {
            System.Windows.Forms.OpenFileDialog selectStartWithSpeechFile = new OpenFileDialog();
            selectStartWithSpeechFile.Title = "Select Speech WAV file...";
            if (selectStartWithSpeechFile.ShowDialog() == DialogResult.OK)
            {
                StartWithSpeechFile.Text = selectStartWithSpeechFile.FileName;
            }
        }

        private void clickPlay(object sender, EventArgs e)
        {
            ResultBox.Text = "";
            string Input;
            if (bStartWithSpeech.Checked)
            {
                Input = StartWithSpeechFile.Text;
            }
            else
            {
                Input = StartWithText.Text;
            }

            foreach (IPlugin Process in ProcessList.Items)
            {
                ResultBox.Text += Process.ToString();

                Process.Input = Input;

                if (Process.getOutputType() == "Wav")
                {
                    string Path = System.IO.Directory.GetCurrentDirectory() + "/" + Process.Output;
                    Path = Path.Replace("\\", "/");
                    ResultBox.Text += " -> ";
                    ResultBox.Text += "file:///" + Path + "\n";
                }
                else if (Process.getOutputType() == "Text")
                {
                    ResultBox.Text += " -> ";
                    ResultBox.Text += Process.Output + "\n";
                }

                Input = Process.Output;
            }
        }

        private void clickaddToProcess(object sender, EventArgs e)
        {
            string matchInput;
            if (ProcessList.Items.Count == 0)
            {
                if (bStartWithSpeech.Checked)
                {
                    matchInput = "Wav";
                }
                else
                {
                    matchInput = "Text";
                }
            }
            else
            {
                matchInput = ((IPlugin)ProcessList.Items[ProcessList.Items.Count - 1]).getOutputType();
            }

            SelectPlugin SelectPlugin = new SelectPlugin();
            foreach (IPlugin Plugin in mPlugins)
            {
                if (Plugin.getInputType() == matchInput)
                {
                    SelectPlugin.addToPluginList(Plugin);
                }
            }

            if (SelectPlugin.ShowDialog(this) == DialogResult.OK && SelectPlugin.getSelectedPlugin() != null)
            {
                IPlugin add = (IPlugin)Activator.CreateInstance(SelectPlugin.getSelectedPlugin().GetType());
                add.configure(mConfig, SelectPlugin.mForceReconfigure);
                ProcessList.Items.Add(add);
            }
        }

        private void clickremoveProcess(object sender, EventArgs e)
        {
            if (ProcessList.Items.Count > 0)
            {
                ProcessList.Items.RemoveAt(ProcessList.Items.Count - 1);
            }
        }

        private void ResultBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
