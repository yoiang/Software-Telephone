using System;
using System.Text;

namespace FreeTTS
{
    class FreeTTSPlugin : SoftwareTelephone.PluginApplication
    {
        protected string mJavaLocation;

        public override string ToString() { return "FreeTTS"; }
        public override string DefaultApplicationFileName() { return "freetts.jar"; }
        public override string getInputType() { return "Text"; }
        public override string getOutputType() { return "Wav"; }

        public FreeTTSPlugin()
        {
            mOutput = "FreeTTS.wav";
        }

        public override void configure(SoftwareTelephone.IConfig Config, bool forceReconfigure)
        {
            mJavaLocation = Config.getSavedConfigurationInformation(ToString() + ".JavaLocation");
            if (forceReconfigure || mJavaLocation.Length == 0)
            {
                System.Windows.Forms.OpenFileDialog selectJava = new System.Windows.Forms.OpenFileDialog();
                selectJava.DefaultExt = "exe";
                selectJava.Filter = "Java|java.exe|All files|*.*";
                selectJava.Title = "Select Java executable...";
                if (selectJava.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Config.setSavedConfigurationInformation(ToString() + ".JavaLocation", selectJava.FileName);
                    mJavaLocation = selectJava.FileName;
                }
            }

            base.configure(Config, forceReconfigure);
        }

        protected override void runApplication()
        {
            System.Diagnostics.Process runApplication = new System.Diagnostics.Process();
            runApplication.StartInfo = new System.Diagnostics.ProcessStartInfo(mJavaLocation, buildParameters(Input));
            runApplication.StartInfo.UseShellExecute = false;
            try
            {
                runApplication.Start();
                runApplication.WaitForExit();
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show(E.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        protected override string buildParameters(string Input)
        {
            System.IO.File.Delete(mOutput);
            return "-jar " + mApplicationLocation + " -dumpAudio " + mOutput + " -text " + Input;
        }
    }
}
