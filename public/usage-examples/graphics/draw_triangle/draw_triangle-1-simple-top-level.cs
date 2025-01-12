using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Draw Triangle", 800, 600);
ClearScreen();

Random random = new Random();
for (int i = 0; i < 10; i++)
{
    // Random point 1 for the trangle (x1,y1)
    int x1 = Rnd(800);
    int y1 = Rnd(600);

    // Random point 2 for the trangle (x2,y2)
    int x2 = Rnd(800);
    int y2 = Rnd(600);

    // Random point 3 for the trangle (x3,y3)
    int x3 = Rnd(800);
    int y3 = Rnd(600);

    Color randomColor = RGBColor(
        Rnd(255), Rnd(255), Rnd(255)
    );

    // Draw trangle base on the three random points
    DrawTriangle(randomColor, x1, y1, x2, y2, x3, y3);
}

RefreshScreen();
Delay(4000);
CloseAllWindows();


