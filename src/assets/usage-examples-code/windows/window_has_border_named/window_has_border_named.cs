using SplashKitSDK;

class Program
{
    static void Main()
    {
        const string windowName = "My Window";
        
        // Check if the window named "My Window" has a border
        bool hasBorder = SplashKit.WindowHasBorderNamed(windowName);

        // Print the result
        if (hasBorder)
        {
            System.Console.WriteLine($"Window '{windowName}' has a border.");
        }
        else
        {
            System.Console.WriteLine($"Window '{windowName}' does not have a border.");
        }
    }
}
