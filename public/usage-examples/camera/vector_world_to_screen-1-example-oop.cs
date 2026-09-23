using SplashKitSDK;

namespace VectorWorldToScreenExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow(
                "World Point to Screen Position",
                800,
                600
            );

            // Position the camera away from the origin so the translation is visible.
            SplashKit.MoveCameraTo(150, 100);

            Point2D worldPoint = SplashKit.PointAt(500, 350);
            Vector2D worldToScreen = SplashKit.VectorWorldToScreen();

            // Apply the returned vector to map the world point onto the screen.
            Point2D screenPoint = SplashKit.PointAt(
                worldPoint.X + worldToScreen.X,
                worldPoint.Y + worldToScreen.Y
            );

            DrawingOptions screenOptions = SplashKit.OptionToScreen();

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                // Draw the world point normally so it is affected by the camera.
                SplashKit.FillCircle(
                    Color.Blue,
                    worldPoint.X,
                    worldPoint.Y,
                    30
                );

                // Draw the calculated screen point without applying the camera again.
                SplashKit.DrawCircle(
                    Color.Red,
                    screenPoint.X,
                    screenPoint.Y,
                    40,
                    screenOptions
                );

                SplashKit.DrawText(
                    "Vector World To Screen",
                    Color.Black,
                    20,
                    20,
                    screenOptions
                );

                SplashKit.DrawText(
                    "Camera position: (150, 100)",
                    Color.Black,
                    20,
                    55,
                    screenOptions
                );

                SplashKit.DrawText(
                    "World point: " + SplashKit.PointToString(worldPoint),
                    Color.Black,
                    20,
                    85,
                    screenOptions
                );

                SplashKit.DrawText(
                    "Translation vector: "
                        + SplashKit.VectorToString(worldToScreen),
                    Color.Black,
                    20,
                    115,
                    screenOptions
                );

                SplashKit.DrawText(
                    "Calculated screen point: "
                        + SplashKit.PointToString(screenPoint),
                    Color.Black,
                    20,
                    145,
                    screenOptions
                );

                SplashKit.DrawText(
                    "The matching circles confirm the coordinate conversion.",
                    Color.Black,
                    20,
                    175,
                    screenOptions
                );

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}