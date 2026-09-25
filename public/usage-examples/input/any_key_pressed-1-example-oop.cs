using SplashKitSDK;

namespace AnyKeyPressedExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Any Key Pressed", 800, 600);

            string message = "No key is being pressed.";
            Color circleColor = Color.Red;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.AnyKeyPressed())
                {
                    message = "A key is being pressed.";
                    circleColor = Color.Green;
                }
                else
                {
                    message = "No key is being pressed.";
                    circleColor = Color.Red;
                }

                SplashKit.ClearScreen(Color.White);

                SplashKit.FillCircle(circleColor, 400, 250, 80);
                SplashKit.DrawText(message, Color.Black, 240, 400);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}