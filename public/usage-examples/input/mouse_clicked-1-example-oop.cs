using SplashKitSDK;

namespace MouseClickedExample
{
    public static class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Circle Click Display", 800, 600);

            string clickedCircle = "None";
            int clickCount = 0;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Point2D mousePoint = SplashKit.MousePosition();

                    if (SplashKit.PointInCircle(mousePoint, SplashKit.CircleAt(180, 250, 60)))
                    {
                        clickedCircle = "Red";
                        clickCount++;
                    }
                    else if (SplashKit.PointInCircle(mousePoint, SplashKit.CircleAt(400, 250, 60)))
                    {
                        clickedCircle = "Blue";
                        clickCount++;
                    }
                    else if (SplashKit.PointInCircle(mousePoint, SplashKit.CircleAt(620, 250, 60)))
                    {
                        clickedCircle = "Green";
                        clickCount++;
                    }
                }

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Click a circle to see which one was selected.", Color.Black, 20, 20);
                SplashKit.DrawText("Last clicked: " + clickedCircle, Color.Black, 20, 60);
                SplashKit.DrawText("Total clicks: " + clickCount, Color.Black, 20, 100);

                SplashKit.FillCircle(Color.Red, 180, 250, 60);
                SplashKit.DrawCircle(Color.Black, 180, 250, 60);

                SplashKit.FillCircle(Color.Blue, 400, 250, 60);
                SplashKit.DrawCircle(Color.Black, 400, 250, 60);

                SplashKit.FillCircle(Color.Green, 620, 250, 60);
                SplashKit.DrawCircle(Color.Black, 620, 250, 60);

                SplashKit.DrawText("Red", Color.Black, 155, 330);
                SplashKit.DrawText("Blue", Color.Black, 375, 330);
                SplashKit.DrawText("Green", Color.Black, 590, 330);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}