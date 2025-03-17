using SplashKitSDK;

namespace TextHeightExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Text_Height", 680, 200);
            SplashKit.ClearScreen(Color.White);

            SplashKit.LoadFont("LOTR", "lotr.TTF");
            SplashKit.SetFontStyle("LOTR", FontStyle.BoldFont);
            SplashKit.DrawText("Ringbearer", Color.Black, "LOTR", 100, 30, 20);

            int height = SplashKit.TextHeight("Ringbearer", "LOTR", 100);
            SplashKit.FillRectangle(Color.Black, 20, 20, 10, height);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);
            SplashKit.CloseAllWindows();
        }
    }
}