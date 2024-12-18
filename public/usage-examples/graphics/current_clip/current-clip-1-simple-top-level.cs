using static SplashKitSDK.SplashKit;
using SplashKitSDK;
        // Open a window with the title "Current Clip" and dimensions
        Window window= OpenWindow("Current Clip", 800, 600);
        
        // Push a clipping area
        Rectangle rectangle = CurrentClip();
        // Display information about the current clipping area (Width and Height) in the window
        DrawText($"Current Clip: Width:{rectangle.Width} Height:{rectangle.Height}", Color.Black, "Arial", 24, 100, 100);
        
        // Refresh the screen to display the text
        RefreshScreen();
        
        // Wait for 5 seconds to observe the clipping area information
        Delay(5000);

        // Close the window
        CloseAllWindows();

