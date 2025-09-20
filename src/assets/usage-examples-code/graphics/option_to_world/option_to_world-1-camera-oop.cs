// I am demonstrating world vs screen coordinates by panning a camera in OOP form.
// Arrow keys are panning the camera; SPACE toggles showing a screen-fixed HUD; ESC quits.

using SplashKitSDK;

namespace GraphicsExamples
{
    public class OptionToWorldCamera
    {
        private double _cameraX;
        private double _cameraY;
        private const double CamSpeed = 8.0;
        private bool _showScreenHud;

        public OptionToWorldCamera()
        {
            SplashKit.OpenWindow("Option To World - camera (world vs screen)", 800, 480);
            _cameraX = 0.0;
            _cameraY = 0.0;
            _showScreenHud = true;
        }

        public void Run()
        {
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyTyped(KeyCode.EscapeKey))
                {
                    break;
                }
                if (SplashKit.KeyDown(KeyCode.LeftKey))
                {
                    _cameraX = _cameraX - CamSpeed;
                }
                if (SplashKit.KeyDown(KeyCode.RightKey))
                {
                    _cameraX = _cameraX + CamSpeed;
                }
                if (SplashKit.KeyDown(KeyCode.UpKey))
                {
                    _cameraY = _cameraY - CamSpeed;
                }
                if (SplashKit.KeyDown(KeyCode.DownKey))
                {
                    _cameraY = _cameraY + CamSpeed;
                }
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    _showScreenHud = !_showScreenHud;
                }
                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    _cameraX = 0.0;
                    _cameraY = 0.0;
                }

                SplashKit.ClearScreen(SplashKit.ColorWhite());

                for (int gx = -1600; gx <= 1600; gx += 80)
                {
                    SplashKit.DrawLine(SplashKit.ColorLightGray(),
                        gx - (int)_cameraX, -2000 - (int)_cameraY,
                        gx - (int)_cameraX, 2000 - (int)_cameraY);
                }
                for (int gy = -1600; gy <= 1600; gy += 80)
                {
                    SplashKit.DrawLine(SplashKit.ColorLightGray(),
                        -2000 - (int)_cameraX, gy - (int)_cameraY,
                        2000 - (int)_cameraX, gy - (int)_cameraY);
                }

                SplashKit.DrawCircle(SplashKit.ColorCornflowerBlue(), (int)(200 - _cameraX), (int)(120 - _cameraY), 28);
                SplashKit.DrawRectangle(SplashKit.ColorOrange(), (int)(400 - _cameraX), (int)(200 - _cameraY), 80, 52);

                if (_showScreenHud)
                {
                    SplashKit.FillRectangle(SplashKit.ColorNavy(), 10, 480 - 60, 300, 48);
                    SplashKit.DrawText("SCREEN HUD (fixed) - toggle with SPACE",
                        SplashKit.ColorWhite(), "arial", 14, 16, 480 - 44);
                }

                SplashKit.DrawText($"Camera: x={(int)_cameraX} y={(int)_cameraY}  |  Arrows: pan  |  C: reset  |  SPACE: HUD  |  ESC: quit",
                    SplashKit.ColorBlack(), "arial", 14, 10, 10);

                SplashKit.RefreshScreen(60);
            }
        }

        public static void Main()
        {
            var demo = new OptionToWorldCamera();
            demo.Run();
        }
    }
}