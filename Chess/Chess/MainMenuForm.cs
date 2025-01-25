using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class MainMenuForm : Form
    {
        private int _originalWidth;
        private int _originalHeight;
        public MainMenuForm()
        {
            InitializeComponent();
            _originalHeight = this.Size.Height;
            _originalWidth = this.Size.Width;
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            AudioManager.PlayAudio();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();


            startForm.TopLevel = false;
            startForm.FormBorderStyle = FormBorderStyle.None;
            startForm.Anchor = AnchorStyles.None;
            int x = (this.Size.Width - _originalWidth) / 2;
            int y = (this.Size.Height - _originalHeight) / 2;
            startForm.Location = new Point(x, y);

            this.Controls.Add(startForm);

            startForm.BringToFront();
            startForm.Show();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();

            optionsForm.TopLevel = false;
            optionsForm.FormBorderStyle = FormBorderStyle.None;
            optionsForm.Anchor = AnchorStyles.None;
            int x = (this.Size.Width - _originalWidth) / 2;
            int y = (this.Size.Height - _originalHeight) / 2;
            optionsForm.Location = new Point(x, y);

            this.Controls.Add(optionsForm);

            optionsForm.BringToFront();
            optionsForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
