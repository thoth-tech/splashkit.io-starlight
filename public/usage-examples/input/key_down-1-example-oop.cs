using SplashKitSDK;

namespace KeyDownExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Key Down Example", 400, 200);

            SplashKit.WriteLine("Press and hold Space...");

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyDown(KeyCode.SpaceKey))
                {
                    SplashKit.WriteLine("Space key is held down!");
                    SplashKit.Delay(500);
                }
            }

            SplashKit.CloseAllWindows();
        }
    }
}