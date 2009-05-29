using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eSpeak
{
    class eSpeakPlugin : SoftwareTelephone.PluginApplication
    {
        public override string ToString() { return "eSpeak"; }
        public override string DefaultApplicationFileName() { return "eSpeak.exe"; }
        public override string getInputType() { return "Text"; }
        public override string getOutputType() { return "Wav"; }

        public eSpeakPlugin()
        {
            mOutput = "eSpeak.wav";
        }

        protected override string buildParameters(string Input)
        {
            System.IO.File.Delete(mOutput);
            return "-w \"" + mOutput + "\" \"" + Input + "\"";
        }
    }
}
