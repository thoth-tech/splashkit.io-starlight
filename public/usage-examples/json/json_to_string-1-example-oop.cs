using SplashKitSDK;

namespace JsonToStringExample
{
    public static class Program
    {
        public static void Main()
        {
            string rawJson = "{\"player\":\"Avery\",\"level\":5,\"status\":\"ready\"}";

            Json playerData = SplashKit.JsonFromString(rawJson);
            string jsonText = SplashKit.JsonToString(playerData);

            SplashKit.WriteLine("Original JSON string:");
            SplashKit.WriteLine(rawJson);
            SplashKit.WriteLine("");
            SplashKit.WriteLine("JSON object converted back to string:");
            SplashKit.WriteLine(jsonText);

            SplashKit.FreeJson(playerData);
        }
    }
}