// Usage Example: draw_circle
// Shows the absolute minimum to demonstrate the function.
// Expected: opens a window and draws a blue circle, then exits.
// Docs: https://splashkit.io/api/graphics/draw_circle

using SplashKitSDK;

SplashKit.OpenWindow("Blue Circle", 200, 200);
SplashKit.DrawCircle(Color.Blue, 100, 100, 50);
SplashKit.RefreshScreen(60);
SplashKit.Delay(1500);