using SplashKitSDK;

namespace DownloadBitmapExample
{
    public class Program
    {
        public static void Main()
        {
            string imageUrl =
                "https://programmers.guide/resources/code-examples/part-0/earth.png";

            // Download the bitmap from the web server
            Bitmap earth = SplashKit.DownloadBitmap(
                "Earth",
                imageUrl,
                443
            );

            Window window = new Window(
                "Downloaded Bitmap",
                700,
                500
            );

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();

                window.Clear(Color.White);

                window.DrawText(
                    "Bitmap downloaded from the internet",
                    Color.Black,
                    170,
                    40
                );

                // Draw the downloaded bitmap
                earth.Draw(220, 100);

                window.Refresh(60);
            }

            window.Close();
        }
    }
}