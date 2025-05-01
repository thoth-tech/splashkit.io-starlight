using SplashKitSDK;

public class Player
{
    private Sprite _currentSprite;
    private string _loadedSprite;

    public Player()
    {
        _loadedSprite = "";
        Load("player1", "player1.png");
    }

    public void Load(string id, string filename)
    {
        if (_loadedSprite != id)
        {
            SplashKit.FreeAllSprites();

            if (!SplashKit.HasBitmap(id))
            {
                SplashKit.LoadBitmap(id, filename);
            }

            _currentSprite = SplashKit.CreateSprite(SplashKit.BitmapNamed(id));
            SplashKit.SpriteSetPosition(_currentSprite, SplashKit.PointAt(400, 300));
            _loadedSprite = id;
        }
    }

    public void HandleInput()
    {
        Vector2D velocity = SplashKit.VectorTo(0, 0);

        if (SplashKit.KeyDown(KeyCode.UpKey)) velocity.Y = -3;
        if (SplashKit.KeyDown(KeyCode.DownKey)) velocity.Y = 3;
        if (SplashKit.KeyDown(KeyCode.LeftKey)) velocity.X = -3;
        if (SplashKit.KeyDown(KeyCode.RightKey)) velocity.X = 3;

        SplashKit.SpriteSetVelocity(_currentSprite, velocity);

        if (SplashKit.KeyTyped(KeyCode.Num1Key)) Load("player1", "player1.png");
        if (SplashKit.KeyTyped(KeyCode.Num2Key)) Load("player2", "player2.png");
    }

    public void Update()
    {
        SplashKit.UpdateSprite(_currentSprite);
        SplashKit.MoveSprite(_currentSprite);
    }

    public void Draw()
    {
        SplashKit.DrawSprite(_currentSprite);
    }
}

public class Program
{
    public static void Main()
    {
        Window window = SplashKit.OpenWindow("Sprite Switcher", 800, 600);
        Player player = new Player();

        while (!SplashKit.WindowCloseRequested(window))
        {
            SplashKit.ProcessEvents();
            player.HandleInput();
            player.Update();

            SplashKit.ClearScreen(Color.White);
            player.Draw();
            SplashKit.DrawText("Use arrow keys to move. Press 1 or 2 to switch..", Color.Black, 10, 10);
            SplashKit.RefreshScreen(60);
        }
    }
}
