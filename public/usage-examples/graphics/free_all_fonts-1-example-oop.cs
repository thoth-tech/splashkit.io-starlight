using System;
using SplashKitSDK;

namespace FreeAllFontsExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = SplashKit.OpenWindow("Free All Fonts Example", 900, 600);

            // Load fonts from bundle
            SplashKit.LoadResourceBundle("bundles", "Font.txt");

            // Use FontA and FontB
            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawText("This is Font A (Montserrat Black)", Color.Black, "FontA", 32, 100, 100);
            SplashKit.DrawText("This is Font B (Montserrat Thin)", Color.Black, "FontB", 32, 100, 150);
            SplashKit.RefreshScreen();
            SplashKit.Delay(2000);

            // Free all fonts
            SplashKit.FreeAllFonts();

            // Load FontC manually
            SplashKit.LoadFont("FontC", "OpenSans_Condensed-Bold.ttf");

            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawText("Fonts A and B were freed.", Color.Red, "FontC", 32, 100, 250);
            SplashKit.DrawText("Now using Font C (OpenSans Condensed Bold)", Color.Red, "FontC", 32, 100, 300);
            SplashKit.RefreshScreen();
            SplashKit.Delay(2000);

            window.Close();
        }
    }
}
