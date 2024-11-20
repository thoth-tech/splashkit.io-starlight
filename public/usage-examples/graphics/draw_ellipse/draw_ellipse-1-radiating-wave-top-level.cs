using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Draw Ellipse", 800, 600);

ClearScreen();

Random random = new Random();
for (int i = 0; i < 30; i++)
        {
            int width = 600 - i * 20;
            int height = 400 - i * 10;
            int x = 100 + i * 10;
            int y = 100 + i * 5;

            Color randomColor = SplashKit.RGBColor(
                random.Next(255), random.Next(255), random.Next(255)  
            );

            DrawEllipse(randomColor, x, y, width, height);
        }

RefreshScreen();
Delay(4000);
CloseAllWindows();