using static SplashKitSDK.SplashKit;
using SplashKitSDK;
        // Open a window with the title "Reset Clip" and dimensions 800x600
        Window window= OpenWindow("Reset Clip", 800, 600);
        Rectangle rectangle = RectangleFrom(100, 100, 600, 400);
        // Set a clipping area
        SetClip(window, rectangle);

        // Draw inside the clipping area (will be clipped)
        FillRectangle(Color.Blue, 50, 50, 700, 500);  // This will be clipped
        RefreshScreen();
        Delay(1000);

        // Draw outside the clipping area (still within the clipped area, so it will be clipped)
        FillRectangle(Color.Red, 100, 100, 200, 200);  
        RefreshScreen();
        Delay(1000);

        // Reset the clipping area
        ResetClip();
        ClearScreen(Color.Green);  // Clear the screen with a new background color
        RefreshScreen();  // Refresh the screen to apply changes
        Delay(5000);  // Wait for 5 seconds to observe the result

        // Close the window
        CloseAllWindows();
    

