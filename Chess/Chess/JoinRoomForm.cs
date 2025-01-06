using Chess.Pieces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class JoinRoomForm : Form
    {
        private RoomNetworkManagerClient _roomClient;
        private List<KeyValuePair<IPAddress, RoomMessage>> _roomList;
        private Colour _colour;
        private IPAddress _ipAddress;


        public JoinRoomForm()
        {
            InitializeComponent();
        }
        private void JoinRoomForm_Load(object sender, EventArgs e)
        {
            _roomClient = new RoomNetworkManagerClient();
            _roomClient.StartClient(UpdateRoomList,HandleReady);
        }


        private void roomList_DubleClick(object sender, EventArgs e)
        {
            ListBox list = (ListBox)sender;
            int item = list.SelectedIndex;

            _ipAddress = _roomList[item].Key;
            _colour = _roomList[item].Value.playerColour == Colour.White ? Colour.Black : Colour.White;


            _roomClient.TryJoinRoom(_ipAddress);
        }
        private void UpdateRoomList(List<KeyValuePair<IPAddress, RoomMessage>> list)
        {
            if (InvokeRequired)
            {
                // Queueing in main thread 
                Invoke(new Action<List<KeyValuePair<IPAddress, RoomMessage>>>(UpdateRoomList), list);
            }
            else
            {
                foreach (var item in list)
                {
                    string itemStr = ItemToString(item);

                    this.roomList.Items.Add(itemStr);
                }

                _roomList = list;
                roomList.Update();
            }

        }
        private string ItemToString(KeyValuePair<IPAddress, RoomMessage> item)
        {
            RoomMessage roomMessage = item.Value;
            string roomName = roomMessage.roomName;
            string hostColour = roomMessage.playerColour == Pieces.Colour.White ? "W" : "B";
            string ipAddress = item.Key.ToString();


            return roomName + " " + hostColour + " " + ipAddress;
        }

        private void HandleReady(bool success)
        {
            if (InvokeRequired)
            {
                // Queueing in main thread 
                Invoke(new Action<Boolean>(HandleReady), success);
            }
            else
            {
                if (!success)
                {
                    MessageBox.Show("Nie udało się połączyć.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ChessBoardForm chessBoardForm = new ChessBoardForm(ChessBoardForm.ConnectionType.Client, _colour, _ipAddress);

                chessBoardForm.TopLevel = false;
                chessBoardForm.FormBorderStyle = FormBorderStyle.None;
                chessBoardForm.Anchor = AnchorStyles.None;

                this.Controls.Clear();
                this.Controls.Add(chessBoardForm);
                chessBoardForm.Show();
            }
        }

    }
}
