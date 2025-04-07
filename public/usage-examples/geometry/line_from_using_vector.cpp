using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Open the window with the specified dimensions
        Window mainWindow = new Window("Vector Field Visualization", 800, 600);
        
        // Main loop to handle events and rendering
        while (!mainWindow.CloseRequested)
        {
            // Process user input events
            SplashKit.ProcessEvents();

            // Clear the screen to white
            SplashKit.ClearScreen(Color.White);

            // Drawing lines originating from grid points
            for (int x = 50; x < 800; x += 50)
            {
                for (int y = 50; y < 600; y += 50)
                {
                    // Define a vector (line) with small offsets as an example
                    Line l = SplashKit.LineFrom(x, y, x + 20, y + 10);
                    // Draw the line in blue
                    SplashKit.DrawLine(Color.Blue, l);
                }
            }

            // Refresh the screen to display the changes
            mainWindow.Refresh();
        }
    }
}
