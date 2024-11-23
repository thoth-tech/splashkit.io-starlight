using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            // Display a dialog to the user
            SplashKit.DisplayDialog("Welcome!", "Hello, this is a simple dialog message.", SplashKit.GetSystemFont(), 20);

            // Display another dialog with a different message and font size
            SplashKit.DisplayDialog("Second Message", "This is another dialog with a different message.", SplashKit.GetSystemFont(), 25);

            // Display a dialog with a different title and message
            SplashKit.DisplayDialog("Third Message", "This is a dialog with BIG TEXT!", SplashKit.GetSystemFont(), 40);
        }
    }
}