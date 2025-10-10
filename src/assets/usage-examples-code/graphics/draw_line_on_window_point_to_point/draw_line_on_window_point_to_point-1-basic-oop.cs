// I am drawing lines on the window by clicking a start point and an end point (OOP form).
// I am left-clicking once for start; I am left-clicking again for end; I am pressing C to clear; I am pressing ESC to quit.

using SplashKitSDK;
using System.Collections.Generic;

namespace GraphicsExamples
{
    public class DrawLinePointToPointDemo
    {
        // I am keeping finished segments so I can redraw them every frame.
        private readonly List<(double x1, double y1, double x2, double y2)> _segments
            = new List<(double, double, double, double)>();

        // I am remembering the current start point state and value.
        private bool _hasStart = false;
        private double _sx = 0.0, _sy = 0.0;

        public void Run()
        {
            // I am opening the window with an ASCII title and explicit size.
            SplashKit.OpenWindow("Draw Line - point to point on window", 720, 405);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents(); // I am polling inputs each frame.

                // I am handling quit and clear.
                if (SplashKit.KeyTyped(KeyCode.EscapeKey))
                {
                    break; // I am exiting on ESC.
                }
                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    _segments.Clear(); // I am clearing finished segments.
                    _hasStart = false; // I am cancelling the in-progress segment.
                }

                // I am turning two clicks into one segment.
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    double mx = SplashKit.MouseX();
                    double my = SplashKit.MouseY();

                    if (!_hasStart)
                    {
                        // I am recording the start point on first click.
                        _hasStart = true;
                        _sx = mx;
                        _sy = my;
                    }
                    else
                    {
                        // I am saving the segment on second click.
                        _segments.Add((_sx, _sy, mx, my));
                        _hasStart = false;
                    }
                }

                // I am rendering the frame.
                SplashKit.ClearScreen(SplashKit.ColorWhite());

                // I am drawing all finished segments in navy.
                foreach (var s in _segments)
                {
                    SplashKit.DrawLine(SplashKit.ColorNavy(), s.x1, s.y1, s.x2, s.y2);
                }

                // I am previewing the current segment in orange from start to mouse.
                if (_hasStart)
                {
                    double mx = SplashKit.MouseX();
                    double my = SplashKit.MouseY();
                    SplashKit.DrawLine(SplashKit.ColorOrangeRed(), _sx, _sy, mx, my);
                    SplashKit.FillCircle(SplashKit.ColorOrangeRed(), _sx, _sy, 3); // I am marking the start.
                }

                // I am showing a small HUD with controls.
                SplashKit.DrawText("Click: start/end   C: clear   ESC: quit", SplashKit.ColorBlack(), 16, 16);

                SplashKit.RefreshScreen(60); // I am pacing to ~60 FPS.
            }
        }

        public static void Main()
        {
            new DrawLinePointToPointDemo().Run();
        }
    }
}