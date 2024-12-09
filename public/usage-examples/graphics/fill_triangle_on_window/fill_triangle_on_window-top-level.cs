using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Fill Triangle", 800, 600);
ClearScreen();

Random random = new Random();
for (int i = 0; i < 10; i++)
    {
    int x1 = random.Next(800);
    int y1 = random.Next(600);
    int x2 = random.Next(800);
    int y2 = random.Next(600);
    int x3 = random.Next(800);
    int y3 = random.Next(600);

    Color randomColor = RGBColor(
        random.Next(255), random.Next(255), random.Next(255)  
    );

    FillTriangle(randomColor, x1, y1, x2, y2, x3, y3);
    }

RefreshScreen();
Delay(4000);
CloseAllWindows();

    

