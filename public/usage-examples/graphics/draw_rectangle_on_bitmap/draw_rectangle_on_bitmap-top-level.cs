using SplashKitSDK;
using static SplashKitSDK.SplashKit;

            OpenWindow("Rectangle on Bitmap", 400, 400);
            Bitmap bitmap = new Bitmap("bricks", 400, 400);
        

        Random random = new Random();
        for (int i = 0; i < 50; i++)
        {
                double x = Rnd(50, 350);  // Random X position
                double y = Rnd(50, 350);  // Random Y position
                double width = Rnd(20, 50); // Random width
                double height = Rnd(20, 50); // Random height
                
            
            Color randcolor = RGBColor(
                Rnd(255), Rnd(255), Rnd(255)
            );

            bitmap.DrawRectangle(randcolor, x, y, width, height);
        }

           // Main loop to display the bitmap
            while(!QuitRequested())
            {
                ProcessEvents();
                DrawBitmap(bitmap, 0, 0);
                RefreshScreen();
            }

            // Free resources
            bitmap.Free();
