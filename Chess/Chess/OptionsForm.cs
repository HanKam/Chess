using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void muteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (muteCheckBox.Checked)
            {
                AudioManager.StopAudio();
            }
            else
            {
                AudioManager.ResumeAudio();
            }

        }

        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            AudioManager.ChangeVolume(volumeBar.Value);
        }
    }
}
