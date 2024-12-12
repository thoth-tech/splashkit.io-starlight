using SplashKitSDK;

namespace CircleY
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Circle Y", 800, 600);
            SplashKit.ClearScreen();

            // Set position for the circle
            double x_position = 400;
            //Give random  y_position value bewteen 200 - 400
            double y_position = SplashKit.Rnd(200) + 200;

            // Create a circle A at the position (x_position, y_position)
            Circle A = SplashKit.CircleAt(x_position, y_position, 200);
            // Find the y position of the circle
            double circleY = SplashKit.CircleY(A);

            //Draw the Circle
            SplashKit.DrawCircle(Color.Red, x_position, circleY, 200);

            //Draw a line to show the circle Y coordinate
            SplashKit.DrawLine(Color.Black, 0, circleY, 800, circleY);

            string text = "Circle Y: " + circleY.ToString();
            // Print result on window
            SplashKit.DrawText(text, Color.Black, 100, 100);

            //Draw 10 circles with radient 50 and the same circle y coordinate
            for (int i = 0; i < 10; i++)
            {
                int x = i * 60 + 100;
                int radiant = 50;

                SplashKit.DrawCircle(Color.Blue, x, circleY, radiant);
            }

            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}