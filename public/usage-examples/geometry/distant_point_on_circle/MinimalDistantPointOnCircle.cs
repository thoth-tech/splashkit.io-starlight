// Usage Example: distant_point_on_circle
// Shows the minimum to compute and visualize the farthest point on a circle from a given point.
// Expected: opens a 220×220 window, draws a grey circle, a red source point, and a blue far point, then exits.
// Docs: https://splashkit.io/api/geometry/#distant-point-on-circle

using SplashKitSDK;

class Program
{
    static void Main()
    {
        SplashKit.OpenWindow("Distant Point On Circle", 220, 220);
        var c   = SplashKit.CircleAt(SplashKit.PointAt(110, 110), 70);
        var pt  = SplashKit.PointAt(160, 120);
        var far = SplashKit.DistantPointOnCircle(pt, c);

        SplashKit.ClearScreen(SplashKit.ColorWhite());
        SplashKit.DrawCircle(SplashKit.ColorGray(), c);
        SplashKit.FillCircle(SplashKit.ColorRed(),  pt.X,  pt.Y,  4);
        SplashKit.FillCircle(SplashKit.ColorBlue(), far.X, far.Y, 4);
        SplashKit.RefreshScreen(60);
        SplashKit.Delay(1500);
    }
}
