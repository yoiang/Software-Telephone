using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoogleTranslate
{
    class GoogleTranslatePlugin : SoftwareTelephone.IPlugin
    {
        protected string mInput;
        protected string mOutput;

        public string Input { get { return mInput; } set { mInput = value; translate(); } }
        public string Output { get { return mOutput; } }

        public override string ToString() { return "Google Translate"; }
        public string getInputType() { return "Text"; }
        public string getOutputType() { return "Text"; }

        protected string FromLanguage, ToLanguage;
        public GoogleTranslatePlugin()
        {
        }

        public void configure(SoftwareTelephone.IConfig Config)
        {
            configure(Config, false);
        }
        public void configure(SoftwareTelephone.IConfig Config, bool forceReconfigure)
        {
            Configure Configure = new Configure();
            Configure.ShowDialog();
            FromLanguage = Configure.getFromLanguage();
            ToLanguage = Configure.getToLanguage();
        }

        protected void translate()
        {
            mOutput = Google.Unoffical.Translate.Translate.translate(mInput, FromLanguage, ToLanguage);
        }

    }

    public class Program
    {
    }
}
