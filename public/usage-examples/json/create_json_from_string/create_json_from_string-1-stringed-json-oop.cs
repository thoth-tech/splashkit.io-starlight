using SplashKitSDK;

namespace CreateJsonString
{
    public class Program
    {
        public static void Main()
        {
            // JSON string to convert to a JSON object
            string jsonString = "{\"name\": \"Breezy\", \"age\": 25}";

            // Create a JSON object from the string
            Json jsonObj = SplashKit.CreateJson(jsonString);

            // Read and display values from the JSON object
            SplashKit.WriteLine("Name: " + SplashKit.JsonReadString(jsonObj, "name"));
            SplashKit.WriteLine("Age: " + SplashKit.JsonReadNumber(jsonObj, "age").ToString());
        }
    }
}