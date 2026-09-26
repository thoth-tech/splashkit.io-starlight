// I am showing a circle that can toggle fill, cycle colors, and pulse (OOP form).
// I am pressing SPACE to toggle fill; I am pressing C to change color;
// I am pressing P to pulse; I am pressing ESC to quit.

using System;
using SplashKitSDK;

namespace GraphicsExamples
{
    public class DrawCircleFillToggle
    {
        private const int W = 720, H = 405;
        private readonly int _cx = W / 2;
        private readonly int _cy = H / 2;
        private const double BaseRadius = 80.0;

        private readonly SplashKitSDK.Color[] _palette =
        {
            SplashKit.RGBColor(100, 149, 237),
            SplashKit.RGBColor(255, 140, 0),
            SplashKit.RGBColor(46, 204, 113),
            SplashKit.RGBColor(155, 89, 182),
            SplashKit.RGBColor(241, 196, 15),
        };
        private int _colorIndex = 0;

        private bool _isFilled = false;
        private bool _isPulsing = false;
        private double _t = 0.0;

        public void Run()
        {
            SplashKit.OpenWindow("Circle - fill / color / pulse", W, H);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyTyped(KeyCode.EscapeKey))
                {
                    break;
                }
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    _isFilled = !_isFilled;
                }
                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    _colorIndex = (_colorIndex + 1) % _palette.Length;
                }
                if (SplashKit.KeyTyped(KeyCode.PKey))
                {
                    _isPulsing = !_isPulsing;
                }

                SplashKit.ClearScreen(SplashKit.ColorWhite());

                double radius = BaseRadius;
                if (_isPulsing)
                {
                    radius = BaseRadius + 12.0 * Math.Sin(_t);
                    _t = _t + 0.07;
                }

                var ink = _palette[_colorIndex];

                if (_isFilled)
                {
                    SplashKit.FillCircle(ink, _cx, _cy, radius);
                    SplashKit.DrawCircle(SplashKit.ColorBlack(), _cx, _cy, radius);
                }
                else
                {
                    SplashKit.DrawCircle(ink, _cx, _cy, radius);
                }

                SplashKit.DrawText("SPACE: fill   C: color   P: pulse   ESC: quit",
                                   SplashKit.ColorNavy(), 16, 16);
                SplashKit.DrawText(_isFilled ? "Mode: filled" : "Mode: outline",
                                   SplashKit.ColorBlack(), 16, 40);

                SplashKit.RefreshScreen(60);
            }
        }

        public static void Main()
        {
            new DrawCircleFillToggle().Run();
        }
    }
}