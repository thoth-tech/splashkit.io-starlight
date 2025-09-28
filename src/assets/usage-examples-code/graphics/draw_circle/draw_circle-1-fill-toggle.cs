// I am showing a circle that can toggle fill, cycle colors, and pulse.
// SPACE toggles fill; C changes color; P pulses; ESC is quitting.

using System;                      // ← added per review
using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Window details use descriptive names
const int windowWidth = 720, windowHeight = 405;
OpenWindow("Circle — fill / color / pulse", windowWidth, windowHeight);

// Circle placement stays centered
int centerX = windowWidth / 2;
int centerY = windowHeight / 2;
double baseRadius = 80.0;

// Pleasant color palette
Color[] palette = new[]
{
    RGBColor(100, 149, 237), // cornflower
    RGBColor(255, 140, 0),   // dark orange
    RGBColor(46, 204, 113),  // emerald
    RGBColor(155, 89, 182),  // amethyst
    RGBColor(241, 196, 15)   // sunflower
};
int colorIndex = 0;

bool isFilled = false;
bool isPulsing = false;
double timeValue = 0.0;

while (!QuitRequested())
{
    ProcessEvents();

    // Controls use clear ifs with braces
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

    ClearScreen(Color.White);

    // Pulse is adding a gentle “breathing” radius
    double radius = baseRadius;
    if (isPulsing)
    {
        radius = baseRadius + 12.0 * Math.Sin(timeValue);
        timeValue = timeValue + 0.07;
    }

    Color circleColor = palette[colorIndex];

    if (isFilled)
    {
        FillCircle(circleColor, centerX, centerY, radius);
        DrawCircle(Color.Black, centerX, centerY, radius); // subtle outline
    }
    else
    {
        DrawCircle(circleColor, centerX, centerY, radius);
    }

    // On-window instructions (no terminal output)
    DrawText("SPACE: fill   C: color   P: pulse   ESC: quit",
             Color.Navy, 16, 16);

    DrawText(isFilled ? "Mode: filled" : "Mode: outline",
             Color.Black, 16, 40);

    RefreshScreen(60);
}