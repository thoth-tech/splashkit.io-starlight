using SplashKitSDK;

namespace CircleAtExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Circle At", 800, 600);
            window.Clear(Color.White);

            // Set position for the circle
            double x_position = 400;
            double y_position = 300;

            // Create A circle name "A"
            Circle A = SplashKit.CircleAt(x_position, y_position, 200);

            //Draw the Circle
            SplashKit.DrawCircle(Color.Red, A);

            string text = "Circle At: (400,300), Radius: 200";
            // Print result on window
            SplashKit.DrawText(text, Color.Black, "NORMAL_FONT", 20, 100, 100);

            window.Refresh();
            SplashKit.Delay(4000);
            window.Close();
        }
    }
}