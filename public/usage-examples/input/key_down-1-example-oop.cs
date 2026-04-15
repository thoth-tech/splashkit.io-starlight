using SplashKitSDK;

namespace KeyDownExample
{
    public class Program
    {
        static void DrawKeyStatus(string label, KeyCode key, double x, double y)
        {
            bool pressed = SplashKit.KeyDown(key);

            Color indicator;
            string state;

            if (pressed)
            {
                indicator = Color.Green;
                state = "Pressed";
            }
            else
            {
                indicator = Color.Gray;
                state = "Released";
            }

            SplashKit.FillCircle(indicator, x, y, 25);
            SplashKit.DrawText(label + ": " + state, Color.Black, x + 40, y - 10);
        }

        public static void Main()
        {
            SplashKit.OpenWindow("Keyboard State Display", 800, 400);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Press the arrow keys or space bar to see their current state.", Color.Black, 120, 40);

                DrawKeyStatus("Left", KeyCode.LeftKey, 120, 130);
                DrawKeyStatus("Right", KeyCode.RightKey, 120, 190);
                DrawKeyStatus("Up", KeyCode.UpKey, 120, 250);
                DrawKeyStatus("Down", KeyCode.DownKey, 120, 310);
                DrawKeyStatus("Space", KeyCode.SpaceKey, 500, 220);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
