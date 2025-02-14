using static SplashKitSDK.SplashKit;
using SplashKitSDK;

        // Open a window with the title "Set Clip" and dimensions 800x600
        Window window = OpenWindow("Set Clip", 800, 600);

        // Define a rectangle that will be used as the clipping area
        Rectangle rectangle = RectangleFrom(100, 100, 600, 400);

        // Push a clipping area onto the window
        SetClip(window, rectangle);

        // Draw a blue rectangle that will be clipped by the clipping area
        FillRectangle(Color.Blue, 50, 50, 700, 500);  // This will be clipped

        // Refresh the screen to display the drawing
        RefreshScreen();
        Delay(5000);  // Wait for 5 seconds to view the result

        // Close the window
        CloseAllWindows();

