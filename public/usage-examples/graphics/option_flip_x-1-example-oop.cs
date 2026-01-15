using SplashKitSDK;

namespace OptionFlipXExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Image Flipping Simulator", 800, 600);

            int opacityValue = 255;
            string displayedText = "This bitmap is not flipped along its X axis";
            bool flipped = false;
            Bitmap imageBitmap = SplashKit.LoadBitmap("imageBitmap", "image1.jpg");

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                if (SplashKit.Button("Click to invert X axis", SplashKit.RectangleFrom(320, 450, 160, 30)) && flipped == false)
                {
                    opacityValue = 0;
                    displayedText = "This bitmap has been flipped along its X axis";
                    flipped = true;
                }
                else if (SplashKit.Button("Click to invert X axis", SplashKit.RectangleFrom(320, 450, 160, 30)) && flipped == true)
                {
                    opacityValue = 0;
                    displayedText = "This bitmap is not flipped along its X axis";
                    flipped = false;
                }

                if (opacityValue != 255)
                {
                    opacityValue += 1;
                }

                SplashKit.ClearScreen();
                if (flipped == false)
                {
                    SplashKit.DrawBitmap(imageBitmap, 200, 155);
                }
                else
                {
                    SplashKit.DrawBitmap(imageBitmap, 200, 155, SplashKit.OptionFlipX());
                }
                SplashKit.DrawText(displayedText, SplashKit.RGBAColor(0, 0, 0, opacityValue), 200, 100);
                SplashKit.DrawInterface();

                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}