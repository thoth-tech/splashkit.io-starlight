using SplashKitSDK;

namespace DrawQuad
{
    public class Program
    {
        public static void Main()
        {
            // Initialise quads with x1,y1,...,x4,y4
            Quad q1 = SplashKit.QuadFrom(400,200,300,300,300,0,200,200);
            Quad q2 = SplashKit.QuadFrom(400,210,310, 300,600,300,400,390);
            Quad q3 = SplashKit.QuadFrom(200,400,300, 300,300,600,400,400);
            Quad q4 = SplashKit.QuadFrom(200,390,290, 300,0,300,200,210);

            // Create Window

            SplashKit.OpenWindow("Draw Quad", 600, 600);
            SplashKit.ClearScreen(SplashKit.ColorWhite());


            SplashKit.DrawQuad(SplashKit.ColorBlack(), q1);
            SplashKit.DrawQuad(SplashKit.ColorGreen(), q2);
            SplashKit.DrawQuad(SplashKit.ColorRed(), q3);
            SplashKit.DrawQuad(SplashKit.ColorBlue(), q4);
            

            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);
            SplashKit.CloseAllWindows();
        }    
    }
}
