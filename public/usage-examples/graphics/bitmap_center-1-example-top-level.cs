using SplashKitSDK;
using System;

public class BitmapCenterApp
{
    private Window _window;
    private Bitmap _img;
    private Point2D _center;

    public BitmapCenterApp(string windowTitle, int width, int height)
    {
        // Initialize window
        _window = new Window(windowTitle, width, height);
    }

    public void LoadBitmap(string name, string filepath)
    {
        // Load bitmap with the specified name and file path
        _img = SplashKit.LoadBitmap(name, filepath);
        if (_img == null)
        {
            Console.WriteLine("Failed to load bitmap.");
            return;
        }
    }

    public void CalculateCenter()
    {
        // Get the center of the bitmap
        if (_img != null)
        {
            _center = SplashKit.BitmapCenter(_img);
        }
    }

    public void Draw()
    {
        if (_img == null) return;

        // Clear screen
        SplashKit.ClearScreen(Color.White);

        // Draw bitmap at its center
        SplashKit.DrawBitmap(_img, _center.X, _center.Y);

        // Refresh screen
        SplashKit.RefreshScreen();
    }

    public void Run()
    {
        // Main program loop
        while (!_window.CloseRequested)
        {
            SplashKit.ProcessEvents();

            // Draw the bitmap
            Draw();

            // Wait for 3 seconds or handle any other events
            SplashKit.Delay(3000);
        }
    }
}

class Program
{
    static void Main()
    {
        // Create application instance
        BitmapCenterApp app = new BitmapCenterApp("Bitmap Center Example", 1200, 800);

        // Load bitmap
        string bitmapPath = "D:/Academic deakin/trimester 05/SIT 378 Group Project//code -website/Bitmap center//Bitmap_center/obj/bitmap.png";
        app.LoadBitmap("example_bitmap", bitmapPath);

        // Calculate bitmap center
        app.CalculateCenter();

        // Run the application
        app.Run();
    }
}
