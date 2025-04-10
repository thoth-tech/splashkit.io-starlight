using static SplashKitSDK.SplashKit;

//Create a window titled "Pop Clip" with pixel size 400x400
Window window = new Window("Pop Clip", 400, 400);

//Set a clipping region at (200, 200) with width and height of 200
//Anything drawn outside this area will not be shown
SetClip(200, 200, 200, 200);

//Draw a red rectangle inside the clipping area
FillRectangle(Color.Red, 200, 200, 100, 100);

//Remove the clipping region so the whole display can be drawn on again
PopClip();

//Draw a green rectangle — this will be fully visible since clipping is removed
FillRectangle(Color.Green, 100, 150, 100, 100);

//Display the changes
RefreshScreen();
Delay(5000);
