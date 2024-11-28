using SplashKitSDK;

namespace CenterPoint
{
    public class Program
    {
        public static void Main()
        {
        SplashKit.OpenWindow("Center Point", 800, 600);
        SplashKit.ClearScreen();

        // Set position for the circle
        double x_position = 400;
        double y_position = 300;

        // Create A circle name "A"
        Circle A = SplashKit.CircleAt(x_position, y_position, 200);

        //Draw the Circle A
        SplashKit.DrawCircle(Color.Red, A);

        //Draw Point in the center of the circle
        SplashKit.FillCircle(Color.Black, SplashKit.CenterPoint(A).X, SplashKit.CenterPoint(A).Y, 3);
    
        string text = "Center Point At: " + SplashKit.PointToString(SplashKit.CenterPoint(A));
        // Print result on window
        SplashKit.DrawText(SplashKit.PointToString(SplashKit.CenterPoint(A)), Color.Black, x_position -20, y_position - 20);

        SplashKit.RefreshScreen();
        SplashKit.Delay(4000);
        SplashKit.CloseAllWindows();
        }
    }
}