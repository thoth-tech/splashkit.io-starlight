using static SplashKitSDK.SplashKit;
using SplashKitSDK;

        // Open a window with the title "Pop Clip" and dimensions 800x600
        Window window = OpenWindow("Pop Clip", 800, 600);

        // Define a rectangle for the clipping area starting at (100, 100) with width 600 and height 400
        Rectangle rectangle = RectangleFrom(100, 100, 600, 400);

        // Push a clipping area to restrict drawing to within the defined rectangle
        PushClip(window, rectangle);

        // Draw a blue rectangle within the clipping area (this will be affected by clipping)
        FillRectangle(Color.Blue, 50, 50, 700, 500);  // This will be clipped

        // Pop the clipping area to restore the full window area for drawing
        PopClip(window);

        // Draw a red rectangle outside the clipping area (this will be fully visible)
        FillRectangle(Color.Red, 100, 100, 200, 200);  // This won't be clipped

        // Refresh the screen to display all changes
        RefreshScreen();

        // Wait for 5 seconds before closing the window
        Delay(5000);

        // Close all open windows to end the program
        CloseAllWindows();


