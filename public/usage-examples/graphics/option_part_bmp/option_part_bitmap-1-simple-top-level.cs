using SplashKitSDK;
using static SplashKitSDK.SplashKit;

        // Open a new window with the title "Sprite Extraction" and dimensions 800x600
        Window window = OpenWindow("Sprite Extraction", 800, 600);
        // Load the bitmap from the file "sprite.png" and give it the name "Sprite"
        Bitmap bmp = LoadBitmap("Sprite", "sprite.png");

        // Draw a specific part of the bitmap onto the window at coordinates (100, 100)
        // The part drawn starts at (70, 90) in the bitmap and has a width and height of 200x200
        SplashKit.DrawBitmap(bmp, 100, 100, OptionPartBmp(70, 90, 200, 200));

        // Refresh the screen to display the changes
        RefreshScreen();

        // Pause the program for 5000 milliseconds (5 seconds)
        Delay(5000);

        // Close all open windows
        CloseAllWindows();
    

