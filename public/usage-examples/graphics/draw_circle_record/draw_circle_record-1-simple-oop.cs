using SplashKitSDK;

namespace DrawCircles {
    class Program {
        static void Main() {
            SplashKit.OpenWindow("Draw Circles", 800, 600);

            SplashKit.ClearScreen();

            // Define the center point of circles
            Point2D center = new Point2D { X = 400, Y = 300 };

            // Create 4 circles with different radii
            Circle circle1 = new Circle { Center = center, Radius = 50 };
            Circle circle2 = new Circle { Center = center, Radius = 100 };
            Circle circle3 = new Circle { Center = center, Radius = 150 };
            Circle circle4 = new Circle { Center = center, Radius = 200 };

            // Draw the circles with different colors
            SplashKit.DrawCircle(SplashKit.ColorRed(), circle1);
            SplashKit.DrawCircle(SplashKit.ColorBlue(), circle2);
            SplashKit.DrawCircle(SplashKit.ColorOrange(), circle3);
            SplashKit.DrawCircle(SplashKit.ColorGreen(), circle4);

            SplashKit.RefreshScreen();

            SplashKit.Delay(4000);

            SplashKit.CloseAllWindows();
        }
    }
}