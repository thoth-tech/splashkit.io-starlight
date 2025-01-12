using SplashKitSDK;
using static SplashKitSDK.SplashKit;

        // Open a new window with the title "Bitmap Scaling" and dimensions 800x600
        Window window = OpenWindow("Bitmap Scaling", 800, 600);

        // Load the bitmap from the file "landscape.png" and give it the name "Landscape"
        Bitmap bmp = LoadBitmap("Landscape", "landscape.png");

        // Set the scaling factors for the bitmap
        double scaleX = 0.5; // Scale the width to 50% of the original size
        double scaleY = 0.5; // Scale the height to 50% of the original size

        // Draw the scaled bitmap onto the window at coordinates (100, 100)
        DrawBitmap(bmp, 100, 100, OptionScaleBmp(scaleX, scaleY));
        // Refresh the screen to display the changes
        RefreshScreen();

        // Pause the program for 3000 milliseconds (3 seconds)
        Delay(3000);

        // Free the memory used by the bitmap
        FreeBitmap(bmp);

        // Close all open windows        
        CloseAllWindows();
    

