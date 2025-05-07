using SplashKitSDK;

SplashKit.OpenWindow("Magnetic Point", 600, 600);

Line line = SplashKit.LineFrom(100, 100, 500, 400);
Point2D mouse, closest;

while (!SplashKit.QuitRequested())
{
    SplashKit.ProcessEvents();
    mouse = SplashKit.MousePosition();
    closest = SplashKit.ClosestPointOnLine(mouse, line);

    SplashKit.ClearScreen(Color.White);
    SplashKit.DrawLine(Color.Black, line);
    SplashKit.FillCircle(Color.Blue, mouse.X, mouse.Y, 5);
    SplashKit.FillCircle(Color.Red, closest.X, closest.Y, 5);
    SplashKit.DrawLine(Color.Gray, mouse.X, mouse.Y, closest.X, closest.Y);
    SplashKit.DrawText("Mouse: " + mouse.ToString(), Color.Black, 20, 520);
    SplashKit.DrawText("Closest: " + closest.ToString(), Color.Red, 20, 540);

    SplashKit.RefreshScreen();
}

SplashKit.CloseAllWindows();


