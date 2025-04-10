using SplashKitSDK;

namespace PopClip
{
    class tester
    {
        static void Main()
        {
            //Create a new window with width and height of 400 called "Pop Clip"
            Window window = new Window("Pop Clip", 400, 400);

            //Set a clipping region at (200, 200) with width and height of 200
            //Anything drawn outside this area will not be shown
            SplashKit.SetClip(200, 200, 200, 200);

            //Draw a red rectangle inside the clipping area
            SplashKit.FillRectangle(Color.Red, 200, 200, 100, 100);

            //Remove the clipping region so the whole display can be drawn on again
            SplashKit.PopClip();

            //Draw a green rectangle — this will be fully visible since clipping is removed
            SplashKit.FillRectangle(Color.Green, 100, 150, 100, 100);

            //Display the changes
            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);
        }
    }
}
