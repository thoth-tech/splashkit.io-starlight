using SplashKitSDK;

namespace QuadsIntersectExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Quads Intersect", 800, 600);

            Quad fixedQuad = SplashKit.QuadFrom(
                500, 200,
                470, 380,
                300, 180,
                280, 350
            );

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                Point2D mouse = SplashKit.MousePosition();

                Quad movingQuad = SplashKit.QuadFrom(
                    mouse.X + 60, mouse.Y - 45,
                    mouse.X + 60, mouse.Y + 45,
                    mouse.X - 60, mouse.Y - 45,
                    mouse.X - 60, mouse.Y + 45
                );

                bool intersects = SplashKit.QuadsIntersect(
                    fixedQuad,
                    movingQuad
                );

                SplashKit.ClearScreen(SplashKit.ColorWhite());

                SplashKit.FillQuad(
                    SplashKit.ColorLightGray(),
                    fixedQuad
                );

                SplashKit.DrawQuad(
                    SplashKit.ColorBlack(),
                    fixedQuad
                );

                if (intersects)
                {
                    SplashKit.FillQuad(
                        SplashKit.ColorRed(),
                        movingQuad
                    );

                    SplashKit.DrawText(
                        "Quads intersect: TRUE",
                        SplashKit.ColorDarkRed(),
                        20,
                        20
                    );
                }
                else
                {
                    SplashKit.FillQuad(
                        SplashKit.ColorBlue(),
                        movingQuad
                    );

                    SplashKit.DrawText(
                        "Quads intersect: FALSE",
                        SplashKit.ColorBlack(),
                        20,
                        20
                    );
                }

                SplashKit.DrawQuad(
                    SplashKit.ColorBlack(),
                    movingQuad
                );

                SplashKit.DrawText(
                    "Move the mouse to test quad intersection",
                    SplashKit.ColorBlack(),
                    20,
                    550
                );

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
