using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        new CircleQuadChecker().Run();
    }
}

public class CircleQuadChecker
{
    private Quad _quad;
    private Color _quadColor;
    private string _message;
    private Circle _mouseCircle;

    public CircleQuadChecker()
    {
        SplashKit.OpenWindow("Is the Circle inside the Quad?", 800, 600);

        // Define a non-rectangular quad using coordinates
        _quad = SplashKit.QuadFrom(
            300, 100,   // top-left
            500, 200,   // top-right
            200, 400,   // bottom-left
            600, 500    // bottom-right
        );
    }

    public void Run()
    {
        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();

            // Create a circle at the current mouse position
            _mouseCircle = SplashKit.CircleAt(SplashKit.MouseX(), SplashKit.MouseY(), 30);

            // Check intersection and update color and message
            if (SplashKit.CircleQuadIntersect(_mouseCircle, _quad))
            {
                _quadColor = Color.Green;
                _message = "Yes, it is!";
            }
            else
            {
                _quadColor = Color.Red;
                _message = "No, it isn't...";
            }

            // Clear screen and draw the scene
            SplashKit.ClearScreen(Color.White);
            SplashKit.FillQuad(_quadColor, _quad);
            SplashKit.DrawText(_message, Color.Black, 330, 300);
            SplashKit.DrawCircle(Color.Black, _mouseCircle);
            SplashKit.RefreshScreen();
        }

        SplashKit.CloseAllWindows();
    }
}