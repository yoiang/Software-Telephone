namespace Julian
{/*
    class eSpeakPlugin : SoftwareTelephone.TextToSpeech
    {
        public override string ToString() { return "eSpeak"; }
        public override string getInputType() { return "Text"; }
        public override string getOutputType() { return "Wav"; }

        public eSpeakPlugin()
        {
            mOutputLocation = "eSpeak.wav";
        }

        public override void configure(SoftwareTelephone.IConfig Config, bool forceReconfigure)
        {
            ApplicationLocation = Config.getSavedConfigurationInformation("eSpeakLocation");
            if (forceReconfigure || ApplicationLocation.Length == 0)
            {
                System.Windows.Forms.OpenFileDialog selecteSpeak = new System.Windows.Forms.OpenFileDialog();
                selecteSpeak.DefaultExt = "exe";
                selecteSpeak.Filter = "eSpeak|eSpeak.exe|All files|*.*";
                selecteSpeak.Title = "Select eSpeak executable...";
                if (selecteSpeak.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Config.setSavedConfigurationInformation("eSpeakLocation", selecteSpeak.FileName);
                    ApplicationLocation = selecteSpeak.FileName;
                }
            }
        }

        public override string buildParameters(string Input)
        {
            System.IO.File.Delete(mOutputLocation);
            return "-w \"" + mOutputLocation + "\" \"" + Input + "\"";
        }
    }

    public class Program
    {
    }*/

    /*
    public class Julian : SpeechToText
    {
        string mJulianConfLocation;
        public Julian(string setJuliusLocation, string setJulianConfLocation) : base("Julian", setJuliusLocation)
        {
            mJulianConfLocation = setJulianConfLocation;
        }

        public static Julian doConfigure(bool forceReconfigure)
        {
            string JulianLocation = Program.getSavedConfigurationInformation("JulianLocation");
            if (forceReconfigure || JulianLocation.Length == 0)
            {
                System.Windows.Forms.OpenFileDialog selectJulian = new System.Windows.Forms.OpenFileDialog();
                selectJulian.DefaultExt = "exe";
                selectJulian.Filter = "Julian|julian.exe|All files|*.*";
                selectJulian.Title = "Select Julian executable...";
                if (selectJulian.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Program.setSavedConfigurationInformation("JulianLocation", selectJulian.FileName);
                    JulianLocation = selectJulian.FileName;
                }
                else
                {
                    return null;
                }
            }
            string JulianConfLocation = Program.getSavedConfigurationInformation("JulianConfLocation");
            if (JulianConfLocation.Length == 0)
            {
                System.Windows.Forms.OpenFileDialog selectJulianConf = new System.Windows.Forms.OpenFileDialog();
                selectJulianConf.DefaultExt = "exe";
                selectJulianConf.Filter = "Julian configuration|*.jconf|All files|*.*";
                selectJulianConf.Title = "Select Julian configuration...";
                if (selectJulianConf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Program.setSavedConfigurationInformation("JulianConfLocation", selectJulianConf.FileName);
                    JulianConfLocation = selectJulianConf.FileName;
                }
                else
                {
                    return null;
                }
            }
            return new Julian(JulianLocation, JulianConfLocation);
        }

        override public string doSpeechToText(string Input)
        {
            System.Diagnostics.Process runApplication = new System.Diagnostics.Process();
            runApplication.StartInfo = new System.Diagnostics.ProcessStartInfo(mApplicationLocation, buildParameters(Input));
            runApplication.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            runApplication.StartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(mJulianConfLocation);
            runApplication.StartInfo.UseShellExecute = false;
            runApplication.StartInfo.RedirectStandardOutput = true;
            runApplication.StartInfo.RedirectStandardError = true;

            System.IO.StreamReader StdOutput = null;
            System.IO.StreamReader StdError = null;
            try
            {
                runApplication.Start();
                StdOutput = runApplication.StandardOutput;
                StdError = runApplication.StandardError;
                runApplication.WaitForExit();
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show(E.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            try
            {
                string readOutput = StdOutput.ReadToEnd();
                string readError = StdError.ReadToEnd();
                if (readOutput.Length == 0  && readError.Length != 0)
                {
                    throw (new Exception(readError));
                }
                string Result = String.Empty;
                Match found = Regex.Match(readOutput, @"sentence1: (.*?)\n", RegexOptions.Multiline); // fix for multiple sentances
                if (found.Length > 1)
                {
                    string stripTags = found.Groups[1].Value;
                    if (stripTags.StartsWith("<s> "))
                    {
                        stripTags = stripTags.Remove(0, 4);
                    }
                    if (stripTags.EndsWith(" </s>"))
                    {
                        stripTags = stripTags.Remove(stripTags.Length-6, 5);
                    }
                    Result += stripTags;
                }
                return Result;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message,"Error", System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
            }
            return String.Empty;
        }

        public override string buildParameters(string Input )
        {
            System.IO.File.Delete(Input + ".txt");
            System.IO.StreamWriter createFileList = new System.IO.StreamWriter(Input + ".txt");
            createFileList.WriteLine(Input);
            createFileList.Close();
            return "-input rawfile -C " + mJulianConfLocation + " -filelist " + System.IO.Directory.GetCurrentDirectory() + "\\" + Input + ".txt -quiet";
        }
    }*/
}
