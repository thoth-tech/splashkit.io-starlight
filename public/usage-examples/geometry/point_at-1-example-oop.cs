using SplashKitSDK;

class Program
{
    static void Main(string[] args)
    {
        // Open a window
        SplashKit.OpenWindow("Point At Example", 800, 600);
        
        // Create various points using point_at function
        Point2D center = SplashKit.PointAt(400, 300);
        Point2D topLeft = SplashKit.PointAt(100, 100);
        Point2D topRight = SplashKit.PointAt(700, 100);
        Point2D bottomLeft = SplashKit.PointAt(100, 500);
        Point2D bottomRight = SplashKit.PointAt(700, 500);
        
        SplashKit.WriteLine("Point At Example");
        SplashKit.WriteLine("Creating and drawing points");
        SplashKit.WriteLine("Press any key to exit");
        
        while (!SplashKit.WindowCloseRequested("Point At Example"))
        {
            // Clear the screen
            SplashKit.ClearScreen(Color.White);
            
            // Draw the center point
            SplashKit.FillCircle(Color.Red, center, 10);
            SplashKit.DrawText("Center", Color.Black, center.X + 15, center.Y - 10);
            
            // Draw corner points
            SplashKit.FillCircle(Color.Blue, topLeft, 8);
            SplashKit.DrawText("Top Left", Color.Black, topLeft.X + 15, topLeft.Y - 10);
            
            SplashKit.FillCircle(Color.Green, topRight, 8);
            SplashKit.DrawText("Top Right", Color.Black, topRight.X - 60, topRight.Y - 10);
            
            SplashKit.FillCircle(Color.Orange, bottomLeft, 8);
            SplashKit.DrawText("Bottom Left", Color.Black, bottomLeft.X + 15, bottomLeft.Y + 15);
            
            SplashKit.FillCircle(Color.Purple, bottomRight, 8);
            SplashKit.DrawText("Bottom Right", Color.Black, bottomRight.X - 70, bottomRight.Y + 15);
            
            // Draw lines connecting points
            SplashKit.DrawLine(Color.Gray, topLeft, topRight);
            SplashKit.DrawLine(Color.Gray, topRight, bottomRight);
            SplashKit.DrawLine(Color.Gray, bottomRight, bottomLeft);
            SplashKit.DrawLine(Color.Gray, bottomLeft, topLeft);
            
            // Refresh the screen
            SplashKit.RefreshScreen();
            
            // Process events
            SplashKit.ProcessEvents();
            
            // Small delay
            SplashKit.Delay(16);
        }
    }
}