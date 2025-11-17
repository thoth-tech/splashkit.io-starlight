using SplashKitSDK;


class Program
{
    static void Main(string[] args)
    {
        // Open a window
        SplashKit.OpenWindow("Color Red Example", 800, 600);
        
        // Get the red color
        Color redColor = SplashKit.ColorRed();
        
        SplashKit.WriteLine("Color Red Example");
        SplashKit.WriteLine("Drawing shapes in red color");
        SplashKit.WriteLine("Press any key to exit");
        
        while (!SplashKit.WindowCloseRequested("Color Red Example"))
        {
            // Clear the screen to white
            SplashKit.ClearScreen(Color.White);
            
            // Draw a red circle
            SplashKit.FillCircle(redColor, 200, 200, 100);
            
            // Draw a red rectangle
            SplashKit.FillRectangle(redColor, 400, 150, 150, 100);
            
            // Draw a red triangle
            SplashKit.FillTriangle(redColor, 600, 300, 700, 200, 650, 400);
            
            // Draw red text
            SplashKit.DrawText("Red Color Example", redColor, 50, 50);
            
            // Refresh the screen
            SplashKit.RefreshScreen();
            
            // Process events
            SplashKit.ProcessEvents();
            
            // Small delay
            SplashKit.Delay(16);
        }
    }
} 