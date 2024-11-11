using SplashKitSDK;
using static SplashKitSDK.SplashKit;

namespace DrawCircles {
    class Program {
        static void Main() {
            OpenWindow("Draw Circles", 800, 600);

            ClearScreen();

            // Define the center point for all circles
            Point2D center = new Point2D { X = 400, Y = 300 };

            // Create four circles with different radius
            Circle circle1 = new Circle { Center = center, Radius = 50 };
            Circle circle2 = new Circle { Center = center, Radius = 100 };
            Circle circle3 = new Circle { Center = center, Radius = 150 };
            Circle circle4 = new Circle { Center = center, Radius = 200 };

            // Draw the circles with different colors
            DrawCircle(ColorRed(), circle1);
            DrawCircle(ColorBlue(), circle2);
            DrawCircle(ColorOrange(), circle3);
            DrawCircle(ColorGreen(), circle4);

            RefreshScreen();

            Delay(4000);

            CloseAllWindows();
        }
    }
}