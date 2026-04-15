// c# oop: least common multiple demo
using SplashKitSDK;

class App
{
    public void Run()
    {
        SplashKit.OpenWindow("Least Common Multiple Demo", 640, 400);

        int num1 = 12, num2 = 18;

        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();

            // controls
            if (SplashKit.KeyTyped(KeyCode.UpKey))    num1++;
            if (SplashKit.KeyTyped(KeyCode.DownKey))  num1 = (num1 > 1) ? num1 - 1 : 1;
            if (SplashKit.KeyTyped(KeyCode.RightKey)) num2++;
            if (SplashKit.KeyTyped(KeyCode.LeftKey))  num2 = (num2 > 1) ? num2 - 1 : 1;
            if (SplashKit.KeyTyped(KeyCode.RKey))     { num1 = 12; num2 = 18; }

            int result = SplashKit.LeastCommonMultiple(num1, num2);

            SplashKit.ClearScreen(Color.White);

            // title
            SplashKit.DrawText("LCM CALCULATOR", Color.Blue, "arial", 28, 190, 40);

            // numbers
            SplashKit.DrawText("Number 1: " + num1, Color.Black, "arial", 22, 180, 140);
            SplashKit.DrawText("Number 2: " + num2, Color.Black, "arial", 22, 180, 180);

            // result
            SplashKit.DrawText("LCM: " + result, Color.Red, "arial", 24, 180, 230);

            // instructions
            SplashKit.DrawText(
                "Controls: UP/DOWN for Number 1,  LEFT/RIGHT for Number 2,  R = reset",
                Color.Gray, "arial", 16, 40, 330
            );

            SplashKit.RefreshScreen();
        }

        SplashKit.CloseAllWindows();
    }
}

class Program
{
    static void Main() => new App().Run();
}
