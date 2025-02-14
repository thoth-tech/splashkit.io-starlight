using SplashKitSDK;
using static SplashKitSDK.SplashKit;

        // Open a window titled "Falling Snow" with a size of 800x600
        Window window = OpenWindow("Falling Snow", 800, 600);

        // Loop until the user requests to quit
        while (!QuitRequested())
        {
            // Generate random X and Y coordinates
            double x = Rnd(0, 800);  // Random X position
            double y = Rnd(0, 600);  // Random Y position

            // Draw 100 random pixels on the window
            for (int i = 0; i < 100; i++)
            {
                DrawPixelOnWindow(window, Color.Gray, x, y);
            }
            // Refresh the screen to show the drawn pixels
            RefreshScreen();
            
            // Delay to control the frame rate
            Delay(50);
        }

        // Close all windows
        CloseAllWindows();

