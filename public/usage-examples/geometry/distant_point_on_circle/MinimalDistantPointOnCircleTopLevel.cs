// Usage Example: distant_point_on_circle
// Shows the minimum to compute and visualize the farthest point on a circle from a given point.
// Expected: opens a 220×220 window, draws a grey circle, a red source point, and a blue far point, then exits.
// Docs: https://splashkit.io/api/geometry/#distant-point-on-circle

using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Distant Point On Circle", 220, 220);
var c   = CircleAt(PointAt(110, 110), 70);
var pt  = PointAt(160, 120);
var far = DistantPointOnCircle(pt, c);

ClearScreen(ColorWhite());
DrawCircle(ColorGray(), c);
FillCircle(ColorRed(),  pt.X,  pt.Y,  4);
FillCircle(ColorBlue(), far.X, far.Y, 4);
RefreshScreen(60);
Delay(1500);