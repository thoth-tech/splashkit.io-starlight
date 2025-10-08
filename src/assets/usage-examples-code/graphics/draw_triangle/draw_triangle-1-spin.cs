// Usage Example for: https://splashkit.io/api/graphics/#draw-triangle-3
// Goal: I am drawing a spinning equilateral triangle and I am toggling between outline and fill with SPACE.
// Why: I am showing how draw_triangle and fill_triangle render the same geometry differently.
// Controls: I am pressing SPACE to toggle fill  •  I am pressing ESC to quit.

using SplashKitSDK;
using static SplashKitSDK.SplashKit;

const int WIDTH = 720, HEIGHT = 405;
OpenWindow("Spinning Triangle", WIDTH, HEIGHT);

bool isFilled = false;   // I am remembering whether I am filling or outlining.
double angle  = 0.0;     // I am advancing the rotation angle each frame.

double centerX = WIDTH * 0.5;   // I am placing the triangle at the window centre.
double centerY = HEIGHT * 0.5;
double radius  = 110.0;         // I am setting the radius from centre to a vertex.

while (!QuitRequested())
{
    ProcessEvents();

    // I am quitting when ESC is pressed.
    if (KeyTyped(KeyCode.EscapeKey)) break;

    // I am toggling between outline and fill when SPACE is pressed.
    if (KeyTyped(KeyCode.SpaceKey)) isFilled = !isFilled;

    ClearScreen(Color.White);

    // I am computing the three triangle points at 120° steps.
    double a0 = angle;
    double a1 = angle + 2.0 * System.Math.PI / 3.0;
    double a2 = angle + 4.0 * System.Math.PI / 3.0;

    double x1 = centerX + radius * System.Math.Cos(a0), y1 = centerY + radius * System.Math.Sin(a0);
    double x2 = centerX + radius * System.Math.Cos(a1), y2 = centerY + radius * System.Math.Sin(a1);
    double x3 = centerX + radius * System.Math.Cos(a2), y3 = centerY + radius * System.Math.Sin(a2);

    // I am drawing the triangle as filled or outlined.
    if (isFilled) FillTriangle(Color.SkyBlue, x1, y1, x2, y2, x3, y3);
    else          DrawTriangle(Color.Navy,    x1, y1, x2, y2, x3, y3);

    // I am drawing the on-screen help.
    DrawText("SPACE toggles fill  ESC quits", Color.Black, 16, 16);

    RefreshScreen();
    Delay(16);     // I am pacing to ~60 FPS.
    angle += 0.02; // I am rotating at a comfortable speed.
}