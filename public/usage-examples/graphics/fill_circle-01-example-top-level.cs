using SplashKitSDK;

new Window("Drawing Example", 800, 600);
while (!SplashKit.QuitRequested()) {
  SplashKit.ProcessEvents();
  SplashKit.ClearScreen(Color.White);
  SplashKit.FillCircle(Color.Blue, 400, 300, 50);
  SplashKit.FillRectangle(Color.Red, 100, 100, 150, 80);
  SplashKit.DrawLine(Color.Green, 50, 50, 750, 550);
  SplashKit.RefreshScreen();
}
