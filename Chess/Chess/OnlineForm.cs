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
    public partial class OnlineForm : Form
    {
        public OnlineForm()
        {
            InitializeComponent();
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            HostForm hostForm = new HostForm();

            hostForm.TopLevel = false;
            hostForm.FormBorderStyle = FormBorderStyle.None;
            hostForm.Anchor = AnchorStyles.None;

            this.Controls.Add(hostForm);

            hostForm.BringToFront();
            hostForm.Show();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            JoinRoomForm joinRoomForm = new JoinRoomForm();

            joinRoomForm.TopLevel = false;
            joinRoomForm.FormBorderStyle = FormBorderStyle.None;
            joinRoomForm.Anchor = AnchorStyles.None;

            this.Controls.Add(joinRoomForm);

            joinRoomForm.BringToFront();
            joinRoomForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
