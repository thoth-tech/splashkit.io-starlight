using SplashKitSDK;

namespace TriangleRectangleIntersectExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow(
                "Triangle Rectangle Intersect Example",
                800,
                600
            );

            double rectX = 300;
            double rectY = 220;
            double rectWidth = 200;
            double rectHeight = 160;

            Rectangle targetRect = SplashKit.RectangleFrom(
                rectX,
                rectY,
                rectWidth,
                rectHeight
            );

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                double mouseXPos = SplashKit.MouseX();
                double mouseYPos = SplashKit.MouseY();

                double x1 = mouseXPos;
                double y1 = mouseYPos - 60;

                double x2 = mouseXPos - 60;
                double y2 = mouseYPos + 50;

                double x3 = mouseXPos + 60;
                double y3 = mouseYPos + 50;

                Triangle movingTriangle = SplashKit.TriangleFrom(
                    SplashKit.PointAt(x1, y1),
                    SplashKit.PointAt(x2, y2),
                    SplashKit.PointAt(x3, y3)
                );

                bool intersects = SplashKit.TriangleRectangleIntersect(
                    movingTriangle,
                    targetRect
                );

                SplashKit.ClearScreen(
                    SplashKit.ColorWhite()
                );

                SplashKit.FillRectangle(
                    SplashKit.ColorGray(),
                    rectX,
                    rectY,
                    rectWidth,
                    rectHeight
                );

                SplashKit.DrawRectangle(
                    SplashKit.ColorBlack(),
                    rectX,
                    rectY,
                    rectWidth,
                    rectHeight
                );

                if (intersects)
                {
                    SplashKit.FillTriangle(
                        SplashKit.ColorRed(),
                        x1,
                        y1,
                        x2,
                        y2,
                        x3,
                        y3
                    );
                }
                else
                {
                    SplashKit.FillTriangle(
                        SplashKit.ColorBlue(),
                        x1,
                        y1,
                        x2,
                        y2,
                        x3,
                        y3
                    );
                }

                SplashKit.DrawTriangle(
                    SplashKit.ColorBlack(),
                    x1,
                    y1,
                    x2,
                    y2,
                    x3,
                    y3
                );

                SplashKit.DrawText(
                    "Move the triangle with your mouse",
                    SplashKit.ColorBlack(),
                    230,
                    40
                );

                if (intersects)
                {
                    SplashKit.DrawText(
                        "Intersection detected!",
                        SplashKit.ColorRed(),
                        300,
                        520
                    );
                }
                else
                {
                    SplashKit.DrawText(
                        "No intersection",
                        SplashKit.ColorBlack(),
                        330,
                        520
                    );
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
