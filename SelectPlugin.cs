using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftwareTelephone
{
    public partial class SelectPlugin : Form
    {
        public bool mForceReconfigure;
        public SelectPlugin()
        {
            InitializeComponent();
        }

        public void addToPluginList(IPlugin add)
        {
            PluginList.Items.Add(add);
        }

        public IPlugin getSelectedPlugin()
        {
            return (IPlugin)PluginList.SelectedItem;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            mForceReconfigure = Control.ModifierKeys == Keys.Shift;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                Ok_Click(sender, e);
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                Cancel_Click(sender, e);
            }
        }

        private void PluginList_onKeyDown(object sender, KeyEventArgs e)
        {
            onKeyDown(sender, e);
        }
    }
}
