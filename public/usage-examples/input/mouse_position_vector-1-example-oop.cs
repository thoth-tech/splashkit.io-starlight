using SplashKitSDK;

namespace MousePositionVectorExample
{
    public static class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Mouse Position Arrow", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // The vector runs from the window origin (the top-left corner) to the mouse
                Vector2D mouseVector = SplashKit.MousePositionVector();

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawLine(Color.Blue, 0, 0, mouseVector.X, mouseVector.Y);

                // Two short lines swept back from the tip make the arrowhead
                double arrowAngle = SplashKit.VectorAngle(mouseVector);
                Vector2D headLeft = SplashKit.VectorFromAngle(arrowAngle + 150, 25);
                Vector2D headRight = SplashKit.VectorFromAngle(arrowAngle - 150, 25);
                SplashKit.DrawLine(Color.Blue, mouseVector.X, mouseVector.Y, mouseVector.X + headLeft.X, mouseVector.Y + headLeft.Y);
                SplashKit.DrawLine(Color.Blue, mouseVector.X, mouseVector.Y, mouseVector.X + headRight.X, mouseVector.Y + headRight.Y);

                SplashKit.DrawText("Move the mouse to aim the arrow from the corner.", Color.Black, 20, 510);
                SplashKit.DrawText("Vector X: " + (int)mouseVector.X, Color.Black, 20, 540);
                SplashKit.DrawText("Vector Y: " + (int)mouseVector.Y, Color.Black, 20, 570);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
