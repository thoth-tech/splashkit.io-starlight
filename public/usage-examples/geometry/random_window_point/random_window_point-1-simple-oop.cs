using SplashKitSDK;

namespace RandomWindowPoint
{
    public class Program
    {
        public static void Main()
        {   
            //Create Window
            Window window = SplashKit.OpenWindow("portal", 600, 600);

            // load portal sprites
            SplashKit.LoadBitmap("bluePortal", "bluePortal.png");
            SplashKit.LoadBitmap("orangePortal", "orangePortal.png");
            Sprite blue_portal = SplashKit.CreateSprite(SplashKit.BitmapNamed("bluePortal"));
            Sprite orange_portal = SplashKit.CreateSprite(SplashKit.BitmapNamed("orangePortal"));


            //set random portal location
            SplashKit.SpriteSetPosition(blue_portal, SplashKit.RandomWindowPoint(window));
            SplashKit.SpriteSetPosition(orange_portal, SplashKit.RandomWindowPoint(window));

            SplashKit.ClearWindow(window, SplashKit.ColorBlack());

            //Draw the sprite
            SplashKit.DrawSprite(blue_portal);
            SplashKit.DrawSprite(orange_portal);

            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);
            SplashKit.CloseAllWindows();
        }
    }
}
