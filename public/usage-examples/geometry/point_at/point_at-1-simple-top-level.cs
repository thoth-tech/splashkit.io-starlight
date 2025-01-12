using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Point At", 800, 600);
ClearScreen();


for (int i = 0; i < 30; i++)
{
    int x1 = Rnd(800);
    int y1 = Rnd(600);

    // Create a point at position (x1,y1)
    Point2D point = PointAt(x1, y1);

    Color randomColor = RGBColor(
        Rnd(255), Rnd(255), Rnd(255)
    );

    // Create graphs at the point
    FillCircle(randomColor, point.X, point.Y, 4);
    FillCircle(randomColor, point.X + 20, point.Y, 4);
    FillRectangle(randomColor, point.X + 10, point.Y + 10, 10, 10);
}

// Create a point at middle of the screen
Point2D pointMiddle = PointAt(400, 300);

// Draw the point
FillCircle(Color.Red, pointMiddle.X, pointMiddle.Y, 4);
DrawText("Center Point", Color.Black, pointMiddle.X - 20, pointMiddle.Y - 20);

RefreshScreen();
Delay(4000);
CloseAllWindows();



