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
    private Window window;
    private Point2D p1, p2, p3, p4;
    private Quad fixedQuad;
    private float radius = 30;

    // Declare reusable variables outside the loop
    private Point2D mouse;
    private Circle mouseCircle;
    private bool isIntersecting;
    private Color fillColor;

    public CircleQuadIntersectionApp()
    {
        window = SplashKit.OpenWindow("Mouse Circle Overlapping Quad", 800, 600);

        p1 = SplashKit.PointAt(300, 200);
        p2 = SplashKit.PointAt(500, 200);
        p3 = SplashKit.PointAt(500, 400);
        p4 = SplashKit.PointAt(300, 400);

        fixedQuad = SplashKit.QuadFrom(p1, p2, p3, p4);
    }

    public void Run()
    {
        while (!window.CloseRequested)
        {
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen(Color.DarkSlateGray);

            mouse = SplashKit.MousePosition();
            mouseCircle = SplashKit.CircleAt(mouse.X, mouse.Y, radius);

            // Detects if the mouse-controlled circle intersects the quad using SplashKit's geometry function
            isIntersecting = SplashKit.CircleQuadIntersect(mouseCircle, fixedQuad);

            fillColor = isIntersecting ? Color.Red : Color.Green;

            SplashKit.FillTriangle(fillColor, p1.X, p1.Y, p2.X, p2.Y, p3.X, p3.Y);
            SplashKit.FillTriangle(fillColor, p1.X, p1.Y, p4.X, p4.Y, p3.X, p3.Y);

            SplashKit.DrawCircle(Color.White, mouseCircle);
            SplashKit.RefreshScreen(60);
        }
    }
}