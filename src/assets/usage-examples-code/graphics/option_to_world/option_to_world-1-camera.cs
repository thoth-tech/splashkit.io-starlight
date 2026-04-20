// Usage Example for: https://splashkit.io/api/graphics/#option-to-world
// Goal: I am demonstrating world vs screen coordinates by panning a camera.
// Why: I am showing how world-anchored things move under the camera while a screen HUD does not.
// Controls: I am using Arrow keys to pan camera | I am pressing C to reset | I am pressing SPACE to toggle HUD | I am pressing ESC to quit.

using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Option To World - camera", 800, 480);

// I am storing the camera offset in world space.
double camX = 0.0;
double camY = 0.0;
const double CamSpeed = 8.0;

bool showHud = true;  // I am showing a screen-fixed HUD.

while (!QuitRequested())
{
    ProcessEvents();

    // I am quitting when ESC is pressed.
    if (KeyTyped(KeyCode.EscapeKey))
    {
        break;
    }
    // I am panning the camera with Arrow keys.
    if (KeyDown(KeyCode.LeftKey))
    {
        camX = camX - CamSpeed;
    }
    if (KeyDown(KeyCode.RightKey))
    {
        camX = camX + CamSpeed;
    }
    if (KeyDown(KeyCode.UpKey))
    {
        camY = camY - CamSpeed;
    }
    if (KeyDown(KeyCode.DownKey))
    {
        camY = camY + CamSpeed;
    }
    // I am toggling the HUD with SPACE.
    if (KeyTyped(KeyCode.SpaceKey))
    {
        showHud = !showHud;
    }
    // I am resetting the camera with C.
    if (KeyTyped(KeyCode.CKey))
    {
        camX = 0.0;
        camY = 0.0;
    }

    ClearScreen(ColorWhite());

    // I am drawing a light grid in world space.
    var LIGHT = ColorLightGray();
    for (int gx = -1600; gx <= 1600; gx += 80)
    {
        DrawLine(LIGHT, gx - (int)camX, -2000 - (int)camY, gx - (int)camX, 2000 - (int)camY);
    }
    for (int gy = -1600; gy <= 1600; gy += 80)
    {
        DrawLine(LIGHT, -2000 - (int)camX, gy - (int)camY, 2000 - (int)camX, gy - (int)camY);
    }

    // I am drawing two world-anchored shapes.
    DrawCircle(ColorCornflowerBlue(), (int)(200 - camX), (int)(120 - camY), 28);
    DrawRectangle(ColorOrange(), (int)(400 - camX), (int)(200 - camY), 80, 52);

    // I am drawing a screen-fixed HUD (wider so text is not clipped).
    if (showHud)
    {
        FillRectangle(ColorNavy(), 10, 480 - 60, 420, 48);
        DrawText("SCREEN HUD (fixed) - toggle with SPACE", ColorWhite(), "arial", 14, 16, 480 - 44);
    }

    // I am drawing the on-screen instructions.
    DrawText(
        $"Camera: x={(int)camX} y={(int)camY}  |  Arrows: pan  |  C: reset  |  SPACE: HUD  |  ESC: quit",
        ColorBlack(), "arial", 14, 10, 10);

    RefreshScreen(60);
}