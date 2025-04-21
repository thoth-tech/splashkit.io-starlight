using SplashKitSDK;

namespace AvoidObstacleOOP
{
    public class CircleObject
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Radius { get; }

        public CircleObject(float x, float y, float radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public void Draw(Color color)
        {
            SplashKit.FillCircle(color, X, Y, Radius);
        }

        public bool Intersects(CircleObject other)
        {
            return SplashKit.CirclesIntersect(X, Y, Radius, other.X, other.Y, other.Radius);
        }
    }

    public class Obstacle : CircleObject
    {
        private float _speedX;
        private float _speedY;
        private readonly float _windowWidth;
        private readonly float _windowHeight;

        public Obstacle(
            float x,
            float y,
            float radius,
            float speedX,
            float speedY,
            float windowWidth,
            float windowHeight
        )
            : base(x, y, radius)
        {
            _speedX = speedX;
            _speedY = speedY;
            _windowWidth = windowWidth;
            _windowHeight = windowHeight;
        }

        public void Update()
        {
            X += _speedX;
            Y += _speedY;

            // Bounce off edges
            if (X - Radius < 0 || X + Radius > _windowWidth)
                _speedX *= -1;
            if (Y - Radius < 0 || Y + Radius > _windowHeight)
                _speedY *= -1;
        }
    }

    public class Game
    {
        private const int WindowWidth = 600;
        private const int WindowHeight = 400;
        private const float PlayerSpeed = 0.5f;

        private Window _window;
        private CircleObject _player;
        private Obstacle _obstacle;

        public Game()
        {
            _window = new Window("Avoid the Obstacle", WindowWidth, WindowHeight);
            _player = new CircleObject(300, 200, 30);
            _obstacle = new Obstacle(100, 100, 30, 0.3f, 0.3f, WindowWidth, WindowHeight);
        }

        public void Run()
        {
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                HandleInput();
                _obstacle.Update();

                if (_player.Intersects(_obstacle))
                    SplashKit.ClearScreen(Color.Red);
                else
                    SplashKit.ClearScreen(Color.White);

                _player.Draw(Color.Blue);
                _obstacle.Draw(Color.Red);

                SplashKit.RefreshScreen();
                SplashKit.Delay(10);
            }

            _window.Close();
        }

        private void HandleInput()
        {
            if (SplashKit.KeyDown(KeyCode.UpKey))
                _player.Y -= PlayerSpeed;
            if (SplashKit.KeyDown(KeyCode.DownKey))
                _player.Y += PlayerSpeed;
            if (SplashKit.KeyDown(KeyCode.LeftKey))
                _player.X -= PlayerSpeed;
            if (SplashKit.KeyDown(KeyCode.RightKey))
                _player.X += PlayerSpeed;

            // Soft screen boundaries
            _player.X = Math.Clamp(_player.X, _player.Radius, WindowWidth - _player.Radius);
            _player.Y = Math.Clamp(_player.Y, _player.Radius, WindowHeight - _player.Radius);
        }
    }

    public static class Program
    {
        public static void Main()
        {
            Game game = new Game();
            game.Run();
        }
    }
}
