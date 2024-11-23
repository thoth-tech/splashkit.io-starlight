using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            // Prompt user for input string and delimiter
            SplashKit.Write("Enter a string to split: ");
            string text = SplashKit.ReadLine();
            
            SplashKit.Write("Enter a delimiter character: ");
            string delimiterInput = SplashKit.ReadLine();

            // Ensure the delimiter is a single character
            if (delimiterInput.Length != 1)
            {
                SplashKit.WriteLine("Please enter a single character as the delimiter.");
            }
            else
            {
                char delimiter = delimiterInput[0];

                // Split the input string
                List<string> result = SplashKit.Split(text, delimiter);

                // Display the split substrings
                SplashKit.WriteLine("Split result:");
                foreach (string part in result)
                {
                    SplashKit.WriteLine($"- {part}");
                }
            }
        }
    }
}