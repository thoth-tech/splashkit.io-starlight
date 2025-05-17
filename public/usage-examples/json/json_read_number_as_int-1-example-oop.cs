using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            // Create a JSON object
            Json json_obj = SplashKit.CreateJson();
            SplashKit.JsonSetNumber(json_obj, "grade", 10);

            // Read the integer value 
            int grade = SplashKit.JsonReadNumberAsInt(json_obj, "grade");

            // Display the integer value
            SplashKit.WriteLine("Grade: " + grade.ToString());

        }
    }
}