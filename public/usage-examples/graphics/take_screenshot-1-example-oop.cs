using SplashKitSDK;

namespace TakeScreenshotExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Take Screenshot", 800, 600);

            double rotation = 0;
            int opacityValue = 0;
            int randColorCounter = 0;
            Color randColor = SplashKit.RandomColor();
            Bitmap imageBitmap = SplashKit.LoadBitmap("image_bitmap", "image1.jpg");

            while (!SplashKit.QuitRequested())
            {
                rotation += 0.01;
                randColorCounter += 1;

                if (opacityValue != 0)
                {
                    opacityValue -= 1;
                }

                if (randColorCounter >= 3000)
                {
                    randColor = SplashKit.RandomColor();
                    randColorCounter = 0;
                }

                SplashKit.ProcessEvents();

                if (SplashKit.KeyTyped(KeyCode.ReturnKey))
                {
                    // Function used here ↓
                    SplashKit.TakeScreenshot("saved_screenshot");
                    opacityValue = 2500;
                }

                SplashKit.ClearScreen(Color.White);
                SplashKit.FillRectangle(randColor, SplashKit.RectangleFrom(450, 200, 150, 150));
                SplashKit.DrawBitmap(imageBitmap, 100, 100, SplashKit.OptionRotateBmp(rotation));
                SplashKit.DrawText("Press the 'Enter' key to take a screenshot of the game window", Color.Black, 175, 450);
                SplashKit.DrawText("Image saved to desktop!", SplashKit.RGBAColor(0, 0, 0, opacityValue), 310, 470);
                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}