using SplashKitSDK;

namespace CenterPointExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Center Point", 800, 600);
            window.Clear(Color.White);

            // Set position for the circle
            double x_position = 400;
            double y_position = 300;

            // Create A circle name "A"
            Circle A = SplashKit.CircleAt(x_position, y_position, 200);

            //Fill the Circle A
            SplashKit.FillCircle(Color.Red, A);

            //Using the center point to fill a triangle to cut the circle
            SplashKit.FillTriangle(Color.White, SplashKit.CenterPoint(A).X, SplashKit.CenterPoint(A).Y, 0, 300, 500, 0);

            //Draw Point in the center of the circle
            SplashKit.FillCircle(Color.Black, SplashKit.CenterPoint(A).X, SplashKit.CenterPoint(A).Y, 3);

            string text = "Center Point At: " + SplashKit.PointToString(SplashKit.CenterPoint(A));

            // Print result on window
            SplashKit.DrawText(SplashKit.PointToString(SplashKit.CenterPoint(A)), Color.Black, x_position - 20, y_position - 20);

            window.Refresh();
            SplashKit.Delay(4000);
            window.Close();
        }
    }
}