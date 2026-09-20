using SplashKitSDK;

namespace JsonReadArrayOfStringExample
{
    public class Program
    {
        public static void Main()
        {
            // Build the Json from text, so the example needs no resource files
            Json basket = SplashKit.JsonFromString("{\"fruits\": [\"apple\", \"banana\", \"cherry\", \"mango\"]}");

            // The function fills a list that we create empty first
            List<string> fruits = new List<string>();
            SplashKit.JsonReadArray(basket, "fruits", ref fruits);

            int fruitCount = fruits.Count;

            SplashKit.OpenWindow("Fruit Basket", 520, 360);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Fruits in the basket", Color.Black, "arial", 30, 30, 25);

                for (int index = 0; index < fruitCount; index++)
                {
                    SplashKit.DrawText($"{index + 1}. {fruits[index]}", Color.Black, "arial", 24, 30, 85 + index * 40);
                }

                SplashKit.RefreshScreen(60);
            }

            basket.Free();
            SplashKit.CloseAllWindows();
        }
    }
}
