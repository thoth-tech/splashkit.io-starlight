using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Color BlendColors(Color c1, Color c2, double t)
{
    // linear interpolation for RGB channels
    int r = (int)((1 - t) * RedOf(c1) + t * RedOf(c2));
    int g = (int)((1 - t) * GreenOf(c1) + t * GreenOf(c2));
    int b = (int)((1 - t) * BlueOf(c1) + t * BlueOf(c2));
    return RGBColor(r, g, b);
}

OpenWindow("Split Text Example", 800, 400);

// I am defining the text to split
string text = "apple,banana,carrot";

// I am splitting the string into parts using SplashKit's split() function
string[] parts = Split(text, ',');

// I am drawing a gradient background manually
Color top = RGBColor(245, 251, 255);
Color bottom = RGBColor(200, 230, 255);

for (int y = 0; y < 400; y++)
{
    double t = (double)y / 400.0;
    Color blended = BlendColors(top, bottom, t);
    DrawLine(blended, 0, y, 800, y);
}

DrawText("Original string:", ColorDarkBlue(), "arial", 20, 60, 50);
DrawText(text, ColorBlack(), "arial", 20, 280, 50);

// I am printing each token from the split result
int yPos = 130;
foreach (string s in parts)
{
    DrawText("Token: " + s, ColorBlack(), "arial", 18, 60, yPos);
    yPos += 40;
}

DrawText("Press ESC to exit", ColorGray(), "arial", 14, 620, 360);
RefreshScreen();

// wait for quit event
while (!QuitRequested())
{
    ProcessEvents();
    if (KeyTyped(KeyCode.EscapeKey)) break;
}

CloseAllWindows();