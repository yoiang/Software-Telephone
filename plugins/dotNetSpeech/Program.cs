using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;


namespace dotNetSpeech
{
    public class dotNetSpeechPlugin : SoftwareTelephone.IPlugin
    {
        protected string mInput;
        protected string mOutput;

        public string Input { get { return mInput; } set { mInput = value; encode(); } }
        public string Output { get { return mOutput; } }

        public override string ToString() { return ".Net Speech Synthesizer"; }
        public string getInputType() { return "Text"; }
        public string getOutputType() { return "Wav"; }

        public dotNetSpeechPlugin()
        {
            mOutput = "dotNet.wav";
        }

        public void configure(SoftwareTelephone.IConfig Config)
        {
        }
        public void configure(SoftwareTelephone.IConfig Config, bool forceReconfigure)
        {
        }

        protected void encode()
        {
            System.IO.File.Delete(mOutput);
            SpeechSynthesizer SpeechSynthesizer = new SpeechSynthesizer();
            System.IO.FileStream writeWavFile = new System.IO.FileStream(mOutput, System.IO.FileMode.Create);
            SpeechSynthesizer.SetOutputToWaveStream(writeWavFile);
            SpeechSynthesizer.Speak(Input);
            writeWavFile.Close();
        }
    }

    public class Program
    {
    }
}
