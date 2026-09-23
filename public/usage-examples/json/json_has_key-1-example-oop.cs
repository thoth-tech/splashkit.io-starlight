using SplashKitSDK;

namespace JsonHasKeyExample
{
    public class Program
    {
        public static void Main()
        {
            Json exampleJson = SplashKit.CreateJson();

            SplashKit.JsonSetString(exampleJson, "name", "SplashKit");

            bool hasName = SplashKit.JsonHasKey(exampleJson, "name");
            bool hasAge = SplashKit.JsonHasKey(exampleJson, "age");

            SplashKit.WriteLine("JSON Has Key Example");
            SplashKit.WriteLine("--------------------");

            if (hasName)
            {
                SplashKit.WriteLine("Has key 'name': true");
            }
            else
            {
                SplashKit.WriteLine("Has key 'name': false");
            }

            if (hasAge)
            {
                SplashKit.WriteLine("Has key 'age': true");
            }
            else
            {
                SplashKit.WriteLine("Has key 'age': false");
            }

            SplashKit.FreeJson(exampleJson);
        }
    }
}