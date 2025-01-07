using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Timer = System.Threading.Timer;

namespace Chess
{
    public class RoomNetworkManagerServer
    {
        private const int Port = 6943;
        private UdpClient _udpServer;
        private IPEndPoint _endPoint;
        private Action _onJoinCallback;
        private CancellationTokenSource _cancellationTokenSource;

        public string roomName { get; set; }
        public Colour playerColour { get; set; }

        private int _timeMove;
        private int _timeAdd;

        public RoomNetworkManagerServer(string roomName, Colour playerColour, int timeMove, int timeAdd, Action onJoinCallback)
        {
            _udpServer = new UdpClient();
            _endPoint = new IPEndPoint(IPAddress.Any, Port);
            this.roomName = roomName;
            this.playerColour = playerColour;
            this._timeMove = timeMove;
            this._timeAdd = timeAdd;

            this._onJoinCallback = onJoinCallback; 
        }

        
        public void StartServer()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            Thread listeningThread = new Thread(() => ListenForRequests(token));
            listeningThread.Start();
        }
        public void StopServer()
        {
            _cancellationTokenSource.Cancel();

        }

        // Listening and answering
        private void ListenForRequests(CancellationToken cancellationToken)
        {
            _udpServer.EnableBroadcast = true;
            _udpServer.Client.Bind(_endPoint);
            _udpServer.Client.ReceiveTimeout = 200;

            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    // Getting a request
                    byte[] receivedData = _udpServer.Receive(ref _endPoint);
                    string request = Encoding.UTF8.GetString(receivedData);

                    // Checking if it is "our" request
                    if (request == "GET_ROOMS")
                    {                        
                        string response = GetRoomResponse();
                        byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                        _udpServer.Send(responseBytes, responseBytes.Length, _endPoint);
                    }

                    if (request == "JOIN_ROOM")
                    {
                        _onJoinCallback.Invoke();
                        _udpServer.Close();

                        return;
                    }
                }
                catch (SocketException)
                {
                    //Ignored - timeout                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while listening: " + ex.Message);
                }
            }

            _udpServer.Close();
        }

        public void SendReady()
        {
            byte[] responseBytes = Encoding.UTF8.GetBytes("READY");
            _udpServer.Send(responseBytes, responseBytes.Length, _endPoint);
        }

        private string GetRoomResponse()
        {
            RoomMessage roomMessage = new RoomMessage(roomName, playerColour, _timeMove, _timeAdd) ;
            return roomMessage.Serialize();
        }

       
    }


}
