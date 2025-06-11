using System;
using SplashKitSDK;

namespace PointOnLineApp
{
    public class Program
    {
        public static void Main()
        {
            // Store the window reference in a variable
            Window window = SplashKit.OpenWindow("Hover to Guess the Hidden Point", 800, 600);

            Line baseLine = SplashKit.LineFrom(SplashKit.PointAt(100, 300), SplashKit.PointAt(700, 300));

            Point2D hiddenPoint = SplashKit.PointAt(SplashKit.Rnd(100, 700), 300);

            while (!SplashKit.WindowCloseRequested(window))
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawLine(Color.Black, baseLine);

                Point2D mouse = SplashKit.MousePosition();

                if (SplashKit.PointPointDistance(mouse, hiddenPoint) <= 8.0)
                {
                    SplashKit.DrawCircle(Color.Blue, hiddenPoint.X, hiddenPoint.Y, 5);
                    SplashKit.DrawText("You found the hidden point!", Color.Green, 260, 450);
                }
                else if (SplashKit.PointOnLine(mouse, baseLine))
                {
                    SplashKit.DrawText("You're on the line, but not on the hidden point.", Color.Red, 180, 450);
                }
                else
                {
                    SplashKit.DrawText("Move your mouse over the line to find the hidden point!", Color.Black, 150, 450);
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseWindow(window);
        }
    }
}
