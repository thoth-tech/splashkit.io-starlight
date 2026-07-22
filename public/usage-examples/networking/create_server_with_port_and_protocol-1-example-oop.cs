using SplashKitSDK;

namespace CreateServerWithPortAndProtocol
{
    public class Program
    {
        public static void Main()
        {
            const int windowWidth = 800;
            const int windowHeight = 600;
            const ushort port = 5000;

            SplashKit.OpenWindow("UDP Sprite Signal", windowWidth, windowHeight);

            Bitmap senderBitmap = SplashKit.CreateBitmap("sender dot", 28, 28);
            SplashKit.ClearBitmap(senderBitmap, SplashKit.RGBAColor(0, 0, 0, 0));
            SplashKit.FillCircleOnBitmap(senderBitmap, SplashKit.RGBAColor(53, 184, 255, 255), 14, 14, 12);
            Sprite senderSprite = SplashKit.CreateSprite(senderBitmap);
            SplashKit.SpriteSetX(senderSprite, 80);
            SplashKit.SpriteSetY(senderSprite, 180);
            double velocityX = 2.4;
            double velocityY = 1.8;

            ServerSocket hubServer = SplashKit.CreateServer("hub", port, ConnectionType.UDP);
            Connection senderConnection = SplashKit.OpenConnection("sender", "127.0.0.1", port, ConnectionType.UDP);
            bool handshakeReceived = false;
            bool hasPosition = false;
            double receivedX = 0;
            double receivedY = 0;
            string lastPayload = "Waiting for position data";
            uint frameCount = 0;

            SplashKit.SendMessageTo("PING", senderConnection);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                double nextX = SplashKit.SpriteX(senderSprite) + velocityX;
                double nextY = SplashKit.SpriteY(senderSprite) + velocityY;
                if (nextX <= 40 || nextX >= 500)
                {
                    velocityX = -velocityX;
                    nextX = SplashKit.SpriteX(senderSprite) + velocityX;
                }
                if (nextY <= 130 || nextY >= 520)
                {
                    velocityY = -velocityY;
                    nextY = SplashKit.SpriteY(senderSprite) + velocityY;
                }
                SplashKit.SpriteSetX(senderSprite, nextX);
                SplashKit.SpriteSetY(senderSprite, nextY);

                double senderX = SplashKit.SpriteX(senderSprite);
                double senderY = SplashKit.SpriteY(senderSprite);
                string positionPacket = "POS:" + ((int)senderX).ToString() + "," + ((int)senderY).ToString();
                SplashKit.SendMessageTo(positionPacket, senderConnection);

                SplashKit.CheckNetworkActivity();
                while (SplashKit.HasMessages(hubServer))
                {
                    Message packet = SplashKit.ReadMessage(hubServer);
                    string payload = SplashKit.MessageData(packet);

                    if (payload == "PING")
                    {
                        handshakeReceived = true;
                    }

                    if (payload.StartsWith("POS:"))
                    {
                        string coordinates = payload.Substring(4);
                        int commaIndex = coordinates.IndexOf(",");
                        receivedX = SplashKit.ConvertToDouble(coordinates.Substring(0, commaIndex));
                        receivedY = SplashKit.ConvertToDouble(coordinates.Substring(commaIndex + 1));
                        lastPayload = payload;
                        hasPosition = true;
                    }
                    SplashKit.CloseMessage(packet);
                }

                SplashKit.ClearScreen(SplashKit.RGBAColor(10, 16, 30, 255));
                SplashKit.FillRectangle(SplashKit.RGBAColor(19, 29, 52, 255), 0, 0, windowWidth, 90);
                SplashKit.DrawText("UDP Sprite Signal", Color.White, 24, 18);
                SplashKit.DrawText("Sender  ->  127.0.0.1:5000  ->  Hub", SplashKit.RGBAColor(142, 202, 255, 255), 24, 50);
                SplashKit.FillRectangle(handshakeReceived ? SplashKit.RGBAColor(22, 101, 52, 255) : SplashKit.RGBAColor(120, 75, 18, 255), 595, 22, 180, 42);
                SplashKit.DrawText(handshakeReceived ? "HANDSHAKE: ONLINE" : "HANDSHAKE: WAITING", Color.White, 610, 36);

                SplashKit.DrawRectangle(SplashKit.RGBAColor(55, 78, 112, 255), 20, 110, 520, 460);
                SplashKit.DrawText("SENDER SPRITE", SplashKit.RGBAColor(142, 202, 255, 255), 36, 124);
                SplashKit.DrawLine(SplashKit.RGBAColor(38, 120, 82, 255), senderX + 14, senderY + 14, 670, 330);
                if (handshakeReceived)
                {
                    double pulse = (frameCount % 90) / 90.0;
                    double pulseX = senderX + 14 + (670 - senderX - 14) * pulse;
                    double pulseY = senderY + 14 + (330 - senderY - 14) * pulse;
                    SplashKit.FillCircle(SplashKit.RGBAColor(74, 222, 128, 255), pulseX, pulseY, 5);
                }
                SplashKit.DrawSprite(senderSprite);

                if (hasPosition)
                {
                    SplashKit.DrawCircle(SplashKit.RGBAColor(255, 220, 85, 255), receivedX + 14, receivedY + 14, 18);
                }

                SplashKit.FillRectangle(SplashKit.RGBAColor(17, 27, 46, 255), 560, 110, 220, 460);
                SplashKit.DrawRectangle(SplashKit.RGBAColor(55, 78, 112, 255), 560, 110, 220, 460);
                SplashKit.DrawText("HUB RECEIVER", SplashKit.RGBAColor(74, 222, 128, 255), 580, 135);
                SplashKit.DrawText("Protocol: UDP", Color.White, 580, 175);
                SplashKit.DrawText("Port: 5000", Color.White, 580, 200);
                SplashKit.DrawText("LATEST COORDINATES", SplashKit.RGBAColor(142, 202, 255, 255), 580, 250);
                SplashKit.DrawText("X: " + ((int)receivedX).ToString(), Color.White, 580, 285);
                SplashKit.DrawText("Y: " + ((int)receivedY).ToString(), Color.White, 580, 315);
                SplashKit.DrawText("LAST PAYLOAD", SplashKit.RGBAColor(142, 202, 255, 255), 580, 375);
                SplashKit.DrawText(lastPayload, SplashKit.RGBAColor(255, 220, 85, 255), 580, 410);
                SplashKit.DrawText(hasPosition ? "PACKETS: LIVE" : "PACKETS: WAITING", hasPosition ? SplashKit.RGBAColor(74, 222, 128, 255) : SplashKit.RGBAColor(255, 183, 77, 255), 580, 500);

                SplashKit.RefreshScreen(60);
                frameCount++;
            }

            SplashKit.FreeSprite(senderSprite);
            SplashKit.FreeBitmap(senderBitmap);
            SplashKit.CloseConnection(senderConnection);
            SplashKit.CloseServer(hubServer);
            SplashKit.CloseAllWindows();
        }
    }
}
