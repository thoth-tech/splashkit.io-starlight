using SplashKitSDK;
using static SplashKitSDK.SplashKit;
    

            // Create a window and a bitmap
            Window window = new Window("Rectangle on Bitmap", 400, 400);
            Bitmap bitmap = new Bitmap("bricks", 400, 400);

            // Clear the bitmap with a base color (representing the brick wall)
            bitmap.Clear(Color.Gray);

            // Draw a grid of rectangles to simulate bricks
            Color brickColor = Color.RGBAColor(180, 50, 50, 255); // Brick color
            for (int y = 0; y < 400; y += 50) // Each brick row
            {
                for (int x = (y / 50) % 2 == 0 ? 0 : 25; x < 400; x += 50) // Offset every other row
                {
                    bitmap.DrawRectangle(brickColor, x, y, 50, 25);
                }
            }

            // Draw additional abstract rectangles on the bitmap
            for (int i = 0; i < 15; i++)
            {
                double x = Rnd(50, 350);  // Random X position
                double y = Rnd(50, 350);  // Random Y position
                double width = Rnd(20, 50); // Random width
                double height = Rnd(20, 50); // Random height
                Color randomColor = RandomRGBColor(255); // Random color
                bitmap.DrawRectangle(randomColor, x, y, width, height);
            }

            // Main loop to display the bitmap
            while (!window.CloseRequested)
            {
                ProcessEvents();
                window.DrawBitmap(bitmap, 0, 0);
                RefreshScreen();
            }

            // Free resources
            bitmap.Free();
        
    

