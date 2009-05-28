using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeTTS
{
    public class Program
    {
    }
    /*
    public class FreeTTS : TextToSpeech
    {
        protected string mFreeTTSLocation;
        public FreeTTS(string setJavaLocation, string setFreeTTSLocation)
            : base("FreeTTS", setJavaLocation, "FreeTTS.wav")
        {
            mFreeTTSLocation = setFreeTTSLocation;
        }

        public static FreeTTS doConfigure(bool forceReconfigure)
        {
            string JavaLocation = Program.getSavedConfigurationInformation("JavaLocation");
            if (forceReconfigure || JavaLocation.Length == 0)
            {
                System.Windows.Forms.OpenFileDialog selectJava = new System.Windows.Forms.OpenFileDialog();
                selectJava.DefaultExt = "exe";
                selectJava.Filter = "Java|java.exe|All files|*.*";
                selectJava.Title = "Select Java executable...";
                if ( selectJava.ShowDialog() == System.Windows.Forms.DialogResult.OK )
                {
                    Program.setSavedConfigurationInformation("JavaLocation", selectJava.FileName );
                    JavaLocation = selectJava.FileName;
                } else
                {
                    return null;
                }
            }

            string FreeTTSLocation = Program.getSavedConfigurationInformation("FreeTTSLocation");
            if(FreeTTSLocation.Length == 0)
            {
                System.Windows.Forms.OpenFileDialog selectFreeTTS = new System.Windows.Forms.OpenFileDialog();
                selectFreeTTS.DefaultExt = "exe";
                selectFreeTTS.Filter = "FreeTTS|freetts.jar|All files|*.*";
                selectFreeTTS.Title = "Select FreeTTS executable...";
                if (selectFreeTTS.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Program.setSavedConfigurationInformation("FreeTTSLocation", selectFreeTTS.FileName);
                    FreeTTSLocation = selectFreeTTS.FileName;
                }
                else
                {
                    return null;
                }
            }
            return new FreeTTS(JavaLocation, FreeTTSLocation);
        }

        public override string buildParameters(string Input )
        {
            System.IO.File.Delete(mOutputLocation);
            return "-jar " + mFreeTTSLocation + " -dumpAudio " + mOutputLocation + " -text " + Input;
        }
    }*/
}
