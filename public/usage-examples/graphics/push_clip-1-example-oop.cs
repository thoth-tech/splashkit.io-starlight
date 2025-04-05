using SplashKitSDK;

namespace PushClipExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Push Clip Example", 800, 600);


            Rectangle clipRect = new Rectangle {
                X = 400,
                Y = 95,
                Width = 205,
                Height = 410
            };

            Rectangle cornerRect = new Rectangle {
                X = 195,
                Y = 295,
                Width = 410,
                Height = 210
            };

            SplashKit.ClearScreen(Color.White);
            SplashKit.FillCircle(Color.Goldenrod, 400, 300, 200);
            SplashKit.FillCircle(Color.SwinburneRed, 400, 300, 180);
            SplashKit.RefreshScreen();
            SplashKit.Delay(1000);

            SplashKit.ClearScreen(Color.White);
            SplashKit.FillCircle(Color.Goldenrod, 400, 300, 200);
            SplashKit.FillCircle(Color.SwinburneRed, 400, 300, 180);
            SplashKit.DrawRectangle(Color.RoyalBlue, clipRect);
            SplashKit.DrawText("First Clipping Rectangle", Color.Black, 100, 550);
            SplashKit.RefreshScreen();
            SplashKit.Delay(2000);

            SplashKit.ClearScreen(Color.White);
            SplashKit.FillCircle(Color.Goldenrod, 400, 300, 200);
            SplashKit.FillCircle(Color.SwinburneRed, 400, 300, 180);
            SplashKit.DrawRectangle(Color.RoyalBlue, cornerRect);
            SplashKit.DrawText("Second Clipping Rectangle", Color.Black, 100, 550);
            SplashKit.RefreshScreen();
            SplashKit.Delay(2000);

            SplashKit.ClearScreen(Color.White);
            SplashKit.FillCircle(Color.Goldenrod, 400, 300, 200);
            SplashKit.FillCircle(Color.SwinburneRed, 400, 300, 180);
            SplashKit.RefreshScreen();
            SplashKit.Delay(100);

            SplashKit.ClearScreen(Color.White);
            SplashKit.FillCircle(Color.Goldenrod, 400, 300, 200);
            SplashKit.FillCircle(Color.SwinburneRed, 400, 300, 180);
            SplashKit.DrawRectangle(Color.RoyalBlue, clipRect);
            SplashKit.DrawRectangle(Color.RoyalBlue, cornerRect);
            SplashKit.DrawText("Intersection of Both Rectangles", Color.Black, 100, 550);
            SplashKit.RefreshScreen();
            SplashKit.Delay(2000);

            SplashKit.PushClip(clipRect);
            SplashKit.ClearScreen(Color.White);
            SplashKit.FillCircle(Color.Goldenrod, 400, 300, 200);
            SplashKit.FillCircle(Color.SwinburneRed, 400, 300, 180);
            SplashKit.PopClip();
            SplashKit.DrawText("First Push Clip", Color.Black, 100, 550);
            SplashKit.RefreshScreen();
            SplashKit.Delay(2000);

            SplashKit.PushClip(clipRect);
            SplashKit.PushClip(cornerRect);
            SplashKit.ClearScreen(Color.White);
            SplashKit.FillCircle(Color.Goldenrod, 400, 300, 200);
            SplashKit.FillCircle(Color.SwinburneRed, 400, 300, 180);
            SplashKit.PopClip();
            SplashKit.PopClip();
            SplashKit.DrawText("Final Result After Second Push Clip", Color.Black, 100, 550);
            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);

            SplashKit.CloseAllWindows();
        }
    }
}
