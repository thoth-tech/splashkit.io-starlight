using System;
using System.Collections.Generic;
using SplashKitSDK;
using static SplashKitSDK.SplashKit;

ushort port = 5000;

ServerSocket server = CreateServer("byte_server", port);

// Create a local connection and send a message
Connection client = OpenConnection(
    "byte_client",
    "127.0.0.1",
    port
);

Delay(100);
CheckNetworkActivity();
AcceptAllNewConnections();

SendMessageTo("Hi", client);

Delay(100);
CheckNetworkActivity();

Message receivedMessage = ReadMessage(server);

// Read the received message as bytes
List<byte> dataBytes =
    MessageDataBytes(receivedMessage);

Console.WriteLine("Message Data Bytes");
Console.WriteLine();
Console.WriteLine("Message: Hi");
Console.Write("Bytes: ");

foreach (byte value in dataBytes)
{
    Console.Write(value + " ");
}

Console.WriteLine();

CloseAllConnections();
CloseAllServers();