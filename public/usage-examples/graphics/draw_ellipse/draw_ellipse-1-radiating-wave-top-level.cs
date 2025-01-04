using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Draw Ellipse", 800, 600);

ClearScreen();

Random random = new Random();
for (int i = 0; i < 30; i++)
        {
            // Decrease width by 20 every round
            int width = 600 - i * 20;
            // Decrease height by 10 every round
            int height = 400 - i * 10;
            // Increase x position by 10 every round
            int x = 100 + i * 10;
            // Increase y position by 5 every round
            int y = 100 + i * 5;

            Color randomColor = SplashKit.RGBColor(
                random.Next(255), random.Next(255), random.Next(255)  
            );

            // Draw ellipse based on the given data
            DrawEllipse(randomColor, x, y, width, height);
        }

RefreshScreen();
Delay(4000);
CloseAllWindows();