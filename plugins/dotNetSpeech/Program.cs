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

        SpeechSynthesizer mSpeechSynthesizer;

        public dotNetSpeechPlugin()
        {
            mOutput = "dotNet.wav";
            mSpeechSynthesizer = new SpeechSynthesizer();
        }

        public void configure(SoftwareTelephone.IConfig Config)
        {
            configure(Config, false);
        }
        public void configure(SoftwareTelephone.IConfig Config, bool forceReconfigure)
        {
            Configure Configure = new Configure( mSpeechSynthesizer );
            Configure.ShowDialog();
        }

        protected void encode()
        {
            System.IO.File.Delete(mOutput);

            System.IO.FileStream writeWavFile = new System.IO.FileStream(mOutput, System.IO.FileMode.Create);
            mSpeechSynthesizer.SetOutputToWaveStream(writeWavFile);
            mSpeechSynthesizer.Speak(Input);
            writeWavFile.Close();
        }
    }

    public class Program
    {
    }
}
