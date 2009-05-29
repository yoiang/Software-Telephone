using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareTelephone
{/*
    abstract public class TextToSpeech : PluginApplication
    {
        protected string mOutputLocation;
        public TextToSpeech(string setName, string setApplicationLocation, string setOutputLocation)
            : base(setName, setApplicationLocation)
        {
            mOutputLocation = setOutputLocation;
        }

        override public string doProcess(string Input)
        {
            return doTextToSpeech(Input);
        }

        virtual public string doTextToSpeech(string Input)
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
            return mOutputLocation;
        }
        abstract public string buildParameters( string Input );
    }*/
}
