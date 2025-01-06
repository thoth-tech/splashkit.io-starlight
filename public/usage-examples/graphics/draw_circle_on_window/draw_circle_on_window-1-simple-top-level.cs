using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window myWindow = OpenWindow("Draw Circle on Window", 800, 600);

ClearScreen();

Random random = new Random();
for (int i = 0; i < 50; i++)
{
    // Set random x position to 1 - 800
    double x = random.Next(800);

    // Set random y position to 1 - 600
    double y = random.Next(600);

    // Set random radius to 1 - 50
    double radius = random.Next(50);

    Color randomColor = RGBColor(
        random.Next(255), random.Next(255), random.Next(255)
    );

    // Draw the circle base on the random data
    DrawCircleOnWindow(myWindow, randomColor, x, y, radius);
}

RefreshScreen();
Delay(4000);
CloseAllWindows();