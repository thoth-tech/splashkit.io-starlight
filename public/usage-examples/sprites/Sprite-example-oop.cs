using SplashKitSDK;

public class Player
{
    private Sprite _sprite;
    private string _loadedId;

    public Player()
    {
        _loadedId = "";
        Load("player1", "player1.png");
    }

    public void Load(string id, string filename)
    {
        if (_loadedId != id)
        {
            SplashKit.FreeAllSprites();

            if (!SplashKit.HasBitmap(id))
                SplashKit.LoadBitmap(id, filename);

            _sprite = SplashKit.CreateSprite(SplashKit.BitmapNamed(id));
            _loadedId = id;

            float x = 800 / 2 - SplashKit.SpriteWidth(_sprite) / 2;
            float y = 600 / 2 - SplashKit.SpriteHeight(_sprite) / 2;
            SplashKit.SpriteSetPosition(_sprite, SplashKit.PointAt(x, y));
        }
    }

    public void HandleInput()
    {
        Vector2D velocity = SplashKit.VectorTo(0, 0);

        if (SplashKit.KeyDown(KeyCode.UpKey)) velocity.Y = -3;
        if (SplashKit.KeyDown(KeyCode.DownKey)) velocity.Y = 3;
        if (SplashKit.KeyDown(KeyCode.LeftKey)) velocity.X = -3;
        if (SplashKit.KeyDown(KeyCode.RightKey)) velocity.X = 3;

        SplashKit.SpriteSetVelocity(_sprite, velocity);

        if (SplashKit.KeyTyped(KeyCode.Num1Key))
            Load("player1", "player1.png");

        if (SplashKit.KeyTyped(KeyCode.Num2Key))
            Load("player2", "player2.png");
    }

    public void Update()
    {
        SplashKit.UpdateSprite(_sprite);
        SplashKit.MoveSprite(_sprite);
    }

    public void Draw()
    {
        SplashKit.DrawSprite(_sprite);
    }
}

public class Program
{
    public static void Main()
    {
        Window gameWindow = SplashKit.OpenWindow("Sprite Switcher", 800, 600);
        Player player = new Player();

        while (!SplashKit.WindowCloseRequested(gameWindow))
        {
            SplashKit.ProcessEvents();
            player.HandleInput();
            player.Update();

            SplashKit.ClearScreen(Color.White);
            player.Draw();
            SplashKit.DrawText("Use arrow keys to move. Press 1 or 2 to switch characters.", Color.Black, 10, 10);
            SplashKit.RefreshScreen(60);
        }
    }
}
