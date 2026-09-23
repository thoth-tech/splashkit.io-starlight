using SplashKitSDK;

namespace SetCameraPositionExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Set Camera Position Example", 400, 300);

            double cameraX = 0;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                // Move the camera position each frame
                SplashKit.SetCameraPosition(SplashKit.PointAt(cameraX, 0));
                cameraX += 1;

                // A stationary object in the world - it does not move itself
                SplashKit.FillRectangle(Color.Red, 200, 100, 50, 50);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}