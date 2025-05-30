using SplashKitSDK;

public class StayCloseToLineGame
{
    private Window _window;
    private Point2D _lineStart;
    private Point2D _lineEnd;
    private Line _pathLine;
    private Point2D _player;
    private double _maxDistance;

    public StayCloseToLineGame()
    {
        // Open a window for the game
        _window = SplashKit.OpenWindow("Stay Close to the Line", 800, 600);

        // Define the line
        _lineStart = SplashKit.PointAt(100, 300);
        _lineEnd = SplashKit.PointAt(700, 300);
        _pathLine = SplashKit.LineFrom(_lineStart, _lineEnd);

        // Define the player point
        _player = SplashKit.PointAt(400, 300);

        // Set the maximum allowed distance from the line
        _maxDistance = 50;
    }

    public void Run()
    {
        while (!_window.CloseRequested)
        {
            SplashKit.ProcessEvents();
            HandlePlayerMovement();

            if (CheckGameOver())
                break;

            Draw();
        }

        _window.Close();
    }

    private void HandlePlayerMovement()
    {
        if (SplashKit.KeyDown(KeyCode.UpKey)) _player.Y -= 5;
        if (SplashKit.KeyDown(KeyCode.DownKey)) _player.Y += 5;
        if (SplashKit.KeyDown(KeyCode.LeftKey)) _player.X -= 5;
        if (SplashKit.KeyDown(KeyCode.RightKey)) _player.X += 5;
    }

    private bool CheckGameOver()
    {
        double distance = SplashKit.PointLineDistance(_player, _pathLine);

        if (distance > _maxDistance)
        {
            SplashKit.DrawText("Game Over - Too Far from the Line", Color.Red, 200, 50);
            SplashKit.RefreshScreen();
            SplashKit.Delay(2000);
            return true;
        }

        return false;
    }

    private void Draw()
    {
        SplashKit.ClearScreen(Color.White);
        SplashKit.DrawLine(Color.Black, _lineStart, _lineEnd);
        
        // Corrected this line to use CircleAt
        SplashKit.FillCircle(Color.Green, SplashKit.CircleAt(_player, 5));
        
        SplashKit.RefreshScreen(60);
    }
}

public static class Program
{
    public static void Main()
    {
        StayCloseToLineGame game = new StayCloseToLineGame();
        game.Run();
    }
}