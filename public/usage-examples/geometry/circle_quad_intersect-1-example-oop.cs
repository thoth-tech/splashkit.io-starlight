using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        new CircleQuadIntersectionApp().Run();
    }
}

public class CircleQuadIntersectionApp
{
    private string _windowName = "Mouse Circle vs Rectangle Area";

    // Points defining the corners of the quad
    private Point2D _topLeft;
    private Point2D _topRight;
    private Point2D _bottomRight;
    private Point2D _bottomLeft;
    private Quad _quad;
    private float _radius = 30;
    private Point2D _mousePos;
    private Circle _mouseCircle;
    private bool _isIntersecting;
    private Color _fillColor;

    public CircleQuadIntersectionApp()
    {
        SplashKit.OpenWindow(_windowName, 800, 600);

        // Define each corner of the rectangular quad
        _topLeft = SplashKit.PointAt(300, 200);
        _topRight = SplashKit.PointAt(500, 200);
        _bottomRight = SplashKit.PointAt(500, 400);
        _bottomLeft = SplashKit.PointAt(300, 400);

        // Create the quad from the corner points
        _quad = SplashKit.QuadFrom(_topLeft, _topRight, _bottomRight, _bottomLeft);
    }

    public void Run()
    {
        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen(Color.White);

            _mousePos = SplashKit.MousePosition();
            _mouseCircle = SplashKit.CircleAt(_mousePos.X, _mousePos.Y, _radius);

            // Check if the circle intersects the quad
            _isIntersecting = SplashKit.CircleQuadIntersect(_mouseCircle, _quad);

            // Change the quad’s color based on whether an intersection is occurring
            if (_isIntersecting)
            {
                _fillColor = Color.Red;
            }
            else
            {
                _fillColor = Color.Green;
            }

            // Draw the quad using two triangles with the chosen color
            SplashKit.FillTriangle(_fillColor, _topLeft.X, _topLeft.Y, _topRight.X, _topRight.Y, _bottomRight.X, _bottomRight.Y);
            SplashKit.FillTriangle(_fillColor, _topLeft.X, _topLeft.Y, _bottomLeft.X, _bottomLeft.Y, _bottomRight.X, _bottomRight.Y);

            SplashKit.DrawCircle(Color.Black, _mouseCircle);

            SplashKit.RefreshScreen();
        }

        SplashKit.CloseAllWindows();
    }
}