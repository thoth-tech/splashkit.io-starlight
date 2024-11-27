using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window myWindow = OpenWindow("Abstract Mosaic", 800, 600);
for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 6; y++)
            {
                FillTriangle(RandomColor(), x * 100, y * 100, x * 100 + 50, y * 100 + 50, x * 100 + 100, y * 100);
            }
        }
RefreshScreen();
Delay(5000);
CloseAllWindows();
    

