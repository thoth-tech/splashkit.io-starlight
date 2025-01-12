using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Draw Rectangle", 800, 600);
ClearScreen();

for (int i = 0; i < 21; i++)
{
    // Increase x position by 40 every round
    int x = i * 40 - 40;

    // Decrease y position by 30 every round
    int y = 600 - i * 30;

    Color randomColor = RGBColor(
        Rnd(255), Rnd(255), Rnd(255)
    );

    // Draw rectangle base on the x, y position with width 40 and height 30
    DrawRectangle(randomColor, x, y, 40, 30);
}

RefreshScreen();
Delay(4000);
CloseAllWindows();


