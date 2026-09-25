using SplashKitSDK;

namespace MouseDownExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Mouse Drag Example", 800, 600);

            double circleX = 400;
            double circleY = 300;
            const double circleRadius = 50;

            bool dragging = false;
            bool wasMouseDown = false;

            double offsetX = 0;
            double offsetY = 0;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                Point2D mouse = SplashKit.MousePosition();
                bool leftMouseDown =
                    SplashKit.MouseDown(MouseButton.LeftButton);

                // Start dragging when the circle is pressed
                if (
                    !dragging &&
                    leftMouseDown &&
                    !wasMouseDown &&
                    SplashKit.PointInCircle(
                        mouse,
                        SplashKit.CircleAt(
                            circleX,
                            circleY,
                            circleRadius
                        )
                    )
                )
                {
                    dragging = true;

                    offsetX = circleX - mouse.X;
                    offsetY = circleY - mouse.Y;
                }

                // Move the circle while dragging
                if (dragging && leftMouseDown)
                {
                    circleX = mouse.X + offsetX;
                    circleY = mouse.Y + offsetY;
                }

                // Stop dragging when released
                if (!leftMouseDown)
                {
                    dragging = false;
                }

                wasMouseDown = leftMouseDown;

                SplashKit.ClearScreen(SplashKit.ColorWhite());

                if (dragging)
                {
                    SplashKit.FillCircle(
                        SplashKit.ColorRed(),
                        circleX,
                        circleY,
                        circleRadius
                    );
                }
                else
                {
                    SplashKit.FillCircle(
                        SplashKit.ColorBlue(),
                        circleX,
                        circleY,
                        circleRadius
                    );
                }

                SplashKit.DrawText(
                    "Click and drag the circle",
                    SplashKit.ColorBlack(),
                    20,
                    20
                );

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}