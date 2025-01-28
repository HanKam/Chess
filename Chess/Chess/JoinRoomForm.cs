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
using Timer = System.Windows.Forms.Timer;

namespace Chess
{
    public partial class JoinRoomForm : Form
    {
        private RoomNetworkManagerClient _roomClient;
        private List<KeyValuePair<IPAddress, RoomMessage>> _roomList;
        private KeyValuePair<IPAddress, RoomMessage> _item;
        private Timer _timer;


        public JoinRoomForm()
        {
            InitializeComponent();

            this._timer = new Timer();
            this._timer.Interval = 1500; // 3 sekundy
            this._timer.Tick += Timer_Tick;            
        }
        private void JoinRoomForm_Load(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            btnBack.Enabled = false;

            this._timer.Start();

            this._roomClient = new RoomNetworkManagerClient();
            this._roomClient.StartClient(UpdateRoomList, HandleReady);
        }


        private void roomList_DubleClick(object sender, EventArgs e)
        {
            ListBox list = (ListBox)sender;
            int item = list.SelectedIndex;
            _item = this._roomList[item];

            this._roomClient.TryJoinRoom(this._item.Key);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            btnBack.Enabled = false; 
            
            this._timer.Start();

            this._roomClient.SendGetRooms();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this._timer.Stop();

            btnRefresh.Enabled = true;
            btnBack.Enabled = true;
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
                this.roomList.Items.Clear();
                foreach (var item in list)
                {
                    string itemStr = ItemToString(item);

                    this.roomList.Items.Add(itemStr);
                }

                this._roomList = list;
                roomList.Update();
            }

        }
        private string ItemToString(KeyValuePair<IPAddress, RoomMessage> item)
        {
            RoomMessage roomMessage = item.Value;
            string roomName = roomMessage.roomName;
            string hostColour = roomMessage.playerColour == Pieces.Colour.White ? "W" : "B";
            string timeMove = roomMessage.timeMove / 60 + ":" + roomMessage.timeMove % 60;
            string timeAdd = roomMessage.timeAdd / 60 + ":" + roomMessage.timeAdd % 60;

            string ipAddress = item.Key.ToString();


            return roomName + "; " + hostColour + "; " + timeMove +  "; " + timeAdd + "; " + ipAddress;
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

                Colour colour = _item.Value.playerColour == Pieces.Colour.White ? Colour.Black : Colour.White;
                ChessBoardForm chessBoardForm = new ChessBoardForm(ChessBoardForm.ConnectionType.Client, colour, _item.Value.timeMove, _item.Value.timeAdd, _item.Value.roomName, null, _item.Key);

                chessBoardForm.TopLevel = false;
                chessBoardForm.FormBorderStyle = FormBorderStyle.None;
                chessBoardForm.Anchor = AnchorStyles.None;

                this.Controls.Add(chessBoardForm);

                chessBoardForm.BringToFront();
                chessBoardForm.Show();
            }
        }

    }
}
