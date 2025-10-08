// Usage Example for: https://splashkit.io/api/graphics/#option-to-world
// Goal: I am demonstrating world vs screen coordinates by panning a camera.
// Why: I am showing how world-anchored things move under the camera while a screen HUD does not.
// Controls: I am using Arrow keys to pan camera | I am pressing C to reset | I am pressing SPACE to toggle HUD | I am pressing ESC to quit.

using SplashKitSDK;

namespace GraphicsExamples
{
    public sealed class OptionToWorldCamera
    {
        private double _camX = 0.0;
        private double _camY = 0.0;
        private const double CamSpeed = 8.0;
        private bool _showHud = true;

        public OptionToWorldCamera()
        {
            SplashKit.OpenWindow("Option To World - camera", 800, 480);
        }

        public void Run()
        {
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // I am quitting when ESC is pressed.
                if (SplashKit.KeyTyped(KeyCode.EscapeKey))
                {
                    break;
                }
                // I am panning the camera with Arrow keys.
                if (SplashKit.KeyDown(KeyCode.LeftKey))
                {
                    _camX = _camX - CamSpeed;
                }
                if (SplashKit.KeyDown(KeyCode.RightKey))
                {
                    _camX = _camX + CamSpeed;
                }
                if (SplashKit.KeyDown(KeyCode.UpKey))
                {
                    _camY = _camY - CamSpeed;
                }
                if (SplashKit.KeyDown(KeyCode.DownKey))
                {
                    _camY = _camY + CamSpeed;
                }
                // I am toggling the HUD with SPACE.
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    _showHud = !_showHud;
                }
                // I am resetting the camera with C.
                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    _camX = 0.0;
                    _camY = 0.0;
                }

                SplashKit.ClearScreen(SplashKit.ColorWhite());

                // I am drawing a light grid in world space.
                var LIGHT = SplashKit.ColorLightGray();
                for (int gx = -1600; gx <= 1600; gx += 80)
                {
                    SplashKit.DrawLine(LIGHT, gx - (int)_camX, -2000 - (int)_camY, gx - (int)_camX, 2000 - (int)_camY);
                }
                for (int gy = -1600; gy <= 1600; gy += 80)
                {
                    SplashKit.DrawLine(LIGHT, -2000 - (int)_camX, gy - (int)_camY, 2000 - (int)_camX, gy - (int)_camY);
                }

                // I am drawing two world-anchored shapes.
                SplashKit.DrawCircle(SplashKit.ColorCornflowerBlue(), (int)(200 - _camX), (int)(120 - _camY), 28);
                SplashKit.DrawRectangle(SplashKit.ColorOrange(), (int)(400 - _camX), (int)(200 - _camY), 80, 52);

                // I am drawing a screen-fixed HUD (wider so text is not clipped).
                if (_showHud)
                {
                    SplashKit.FillRectangle(SplashKit.ColorNavy(), 10, 480 - 60, 420, 48);
                    SplashKit.DrawText("SCREEN HUD (fixed) - toggle with SPACE",
                        SplashKit.ColorWhite(), "arial", 14, 16, 480 - 44);
                }

                // I am drawing the on-screen instructions.
                SplashKit.DrawText(
                    $"Camera: x={(int)_camX} y={(int)_camY}  |  Arrows: pan  |  C: reset  |  SPACE: HUD  |  ESC: quit",
                    SplashKit.ColorBlack(), "arial", 14, 10, 10);

                SplashKit.RefreshScreen(60);
            }
        }

        public static void Main()
        {
            new OptionToWorldCamera().Run();
        }
    }
}