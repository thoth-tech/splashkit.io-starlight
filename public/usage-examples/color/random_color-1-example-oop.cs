using SplashKitSDK;

namespace RandomColorExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Random Color", 800, 600);

            // Function used here ↓
            Color color = SplashKit.RandomColor();
            int redComponent = SplashKit.RedOf(color);
            int greenComponent = SplashKit.GreenOf(color);
            int blueComponent = SplashKit.BlueOf(color);
            int alphaComponent = SplashKit.AlphaOf(color);
            Rectangle rectangle = SplashKit.RectangleFrom(200, 100, 400, 300);

            SplashKit.ClearScreen(Color.White);
            SplashKit.FillRectangle(color, rectangle);
            SplashKit.DrawText("This random color's RGBA values are: R-" + redComponent.ToString() + ", G-" + greenComponent.ToString() + ", B-" + blueComponent.ToString() + ", A-" + alphaComponent.ToString(), Color.Black, 160, 450);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}