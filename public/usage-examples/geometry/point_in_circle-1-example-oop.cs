using SplashKitSDK;

namespace PointInCircleExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Circular Toggle Button", 800, 600);

            //Declaring the variables
            Color circleColor;
            Color textColor;
            Color bgColor = Color.White;
            string text;
            Point2D cursorPos;
            Circle circle = SplashKit.CircleAt(400, 300, 80);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                cursorPos = SplashKit.MousePosition();

                // Check for mouse position in relation to circle
                if (SplashKit.PointInCircle(cursorPos, circle))
                {
                    circleColor = Color.Green;
                    textColor = Color.Green;
                    text = "Point is in the circle";
                    circle.Radius = 90;
                    if (SplashKit.MouseClicked(MouseButton.LeftButton))
                    {
                        bgColor = Color.Random();
                    }
                }
                else
                {
                    circleColor = Color.BrightGreen;
                    textColor = Color.Red;
                    text = "Point is not in the circle";
                    circle.Radius = 80;
                }

                // Display the button and results
                SplashKit.ClearScreen(bgColor);
                SplashKit.DrawText("Click the button to change colour of the Screen", Color.Black, 200, 100);
                SplashKit.DrawText(text, textColor, 300, 150);
                SplashKit.FillCircle(circleColor, circle);
                SplashKit.DrawText("Button", Color.Black, 375, 300);
                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}
