using SplashKitSDK;


namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            const int SPEED = 3;
            const int PLAYER_RADIUS = 50;

            List<Circle> circles = new List<Circle>();
            circles.Add(SplashKit.CircleAt(150, 150, 130));
            circles.Add(SplashKit.CircleAt(450, 150, 130));
            circles.Add(SplashKit.CircleAt(150, 450, 130));
            circles.Add(SplashKit.CircleAt(450, 450, 130));

            Circle player_circle = SplashKit.CircleAt(300, 300, PLAYER_RADIUS);
            SplashKit.OpenWindow("Intersecting Circles?", 600, 600);
            while(!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyDown(KeyCode.LeftKey) && SplashKit.CircleX(player_circle) > PLAYER_RADIUS)
                {
                    float val = SplashKit.CircleX(player_circle) - SPEED;
                    player_circle = SplashKit.CircleAt(val, SplashKit.CircleY(player_circle), PLAYER_RADIUS);
                }
                if (SplashKit.KeyDown(KeyCode.RightKey)&& SplashKit.CircleX(player_circle) > PLAYER_RADIUS)
                {
                    float val = SplashKit.CircleX(player_circle) + SPEED;
                    player_circle = SplashKit.CircleAt(val, SplashKit.CircleY(player_circle), PLAYER_RADIUS);
                }
                if (SplashKit.KeyDown(KeyCode.DownKey)&& SplashKit.CircleY(player_circle) > PLAYER_RADIUS)
                {
                    float val = SplashKit.CircleY(player_circle) + SPEED;
                    player_circle = SplashKit.CircleAt(SplashKit.CircleX(player_circle), val, PLAYER_RADIUS);
                }
                if (SplashKit.KeyDown(KeyCode.UpKey)&& SplashKit.CircleY(player_circle) > PLAYER_RADIUS)
                {
                    float val = SplashKit.CircleY(player_circle) - SPEED;
                    player_circle = SplashKit.CircleAt(SplashKit.CircleX(player_circle), val, PLAYER_RADIUS);
                }

                SplashKit.ClearScreen(SplashKit.ColorWhite());
                for (int i = 0; i < 4; i++)
                {
                    // Check if the player circle has intersected any other circles
                    if (SplashKit.CirclesIntersect(player_circle, circles[i]))
                    {
                        SplashKit.FillCircle(SplashKit.ColorRed(), circles[i]);
                    }
                    else
                    {
                        SplashKit.DrawCircle(SplashKit.ColorRed(), circles[i]);
                    }
                }
                SplashKit.FillCircle(SplashKit.ColorBlue(), player_circle);
                SplashKit.Delay(60);
                SplashKit.RefreshScreen();
            }
        }
    }
}