using System;
using SplashKitSDK;

namespace ReadMessageExample
{
    class Program
    {
        public static void Main()
        {
            // create a TCP server on port 4000
            ServerSocket server = SplashKit.CreateServer("my_server", 4000);

            // connect the client to our server
            Connection client = SplashKit.OpenConnection("client", "127.0.0.1", 4000);
            if (!SplashKit.IsConnectionOpen(client))
            {
                Console.WriteLine("Connection failed.");
                return;
            }

            // wait for the server to accept the client
            while (!server.AcceptNewConnection())
            {
                SplashKit.CheckNetworkActivity();
                SplashKit.Delay(50);
            }
            Connection serverConn = server.FetchNewConnection();

            // server sends its greeting
            serverConn.SendMessage("Hello from SplashKit server!");

            // pump the network so the client can receive it
            SplashKit.CheckNetworkActivity();

            // client reads and prints the message
            if (client.HasMessages)
            {
                Message msg = client.ReadMessage();
                Console.WriteLine("Client got: " + msg.Data);
            }
            else
            {
                Console.WriteLine("No message arrived.");
            }

            // clean up
            client.Close();
            serverConn.Close();
            server.Close();
        }
    }
}
