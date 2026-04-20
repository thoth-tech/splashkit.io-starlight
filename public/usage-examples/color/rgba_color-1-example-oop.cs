using SplashKitSDK;

namespace RgbaColorExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Draw Rectangle with Random Color", 800, 600);

            int random_red = new Random().Next(0, 255);
            int random_green = new Random().Next(0, 255);
            int random_blue = new Random().Next(0, 255);
            // The function creates a color which is saved to a color variable. In this example a random red, green and blue value is inputted. Alpha/opacity is also set to the maximum
            Color color = SplashKit.RGBAColor(random_red, random_green, random_blue, 255);
            Rectangle rectangle = SplashKit.RectangleFrom(200, 100, 400, 300);

            SplashKit.ClearScreen(Color.White);
            SplashKit.FillRectangle(color, rectangle);
            // Show RGBA values of the randomly generated color
            SplashKit.DrawText("Current color details: R-" + random_red.ToString() + ", G-" + random_green.ToString() + ", B-" + random_blue.ToString(), Color.Black, 235, 450);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}