using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        new RectangleLinesApp().Run();
    }
}

public class RectangleLinesApp
{
    private Rectangle _myRectangle;
    private List<Line> _rectangleEdges;
    private List<Color> _normalColors;
    private List<Color> _hoverColors;
    private Point2D _mouse;
    private Line _edge;

    public void Run()
    {
        // Open the window using SplashKit.OpenWindow to match usage guide
        SplashKit.OpenWindow("Interactive Rectangle Edges", 800, 600);

        _myRectangle = SplashKit.RectangleFrom(250, 200, 300, 200);
        _rectangleEdges = SplashKit.LinesFrom(_myRectangle);

        _normalColors = new List<Color> { Color.Red, Color.LimeGreen, Color.Blue, Color.Orange };
        _hoverColors = new List<Color> { Color.White, Color.White, Color.White, Color.White };

        while (!SplashKit.WindowCloseRequested("Interactive Rectangle Edges"))
        {
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen(Color.DarkSlateGray);

            SplashKit.FillRectangle(Color.Black, _myRectangle.X, _myRectangle.Y, _myRectangle.Width, _myRectangle.Height);

            _mouse = SplashKit.MousePosition();

            for (int i = 0; i < _rectangleEdges.Count; i++)
            {
                _edge = _rectangleEdges[i];

                if (SplashKit.PointOnLine(_mouse, _edge))
                {
                    SplashKit.DrawLine(
                        _hoverColors[i],
                        _edge.StartPoint.X, _edge.StartPoint.Y,
                        _edge.EndPoint.X, _edge.EndPoint.Y
                    );
                }
                else
                {
                    SplashKit.DrawLine(_normalColors[i], _edge);
                }
            }

            SplashKit.RefreshScreen(60);
        }

        SplashKit.CloseAllWindows();
    }
}