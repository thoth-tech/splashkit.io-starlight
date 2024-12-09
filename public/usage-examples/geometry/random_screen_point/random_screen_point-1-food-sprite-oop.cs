using SplashKitSDK;

namespace RandomScreenPoint
{
    public class Program
    {
        public static void Main()
        {
            // Create Window
            Window Window = new Window("Food Generator", 600, 600);

            Bitmap Food = new Bitmap("Food", "food.png");
            Sprite FoodSprite = SplashKit.CreateSprite(Food);

            // Set random food location
            FoodSprite.Position = SplashKit.RandomScreenPoint();

            Window.Clear(Color.Black);

            // Draw the sprite
            SplashKit.DrawSprite(FoodSprite);

            Window.Refresh();
            SplashKit.Delay(5000);
            Window.Close();
        }
    }
}