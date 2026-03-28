using SplashKitSDK;

namespace DisplayDialogExample
{
    public class Program
    {
        public static void Main()
        {
            // Open a window (some platforms require a window for dialogs)
            SplashKit.open_window("Dialog Demo", 400, 300);
            // Load a font from Resources/fonts (ensure arial.ttf exists)
            Font f = SplashKit.load_font("Custom", "arial.ttf");
            // Show dialog with custom font and size
            SplashKit.display_dialog("Hello!", "Custom font size demo", f, 28);
            // Close the window after a short delay
            SplashKit.delay(1200); SplashKit.close_all_windows();
        }
    }
}
