using SplashKitSDK;

namespace MoveWindowToExample
{
    public class Program
    {
        public static void Main()
        {
            Window win = SplashKit.OpenWindow("Window Mover", 300, 300);

            while (!SplashKit.QuitRequested())
            {
                // get user inputs
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                // Get position of the window
                int currentX = SplashKit.WindowX(win);
                int currentY = SplashKit.WindowY(win);

                // Move window buttons
                if (SplashKit.Button("NW", SplashKit.RectangleFrom(50, 50, 40, 40)))
                {
                    SplashKit.MoveWindowTo(win, currentX - 10, currentY - 10);
                }

                if (SplashKit.Button("N", SplashKit.RectangleFrom(130, 50, 40, 40)))
                {
                    SplashKit.MoveWindowTo(win, currentX, currentY - 10);
                }

                if (SplashKit.Button("NE", SplashKit.RectangleFrom(210, 50, 40, 40)))
                {
                    SplashKit.MoveWindowTo(win, currentX + 10, currentY - 10);
                }

                if (SplashKit.Button("W", SplashKit.RectangleFrom(50, 130, 40, 40)))
                {
                    SplashKit.MoveWindowTo(win, currentX - 10, currentY);
                }

                if (SplashKit.Button("E", SplashKit.RectangleFrom(210, 130, 40, 40)))
                {
                    SplashKit.MoveWindowTo(win, currentX + 10, currentY);
                }

                if (SplashKit.Button("SW", SplashKit.RectangleFrom(50, 210, 40, 40)))
                {
                    SplashKit.MoveWindowTo(win, currentX - 10, currentY + 10);
                }

                if (SplashKit.Button("S", SplashKit.RectangleFrom(130, 210, 40, 40)))
                {
                    SplashKit.MoveWindowTo(win, currentX, currentY + 10);
                }

                if (SplashKit.Button("SE", SplashKit.RectangleFrom(210, 210, 40, 40)))
                {
                    SplashKit.MoveWindowTo(win, currentX + 10, currentY + 10);
                }

                SplashKit.DrawInterface();
                SplashKit.RefreshScreen();
            }

            // close all open windows
            SplashKit.CloseAllWindows();
        }
    }
}