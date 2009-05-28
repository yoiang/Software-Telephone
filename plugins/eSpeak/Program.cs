using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eSpeak
{
    class eSpeakPlugin : SoftwareTelephone.SupportApplication
    {
        public override string ToString() { return "eSpeak"; }
        public override string getInputType() { return "Text"; }
        public override string getOutputType() { return "Wav"; }

        public eSpeakPlugin()
        {
            mOutput = "eSpeak.wav";
        }

        public override void configure(SoftwareTelephone.IConfig Config, bool forceReconfigure)
        {
            mApplicationLocation = Config.getSavedConfigurationInformation("eSpeakLocation");
            if (forceReconfigure || mApplicationLocation.Length == 0)
            {
                System.Windows.Forms.OpenFileDialog selecteSpeak = new System.Windows.Forms.OpenFileDialog();
                selecteSpeak.DefaultExt = "exe";
                selecteSpeak.Filter = "eSpeak|eSpeak.exe|All files|*.*";
                selecteSpeak.Title = "Select eSpeak executable...";
                if (selecteSpeak.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Config.setSavedConfigurationInformation("eSpeakLocation", selecteSpeak.FileName);
                    mApplicationLocation = selecteSpeak.FileName;
                }
            }
        }

        protected override string buildParameters(string Input)
        {
            System.IO.File.Delete(mOutput);
            return "-w \"" + mOutput + "\" \"" + Input + "\"";
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MessageBox.Show("Dll, please don't run");
        }
    }
}
