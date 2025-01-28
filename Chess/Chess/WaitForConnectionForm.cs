using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class WaitForConnectionForm : Form
    {
        private string _roomName;
        private Colour _colour;
        private int _timeMove;
        private int _timeAdd;
        private RoomNetworkManagerServer _roomServer;

        public WaitForConnectionForm(string roomName, Colour colour, int timeMove, int timeAdd)
        {
            InitializeComponent();

            this._roomName = roomName;
            this._colour = colour;
            this._timeMove = timeMove;
            this._timeAdd = timeAdd;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this._roomServer.StopServer();

            Thread.Sleep(205);

            this.Close();
        }

        private void WaitForConnectionForm_Load(object sender, EventArgs e)
        {
            this._roomServer = new RoomNetworkManagerServer(this._roomName, this._colour, this._timeMove, this._timeAdd, SwitchToChessBoardForm);
            this._roomServer.StartServer();
        }
        private void SwitchToChessBoardForm()
        {
            if (InvokeRequired)
            {
                // Queueing in main thread 
                Invoke(new Action (SwitchToChessBoardForm));
            }
            else
            {
                ChessBoardForm chessBoardForm = new ChessBoardForm(ChessBoardForm.ConnectionType.Host, this._colour, this._timeMove, this._timeAdd, _roomName, this);

                chessBoardForm.TopLevel = false;
                chessBoardForm.FormBorderStyle = FormBorderStyle.None;
                chessBoardForm.Anchor = AnchorStyles.None;

                
                this.Controls.Add(chessBoardForm);

                chessBoardForm.BringToFront();
                chessBoardForm.Show();

                this._roomServer.SendReady();
            }
        }
    }
}
