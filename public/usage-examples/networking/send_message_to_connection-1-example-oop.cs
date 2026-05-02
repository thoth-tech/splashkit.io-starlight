using SplashKitSDK;

namespace SendMessageToConnectionExample
{
    public class Program
    {
        public static void Main()
        {
            // Open a window for the telemetry hub display
            SplashKit.OpenWindow("UDP Telemetry Hub", 800, 600);

            // Set up a UDP server to receive telemetry data
            ServerSocket hubServer = SplashKit.CreateServer("hub", 5000, ConnectionType.UDP);

            // Set up a UDP connection to send telemetry data to the hub
            Connection senderConn = SplashKit.OpenConnection("sender", "127.0.0.1", 5000, ConnectionType.UDP);

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
            senderConn.SendMessage("PING");

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

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
                senderConn.SendMessage(posData);

                // Check for incoming UDP packets on the hub server
                SplashKit.CheckNetworkActivity();

                // Process any received messages
                if (SplashKit.HasMessages())
                {
                    // Read the incoming message and extract its payload
                    Message msg = SplashKit.ReadMessage();
                    string payload = msg.Data;

                    // Parse the position data from the payload
                    if (payload.Length >= 4 && payload.Substring(0, 4) == "POS:")
                    {
                        string coords = payload.Substring(4);
                        int commaPos = coords.IndexOf(",");
                        receivedX = double.Parse(coords.Substring(0, commaPos));
                        receivedY = double.Parse(coords.Substring(commaPos + 1));
                        hasData = true;
                    }

                    SplashKit.CloseMessage(msg);
                }

                // Render the hub display
                SplashKit.ClearScreen(Color.Black);

                // Draw header panel
                SplashKit.FillRectangle(SplashKit.RGBAColor(30, 30, 50, 255), 0, 0, 800, 70);
                SplashKit.DrawText("UDP Telemetry Hub", Color.White, 20, 10);
                SplashKit.DrawText("Protocol: UDP | Port: 5000 | Status: LIVE", Color.Green, 20, 35);

                // Draw the sender indicator (what is being sent)
                SplashKit.FillCircle(SplashKit.RGBAColor(50, 120, 200, 150), spritePosX, spritePosY, 10);
                SplashKit.DrawText("SENDER", SplashKit.RGBAColor(50, 120, 200, 200), spritePosX - 20, spritePosY - 20);

                // Draw the received position indicator (what the hub received)
                if (hasData)
                {
                    SplashKit.FillCircle(Color.Yellow, receivedX, receivedY, 6);
                    SplashKit.DrawCircle(SplashKit.RGBAColor(255, 255, 0, 100), receivedX, receivedY, 15);
                    SplashKit.DrawText("HUB", Color.Yellow, receivedX - 10, receivedY + 18);

                    // Display telemetry readout
                    SplashKit.FillRectangle(SplashKit.RGBAColor(20, 20, 40, 200), 560, 80, 230, 100);
                    SplashKit.DrawRectangle(SplashKit.RGBAColor(0, 200, 100, 150), 560, 80, 230, 100);
                    SplashKit.DrawText("Telemetry Readout", Color.Green, 580, 90);
                    SplashKit.DrawText("X: " + ((int)receivedX).ToString(), Color.White, 580, 115);
                    SplashKit.DrawText("Y: " + ((int)receivedY).ToString(), Color.White, 580, 140);
                }

                // Draw a dashed connection line between sender and hub
                if (hasData)
                {
                    SplashKit.DrawLine(SplashKit.RGBAColor(0, 200, 100, 80), spritePosX, spritePosY, receivedX, receivedY);
                }

                SplashKit.RefreshScreen(60);
            }

            // Clean up networking resources
            SplashKit.CloseAllConnections();
            SplashKit.CloseAllServers();
            SplashKit.CloseAllWindows();
        }
    }
}
