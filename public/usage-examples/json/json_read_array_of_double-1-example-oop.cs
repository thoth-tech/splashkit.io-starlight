using SplashKitSDK;

namespace JsonReadArrayOfDoubleExample
{
    public class Program
    {
        public static void Main()
        {
            // Build the Json from text, so the example needs no resource files
            Json weather = SplashKit.JsonFromString("{\"temperatures\": [18.5, 21.5, 19.5, 22.5]}");

            // The function fills a list that we create empty first
            List<double> temperatures = new List<double>();
            SplashKit.JsonReadArray(weather, "temperatures", ref temperatures);

            // The readings never change, so add them up once instead of every frame
            int temperatureCount = temperatures.Count;
            double total = 0;

            for (int index = 0; index < temperatureCount; index++)
            {
                total += temperatures[index];
            }

            double average = total / temperatureCount;

            SplashKit.OpenWindow("Temperature Log", 520, 360);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Recent temperatures", Color.Black, "arial", 30, 30, 25);

                for (int index = 0; index < temperatureCount; index++)
                {
                    SplashKit.DrawText($"Day {index + 1}: {temperatures[index]} C", Color.Black, "arial", 24, 30, 85 + index * 40);
                }

                SplashKit.DrawText($"Average: {average} C", Color.Black, "arial", 26, 30, 270);

                SplashKit.RefreshScreen(60);
            }

            weather.Free();
            SplashKit.CloseAllWindows();
        }
    }
}
