using SplashKitSDK;

namespace DisplayWidthExample
{
    public class Program
    {
        public static void Main()
        {
            // Get display width
            int width = SplashKit.DisplayDetails(0).Width;

            // Open window with same width of display
            Window wind = SplashKit.OpenWindow("Display Width Exmaple", width, 100);
            wind.Clear(Color.Black);

            // Write on window the display width
            wind.DrawText($"Display Width: {width}", Color.White, width / 2, 50);
            wind.Refresh();
            while (!SplashKit.QuitRequested()) SplashKit.ProcessEvents();
        }
    }
}
