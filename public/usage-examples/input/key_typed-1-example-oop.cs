using SplashKitSDK;

namespace KeyTypedExample
{
    public class Program
    {
        public static void Main()
        {
            KeyCode[] trackedKeys =
            {
                KeyCode.AKey, KeyCode.BKey, KeyCode.CKey, KeyCode.DKey, KeyCode.EKey,
                KeyCode.FKey, KeyCode.GKey, KeyCode.HKey, KeyCode.IKey, KeyCode.JKey,
                KeyCode.KKey, KeyCode.LKey, KeyCode.MKey, KeyCode.NKey, KeyCode.OKey,
                KeyCode.PKey, KeyCode.QKey, KeyCode.RKey, KeyCode.SKey, KeyCode.TKey,
                KeyCode.UKey, KeyCode.VKey, KeyCode.WKey, KeyCode.XKey, KeyCode.YKey, KeyCode.ZKey,
                KeyCode.Num0Key, KeyCode.Num1Key, KeyCode.Num2Key, KeyCode.Num3Key, KeyCode.Num4Key,
                KeyCode.Num5Key, KeyCode.Num6Key, KeyCode.Num7Key, KeyCode.Num8Key, KeyCode.Num9Key,
                KeyCode.SpaceKey, KeyCode.EscapeKey
            };

            string lastKey = "None";

            SplashKit.OpenWindow("Last Typed Key", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Update the text when a supported key is typed
                foreach (KeyCode key in trackedKeys)
                {
                    if (SplashKit.KeyTyped(key))
                    {
                        lastKey = SplashKit.KeyName(key);
                    }
                }

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Press a supported key", Color.Black, 20, 20);
                SplashKit.DrawText("Last typed: " + lastKey, Color.Blue, 20, 80);

                SplashKit.RefreshScreen();
            }

            SplashKit.CloseAllWindows();
        }
    }
}