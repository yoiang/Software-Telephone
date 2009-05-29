using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace dotNetSpeech
{
    public partial class Configure : Form
    {
        SpeechSynthesizer mSpeechSynthesizer;
        public Configure( SpeechSynthesizer setSpeechSynthesizer )
        {
            InitializeComponent();

            mSpeechSynthesizer = setSpeechSynthesizer;

            Rate.Value = mSpeechSynthesizer.Rate;
            Volume.Value = mSpeechSynthesizer.Volume;

            System.Collections.ObjectModel.ReadOnlyCollection<InstalledVoice> InstalledVoices = mSpeechSynthesizer.GetInstalledVoices();
            foreach( InstalledVoice InstalledVoice in InstalledVoices )
            {
                if (InstalledVoice.Enabled)
                {
                    VoiceList.Items.Add(InstalledVoice.VoiceInfo.Name);
                }
            }
            VoiceList.SelectedIndex = 0;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            mSpeechSynthesizer.Rate = (int)Rate.Value;
            mSpeechSynthesizer.Volume = (int)Volume.Value;

            mSpeechSynthesizer.SelectVoice((string)VoiceList.SelectedItem);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
