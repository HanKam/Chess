using Chess;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class MoveNetworkManager
{
    private TcpListener _server;
    private TcpClient _client;
    private NetworkStream _stream;
    private Action<MoveMessage> _callback;
    private int _port;

    public MoveNetworkManager(int port, Action<MoveMessage> callback)
    {
        _callback = callback;
        _port = port;
    }

    public void Connect(string ipAddress, int port)
    {
        _client = new TcpClient(ipAddress, port);
        _stream = _client.GetStream();
        Thread receiveThread = new Thread(ReceiveData);
        receiveThread.Start();
    }

    public void WaitForConnection()
    {
        Thread listenerThread = new Thread(() =>
        {
            _server = new TcpListener(IPAddress.Any, _port);
            _server.Start();
            _client = _server.AcceptTcpClient();
            _stream = _client.GetStream();
            Thread receiveThread = new Thread(ReceiveData);
            receiveThread.Start();
        });

        // Waiting for a client to join
        listenerThread.Start();
    }

    public void SendData(string message)
    {
        byte[] data = Encoding.UTF8.GetBytes(message);
        _stream.Write(data, 0, data.Length);
    }

    private void ReceiveData()
    {     
        byte[] buffer = new byte[1024];
        while (true)
        {
            int bytesRead = _stream.Read(buffer, 0, buffer.Length);
            if (bytesRead > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                HandleMessage(message);
            }
        }
    }

    private void HandleMessage(string message)
    {
        MoveMessage moveMessage = new MoveMessage();
        moveMessage.Deserialize(message);
        _callback.Invoke(moveMessage);
    }

    public void Close()
    {
        _stream.Close();
        _client.Close();
        _server.Stop();
    }
}
