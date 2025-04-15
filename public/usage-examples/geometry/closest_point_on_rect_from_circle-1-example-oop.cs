using SplashKitSDK;

namespace ClosestPointOnRectFromCircle
{
    public class Program
    {
        public static void Main()
        {
            Window window = SplashKit.OpenWindow("Closest Point On Rect From Circle", 800, 600);

            // Rectangle for creating the point on
            Rectangle rectangleObj = new Rectangle
            {
                X = 300,
                Y = 200,
                Width = 200,
                Height = 150
            };

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawRectangle(Color.Black, rectangleObj);

                // Create circle at mouse position to make it dynamic
                Point2D mousePos = SplashKit.MousePosition();
                Circle circleObj = SplashKit.CircleAt(mousePos, 30);
                SplashKit.FillCircle(Color.Red, circleObj);

                // Get closest point on the rect to the circle and draw it
                Point2D closestPoint = SplashKit.ClosestPointOnRectFromCircle(circleObj, rectangleObj);
                Circle pointOnRect = SplashKit.CircleAt(closestPoint, 5);
                SplashKit.FillCircle(Color.Green, pointOnRect);

                SplashKit.RefreshScreen();

            }
        }
    }
}