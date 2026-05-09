using SplashKitSDK;

namespace MoveMouse
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Move Mouse To Point", 800, 600);

            // Define five target points using PointAt to create Point2D values
            // These represent the four corners and the center of the window
            Point2D topLeft     = SplashKit.PointAt(100, 100);
            Point2D topRight    = SplashKit.PointAt(700, 100);
            Point2D bottomLeft  = SplashKit.PointAt(100, 500);
            Point2D bottomRight = SplashKit.PointAt(700, 500);
            Point2D center      = SplashKit.PointAt(400, 300);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // MoveMouse repositions the cursor to the given Point2D location
                // Each key press snaps the mouse to the corresponding target point
                if (SplashKit.KeyTyped(KeyCode.QKey))
                    SplashKit.MoveMouse(topLeft);
                if (SplashKit.KeyTyped(KeyCode.EKey))
                    SplashKit.MoveMouse(topRight);
                if (SplashKit.KeyTyped(KeyCode.AKey))
                    SplashKit.MoveMouse(bottomLeft);
                if (SplashKit.KeyTyped(KeyCode.DKey))
                    SplashKit.MoveMouse(bottomRight);
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                    SplashKit.MoveMouse(center);

                SplashKit.ClearScreen(Color.White);

                // Draw a coloured circle at each target point so the user can see where the mouse will snap
                SplashKit.FillCircle(Color.Red,    topLeft.X,     topLeft.Y,     12);
                SplashKit.FillCircle(Color.Blue,   topRight.X,    topRight.Y,    12);
                SplashKit.FillCircle(Color.Green,  bottomLeft.X,  bottomLeft.Y,  12);
                SplashKit.FillCircle(Color.Orange, bottomRight.X, bottomRight.Y, 12);
                SplashKit.FillCircle(Color.Purple, center.X,      center.Y,      12);

                // Label each target with its corresponding key
                SplashKit.DrawText("[Q]",     Color.Red,    "Arial", 16, topLeft.X - 12,     topLeft.Y + 18);
                SplashKit.DrawText("[E]",     Color.Blue,   "Arial", 16, topRight.X - 12,    topRight.Y + 18);
                SplashKit.DrawText("[A]",     Color.Green,  "Arial", 16, bottomLeft.X - 12,  bottomLeft.Y + 18);
                SplashKit.DrawText("[D]",     Color.Orange, "Arial", 16, bottomRight.X - 12, bottomRight.Y + 18);
                SplashKit.DrawText("[SPACE]", Color.Purple, "Arial", 16, center.X - 28,      center.Y + 18);

                SplashKit.DrawText("Press a key to move the mouse to that point", Color.Black, "Arial", 18, 185, 260);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
