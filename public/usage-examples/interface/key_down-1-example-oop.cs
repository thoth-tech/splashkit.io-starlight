using SplashKitSDK;

public class Program
{
    static void DrawKeyStatus(string label, KeyCode key, double x, double y)
    {
        // Check whether the selected key is currently pressed
        bool pressed = SplashKit.KeyDown(key);
        Color indicator = pressed ? Color.Green : Color.Gray;
        string state = pressed ? "Pressed" : "Released";

        // Draw the key status indicator and label
        SplashKit.FillCircle(indicator, x, y, 25);
        SplashKit.DrawText(label + ": " + state, Color.Black, x + 40, y - 10);
    }

    public static void Main()
    {
        // Open the window for the usage example
        SplashKit.OpenWindow("Keyboard State Display", 800, 400);

        while (!SplashKit.WindowCloseRequested("Keyboard State Display"))
        {
            SplashKit.ProcessEvents();

            // Draw the background and instructions
            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawText("Press the arrow keys or space bar to see their current state.", Color.Black, 120, 40);

            // Draw the live status of each selected key
            DrawKeyStatus("Left", KeyCode.LeftKey, 120, 130);
            DrawKeyStatus("Right", KeyCode.RightKey, 120, 190);
            DrawKeyStatus("Up", KeyCode.UpKey, 120, 250);
            DrawKeyStatus("Down", KeyCode.DownKey, 120, 310);
            DrawKeyStatus("Space", KeyCode.SpaceKey, 500, 220);

            SplashKit.RefreshScreen(60);
        }
    }
}