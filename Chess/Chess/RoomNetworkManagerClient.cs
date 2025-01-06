using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Chess
{
    public class RoomNetworkManagerClient
    {
        // Next port after MoveNetworkManager's port
        private const int Port = 6943; 
        private UdpClient _udpClient;
        private IPEndPoint _endPoint;
        private Action<List<KeyValuePair<IPAddress, RoomMessage>>> _callbackList;
        Action<Boolean> _callbackJoin;



        public RoomNetworkManagerClient()
        {
            this._udpClient = new UdpClient();
            this._endPoint = new IPEndPoint(IPAddress.Any, Port);
        }

        
        public void StartClient(Action<List<KeyValuePair<IPAddress, RoomMessage>>> callbackList, Action<Boolean> callbackJoin)
        {
            this._callbackList = callbackList;
            this._callbackJoin = callbackJoin;

            Thread sendRequestThread = new Thread(new ThreadStart(SendRequest));
            sendRequestThread.Start();
        }

        public void TryJoinRoom(IPAddress ipAddress)
        {
            string message = "JOIN_ROOM";
            byte[] data = Encoding.UTF8.GetBytes(message);
            _udpClient.Send(data, data.Length, new IPEndPoint(ipAddress, Port));

            Thread waitForJoinThread = new Thread(new ThreadStart(WaitForReady));
            waitForJoinThread.Start();
        }

        // Client is sending request about available rooms
        private void SendRequest()
        {         
            try
            {
                string message = "GET_ROOMS";
                byte[] data = Encoding.UTF8.GetBytes(message);
                _udpClient.Send(data, data.Length, new IPEndPoint(IPAddress.Broadcast, Port));

                // Waiting for 1 sec 
                List<KeyValuePair<IPAddress, RoomMessage>> responses = ReceiveResponses();

                // Calling a function from RoomJoinForm with list of available rooms
                _callbackList.Invoke(responses);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while sending request: " + ex.Message);
            }
        }

       
        private List<KeyValuePair<IPAddress, RoomMessage>> ReceiveResponses()
        {
            List<KeyValuePair<IPAddress, RoomMessage>> responses = new List<KeyValuePair<IPAddress, RoomMessage>>();

            
            DateTime startTime = DateTime.Now;
                        
            _udpClient.Client.ReceiveTimeout = 1000;  // 1000 ms = 1 sec

            // Waiting for 1 sec
            while ((DateTime.Now - startTime).TotalSeconds < 1)
            {
                try
                {
                    byte[] receivedData = _udpClient.Receive(ref this._endPoint);
                    string response = Encoding.UTF8.GetString(receivedData);
                                        
                    responses.Add(new KeyValuePair<IPAddress, RoomMessage>(this._endPoint.Address, new RoomMessage(response)));
                }
                catch (SocketException)
                {
                    //Ignored - timeout
                    break;  
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while receiving response: " + ex.Message);
                }
            }

            return responses;
        }

        private void WaitForReady()
        {
            DateTime startTime = DateTime.Now;

            _udpClient.Client.ReceiveTimeout = 1000;  // 1000 ms = 1 sec

            // Waiting for 1 sec
            while ((DateTime.Now - startTime).TotalSeconds < 1)
            {
                try
                {
                    byte[] receivedData = _udpClient.Receive(ref this._endPoint);
                    string response = Encoding.UTF8.GetString(receivedData);

                    if(response == "READY")
                    {
                        _callbackJoin.Invoke(true);
                        return;
                    }
                }
                catch (SocketException)
                {
                    _callbackJoin.Invoke(false);
                    return;
                }
                catch (Exception ex)
                {
                    _callbackJoin.Invoke(false);
                    Console.WriteLine("Error while waiting for ready: " + ex.Message);
                }
            }
        }
    }
}
