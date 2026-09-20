using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("File Permission Bits", 640, 400);

// Each octal digit of a Unix permission code is three bits: read, write and execute
string permissionCode = "754";
string bits = OctToBin(permissionCode);

string[] whoNames = { "Owner", "Group", "Others" };
string[] permissionNames = { "Read", "Write", "Execute" };

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(ColorWhite());

    DrawText("Permission code: " + permissionCode, ColorBlack(), 40, 30);
    DrawText("As bits: " + bits, ColorBlack(), 40, 60);

    for (int column = 0; column < 3; column++)
    {
        DrawText(permissionNames[column], ColorBlack(), 230 + column * 130, 115);
    }

    for (int row = 0; row < 3; row++)
    {
        DrawText(whoNames[row], ColorBlack(), 60, 165 + row * 70);
    }

    // 754 has no leading zero digit, so all nine bits come back
    for (int position = 0; position < 9; position++)
    {
        double boxX = 200 + (position % 3) * 130;
        double boxY = 140 + (position / 3) * 70;

        if (bits[position] == '1')
        {
            FillRectangle(ColorGreen(), boxX, boxY, 100, 50);
        }
        else
        {
            FillRectangle(ColorLightGray(), boxX, boxY, 100, 50);
        }

        DrawRectangle(ColorBlack(), boxX, boxY, 100, 50);
    }

    RefreshScreen(60);
}

CloseAllWindows();
