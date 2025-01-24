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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnSingleplayer_Click(object sender, EventArgs e)
        {
            SingleForm singleplayerForm = new SingleForm();

            singleplayerForm.TopLevel = false;
            singleplayerForm.FormBorderStyle = FormBorderStyle.None;
            singleplayerForm.Anchor = AnchorStyles.None;

            this.Controls.Add(singleplayerForm);

            singleplayerForm.BringToFront();
            singleplayerForm.Show();
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            OnlineForm multiplayerForm = new OnlineForm();

            multiplayerForm.TopLevel = false;
            multiplayerForm.FormBorderStyle = FormBorderStyle.None;
            multiplayerForm.Anchor = AnchorStyles.None;

            this.Controls.Add(multiplayerForm);

            multiplayerForm.BringToFront();
            multiplayerForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
