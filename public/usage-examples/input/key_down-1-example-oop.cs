 using SplashKitSDK;

namespace KeyDownExample
{
    public static class Program
    {
        public static void Main()
        {
            Window window = new Window("Live Key Press Display", 800, 400);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                bool spacePressed = SplashKit.KeyDown(KeyCode.SpaceKey);
                bool leftPressed = SplashKit.KeyDown(KeyCode.LeftKey);
                bool rightPressed = SplashKit.KeyDown(KeyCode.RightKey);
                bool upPressed = SplashKit.KeyDown(KeyCode.UpKey);
                bool downPressed = SplashKit.KeyDown(KeyCode.DownKey);

                window.Clear(Color.White);

                window.DrawText("Hold the keys to see their current state.", Color.Black, 20, 20);

                DrawKeyState(window, "Space", spacePressed, 20, 80);
                DrawKeyState(window, "Left", leftPressed, 20, 130);
                DrawKeyState(window, "Right", rightPressed, 20, 180);
                DrawKeyState(window, "Up", upPressed, 20, 230);
                DrawKeyState(window, "Down", downPressed, 20, 280);

                window.Refresh(60);
            }

            SplashKit.CloseAllWindows();
        }

        public static void DrawKeyState(Window window, string keyName, bool isPressed, double x, double y)
        {
            Color circleColor;

            if (isPressed)
            {
                circleColor = Color.Green;
            }
            else
            {
                circleColor = Color.Gray;
            }

            window.FillCircle(circleColor, x + 15, y + 15, 15);
            window.DrawCircle(Color.Black, x + 15, y + 15, 15);

            if (isPressed)
            {
                window.DrawText(keyName + ": Pressed", Color.Black, x + 40, y);
            }
            else
            {
                window.DrawText(keyName + ": Released", Color.Black, x + 40, y);
            }
        }
    }
}
