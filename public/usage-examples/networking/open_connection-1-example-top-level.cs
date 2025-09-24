using SplashKitSDK;

// Open a window
SplashKit.OpenWindow("Open Connection Example", 800, 600);

SplashKit.WriteLine("Open Connection Example");
SplashKit.WriteLine("Attempting to open a network connection");
SplashKit.WriteLine("Press any key to exit");

// Connection details
string host = "example.com";
int port = 80;

// Try to open a connection
Connection conn = SplashKit.OpenConnection(host, port);

if (SplashKit.IsConnectionOpen(conn))
{
    SplashKit.WriteLine("Connection opened successfully!");
    SplashKit.WriteLine("Host: " + host);
    SplashKit.WriteLine("Port: " + port);
    SplashKit.WriteLine("Connection IP: " + SplashKit.ConnectionIP(conn));
    SplashKit.WriteLine("Connection Port: " + SplashKit.ConnectionPort(conn));
}
else
{
    SplashKit.WriteLine("Failed to open connection to " + host + ":" + port);
    SplashKit.WriteLine("This is expected for example.com as it may not accept connections");
}

while (!SplashKit.WindowCloseRequested("Open Connection Example"))
{
    // Clear the screen
    SplashKit.ClearScreen(Color.White);
    
    // Display connection information
    SplashKit.DrawText("Open Connection Example", Color.Black, 50, 50);
    SplashKit.DrawText("Network Connection Test", Color.Black, 50, 100);
    
    if (SplashKit.IsConnectionOpen(conn))
    {
        SplashKit.DrawText("Connection Status: OPEN", Color.Green, 50, 150);
        SplashKit.DrawText("Host: " + host, Color.Blue, 70, 200);
        SplashKit.DrawText("Port: " + port, Color.Blue, 70, 230);
        SplashKit.DrawText("Connection IP: " + SplashKit.ConnectionIP(conn), Color.Blue, 70, 260);
        SplashKit.DrawText("Connection Port: " + SplashKit.ConnectionPort(conn), Color.Blue, 70, 290);
    }
    else
    {
        SplashKit.DrawText("Connection Status: FAILED", Color.Red, 50, 150);
        SplashKit.DrawText("Host: " + host, Color.Red, 70, 200);
        SplashKit.DrawText("Port: " + port, Color.Red, 70, 230);
        SplashKit.DrawText("Note: This is expected for example.com", Color.Orange, 70, 260);
        SplashKit.DrawText("as it may not accept connections", Color.Orange, 70, 290);
    }
    
    // Instructions
    SplashKit.DrawText("This example demonstrates opening network connections", Color.Black, 50, 400);
    SplashKit.DrawText("Check the console for detailed connection information", Color.Black, 50, 450);
    SplashKit.DrawText("Press any key to exit", Color.Black, 50, 500);
    
    // Refresh the screen
    SplashKit.RefreshScreen();
    
    // Process events
    SplashKit.ProcessEvents();
    
    // Small delay
    SplashKit.Delay(16);
}

// Close the connection if it's open
if (SplashKit.IsConnectionOpen(conn))
{
    SplashKit.CloseConnection(conn);
    SplashKit.WriteLine("Connection closed");
} 