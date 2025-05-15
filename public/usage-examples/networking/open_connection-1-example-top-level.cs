using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Establish a TCP connection to a local server on port 8080
Connection conn = OpenConnection("local server connection", "127.0.0.1", 8080);

if (IsConnectionOpen(conn))
{
    WriteLine("Connection successfully established.");
}
else
{
    WriteLine("Failed to connect.");
}
