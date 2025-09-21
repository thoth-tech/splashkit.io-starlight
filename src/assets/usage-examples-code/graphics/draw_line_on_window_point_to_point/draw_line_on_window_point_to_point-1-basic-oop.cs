// I am drawing lines on the window by clicking a start point and an end point.
// Left-click once for start; left-click again for end; C clears; ESC is quitting.

using SplashKitSDK;
using System.Collections.Generic;

namespace GraphicsExamples
{
    public class DrawLinePointToPointDemo
    {
        private const int WindowWidth = 720;
        private const int WindowHeight = 405;

        private readonly List<(double x1, double y1, double x2, double y2)> _segments
            = new List<(double, double, double, double)>();

        private bool _hasStart = false;
        private double _sx = 0.0, _sy = 0.0;

        public void Run()
        {
            SplashKit.OpenWindow("Draw Line — point to point on window", WindowWidth, WindowHeight);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyTyped(KeyCode.EscapeKey))
                {
                    break;
                }
                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    _segments.Clear();
                    _hasStart = false;
                }

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    double mx = SplashKit.MouseX();
                    double my = SplashKit.MouseY();

                    if (!_hasStart)
                    {
                        _hasStart = true;
                        _sx = mx;
                        _sy = my;
                    }
                    else
                    {
                        _segments.Add((_sx, _sy, mx, my));
                        _hasStart = false;
                    }
                }

                SplashKit.ClearScreen(SplashKit.ColorWhite());

                foreach (var s in _segments)
                {
                    SplashKit.DrawLine(SplashKit.ColorNavy(), s.x1, s.y1, s.x2, s.y2);
                }

                if (_hasStart)
                {
                    double mx = SplashKit.MouseX();
                    double my = SplashKit.MouseY();
                    SplashKit.DrawLine(SplashKit.ColorOrangeRed(), _sx, _sy, mx, my);
                    SplashKit.FillCircle(SplashKit.ColorOrangeRed(), _sx, _sy, 3);
                }

                SplashKit.DrawText("Click: start/end   C: clear   ESC: quit",
                    SplashKit.ColorBlack(), 16, 16);

                SplashKit.RefreshScreen(60);
            }
        }

        public static void Main()
        {
            new DrawLinePointToPointDemo().Run();
        }
    }
}