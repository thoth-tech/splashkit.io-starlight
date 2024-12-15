using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            string[] values = { "123", "45.67", "-50", "abc", "789", "0" };

            foreach (string value in values)
            {
                // Check if string is a valid double
                bool number = SplashKit.IsDouble(value);

                // Print the value along with the result using "true" or "false"
                SplashKit.WriteLine(value + " - " + (number ? "true" : "false"));
            }
        }
    }
}
