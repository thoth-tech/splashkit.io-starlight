using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window myWindow = OpenWindow("Draw Triangle on Window", 800, 600);

ClearScreen();

for (int i = 0; i < 20; i++)
{
    // Set the x position for triangles increase by 40 * i every round
    double x = 40 * i;

    Color randomColor = RGBColor(
        Rnd(255), Rnd(255), Rnd(255)
    );

    // Draw the triangles by increasing x position
    DrawTriangleOnWindow(myWindow, randomColor, 0 + x, 0, 20 + x, 40, 40 + x, 0);
}

RefreshScreen();
Delay(4000);
CloseAllWindows();

