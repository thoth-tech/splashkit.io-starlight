using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window window = OpenWindow("Random Color", 800, 600);

// Store the original and current color
Color originalColor = RandomColor();
Color currentColor = originalColor;

            
    while (!WindowCloseRequested(window))
        {   
            ProcessEvents();
            // Left click: change to a new random color
            if (MouseClicked(MouseButton.LeftButton))
            {
                currentColor = RandomColor();
            }

            // Right click: return to original color
            if (MouseClicked(MouseButton.RightButton))
            {
                currentColor = originalColor;
            }
                ClearScreen(currentColor);
                RefreshScreen(60);
        }

CloseAllWindows();