using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window myWindow = OpenWindow("Draw Circle on Window", 800, 600);

ClearScreen();

Random random = new Random();
for (int i = 0; i < 50; i++)
{
    double x = random.Next(800);
    double y = random.Next(600);
    double radius = random.Next(50);

    Color randomColor = RGBColor(
        random.Next(255), random.Next(255), random.Next(255)  
    );

    DrawCircleOnWindow(myWindow, randomColor, x, y, radius);
}

RefreshScreen();
Delay(4000);
CloseAllWindows();