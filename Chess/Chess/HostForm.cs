using Chess.Pieces;
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
    public partial class HostForm : Form
    {
        public HostForm()
        {
            InitializeComponent();
        }

        private void HostForm_Load(object sender, EventArgs e)
        {
            string defaultRoomName = GetRandomRoomName();
            textBoxRoomName.Text = defaultRoomName;
        }

        private string GetRandomRoomName()
        {
            string[] firstParts = {
                "Pokój",
                "Stowarzyszenie",
                "Grupa",
                "Sekta",
                "Towarzystwo",
                "Klub",
                "Zespół",
                "Zbiór",
                "Koło"
            };

            string[] secondParts = {
                "przyjaciół kotów",
                "najlepszych szachistów",
                "najprzystojniejszych szachistów",
                "najpiękniejszych szachistek",
                "szeroko rozumianych osób wariackich",
                "przyjaciół myszki Miki",
                "miłośników kotów",
                "wzajemnej adoracji",
                "maniaków szachowych",
                "wielbicieli gier intelektualnych",
                "rannych ptaszków",
                "nocnych marków",
                "popołudionych leniwców",
                "jesieniar i jesieniarzy",
                "posiadaczy drogiego samochodu",
                "ludzi preferujących kolor zielony",
                "kolejrzy"
            };

            Random random = new Random();
            int firstPartIndex = random.Next(0, firstParts.Length);
            int secondPartIndex = random.Next(0, secondParts.Length);
            return firstParts[firstPartIndex] + " " + secondParts[secondPartIndex];
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            string roomName = textBoxRoomName.Text;

            if (roomName == "")
            {
                MessageBox.Show("Nazwa pokoju nie może być pusta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Colour hostColour = Colour.White;
            if (radioBtnBlack.Checked)
            {
                hostColour = Colour.Black;
            }
            if (radioBtnRandom.Checked)
            {
                Random random = new Random();
                if (random.Next(0, 2) == 0)
                {
                    hostColour = Colour.Black;
                }
            }

            WaitForConnectionForm multiplayerWaitForm = new WaitForConnectionForm(roomName, hostColour);

            multiplayerWaitForm.TopLevel = false;
            multiplayerWaitForm.FormBorderStyle = FormBorderStyle.None;
            multiplayerWaitForm.Anchor = AnchorStyles.None;

            this.Controls.Add(multiplayerWaitForm);

            multiplayerWaitForm.BringToFront();
            multiplayerWaitForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
