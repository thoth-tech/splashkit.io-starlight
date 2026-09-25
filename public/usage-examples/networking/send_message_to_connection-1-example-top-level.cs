using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a window for the telemetry hub display
OpenWindow("UDP Telemetry Hub", 800, 600);

// Set up a UDP server to receive telemetry data
ServerSocket hubServer = CreateServer("hub", 5000, ConnectionType.UDP);

// Set up a UDP connection to send telemetry data to the hub
Connection senderConn = OpenConnection("sender", "127.0.0.1", 5000, ConnectionType.UDP);

// Simulated sprite position (sender side)
double spritePosX = 400.0;
double spritePosY = 300.0;
double velocityX = 2.0;
double velocityY = 1.5;

// Received position (hub display side)
double receivedX = 0.0;
double receivedY = 0.0;
bool hasData = false;

// Send an initial handshake ping
SendMessageTo("PING", senderConn);

while (!QuitRequested())
{
    ProcessEvents();

    // Update simulated sprite position with bouncing
    spritePosX += velocityX;
    spritePosY += velocityY;

    // Bounce off window edges
    if (spritePosX <= 0 || spritePosX >= 780)
    {
        velocityX = -velocityX;
    }
    if (spritePosY <= 80 || spritePosY >= 580)
    {
        velocityY = -velocityY;
    }

    // Format position data as a string and send via UDP
    string posData = "POS:" + ((int)spritePosX).ToString() + "," + ((int)spritePosY).ToString();
    SendMessageTo(posData, senderConn);

    // Check for incoming UDP packets on the hub server
    CheckNetworkActivity();

    // Process any received messages
    if (HasMessages())
    {
        // Read the incoming message and extract its payload
        Message msg = ReadMessage();
        string payload = MessageData(msg);

        // Parse the position data from the payload
        if (payload.Length >= 4 && payload.Substring(0, 4) == "POS:")
        {
            string coords = payload.Substring(4);
            int commaPos = coords.IndexOf(",");
            receivedX = double.Parse(coords.Substring(0, commaPos));
            receivedY = double.Parse(coords.Substring(commaPos + 1));
            hasData = true;
        }

        CloseMessage(msg);
    }

    // Render the hub display
    ClearScreen(ColorBlack());

    // Draw header panel
    FillRectangle(RGBAColor(30, 30, 50, 255), 0, 0, 800, 70);
    DrawText("UDP Telemetry Hub", ColorWhite(), 20, 10);
    DrawText("Protocol: UDP | Port: 5000 | Status: LIVE", ColorGreen(), 20, 35);

    // Draw the sender indicator (what is being sent)
    FillCircle(RGBAColor(50, 120, 200, 150), spritePosX, spritePosY, 10);
    DrawText("SENDER", RGBAColor(50, 120, 200, 200), spritePosX - 20, spritePosY - 20);

    // Draw the received position indicator (what the hub received)
    if (hasData)
    {
        FillCircle(ColorYellow(), receivedX, receivedY, 6);
        DrawCircle(RGBAColor(255, 255, 0, 100), receivedX, receivedY, 15);
        DrawText("HUB", ColorYellow(), receivedX - 10, receivedY + 18);

        // Display telemetry readout
        FillRectangle(RGBAColor(20, 20, 40, 200), 560, 80, 230, 100);
        DrawRectangle(RGBAColor(0, 200, 100, 150), 560, 80, 230, 100);
        DrawText("Telemetry Readout", ColorGreen(), 580, 90);
        DrawText("X: " + ((int)receivedX).ToString(), ColorWhite(), 580, 115);
        DrawText("Y: " + ((int)receivedY).ToString(), ColorWhite(), 580, 140);
    }

    // Draw a dashed connection line between sender and hub
    if (hasData)
    {
        DrawLine(RGBAColor(0, 200, 100, 80), spritePosX, spritePosY, receivedX, receivedY);
    }

    RefreshScreen(60);
}

// Clean up networking resources
CloseAllConnections();
CloseAllServers();
CloseAllWindows();
