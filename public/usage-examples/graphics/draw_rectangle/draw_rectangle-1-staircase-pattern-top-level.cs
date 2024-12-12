using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Draw Rectangle", 800, 600);
ClearScreen();

for (int i = 0; i < 21; i++)
{
    int x = i * 40 - 40;
    int y = 600 - i * 30;

    Color randomColor = RGBColor(
        Rnd(255), Rnd(255), Rnd(255)
    );

    DrawRectangle(randomColor, x, y, 40, 30);
}

RefreshScreen();
Delay(4000);
CloseAllWindows();


