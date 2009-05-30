using System;

namespace SoftwareTelephone
{
    public interface IPlugin
    {
        string Input { get; set; }
        string Output { get; }
        string ToString();
        string getInputType();
        string getOutputType();
        void configure(IConfig Config);
        void configure(IConfig Config, bool forceReconfigure);
    }

    abstract public class PluginApplication : IPlugin
    {
        protected string mInput;
        protected string mOutput;

        protected string mApplicationLocation;

        public string Input { get { return mInput; } set { mInput = value; runApplication(); } }
        public string Output { get { return mOutput; } }

        public override abstract string ToString();
        public abstract string DefaultApplicationFileName();
        public abstract string getInputType();
        public abstract string getOutputType();

        public void configure(IConfig Config) 
        { 
            configure(Config, false); 
        }
        public virtual void configure(IConfig Config, bool forceReconfigure)
        {
            mApplicationLocation = Config.getSavedConfigurationInformation(ToString() + ".Location");
            if (forceReconfigure || mApplicationLocation.Length == 0 || !System.IO.File.Exists( mApplicationLocation ))
            {
                System.Windows.Forms.OpenFileDialog selecteSpeak = new System.Windows.Forms.OpenFileDialog();
                selecteSpeak.DefaultExt = "exe";
                selecteSpeak.Filter = ToString() + "|" + DefaultApplicationFileName() + "|All files|*.*";
                selecteSpeak.Title = "Select " + ToString() + " executable...";
                if (selecteSpeak.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Config.setSavedConfigurationInformation(ToString() + ".Location", selecteSpeak.FileName);
                    mApplicationLocation = selecteSpeak.FileName;
                }
            }
        }

        protected virtual void runApplication()
        {
            System.Diagnostics.Process runApplication = new System.Diagnostics.Process();
            runApplication.StartInfo = new System.Diagnostics.ProcessStartInfo(mApplicationLocation, buildParameters(Input));
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
        abstract protected string buildParameters(string Input);
    }

    public interface IConfig
    {
        string getSavedConfigurationInformation(string ForWhat);
        void setSavedConfigurationInformation(string ForWhat, string Value);
    }
}
