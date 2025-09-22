using SplashKitSDK;

class Program
{
    static void Main(string[] args)
    {
        // Open a window
        SplashKit.OpenWindow("GPIO Check Example", 800, 600);
        
        SplashKit.WriteLine("GPIO Check Example");
        SplashKit.WriteLine("Checking GPIO availability");
        SplashKit.WriteLine("Press any key to exit");
        
        // Check if GPIO is available
        bool gpioAvailable = SplashKit.HasGPIO();
        
        while (!SplashKit.WindowCloseRequested("GPIO Check Example"))
        {
            // Clear the screen
            SplashKit.ClearScreen(Color.White);
            
            // Display GPIO information
            SplashKit.DrawText("GPIO Check Example", Color.Black, 50, 50);
            SplashKit.DrawText("Raspberry Pi GPIO Availability", Color.Black, 50, 100);
            
            if (gpioAvailable)
            {
                SplashKit.DrawText("GPIO Status: AVAILABLE", Color.Green, 50, 150);
                SplashKit.DrawText("GPIO is ready for use on this system", Color.Green, 70, 200);
                SplashKit.DrawText("You can control GPIO pins for hardware projects", Color.Green, 70, 230);
            }
            else
            {
                SplashKit.DrawText("GPIO Status: NOT AVAILABLE", Color.Red, 50, 150);
                SplashKit.DrawText("GPIO is not available on this system", Color.Red, 70, 200);
                SplashKit.DrawText("This is normal on non-Raspberry Pi systems", Color.Red, 70, 230);
            }
            
            // Additional information
            SplashKit.DrawText("GPIO (General Purpose Input/Output) allows you to:", Color.Black, 50, 300);
            SplashKit.DrawText("- Control LED lights", Color.Blue, 70, 330);
            SplashKit.DrawText("- Read button presses", Color.Blue, 70, 360);
            SplashKit.DrawText("- Control motors and servos", Color.Blue, 70, 390);
            SplashKit.DrawText("- Interface with sensors", Color.Blue, 70, 420);
            
            // Instructions
            SplashKit.DrawText("This example checks if GPIO hardware is available", Color.Black, 50, 500);
            SplashKit.DrawText("Press any key to exit", Color.Black, 50, 530);
            
            // Refresh the screen
            SplashKit.RefreshScreen();
            
            // Process events
            SplashKit.ProcessEvents();
            
            // Small delay
            SplashKit.Delay(16);
        }
    }
} 