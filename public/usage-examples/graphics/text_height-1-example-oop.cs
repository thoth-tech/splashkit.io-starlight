using SplashKitSDK;

namespace TextHeightExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Text Height", 800, 600);

            Font textFont = SplashKit.FontNamed("Century.ttf");
            string textString = "Example text";
            //Change the below value to affect the text's height
            int textFontSize = 100;
            int height = SplashKit.TextHeight(textString, textFont, textFontSize);
            Line l = SplashKit.LineFrom(30, 200, 30, 200 + height);

            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawText(textString, Color.Black, textFont, textFontSize, 50, 200);
            SplashKit.DrawLine(Color.Black, l);
            SplashKit.FillTriangle(Color.Black, l.StartPoint.X, l.StartPoint.Y, l.StartPoint.X - 7, l.StartPoint.Y + 7, l.StartPoint.X + 7, l.StartPoint.Y + 7);
            SplashKit.FillTriangle(Color.Black, l.EndPoint.X, l.EndPoint.Y, l.EndPoint.X + 7, l.EndPoint.Y - 7, l.EndPoint.X - 7, l.EndPoint.Y - 7);
            SplashKit.DrawText($"This text is {height} pixels tall", Color.Black, 30, 220 + height);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}