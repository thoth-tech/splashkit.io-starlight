using SplashKitSDK;

namespace KeyTypedExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Typed Key Counter", 800, 600);

            int aCount = 0;
            int spaceCount = 0;
            int enterCount = 0;
            string lastTypedKey = "None";

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Count each key once when it is first pressed.
                if (SplashKit.KeyTyped(KeyCode.AKey))
                {
                    aCount++;
                    lastTypedKey = "A";
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    spaceCount++;
                    lastTypedKey = "Space";
                }

                if (SplashKit.KeyTyped(KeyCode.ReturnKey))
                {
                    enterCount++;
                    lastTypedKey = "Enter";
                }

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Press A, Space, or Enter.", Color.Black, 20, 20);
                SplashKit.DrawText("Hold a key down and the count only changes once.", Color.Black, 20, 50);
                SplashKit.DrawText("Last typed key: " + lastTypedKey, Color.Black, 20, 100);
                SplashKit.DrawText("A count: " + aCount, Color.Black, 20, 150);
                SplashKit.DrawText("Space count: " + spaceCount, Color.Black, 20, 190);
                SplashKit.DrawText("Enter count: " + enterCount, Color.Black, 20, 230);

                SplashKit.RefreshScreen(60);
            }
        }
    }
}