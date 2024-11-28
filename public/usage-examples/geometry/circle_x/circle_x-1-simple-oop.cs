using SplashKitSDK;

namespace CircleX
{
    public class Program
    {
        public static void Main()
        {
        SplashKit.OpenWindow("Circle X", 800, 600);
        SplashKit.ClearScreen();

        Random random = new Random();
        // Set position for the circle
        //Give random  x_position value bewteen 200 - 600
        double x_position = random.Next(400) + 200;
        double y_position = 300;

        // Create A circle name "A"
        Circle A = SplashKit.CircleAt(x_position, y_position, 200);
        // Find the x position of the circle
        double circleX = SplashKit.CircleX(A);

        //Draw the Circle
        SplashKit.DrawCircle(Color.Red, circleX, y_position, 200);
    
        string text = "Circle X: " + circleX.ToString();
        // Print result on window
        SplashKit.DrawText(text, Color.Black, "NORMAL_FONT", 20, 100, 100);

        SplashKit.RefreshScreen();
        SplashKit.Delay(4000);
        SplashKit.CloseAllWindows();
        }
    }
}