using SplashKitSDK;

new Window("Sprite Example", 800, 600);
Bitmap bmp = SplashKit.LoadBitmap("player", "images/player.png");
Sprite player = SplashKit.CreateSprite(bmp);
while (!SplashKit.QuitRequested()) {
  SplashKit.ProcessEvents();
  SplashKit.ClearScreen(Color.White);
  SplashKit.DrawSprite(player);
  SplashKit.RefreshScreen();
}
