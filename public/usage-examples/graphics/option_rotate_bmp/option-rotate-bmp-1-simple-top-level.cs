using SplashKitSDK;
using static SplashKitSDK.SplashKit;

        // Open a window with the title "Rotate bitmap" and dimensions 800x600
        OpenWindow("Rotate bitmap", 800, 600);

        // Load the bitmap for the clock hand from the file "clock_hand.png"
        Bitmap bitmap = LoadBitmap("Clock Hand", "clock_hand.png");

        // Load the bitmap for the clock face from the file "clock.png"
        Bitmap clock = LoadBitmap("Clock", "clock.png");

        // Loop to rotate the clock hand through 360 degrees
        for (int i = 0; i < 360; i++)
        {
            // Draw the rotated clock hand bitmap at position (100, 100)
            DrawBitmap(bitmap, 100, 100, OptionRotateBmp(i));

            // Draw the clock face bitmap at the same position to create the effect of a rotating hand
            DrawBitmap(clock, 100, 100);

            // Refresh the screen to display the updated frame
            RefreshScreen();

            // Pause for 100 milliseconds before the next frame
            Delay(100);

            // Clear the screen to prepare for the next frame
            ClearScreen();
        }

        // Free all loaded bitmap resources
        FreeAllBitmaps();

        // Close all open windows
        CloseAllWindows();


