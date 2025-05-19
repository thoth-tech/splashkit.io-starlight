using System;
using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Simple SplashKit.NET networking demo using top‐level statements

// create a TCP server on port 4000
var server = CreateServer("my_server", 4000);

// open a client connection to that server
var client = OpenConnection("client", "127.0.0.1", 4000);
if (!IsConnectionOpen(client))
{
    Console.WriteLine("Connection failed.");
    return;
}

// wait until the server accepts the client
Console.WriteLine("Waiting for server to accept connection…");
while (!ServerHasNewConnection(server))
{
    CheckNetworkActivity();
    Delay(50);
}

// fetch the newly‐accepted connection on the server
var serverConn = FetchNewConnection(server);

// server sends its greeting
SendMessageTo("Hello from SplashKit server!", serverConn);

// pump the network so the client can receive it
CheckNetworkActivity();

// client reads and prints the message
if (HasMessages(client))
{
    var msg = ReadMessage(client);
    Console.WriteLine("Client got: " + MessageData(msg));
}
else
{
    Console.WriteLine("No message arrived.");
}

// clean up
CloseConnection(client);
CloseConnection(serverConn);
CloseAllServers();
