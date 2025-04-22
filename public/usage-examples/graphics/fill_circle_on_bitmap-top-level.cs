using SplashKitSDK;

Window window = new Window("Top Level Circle Drawer", 400, 400);
Bitmap surface = new Bitmap("surface", 400, 400);
surface.Clear(Color.Black);

Color mainColor = SplashKit.RGBAColor(180, 0, 0, 255);
surface.FillCircle(mainColor, 200, 200, 150);
surface.DrawCircle(Color.Red, 200, 200, 150);

for (int i = 0; i < 15; i++)
{
    float x = SplashKit.Rnd(100, 300);
    float y = SplashKit.Rnd(100, 300);
    float radius = SplashKit.Rnd(10, 30);
    surface.DrawCircle(Color.Red, x, y, radius);
}

while (!window.CloseRequested)
{
    SplashKit.ProcessEvents();
    window.Draw(surface, 0, 0);
    SplashKit.RefreshScreen();
}
