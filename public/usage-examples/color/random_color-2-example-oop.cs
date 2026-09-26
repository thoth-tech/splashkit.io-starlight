using SplashKitSDK;

public static class Program
{
    public static void Main()
    {
        new Window("Random Color Example", 800, 600);

        Color boxColor = Color.Blue;

        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();

            if (SplashKit.MouseClicked(MouseButton.LeftButton))
            {
                boxColor = SplashKit.RandomColor();
            }

            SplashKit.ClearScreen(Color.White);

            SplashKit.FillRectangle(
                boxColor,
                250,
                200,
                300,
                180
            );

            SplashKit.DrawText(
                "Click anywhere to change colour",
                Color.Black,
                220,
                420
            );

            SplashKit.RefreshScreen();
        }
    }
}