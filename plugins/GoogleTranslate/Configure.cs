using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Google.Unoffical.Translate;

namespace GoogleTranslate
{
    public partial class Configure : Form
    {
        public Configure()
        {
            InitializeComponent();
            foreach (string addLanguage in Language.validLanguages)
            {
                FromList.Items.Add(addLanguage);
                ToList.Items.Add(addLanguage);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        public string getFromLanguage()
        {
            return (string)FromList.SelectedItem;
        }

        public string getToLanguage()
        {
            return (string)ToList.SelectedItem;
        }
    }
}
