// I am demonstrating world vs screen coordinates by panning a camera.
// Arrow keys are panning the camera; SPACE toggles showing a screen-fixed HUD; ESC quits.

using SplashKitSDK;
using static SplashKitSDK.SplashKit;

const int windowWidth = 800;
const int windowHeight = 480;
OpenWindow("Option To World - camera (world vs screen)", windowWidth, windowHeight);

// I am representing the camera as an (x,y) offset in world space
double cameraX = 0.0;
double cameraY = 0.0;
const double camSpeed = 8.0;

bool showScreenHud = true;

while (!QuitRequested())
{
    ProcessEvents(); // I am handling input every frame

    if (KeyTyped(KeyCode.EscapeKey))
    {
        break;
    }
    if (KeyDown(KeyCode.LeftKey))
    {
        cameraX = cameraX - camSpeed;
    }
    if (KeyDown(KeyCode.RightKey))
    {
        cameraX = cameraX + camSpeed;
    }
    if (KeyDown(KeyCode.UpKey))
    {
        cameraY = cameraY - camSpeed;
    }
    if (KeyDown(KeyCode.DownKey))
    {
        cameraY = cameraY + camSpeed;
    }
    if (KeyTyped(KeyCode.SpaceKey))
    {
        showScreenHud = !showScreenHud;
    }
    if (KeyTyped(KeyCode.CKey))
    {
        cameraX = 0.0;
        cameraY = 0.0;
    }

    ClearScreen(ColorWhite());

    // I am drawing a simple world grid and world objects transformed by camera
    for (int gx = -1600; gx <= 1600; gx += 80)
    {
        DrawLine(ColorLightGray(), gx - (int)cameraX, -2000 - (int)cameraY,
                 gx - (int)cameraX, 2000 - (int)cameraY);
    }
    for (int gy = -1600; gy <= 1600; gy += 80)
    {
        DrawLine(ColorLightGray(), -2000 - (int)cameraX, gy - (int)cameraY,
                 2000 - (int)cameraX, gy - (int)cameraY);
    }

    // I am showing world-anchored shapes
    DrawCircle(ColorCornflowerBlue(), (int)(200 - cameraX), (int)(120 - cameraY), 28);
    DrawRectangle(ColorOrange(), (int)(400 - cameraX), (int)(200 - cameraY), 80, 52);

    // I am optionally drawing a screen-fixed HUD that is not affected by camera
    if (showScreenHud)
    {
        FillRectangle(ColorNavy(), 10, windowHeight - 60, 300, 48);
        DrawText("SCREEN HUD (fixed) - toggle with SPACE",
            ColorWhite(), "arial", 14, 16, windowHeight - 44);
    }

    // I am drawing camera coordinates and instructions inside the window
    DrawText($"Camera: x={(int)cameraX} y={(int)cameraY}  |  Arrows: pan  |  C: reset  |  SPACE: HUD  |  ESC: quit",
        ColorBlack(), "arial", 14, 10, 10);

    RefreshScreen(60);
}