using SplashKitSDK;

namespace MouseUpExample
{
    public static class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Mouse Button Lamp", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Hold the left mouse button to turn the lamp red.", Color.Black, 20, 20);

                // The lamp stays green while the button is released and turns red for as long as it is held
                if (SplashKit.MouseUp(MouseButton.LeftButton))
                {
                    SplashKit.FillCircle(Color.Green, 400, 330, 110);
                    SplashKit.DrawText("Left button: up", Color.Black, 20, 60);
                }
                else
                {
                    SplashKit.FillCircle(Color.Red, 400, 330, 110);
                    SplashKit.DrawText("Left button: down", Color.Black, 20, 60);
                }

                SplashKit.DrawCircle(Color.Black, 400, 330, 110);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
