using SplashKitSDK;

namespace SaveBitmapExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Save Bitmap", 800, 600);

            int opacityValue = 0;
            Bitmap imageBitmap = SplashKit.LoadBitmap("imageBitmap", "image1.jpg");

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                if (SplashKit.KeyTyped(KeyCode.ReturnKey))
                {
                    SplashKit.SaveBitmap(imageBitmap, "savedBitmap");
                    opacityValue = 2500;
                }

                if (opacityValue != 0)
                {
                    opacityValue -= 1;
                }

                SplashKit.ClearScreen();
                SplashKit.DrawBitmap(imageBitmap, 200, 155);
                SplashKit.DrawText("Press the 'Enter' key to save the above bitmap to desktop", Color.Black, 175, 450);
                SplashKit.DrawText("Image saved to desktop!", SplashKit.RGBAColor(0, 0, 0, opacityValue), 310, 470);

                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}