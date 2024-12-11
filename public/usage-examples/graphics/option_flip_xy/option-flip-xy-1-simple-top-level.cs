using SplashKitSDK;
using static SplashKitSDK.SplashKit;

        // Open a new window with the title "OptionFlipXY" and dimensions 800x600
        Window window = OpenWindow("Option Flip XY ", 800, 600);

        // Load a bitmap image named "House" from the file "house.png"
        Bitmap bmp = LoadBitmap("House", "house.png");

        // Draw the original bitmap image at position (100, 100) in the window
        DrawBitmap(bmp, 100, 100); 

        // Draw the bitmap image flipped horizontally at position (300, 100)
        DrawBitmap(bmp, 300, 100, OptionFlipXy());

        // Refresh the screen to display the drawings
        RefreshScreen();

        // Pause the program for 5000 milliseconds (5 seconds) to keep the window open
        Delay(5000);

        // Close all open windows
        CloseAllWindows();

