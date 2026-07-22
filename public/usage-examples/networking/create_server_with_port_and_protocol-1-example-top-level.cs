using SplashKitSDK;
using static SplashKitSDK.SplashKit;

const int windowWidth = 800;
const int windowHeight = 600;
const ushort port = 5000;

OpenWindow("UDP Sprite Signal", windowWidth, windowHeight);

Bitmap senderBitmap = CreateBitmap("sender dot", 28, 28);
ClearBitmap(senderBitmap, RGBAColor(0, 0, 0, 0));
FillCircleOnBitmap(senderBitmap, RGBAColor(53, 184, 255, 255), 14, 14, 12);
Sprite senderSprite = CreateSprite(senderBitmap);
SpriteSetX(senderSprite, 80);
SpriteSetY(senderSprite, 180);
double velocityX = 2.4;
double velocityY = 1.8;

ServerSocket hubServer = CreateServer("hub", port, ConnectionType.UDP);
Connection senderConnection = OpenConnection("sender", "127.0.0.1", port, ConnectionType.UDP);
bool handshakeReceived = false;
bool hasPosition = false;
double receivedX = 0;
double receivedY = 0;
string lastPayload = "Waiting for position data";
uint frameCount = 0;

SendMessageTo("PING", senderConnection);

while (!QuitRequested())
{
    ProcessEvents();

    double nextX = SpriteX(senderSprite) + velocityX;
    double nextY = SpriteY(senderSprite) + velocityY;
    if (nextX <= 40 || nextX >= 500)
    {
        velocityX = -velocityX;
        nextX = SpriteX(senderSprite) + velocityX;
    }
    if (nextY <= 130 || nextY >= 520)
    {
        velocityY = -velocityY;
        nextY = SpriteY(senderSprite) + velocityY;
    }
    SpriteSetX(senderSprite, nextX);
    SpriteSetY(senderSprite, nextY);

    double senderX = SpriteX(senderSprite);
    double senderY = SpriteY(senderSprite);
    string positionPacket = "POS:" + ((int)senderX).ToString() + "," + ((int)senderY).ToString();
    SendMessageTo(positionPacket, senderConnection);

    CheckNetworkActivity();
    while (HasMessages(hubServer))
    {
        Message packet = ReadMessage(hubServer);
        string payload = MessageData(packet);

        if (payload == "PING")
        {
            handshakeReceived = true;
        }

        if (payload.StartsWith("POS:"))
        {
            string coordinates = payload.Substring(4);
            int commaIndex = coordinates.IndexOf(",");
            receivedX = ConvertToDouble(coordinates.Substring(0, commaIndex));
            receivedY = ConvertToDouble(coordinates.Substring(commaIndex + 1));
            lastPayload = payload;
            hasPosition = true;
        }
        CloseMessage(packet);
    }

    ClearScreen(RGBAColor(10, 16, 30, 255));
    FillRectangle(RGBAColor(19, 29, 52, 255), 0, 0, windowWidth, 90);
    DrawText("UDP Sprite Signal", ColorWhite(), 24, 18);
    DrawText("Sender  ->  127.0.0.1:5000  ->  Hub", RGBAColor(142, 202, 255, 255), 24, 50);
    FillRectangle(handshakeReceived ? RGBAColor(22, 101, 52, 255) : RGBAColor(120, 75, 18, 255), 595, 22, 180, 42);
    DrawText(handshakeReceived ? "HANDSHAKE: ONLINE" : "HANDSHAKE: WAITING", ColorWhite(), 610, 36);

    DrawRectangle(RGBAColor(55, 78, 112, 255), 20, 110, 520, 460);
    DrawText("SENDER SPRITE", RGBAColor(142, 202, 255, 255), 36, 124);
    DrawLine(RGBAColor(38, 120, 82, 255), senderX + 14, senderY + 14, 670, 330);
    if (handshakeReceived)
    {
        double pulse = (frameCount % 90) / 90.0;
        double pulseX = senderX + 14 + (670 - senderX - 14) * pulse;
        double pulseY = senderY + 14 + (330 - senderY - 14) * pulse;
        FillCircle(RGBAColor(74, 222, 128, 255), pulseX, pulseY, 5);
    }
    DrawSprite(senderSprite);

    if (hasPosition)
    {
        DrawCircle(RGBAColor(255, 220, 85, 255), receivedX + 14, receivedY + 14, 18);
    }

    FillRectangle(RGBAColor(17, 27, 46, 255), 560, 110, 220, 460);
    DrawRectangle(RGBAColor(55, 78, 112, 255), 560, 110, 220, 460);
    DrawText("HUB RECEIVER", RGBAColor(74, 222, 128, 255), 580, 135);
    DrawText("Protocol: UDP", ColorWhite(), 580, 175);
    DrawText("Port: 5000", ColorWhite(), 580, 200);
    DrawText("LATEST COORDINATES", RGBAColor(142, 202, 255, 255), 580, 250);
    DrawText("X: " + ((int)receivedX).ToString(), ColorWhite(), 580, 285);
    DrawText("Y: " + ((int)receivedY).ToString(), ColorWhite(), 580, 315);
    DrawText("LAST PAYLOAD", RGBAColor(142, 202, 255, 255), 580, 375);
    DrawText(lastPayload, RGBAColor(255, 220, 85, 255), 580, 410);
    DrawText(hasPosition ? "PACKETS: LIVE" : "PACKETS: WAITING", hasPosition ? RGBAColor(74, 222, 128, 255) : RGBAColor(255, 183, 77, 255), 580, 500);

    RefreshScreen(60);
    frameCount++;
}

FreeSprite(senderSprite);
FreeBitmap(senderBitmap);
CloseConnection(senderConnection);
CloseServer(hubServer);
CloseAllWindows();
