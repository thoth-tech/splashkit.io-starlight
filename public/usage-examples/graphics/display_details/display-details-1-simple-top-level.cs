using SplashKitSDK;
using static SplashKitSDK.SplashKit;
        // Open a window
            OpenWindow("Display Detail", 800, 600);

       
        // Loop through all displays and print their details
            for (uint i = 0; i < NumberOfDisplays(); i++)
            {
                // Retrieve display details
                var display = DisplayDetails(i);

                // Write display details to the console
                
                DrawText($"  Name: {display.Name}", Color.Black, "Arial", 24, 100, 100);
                DrawText($"  Resolution: {display.Width} X {display.Height}", Color.Black, "Arial", 24, 100, 200);
                
            }
            // Keep the window open for 5 seconds
            RefreshScreen();
            Delay(3000);

            CloseAllWindows();

            // Close the window
            CloseAllWindows();
