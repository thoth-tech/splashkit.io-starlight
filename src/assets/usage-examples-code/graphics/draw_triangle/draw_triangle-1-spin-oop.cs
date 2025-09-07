// I am drawing a spinning triangle; SPACE is toggling fill; ESC is quitting.
using System;
using SplashKitSDK;

namespace DrawTriangleSpinExample
{
    public static class Program
    {
        public static void Main()
        {
            const int W = 720, H = 405;
            SplashKit.OpenWindow("Spinning Triangle — SPACE toggles fill", W, H);

            bool filled = false;     // I am remembering whether I am filling or outlining.
            double angle = 0.0;      // I am advancing the rotation angle each frame.

            double cx = W * 0.5;     // I am placing the triangle at the window centre.
            double cy = H * 0.5;
            double r  = 110.0;       // I am setting the radius from centre to a vertex.

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // I am quitting when ESC is pressed.
                if (SplashKit.KeyTyped(KeyCode.EscapeKey))
                {
                    break;
                }

                // I am toggling fill mode on SPACE.
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    filled = !filled;
                }

                SplashKit.ClearScreen(Color.White);

                // I am computing the three triangle points at 120° steps.
                double a0 = angle;
                double a1 = angle + 2.0 * Math.PI / 3.0;
                double a2 = angle + 4.0 * Math.PI / 3.0;

                double x1 = cx + r * Math.Cos(a0), y1 = cy + r * Math.Sin(a0);
                double x2 = cx + r * Math.Cos(a1), y2 = cy + r * Math.Sin(a1);
                double x3 = cx + r * Math.Cos(a2), y3 = cy + r * Math.Sin(a2);

                if (filled)
                {
                    SplashKit.FillTriangle(Color.SkyBlue, x1, y1, x2, y2, x3, y3);
                }
                else
                {
                    SplashKit.DrawTriangle(Color.Navy, x1, y1, x2, y2, x3, y3);
                }

                SplashKit.DrawText("SPACE toggles fill  •  ESC quits", Color.Black, 16, 16);

                SplashKit.RefreshScreen(60);
                angle += 0.03;
            }
        }
    }
}