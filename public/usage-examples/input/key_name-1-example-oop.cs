using SplashKitSDK;

namespace KeyNameExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Key Name", 800, 600);

            // Store the last key typed from this example's set of demo keys
            KeyCode lastKey = KeyCode.UnknownKey;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Check which demo key was typed and save its key code
                if (SplashKit.KeyTyped(KeyCode.AKey)) lastKey = KeyCode.AKey;
                if (SplashKit.KeyTyped(KeyCode.Num1Key)) lastKey = KeyCode.Num1Key;
                if (SplashKit.KeyTyped(KeyCode.SpaceKey)) lastKey = KeyCode.SpaceKey;
                if (SplashKit.KeyTyped(KeyCode.LeftKey)) lastKey = KeyCode.LeftKey;
                if (SplashKit.KeyTyped(KeyCode.ReturnKey)) lastKey = KeyCode.ReturnKey;

                // Draw the instructions and the readable name of the last key
                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawText("Press A, 1, Space, Left, or Enter", Color.Black, 150, 220);
                SplashKit.DrawText("Last key: " + SplashKit.KeyName(lastKey), Color.Blue, 280, 300);
                SplashKit.RefreshScreen();
            }

            SplashKit.CloseAllWindows();
        }
    }
}
