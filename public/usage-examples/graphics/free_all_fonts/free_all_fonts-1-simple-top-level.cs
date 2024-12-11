using SplashKitSDK;
using static SplashKitSDK.SplashKit;

        // Open a new window with the title "Free All Front" and dimensions 800x600
        OpenWindow("Free All Front", 800, 600);

        // Load the "Arial" font from the file "arial.ttf"
        LoadFont("Arial", "arial.ttf");

        // Draw text using the "Arial" font with the color black at position (100, 100)
        DrawText("Old Theme", Color.Black, "Arial", 24, 100, 100);

        // Refresh the screen to display the text
        RefreshScreen();

        // Pause for 2000 milliseconds (2 seconds) to allow the text to be visible
        Delay(2000);

        // Free all loaded fonts to reset the theme
        FreeAllFonts();

        // Clear the screen to prepare for the new theme
        ClearScreen();

        // Load the "Verdana" font from the file "verdana.ttf"
        LoadFont("Verdana", "verdana.ttf");

        // Draw text using the "Verdana" font with the color blue at position (100, 100)
        DrawText("New Theme", Color.Blue, "Verdana", 24, 100, 100);

        // Refresh the screen to display the updated text
        RefreshScreen();

        // Pause for 3000 milliseconds (3 seconds) to allow the updated text to be visible
        Delay(3000);

        // Close all open windows
        CloseAllWindows();
