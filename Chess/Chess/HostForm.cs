using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                "przyjaciół Myszki Miki",
                "miłośników kotów",
                "wzajemnej adoracji",
                "maniaków szachowych",
                "wielbicieli gier intelektualnych",
                "rannych ptaszków",
                "nocnych marków",
                "popołudniowych leniwców",
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

            int timeMove = (int)((minTimerMoves.Value * 60) + secTimerMoves.Value);
            int timeAdd = (int)((minTimerAdd.Value * 60) + secTimerAdd.Value);
            

            WaitForConnectionForm multiWaitForm = new WaitForConnectionForm(roomName, hostColour, timeMove, timeAdd);


            multiWaitForm.TopLevel = false;
            multiWaitForm.FormBorderStyle = FormBorderStyle.None;
            multiWaitForm.Anchor = AnchorStyles.None;

            this.Controls.Add(multiWaitForm);

            multiWaitForm.BringToFront();
            multiWaitForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
