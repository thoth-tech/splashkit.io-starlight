using SplashKitSDK;

namespace CircleY
{
    public class Program
    {
        public static void Main()
        {
        SplashKit.OpenWindow("Circle Y", 800, 600);
        SplashKit.ClearScreen();

        Random random = new Random();
        // Set position for the circle
        double x_position = 400;
        //Give random  y_position value bewteen 200 - 400
        double y_position = random.Next(200) + 200;

        // Create A circle name "A"
        Circle A = SplashKit.CircleAt(x_position, y_position, 200);
        // Find the y position of the circle
        double circleY = SplashKit.CircleY(A);

        //Draw the Circle
        SplashKit.DrawCircle(Color.Red, x_position, circleY, 200);
    
        string text = "Circle Y: " + circleY.ToString();
        // Print result on window
        SplashKit.DrawText(text, Color.Black, "NORMAL_FONT", 20, 100, 100);

        SplashKit.RefreshScreen();
        SplashKit.Delay(4000);
        SplashKit.CloseAllWindows();
        }
    }
}