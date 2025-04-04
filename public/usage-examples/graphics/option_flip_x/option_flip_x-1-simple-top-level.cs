using SplashKitSDK;
using static SplashKitSDK.SplashKit;

        // Open a new window with the title "Option Flip X" 
        Window window = OpenWindow("Option Flip X ", 600, 600);

        // Load a bitmap image named "Player" from the file "character.png"
        Bitmap bmp = LoadBitmap("Player", "character.png");

        // Draw the original bitmap image at position (100, 300) in the window
        DrawBitmap(bmp, 100, 300); 

        // Draw the bitmap image flipped horizontally at position (500, 300)
        DrawBitmap(bmp, 500, 300, OptionFlipX());

        // Refresh the screen to display the drawings
        RefreshScreen();

        // Wait for 5 seconds before closing the window
        Delay(5000);

        // Close all open windows
        CloseAllWindows();
 
