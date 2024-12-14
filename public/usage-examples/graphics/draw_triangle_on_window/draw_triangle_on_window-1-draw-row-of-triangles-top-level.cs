using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window myWindow = OpenWindow("Draw Triangle on Window", 800, 600);

ClearScreen();

Random random = new Random();
for (int i = 0; i < 20; i++)
{
    double x = 40 * i;

    Color randomColor = RGBColor(
        random.Next(255), random.Next(255), random.Next(255)  
    );

    DrawTriangleOnWindow(myWindow, randomColor, 0 + x, 0, 20 + x, 40, 40 + x, 0);
}

RefreshScreen();
Delay(4000);
CloseAllWindows();

