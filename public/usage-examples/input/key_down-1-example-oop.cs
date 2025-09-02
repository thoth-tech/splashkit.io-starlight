using SplashKitSDK;

class Program
{
    static void Main(string[] args)
    {
        // Open a window
        SplashKit.OpenWindow("Key Down Example", 800, 600);
        
        SplashKit.WriteLine("Key Down Example");
        SplashKit.WriteLine("Press and hold keys to see their state");
        SplashKit.WriteLine("Press ESC to exit");
        
        while (!SplashKit.WindowCloseRequested("Key Down Example"))
        {
            // Clear the screen
            SplashKit.ClearScreen(Color.White);
            
            // Check various keys and display their state
            if (SplashKit.KeyDown(KeyCode.SpaceKey))
            {
                SplashKit.FillCircle(Color.Red, 200, 200, 50);
                SplashKit.DrawText("SPACE - PRESSED", Color.Red, 50, 50);
            }
            else
            {
                SplashKit.DrawCircle(Color.Gray, 200, 200, 50);
                SplashKit.DrawText("SPACE - Released", Color.Gray, 50, 50);
            }
            
            if (SplashKit.KeyDown(KeyCode.LeftKey))
            {
                SplashKit.FillCircle(Color.Blue, 400, 200, 50);
                SplashKit.DrawText("LEFT - PRESSED", Color.Blue, 50, 100);
            }
            else
            {
                SplashKit.DrawCircle(Color.Gray, 400, 200, 50);
                SplashKit.DrawText("LEFT - Released", Color.Gray, 50, 100);
            }
            
            if (SplashKit.KeyDown(KeyCode.RightKey))
            {
                SplashKit.FillCircle(Color.Green, 600, 200, 50);
                SplashKit.DrawText("RIGHT - PRESSED", Color.Green, 50, 150);
            }
            else
            {
                SplashKit.DrawCircle(Color.Gray, 600, 200, 50);
                SplashKit.DrawText("RIGHT - Released", Color.Gray, 50, 150);
            }
            
            if (SplashKit.KeyDown(KeyCode.UpKey))
            {
                SplashKit.FillCircle(Color.Orange, 300, 350, 50);
                SplashKit.DrawText("UP - PRESSED", Color.Orange, 50, 200);
            }
            else
            {
                SplashKit.DrawCircle(Color.Gray, 300, 350, 50);
                SplashKit.DrawText("UP - Released", Color.Gray, 50, 200);
            }
            
            if (SplashKit.KeyDown(KeyCode.DownKey))
            {
                SplashKit.FillCircle(Color.Purple, 500, 350, 50);
                SplashKit.DrawText("DOWN - PRESSED", Color.Purple, 50, 250);
            }
            else
            {
                SplashKit.DrawCircle(Color.Gray, 500, 350, 50);
                SplashKit.DrawText("DOWN - Released", Color.Gray, 50, 250);
            }
            
            // Instructions
            SplashKit.DrawText("Hold down arrow keys and space to see changes", Color.Black, 50, 500);
            
            // Refresh the screen
            SplashKit.RefreshScreen();
            
            // Process events
            SplashKit.ProcessEvents();
            
            // Small delay
            SplashKit.Delay(16);
        }
    }
} 