program MoveCameraToExample;
uses
  SplashKit;

var
  PlayerBmp: Bitmap;
  Player: Sprite;
  TargetX, TargetY: Double;

begin
  // Open a window
  OpenWindow('Move Camera To Example', 800, 600);

  // Create a player bitmap and sprite
  PlayerBmp := CreateBitmap('player', 40, 40);
  ClearBitmap(PlayerBmp, ColorBrightGreen());
  Player := CreateSprite(PlayerBmp);

  // Position the player further out in the game world
  SpriteSetX(Player, 1000);
  SpriteSetY(Player, 1000);

  while not QuitRequested() do
  begin
    // Handle input to move the player
    ProcessEvents();

    if KeyDown(LeftKey) then SpriteSetX(Player, SpriteX(Player) - 5);
    if KeyDown(RightKey) then SpriteSetX(Player, SpriteX(Player) + 5);
    if KeyDown(UpKey) then SpriteSetY(Player, SpriteY(Player) - 5);
    if KeyDown(DownKey) then SpriteSetY(Player, SpriteY(Player) + 5);

    // Center camera on player when SPACE is pressed
    if KeyTyped(SpaceKey) then
    begin
      // Calculate the top-left position for the camera to center the player
      TargetX := SpriteX(Player) + SpriteWidth(Player) / 2 - ScreenWidth() / 2;
      TargetY := SpriteY(Player) + SpriteHeight(Player) / 2 - ScreenHeight() / 2;
      
      // Move the camera to the calculated point
      MoveCameraTo(TargetX, TargetY);
    end;

    // Reset camera to origin when M is pressed
    if KeyTyped(MKey) then
    begin
      MoveCameraTo(0, 0);
    end;

    // Clear the screen
    ClearScreen(ColorBlack());

    // Draw some world markers to visualize the camera move
    FillRectangle(ColorWhite(), 0, 0, 20, 20);
    DrawText('World (0,0)', ColorWhite(), 5, 25);

    FillRectangle(ColorRed(), 1000, 1000, 20, 20);
    DrawText('World (1000,1000)', ColorRed(), 1000, 1025);

    // Draw the sprite (automatically uses camera offset)
    DrawSprite(Player);

    // Draw HUD (Heads-Up Display) directly to the screen
    FillRectangle(ColorDimGray(), 0, 0, 260, 80, OptionToScreen());
    DrawText('Camera Position: ' + PointToString(CameraPosition()), ColorWhite(), 10, 10, OptionToScreen());
    DrawText('Player World Pos: (' + FloatToStr(SpriteX(Player)) + ', ' + FloatToStr(SpriteY(Player)) + ')', ColorWhite(), 10, 30, OptionToScreen());
    DrawText('Press SPACE to center on player', ColorWhite(), 10, 50, OptionToScreen());
    DrawText('Press M to move camera to (0,0)', ColorWhite(), 10, 65, OptionToScreen());

    RefreshScreen(60);
  end;

  CloseAllWindows();
end.
