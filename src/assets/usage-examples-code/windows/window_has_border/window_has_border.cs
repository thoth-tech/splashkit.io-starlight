using SplashKitSDK;

class Program
{
    static void Main()
    {
        Window myWindow = new Window("My Window", 800, 600);

        // Check if the window has a border
        bool hasBorder = SplashKit.WindowHasBorder(myWindow);

        // Set the background color
        if (hasBorder)
        {
            myWindow.Clear(Color.White);
        }
        else
        {
            myWindow.Clear(Color.Black);
        }

        // Refresh the window
        myWindow.Refresh();

        // Close the window after a delay
        SplashKit.Delay(2000); // Wait for 2 seconds
        myWindow.Close();
    }
}
