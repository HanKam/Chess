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
        private RoomNetworkManagerServer _roomServer;
        private MoveNetworkManager _moveServer;

        public WaitForConnectionForm(string roomName, Colour colour)
        {
            InitializeComponent();

            _roomName = roomName;
            _colour = colour;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void WaitForConnectionForm_Load(object sender, EventArgs e)
        {
            _roomServer = new RoomNetworkManagerServer(_roomName, _colour, SwitchToChessBoardForm);
            _roomServer.StartServer();
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
                ChessBoardForm chessBoardForm = new ChessBoardForm(ChessBoardForm.ConnectionType.Host, _colour);

                chessBoardForm.TopLevel = false;
                chessBoardForm.FormBorderStyle = FormBorderStyle.None;
                chessBoardForm.Anchor = AnchorStyles.None;

                this.Controls.Clear();
                this.Controls.Add(chessBoardForm);
                chessBoardForm.Show();

                _roomServer.SendReady();
            }
        }
    }
}
