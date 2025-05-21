using static SplashKitSDK.SplashKit;

OpenWindow("Current Clip Example", 400, 400);

//Fill that region with red (with a rectangle)
var region = new Rectangle { X = 100, Y = 100, Width = 200, Height = 200 };


while (!QuitRequested())
{

    ProcessEvents();
    ClearScreen(Color.White);
    //Clip the window to the rectangle
    SetClip(region);

    //Fill that region with red
    FillRectangle(Color.Red, region);

    //Retrieve the clip bounds
    Rectangle clip = CurrentClip();

    //Exit out of the clip
    PopClip();

    //Outline the old clip in green as a rectangle
    DrawRectangle(Color.Green,clip.X, clip.Y, clip.Width, clip.Height);

    RefreshScreen();
}

CloseWindow("Current Clip Example");
