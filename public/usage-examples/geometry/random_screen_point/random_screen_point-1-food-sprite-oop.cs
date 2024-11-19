using SplashKitSDK;

namespace FillCircleOnBitmap
{
    public class Program
    {
        public static void Main()
        {
           //Create Window
            SplashKit.OpenWindow("draw sprite random", 600, 600);

            SplashKit.LoadBitmap("food", "food.png");
            Sprite FoodSprite = SplashKit.CreateSprite(SplashKit.BitmapNamed("food"));

            //set random food location
            SplashKit.SpriteSetPosition(FoodSprite, SplashKit.RandomScreenPoint());


            SplashKit.ClearScreen(SplashKit.ColorBlack());

            //Draw the sprite
            SplashKit.DrawSprite(FoodSprite);

            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);
            SplashKit.CloseAllWindows();
        }
    }
}