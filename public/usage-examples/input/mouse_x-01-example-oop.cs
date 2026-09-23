using SplashKitSDK;

public static class Program {
  public static void Main() {
    new Window("Mouse Example", 800, 600);
    while (!SplashKit.QuitRequested()) {
      SplashKit.ProcessEvents();
      SplashKit.ClearScreen(Color.White);
      SplashKit.DrawText("Mouse X: " + SplashKit.MouseX().ToString(), Color.Black, 20, 20);
      SplashKit.DrawText("Mouse Y: " + SplashKit.MouseY().ToString(), Color.Black, 20, 45);
      SplashKit.RefreshScreen();
    }
  }
}
