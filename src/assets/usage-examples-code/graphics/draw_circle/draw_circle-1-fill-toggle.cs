// I am showing a circle that can toggle fill, cycle colors, and pulse.
// I am pressing SPACE to toggle fill; I am pressing C to change color;
// I am pressing P to pulse; I am pressing ESC to quit.

using System;
using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Circle - fill / color / pulse", 720, 405);

// I am keeping the circle centered.
int cx = 720 / 2;
int cy = 405 / 2;
double baseRadius = 80.0;

// I am using a small palette for clarity.
Color[] palette =
{
    RGBColor(100, 149, 237), // cornflower
    RGBColor(255, 140, 0),   // dark orange
    RGBColor(46, 204, 113),  // emerald
    RGBColor(155, 89, 182),  // amethyst
    RGBColor(241, 196, 15)   // sunflower
};
int colorIndex = 0;

// I am tracking state and a time value for pulsing.
bool isFilled = false;
bool isPulsing = false;
double t = 0.0;

while (!QuitRequested())
{
    ProcessEvents();

    if (KeyTyped(KeyCode.EscapeKey))
    {
        break;
    }
    if (KeyTyped(KeyCode.SpaceKey))
    {
        isFilled = !isFilled;
    }
    if (KeyTyped(KeyCode.CKey))
    {
        colorIndex = (colorIndex + 1) % palette.Length;
    }
    if (KeyTyped(KeyCode.PKey))
    {
        isPulsing = !isPulsing;
    }

    ClearScreen(ColorWhite());

    double radius = baseRadius;
    if (isPulsing)
    {
        radius = baseRadius + 12.0 * Math.Sin(t);
        t = t + 0.07;
    }

    Color ink = palette[colorIndex];

    if (isFilled)
    {
        FillCircle(ink, cx, cy, radius);
        DrawCircle(ColorBlack(), cx, cy, radius); // I am adding a subtle outline.
    }
    else
    {
        DrawCircle(ink, cx, cy, radius);
    }

    DrawText("SPACE: fill   C: color   P: pulse   ESC: quit",
             ColorNavy(), 16, 16);
    DrawText(isFilled ? "Mode: filled" : "Mode: outline",
             ColorBlack(), 16, 40);

    RefreshScreen(60);
}