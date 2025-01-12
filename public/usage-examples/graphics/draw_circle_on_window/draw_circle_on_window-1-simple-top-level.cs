using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window window = OpenWindow("Draw Circle on Window", 800, 600);

ClearScreen();

for (int i = 0; i < 50; i++)
{
    // Set random x position to 1 - 800
    double x = Rnd(800);

    // Set random y position to 1 - 600
    double y = Rnd(600);

    // Set random radius to 1 - 50
    double radius = Rnd(50);

    Color randomColor = RGBColor(
        Rnd(255), Rnd(255), Rnd(255)
    );

    // Draw the circle base on the random data
    DrawCircleOnWindow(window, randomColor, x, y, radius);
}

RefreshScreen();
Delay(4000);
CloseAllWindows();