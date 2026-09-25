using System;
using System.Collections.Generic;
using SplashKitSDK;

namespace MessageDataBytesExample
{
    public class Program
    {
        public static void Main()
        {
            ushort port = 5000;

            ServerSocket server =
                new ServerSocket("byte_server", port);

            // Create a local connection and send a message
            Connection client = new Connection(
                "byte_client",
                "127.0.0.1",
                port
            );

            SplashKit.Delay(100);
            SplashKit.CheckNetworkActivity();
            SplashKit.AcceptAllNewConnections();

            client.SendMessage("Hi");

            SplashKit.Delay(100);
            SplashKit.CheckNetworkActivity();

            Message receivedMessage =
                server.ReadMessage();

            // Read the received message as bytes
            List<byte> dataBytes =
                receivedMessage.DataBytes;

            Console.WriteLine("Message Data Bytes");
            Console.WriteLine();
            Console.WriteLine("Message: Hi");
            Console.Write("Bytes: ");

            foreach (byte value in dataBytes)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();

            SplashKit.CloseAllConnections();
            SplashKit.CloseAllServers();
        }
    }
}