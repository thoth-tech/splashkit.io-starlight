using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Color To String", 800, 500);

Color[] shades =
{
    RGBAColor(180, 30, 80, 255),
    RGBAColor(40, 140, 220, 255),
    RGBAColor(90, 180, 100, 255)
};

string[] names = { "Rose", "Blue", "Green" };

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(Color.White);
    DrawText("Color to string examples", Color.Black, 260, 40);

    for (int i = 0; i < 3; i++)
    {
        string value = ColorToString(shades[i]);

        FillRectangle(shades[i], 90 + i * 240, 150, 160, 100);
        DrawText(names[i], Color.Black, 140 + i * 240, 280);
        DrawText(value, Color.Black, 110 + i * 240, 320);
    }

    RefreshScreen(60);
}

CloseAllWindows();