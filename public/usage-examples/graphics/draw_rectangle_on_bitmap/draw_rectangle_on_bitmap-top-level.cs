using SplashKitSDK;
using static SplashKitSDK.SplashKit;

            // Open a window
            OpenWindow("Rectangle on Bitmap", 400, 400);

            // Create a bitmap
            Bitmap bitmap = new Bitmap("bricks", 400, 400);
        
        // Draw 50 random rectangles on the bitmap
        Random random = new Random();
        for (int i = 0; i < 50; i++)
        {
                double x = SplashKit.Rnd(50, 350);  
                double y = SplashKit.Rnd(50, 350);  
                double width = SplashKit.Rnd(20, 50); 
                double height = SplashKit.Rnd(20, 50); 
                
            // Generate a random color
            Color randcolor = RGBColor(
                Rnd(255), Rnd(255), Rnd(255)
            );
            // Draw the rectangle with the random color on the bitmap
            bitmap.DrawRectangle(randcolor, x, y, width, height);
        }

            // Draw the bitmap onto the window
            DrawBitmap(bitmap, 0, 0);

            // Refresh the screen
            RefreshScreen();

            // Delay to keep the window open for 5 seconds
            Delay(5000);
            

            // Close the window
            CloseAllWindows();
