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

    abstract public class SupportApplication : IPlugin
    {
        protected string mInput;
        protected string mOutput;
        protected string mApplicationLocation;

        public string Input { get { return mInput; } set { mInput = value; runApplication(); } }
        public string Output { get { return mOutput; } }

        public override abstract string ToString();
        public abstract string getInputType();
        public abstract string getOutputType();

        public void configure(IConfig Config) { configure(Config, false); }
        public abstract void configure(IConfig Config, bool forceReconfigure);

        protected void runApplication()
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
                Console.WriteLine(E.Message);
                //                System.Windows.Forms.MessageBox.Show(E.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
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
