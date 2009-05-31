using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace dotNetListen
{
    public class dotNetListenPlugin : SoftwareTelephone.IPlugin
    {
        protected string mInput;
        protected string mOutput;

        public string Input { get { return mInput; } set { mInput = value; decode(); } }
        public string Output { get { return mOutput; } }

        public override string ToString() { return ".Net Speech Recognition"; }
        public string getInputType() { return "Wav"; }
        public string getOutputType() { return "Text"; }

        public dotNetListenPlugin()
        {
        }

        public void configure(SoftwareTelephone.IConfig Config)
        {
            configure(Config, false);
        }
        public void configure(SoftwareTelephone.IConfig Config, bool forceReconfigure)
        {
        }

        protected void decode()
        {
            try
            {
                SpeechRecognitionEngine SpeechRecognitionEngine = new SpeechRecognitionEngine();
                DictationGrammar DictationGrammer = new DictationGrammar();
                SpeechRecognitionEngine.LoadGrammar(DictationGrammer);

                SpeechRecognitionEngine.SetInputToWaveFile(Input);
                RecognitionResult Result = SpeechRecognitionEngine.Recognize();
                mOutput = Result.Text;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
